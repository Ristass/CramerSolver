namespace CramerSolverWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtA11;
        private System.Windows.Forms.TextBox txtA12;
        private System.Windows.Forms.TextBox txtA13;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtA21;
        private System.Windows.Forms.TextBox txtA22;
        private System.Windows.Forms.TextBox txtA23;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtA31;
        private System.Windows.Forms.TextBox txtA32;
        private System.Windows.Forms.TextBox txtA33;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Label lblEq1;
        private System.Windows.Forms.Label lblEq2;
        private System.Windows.Forms.Label lblEq3;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtA11 = new System.Windows.Forms.TextBox();
            txtA12 = new System.Windows.Forms.TextBox();
            txtA13 = new System.Windows.Forms.TextBox();
            txtB1 = new System.Windows.Forms.TextBox();
            txtA21 = new System.Windows.Forms.TextBox();
            txtA22 = new System.Windows.Forms.TextBox();
            txtA23 = new System.Windows.Forms.TextBox();
            txtB2 = new System.Windows.Forms.TextBox();
            txtA31 = new System.Windows.Forms.TextBox();
            txtA32 = new System.Windows.Forms.TextBox();
            txtA33 = new System.Windows.Forms.TextBox();
            txtB3 = new System.Windows.Forms.TextBox();
            lblEq1 = new System.Windows.Forms.Label();
            lblEq2 = new System.Windows.Forms.Label();
            lblEq3 = new System.Windows.Forms.Label();
            lblX = new System.Windows.Forms.Label();
            txtX = new System.Windows.Forms.TextBox();
            lblY = new System.Windows.Forms.Label();
            txtY = new System.Windows.Forms.TextBox();
            lblZ = new System.Windows.Forms.Label();
            txtZ = new System.Windows.Forms.TextBox();
            btnSolve = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExportPdf = new System.Windows.Forms.Button();
            txtSteps = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtA11
            // 
            txtA11.Location = new System.Drawing.Point(20, 50);
            txtA11.Name = "txtA11";
            txtA11.Size = new System.Drawing.Size(50, 31);
            txtA11.TabIndex = 0;
            // 
            // txtA12
            // 
            txtA12.Location = new System.Drawing.Point(90, 50);
            txtA12.Name = "txtA12";
            txtA12.Size = new System.Drawing.Size(50, 31);
            txtA12.TabIndex = 1;
            // 
            // txtA13
            // 
            txtA13.Location = new System.Drawing.Point(160, 50);
            txtA13.Name = "txtA13";
            txtA13.Size = new System.Drawing.Size(50, 31);
            txtA13.TabIndex = 2;
            // 
            // txtB1
            // 
            txtB1.Location = new System.Drawing.Point(260, 50);
            txtB1.Name = "txtB1";
            txtB1.Size = new System.Drawing.Size(60, 31);
            txtB1.TabIndex = 3;
            // 
            // txtA21
            // 
            txtA21.Location = new System.Drawing.Point(20, 100);
            txtA21.Name = "txtA21";
            txtA21.Size = new System.Drawing.Size(50, 31);
            txtA21.TabIndex = 4;
            // 
            // txtA22
            // 
            txtA22.Location = new System.Drawing.Point(90, 100);
            txtA22.Name = "txtA22";
            txtA22.Size = new System.Drawing.Size(50, 31);
            txtA22.TabIndex = 5;
            // 
            // txtA23
            // 
            txtA23.Location = new System.Drawing.Point(160, 100);
            txtA23.Name = "txtA23";
            txtA23.Size = new System.Drawing.Size(50, 31);
            txtA23.TabIndex = 6;
            // 
            // txtB2
            // 
            txtB2.Location = new System.Drawing.Point(260, 100);
            txtB2.Name = "txtB2";
            txtB2.Size = new System.Drawing.Size(60, 31);
            txtB2.TabIndex = 7;
            // 
            // txtA31
            // 
            txtA31.Location = new System.Drawing.Point(20, 150);
            txtA31.Name = "txtA31";
            txtA31.Size = new System.Drawing.Size(50, 31);
            txtA31.TabIndex = 8;
            // 
            // txtA32
            // 
            txtA32.Location = new System.Drawing.Point(90, 150);
            txtA32.Name = "txtA32";
            txtA32.Size = new System.Drawing.Size(50, 31);
            txtA32.TabIndex = 9;
            // 
            // txtA33
            // 
            txtA33.Location = new System.Drawing.Point(160, 150);
            txtA33.Name = "txtA33";
            txtA33.Size = new System.Drawing.Size(50, 31);
            txtA33.TabIndex = 10;
            // 
            // txtB3
            // 
            txtB3.Location = new System.Drawing.Point(260, 150);
            txtB3.Name = "txtB3";
            txtB3.Size = new System.Drawing.Size(60, 31);
            txtB3.TabIndex = 11;
            // 
            // lblEq1
            // 
            lblEq1.AutoSize = true;
            lblEq1.Location = new System.Drawing.Point(20, 30);
            lblEq1.Name = "lblEq1";
            lblEq1.Size = new System.Drawing.Size(223, 25);
            lblEq1.TabIndex = 100;
            lblEq1.Text = "a11·x + a12·y + a13·z = b1";
            // 
            // lblEq2
            // 
            lblEq2.AutoSize = true;
            lblEq2.Location = new System.Drawing.Point(20, 80);
            lblEq2.Name = "lblEq2";
            lblEq2.Size = new System.Drawing.Size(223, 25);
            lblEq2.TabIndex = 101;
            lblEq2.Text = "a21·x + a22·y + a23·z = b2";
            // 
            // lblEq3
            // 
            lblEq3.AutoSize = true;
            lblEq3.Location = new System.Drawing.Point(20, 130);
            lblEq3.Name = "lblEq3";
            lblEq3.Size = new System.Drawing.Size(223, 25);
            lblEq3.TabIndex = 102;
            lblEq3.Text = "a31·x + a32·y + a33·z = b3";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new System.Drawing.Point(360, 50);
            lblX.Name = "lblX";
            lblX.Size = new System.Drawing.Size(37, 25);
            lblX.TabIndex = 103;
            lblX.Text = "x =";
            // 
            // txtX
            // 
            txtX.Location = new System.Drawing.Point(390, 47);
            txtX.Name = "txtX";
            txtX.ReadOnly = true;
            txtX.Size = new System.Drawing.Size(80, 31);
            txtX.TabIndex = 200;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new System.Drawing.Point(360, 80);
            lblY.Name = "lblY";
            lblY.Size = new System.Drawing.Size(38, 25);
            lblY.TabIndex = 104;
            lblY.Text = "y =";
            // 
            // txtY
            // 
            txtY.Location = new System.Drawing.Point(390, 77);
            txtY.Name = "txtY";
            txtY.ReadOnly = true;
            txtY.Size = new System.Drawing.Size(80, 31);
            txtY.TabIndex = 201;
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Location = new System.Drawing.Point(360, 110);
            lblZ.Name = "lblZ";
            lblZ.Size = new System.Drawing.Size(37, 25);
            lblZ.TabIndex = 105;
            lblZ.Text = "z =";
            // 
            // txtZ
            // 
            txtZ.Location = new System.Drawing.Point(390, 107);
            txtZ.Name = "txtZ";
            txtZ.ReadOnly = true;
            txtZ.Size = new System.Drawing.Size(80, 31);
            txtZ.TabIndex = 202;
            // 
            // btnSolve
            // 
            btnSolve.Location = new System.Drawing.Point(20, 200);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new System.Drawing.Size(120, 35);
            btnSolve.TabIndex = 300;
            btnSolve.Text = "Решить";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(160, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(120, 35);
            btnClear.TabIndex = 301;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new System.Drawing.Point(300, 200);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new System.Drawing.Size(140, 35);
            btnExportPdf.TabIndex = 302;
            btnExportPdf.Text = "Экспорт в PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // txtSteps
            // 
            txtSteps.Location = new System.Drawing.Point(20, 254);
            txtSteps.Multiline = true;
            txtSteps.Name = "txtSteps";
            txtSteps.ReadOnly = true;
            txtSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSteps.Size = new System.Drawing.Size(450, 150);
            txtSteps.TabIndex = 401;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(500, 430);
            Controls.Add(txtSteps);
            Controls.Add(btnExportPdf);
            Controls.Add(btnClear);
            Controls.Add(btnSolve);
            Controls.Add(txtZ);
            Controls.Add(lblZ);
            Controls.Add(txtY);
            Controls.Add(lblY);
            Controls.Add(txtX);
            Controls.Add(lblX);
            Controls.Add(lblEq3);
            Controls.Add(lblEq2);
            Controls.Add(lblEq1);
            Controls.Add(txtB3);
            Controls.Add(txtA33);
            Controls.Add(txtA32);
            Controls.Add(txtA31);
            Controls.Add(txtB2);
            Controls.Add(txtA23);
            Controls.Add(txtA22);
            Controls.Add(txtA21);
            Controls.Add(txtB1);
            Controls.Add(txtA13);
            Controls.Add(txtA12);
            Controls.Add(txtA11);
            Name = "Form1";
            Text = "CramerSolver — метод Крамера для системы 3×3";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}
