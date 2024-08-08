namespace Triangulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVerificar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            lblPrimeiro = new Label();
            lblSegundo = new Label();
            lblTerceiro = new Label();
            lblClassificacao = new Label();
            pctTriangulo = new PictureBox();
            txtPrimeiro = new TextBox();
            txtSegundo = new TextBox();
            txtTerceiro = new TextBox();
            lblTriangulo = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctTriangulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(73, 345);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(102, 102);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(228, 345);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(102, 102);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(378, 345);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 102);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblPrimeiro
            // 
            lblPrimeiro.AutoSize = true;
            lblPrimeiro.Location = new Point(29, 147);
            lblPrimeiro.Name = "lblPrimeiro";
            lblPrimeiro.Size = new Size(81, 15);
            lblPrimeiro.TabIndex = 3;
            lblPrimeiro.Text = "Primeiro Lado";
            // 
            // lblSegundo
            // 
            lblSegundo.AutoSize = true;
            lblSegundo.Location = new Point(27, 198);
            lblSegundo.Name = "lblSegundo";
            lblSegundo.Size = new Size(83, 15);
            lblSegundo.TabIndex = 4;
            lblSegundo.Text = "Segundo Lado";
            // 
            // lblTerceiro
            // 
            lblTerceiro.AutoSize = true;
            lblTerceiro.Location = new Point(33, 244);
            lblTerceiro.Name = "lblTerceiro";
            lblTerceiro.Size = new Size(77, 15);
            lblTerceiro.TabIndex = 5;
            lblTerceiro.Text = "Terceiro Lado";
            lblTerceiro.Click += lblTerceiro_Click;
            // 
            // lblClassificacao
            // 
            lblClassificacao.AutoSize = true;
            lblClassificacao.Location = new Point(266, 285);
            lblClassificacao.Name = "lblClassificacao";
            lblClassificacao.Size = new Size(78, 15);
            lblClassificacao.TabIndex = 6;
            lblClassificacao.Text = "Classificação:";
            // 
            // pctTriangulo
            // 
            pctTriangulo.Location = new Point(266, 126);
            pctTriangulo.Name = "pctTriangulo";
            pctTriangulo.Size = new Size(202, 156);
            pctTriangulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTriangulo.TabIndex = 8;
            pctTriangulo.TabStop = false;
            // 
            // txtPrimeiro
            // 
            txtPrimeiro.Location = new Point(134, 144);
            txtPrimeiro.Name = "txtPrimeiro";
            txtPrimeiro.Size = new Size(63, 23);
            txtPrimeiro.TabIndex = 10;
            txtPrimeiro.TextChanged += textBox1_TextChanged;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(134, 195);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(63, 23);
            txtSegundo.TabIndex = 11;
            // 
            // txtTerceiro
            // 
            txtTerceiro.Location = new Point(134, 241);
            txtTerceiro.Name = "txtTerceiro";
            txtTerceiro.Size = new Size(63, 23);
            txtTerceiro.TabIndex = 12;
            // 
            // lblTriangulo
            // 
            lblTriangulo.AutoSize = true;
            lblTriangulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTriangulo.ForeColor = Color.Red;
            lblTriangulo.Location = new Point(293, 50);
            lblTriangulo.Name = "lblTriangulo";
            lblTriangulo.Size = new Size(187, 37);
            lblTriangulo.TabIndex = 13;
            lblTriangulo.Text = "TRIÂNGULOS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(555, 484);
            Controls.Add(pictureBox2);
            Controls.Add(lblTriangulo);
            Controls.Add(txtTerceiro);
            Controls.Add(txtSegundo);
            Controls.Add(txtPrimeiro);
            Controls.Add(pctTriangulo);
            Controls.Add(lblClassificacao);
            Controls.Add(lblTerceiro);
            Controls.Add(lblSegundo);
            Controls.Add(lblPrimeiro);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctTriangulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private Button btnLimpar;
        private Button btnSair;
        private Label lblPrimeiro;
        private Label lblSegundo;
        private Label lblTerceiro;
        private Label lblClassificacao;
        private PictureBox pctTriangulo;
        private TextBox txtPrimeiro;
        private TextBox txtSegundo;
        private TextBox txtTerceiro;
        private Label lblTriangulo;
        private PictureBox pictureBox2;
    }
}