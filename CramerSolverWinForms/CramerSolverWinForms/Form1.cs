using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CramerSolverWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        }

        // ===== ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ =====

        // Детерминант 3×3
        private double Det3(double[,] m)
        {
            double a11 = m[0, 0], a12 = m[0, 1], a13 = m[0, 2];
            double a21 = m[1, 0], a22 = m[1, 1], a23 = m[1, 2];
            double a31 = m[2, 0], a32 = m[2, 1], a33 = m[2, 2];

            return
                a11 * a22 * a33 +
                a12 * a23 * a31 +
                a13 * a21 * a32 -
                a13 * a22 * a31 -
                a11 * a23 * a32 -
                a12 * a21 * a33;
        }

        // Подмена столбца
        private double[,] ReplaceColumn(double[,] A, double[] b, int colIndex)
        {
            var M = (double[,])A.Clone();
            for (int i = 0; i < 3; i++)
                M[i, colIndex] = b[i];
            return M;
        }

        // "Умный" парсер для TextBox: подсвечивает ошибки через ErrorProvider
        private bool TryParse(TextBox tb, out double value)
        {
            errorProvider1.SetError(tb, string.Empty); // очищаем прежнюю ошибку

            string text = tb.Text?.Trim() ?? string.Empty;
            text = text.Replace(',', '.');

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(tb, "Поле не должно быть пустым");
                value = 0;
                return false;
            }

            if (!double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                errorProvider1.SetError(tb, "Введите число (можно с точкой или запятой)");
                return false;
            }

            return true;
        }

        // Считывание системы из текстбоксов
        private bool TryReadSystem(out double[,] A, out double[] b)
        {
            A = new double[3, 3];
            b = new double[3];

            bool ok = true;

            ok &= TryParse(txtA11, out A[0, 0]);
            ok &= TryParse(txtA12, out A[0, 1]);
            ok &= TryParse(txtA13, out A[0, 2]);
            ok &= TryParse(txtB1, out b[0]);

            ok &= TryParse(txtA21, out A[1, 0]);
            ok &= TryParse(txtA22, out A[1, 1]);
            ok &= TryParse(txtA23, out A[1, 2]);
            ok &= TryParse(txtB2, out b[1]);

            ok &= TryParse(txtA31, out A[2, 0]);
            ok &= TryParse(txtA32, out A[2, 1]);
            ok &= TryParse(txtA33, out A[2, 2]);
            ok &= TryParse(txtB3, out b[2]);

            if (!ok)
            {
                MessageBox.Show(
                    "Исправьте поля, помеченные значком ошибки.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Основное решение методом Крамера + формирование "пошагового" текста
        private void SolveCramer(
            double[,] A,
            double[] b,
            out double? x,
            out double? y,
            out double? z,
            out string message,
            out string stepText)
        {
            const double eps = 1e-9;
            var sb = new StringBuilder();

            sb.AppendLine("Решение системы 3×3 методом Крамера");
            sb.AppendLine();

            sb.AppendLine("Матрица A:");
            sb.AppendLine(
                $"[{A[0, 0]}  {A[0, 1]}  {A[0, 2]}]\n" +
                $"[{A[1, 0]}  {A[1, 1]}  {A[1, 2]}]\n" +
                $"[{A[2, 0]}  {A[2, 1]}  {A[2, 2]}]");
            sb.AppendLine();
            sb.AppendLine($"Столбец свободных членов b: [{b[0]}, {b[1]}, {b[2]}]");
            sb.AppendLine();

            double detA = Det3(A);
            sb.AppendLine($"Шаг 1. Вычисляем det(A) = {detA:F4}");

            if (Math.Abs(detA) < eps)
            {
                double Dx = Det3(ReplaceColumn(A, b, 0));
                double Dy = Det3(ReplaceColumn(A, b, 1));
                double Dz = Det3(ReplaceColumn(A, b, 2));

                sb.AppendLine($"Шаг 2. det(A)=0, вычисляем Dx, Dy, Dz:");
                sb.AppendLine($"Dx = {Dx:F4}, Dy = {Dy:F4}, Dz = {Dz:F4}");

                if (Math.Abs(Dx) < eps && Math.Abs(Dy) < eps && Math.Abs(Dz) < eps)
                {
                    x = y = z = null;
                    message = "Система имеет бесконечно много решений (det(A)=0, Dx=Dy=Dz=0).";
                    sb.AppendLine("Вывод: det(A)=0 и все Dx,Dy,Dz=0 ⇒ бесконечно много решений.");
                }
                else
                {
                    x = y = z = null;
                    message = "Система несовместна (det(A)=0, хотя бы один из Dx,Dy,Dz ≠ 0).";
                    sb.AppendLine("Вывод: det(A)=0, но хотя бы один из Dx,Dy,Dz ≠ 0 ⇒ система несовместна.");
                }
            }
            else
            {
                double Dx = Det3(ReplaceColumn(A, b, 0));
                double Dy = Det3(ReplaceColumn(A, b, 1));
                double Dz = Det3(ReplaceColumn(A, b, 2));

                sb.AppendLine($"Шаг 2. Вычисляем Dx, Dy, Dz:");
                sb.AppendLine($"Dx = {Dx:F4}, Dy = {Dy:F4}, Dz = {Dz:F4}");
                sb.AppendLine();

                x = Dx / detA;
                y = Dy / detA;
                z = Dz / detA;

                sb.AppendLine("Шаг 3. Вычисляем неизвестные:");
                sb.AppendLine($"x = Dx / det(A) = {x:F4}");
                sb.AppendLine($"y = Dy / det(A) = {y:F4}");
                sb.AppendLine($"z = Dz / det(A) = {z:F4}");

                message = $"Найдено единственное решение. det(A) = {detA:F4}.";
            }

            stepText = sb.ToString();
        }

        // Путь к файлу истории
        private string GetHistoryFilePath()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(dir, "history.txt");
        }

        // Сохранение истории в текстовый файл
        private void SaveHistory(double[,] A, double[] b, double? x, double? y, double? z, string message)
        {
            var sb = new StringBuilder();
            sb.AppendLine("=====================================");
            sb.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("Система:");
            sb.AppendLine(
                $"{A[0, 0]}·x + {A[0, 1]}·y + {A[0, 2]}·z = {b[0]}\n" +
                $"{A[1, 0]}·x + {A[1, 1]}·y + {A[1, 2]}·z = {b[1]}\n" +
                $"{A[2, 0]}·x + {A[2, 1]}·y + {A[2, 2]}·z = {b[2]}");
            sb.AppendLine("Результат:");
            sb.AppendLine(message);

            if (x.HasValue)
            {
                sb.AppendLine($"x = {x:F4}");
                sb.AppendLine($"y = {y:F4}");
                sb.AppendLine($"z = {z:F4}");
            }

            sb.AppendLine();

            File.AppendAllText(GetHistoryFilePath(), sb.ToString(), Encoding.UTF8);
        }

        // ===== ОБРАБОТЧИКИ КНОПОК =====

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (!TryReadSystem(out double[,] A, out double[] b))
                return;

            SolveCramer(A, b,
                out double? x, out double? y, out double? z,
                out string msg, out string steps);

            txtSteps.Text = steps; // пошаговое объяснение

            if (x.HasValue)
            {
                txtX.Text = x.Value.ToString("F4");
                txtY.Text = y.Value.ToString("F4");
                txtZ.Text = z.Value.ToString("F4");
            }
            else
            {
                txtX.Text = txtY.Text = txtZ.Text = string.Empty;
            }

            // Автоматически добавляем запись в историю
            SaveHistory(A, b, x, y, z, msg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // очищаем все вводимые текстбоксы
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb && tb.ReadOnly == false && tb != txtSteps)
                    tb.Text = string.Empty;
            }

            txtX.Text = txtY.Text = txtZ.Text = string.Empty;
            txtSteps.Text = string.Empty;

            errorProvider1.Clear();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            // очень простой экспорт: записываем текст с результатом в файл с расширением .pdf
            // (для учебной работы этого обычно достаточно)
            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Сохранить результат";
                dlg.Filter = "PDF-файл (*.pdf)|*.pdf|Текстовый файл (*.txt)|*.txt";
                dlg.FileName = "CramerSolverResult.pdf";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                var sb = new StringBuilder();
                sb.AppendLine("Решение системы 3×3 методом Крамера");
                sb.AppendLine();
                sb.AppendLine("Система:");
                sb.AppendLine(
                    $"{txtA11.Text}·x + {txtA12.Text}·y + {txtA13.Text}·z = {txtB1.Text}\n" +
                    $"{txtA21.Text}·x + {txtA22.Text}·y + {txtA23.Text}·z = {txtB2.Text}\n" +
                    $"{txtA31.Text}·x + {txtA32.Text}·y + {txtA33.Text}·z = {txtB3.Text}");
                sb.AppendLine();
                sb.AppendLine("Результат:");
                sb.AppendLine($"x = {txtX.Text}");
                sb.AppendLine($"y = {txtY.Text}");
                sb.AppendLine($"z = {txtZ.Text}");
                sb.AppendLine();
                sb.AppendLine("Пошаговое объяснение:");
                sb.AppendLine(txtSteps.Text);

                File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show(
                    "Результат сохранён в файл.\n(Формат содержимого текстовый, но файл имеет расширение .pdf.)",
                    "Экспорт завершён",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
