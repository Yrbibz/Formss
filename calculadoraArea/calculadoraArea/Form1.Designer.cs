namespace calculadoraArea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipo = new Label();
            rdbCirculo = new RadioButton();
            rdbTrapezio = new RadioButton();
            rdbTriangulo = new RadioButton();
            rdbRetangulo = new RadioButton();
            rdbQuadrado = new RadioButton();
            lblResultado = new Label();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            txtValorUm = new TextBox();
            lblValorUm = new Label();
            txtValorTres = new TextBox();
            txtValorDois = new TextBox();
            lblValorTres = new Label();
            lblValorDois = new Label();
            lblLado = new Label();
            lblAviso = new Label();
            lblBaseD = new Label();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTipo.Location = new Point(31, 32);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(403, 30);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Escolha a forma geométrica";
            // 
            // rdbCirculo
            // 
            rdbCirculo.AutoSize = true;
            rdbCirculo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCirculo.Location = new Point(48, 98);
            rdbCirculo.Name = "rdbCirculo";
            rdbCirculo.Size = new Size(77, 25);
            rdbCirculo.TabIndex = 0;
            rdbCirculo.TabStop = true;
            rdbCirculo.Text = "Circulo";
            rdbCirculo.UseVisualStyleBackColor = true;
            rdbCirculo.CheckedChanged += rdbCirculo_CheckedChanged;
            // 
            // rdbTrapezio
            // 
            rdbTrapezio.AutoSize = true;
            rdbTrapezio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTrapezio.Location = new Point(48, 222);
            rdbTrapezio.Name = "rdbTrapezio";
            rdbTrapezio.Size = new Size(86, 25);
            rdbTrapezio.TabIndex = 4;
            rdbTrapezio.TabStop = true;
            rdbTrapezio.Text = "Trapézio";
            rdbTrapezio.UseVisualStyleBackColor = true;
            rdbTrapezio.CheckedChanged += rdbTrapezio_CheckedChanged;
            // 
            // rdbTriangulo
            // 
            rdbTriangulo.AutoSize = true;
            rdbTriangulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTriangulo.Location = new Point(48, 191);
            rdbTriangulo.Name = "rdbTriangulo";
            rdbTriangulo.Size = new Size(93, 25);
            rdbTriangulo.TabIndex = 3;
            rdbTriangulo.TabStop = true;
            rdbTriangulo.Text = "Triângulo";
            rdbTriangulo.UseVisualStyleBackColor = true;
            rdbTriangulo.CheckedChanged += rdbTriangulo_CheckedChanged;
            // 
            // rdbRetangulo
            // 
            rdbRetangulo.AutoSize = true;
            rdbRetangulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbRetangulo.Location = new Point(48, 160);
            rdbRetangulo.Name = "rdbRetangulo";
            rdbRetangulo.Size = new Size(99, 25);
            rdbRetangulo.TabIndex = 2;
            rdbRetangulo.TabStop = true;
            rdbRetangulo.Text = "Retângulo";
            rdbRetangulo.UseVisualStyleBackColor = true;
            rdbRetangulo.CheckedChanged += rdbRetangulo_CheckedChanged;
            // 
            // rdbQuadrado
            // 
            rdbQuadrado.AutoSize = true;
            rdbQuadrado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbQuadrado.Location = new Point(48, 129);
            rdbQuadrado.Name = "rdbQuadrado";
            rdbQuadrado.Size = new Size(98, 25);
            rdbQuadrado.TabIndex = 1;
            rdbQuadrado.TabStop = true;
            rdbQuadrado.Text = "Quadrado";
            rdbQuadrado.UseVisualStyleBackColor = true;
            rdbQuadrado.CheckedChanged += rdbQuadrado_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(31, 386);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(82, 21);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 255, 192);
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(144, 279);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(159, 47);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Info;
            txtResultado.Location = new Point(144, 384);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(310, 23);
            txtResultado.TabIndex = 9;
            // 
            // txtValorUm
            // 
            txtValorUm.BackColor = SystemColors.Info;
            txtValorUm.Location = new Point(296, 115);
            txtValorUm.Name = "txtValorUm";
            txtValorUm.Size = new Size(100, 23);
            txtValorUm.TabIndex = 0;
            txtValorUm.Visible = false;
            // 
            // lblValorUm
            // 
            lblValorUm.AutoSize = true;
            lblValorUm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorUm.Location = new Point(245, 117);
            lblValorUm.Name = "lblValorUm";
            lblValorUm.Size = new Size(45, 21);
            lblValorUm.TabIndex = 11;
            lblValorUm.Text = "Base:";
            lblValorUm.Visible = false;
            // 
            // txtValorTres
            // 
            txtValorTres.BackColor = SystemColors.Info;
            txtValorTres.Location = new Point(296, 176);
            txtValorTres.Name = "txtValorTres";
            txtValorTres.Size = new Size(100, 23);
            txtValorTres.TabIndex = 3;
            txtValorTres.Visible = false;
            // 
            // txtValorDois
            // 
            txtValorDois.BackColor = SystemColors.Info;
            txtValorDois.Location = new Point(296, 144);
            txtValorDois.Name = "txtValorDois";
            txtValorDois.Size = new Size(100, 23);
            txtValorDois.TabIndex = 2;
            txtValorDois.Visible = false;
            // 
            // lblValorTres
            // 
            lblValorTres.AutoSize = true;
            lblValorTres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTres.Location = new Point(246, 174);
            lblValorTres.Name = "lblValorTres";
            lblValorTres.Size = new Size(44, 21);
            lblValorTres.TabIndex = 14;
            lblValorTres.Text = "Raio:";
            lblValorTres.Visible = false;
            // 
            // lblValorDois
            // 
            lblValorDois.AutoSize = true;
            lblValorDois.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDois.Location = new Point(235, 176);
            lblValorDois.Name = "lblValorDois";
            lblValorDois.Size = new Size(55, 21);
            lblValorDois.TabIndex = 15;
            lblValorDois.Text = "Altura:";
            lblValorDois.Visible = false;
            lblValorDois.Click += lblValorDois_Click;
            // 
            // lblLado
            // 
            lblLado.AutoSize = true;
            lblLado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLado.Location = new Point(243, 176);
            lblLado.Name = "lblLado";
            lblLado.Size = new Size(47, 21);
            lblLado.TabIndex = 16;
            lblLado.Text = "Lado:";
            lblLado.Visible = false;
            lblLado.Click += lblLado_Click;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = SystemColors.AppWorkspace;
            lblAviso.Location = new Point(246, 212);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(154, 15);
            lblAviso.TabIndex = 18;
            lblAviso.Text = "* Preencha em centrimetros";
            lblAviso.Visible = false;
            lblAviso.Click += lblAviso_Click;
            // 
            // lblBaseD
            // 
            lblBaseD.AutoSize = true;
            lblBaseD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaseD.Location = new Point(245, 146);
            lblBaseD.Name = "lblBaseD";
            lblBaseD.Size = new Size(45, 21);
            lblBaseD.TabIndex = 19;
            lblBaseD.Text = "Base:";
            lblBaseD.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(465, 438);
            Controls.Add(lblBaseD);
            Controls.Add(lblAviso);
            Controls.Add(lblLado);
            Controls.Add(lblValorDois);
            Controls.Add(lblValorTres);
            Controls.Add(txtValorDois);
            Controls.Add(txtValorTres);
            Controls.Add(lblValorUm);
            Controls.Add(txtValorUm);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(rdbQuadrado);
            Controls.Add(rdbRetangulo);
            Controls.Add(rdbTriangulo);
            Controls.Add(rdbTrapezio);
            Controls.Add(rdbCirculo);
            Controls.Add(lblTipo);
            Name = "Form1";
            Text = "Calculadora de Área";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private RadioButton rdbCirculo;
        private RadioButton rdbTrapezio;
        private RadioButton rdbTriangulo;
        private RadioButton rdbRetangulo;
        private RadioButton rdbQuadrado;
        private Label lblResultado;
        private Button btnCalcular;
        private TextBox txtResultado;
        private TextBox txtValorUm;
        private Label lblValorUm;
        private TextBox txtValorTres;
        private TextBox txtValorDois;
        private Label lblValorTres;
        private Label lblValorDois;
        private Label lblLado;
        private Label lblAviso;
        private Label lblBaseD;
    }
}