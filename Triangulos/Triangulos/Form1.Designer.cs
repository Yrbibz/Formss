namespace Triangulos
{
    partial class Forms1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms1));
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
            pctAngulo = new PictureBox();
            lblClassificacaoAngulo = new Label();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pctTriangulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAngulo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Image = (Image)resources.GetObject("btnVerificar.Image");
            btnVerificar.ImageAlign = ContentAlignment.TopCenter;
            btnVerificar.Location = new Point(73, 364);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(102, 83);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.TextAlign = ContentAlignment.BottomCenter;
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.TopCenter;
            btnLimpar.Location = new Point(293, 364);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(102, 83);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(513, 364);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 83);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
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
            lblClassificacao.Location = new Point(243, 285);
            lblClassificacao.Name = "lblClassificacao";
            lblClassificacao.Size = new Size(78, 15);
            lblClassificacao.TabIndex = 6;
            lblClassificacao.Text = "Classificação:";
            // 
            // pctTriangulo
            // 
            pctTriangulo.Location = new Point(243, 126);
            pctTriangulo.Name = "pctTriangulo";
            pctTriangulo.Size = new Size(199, 156);
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
            pictureBox2.Location = new Point(12, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pctAngulo
            // 
            pctAngulo.Location = new Point(475, 126);
            pctAngulo.Name = "pctAngulo";
            pctAngulo.Size = new Size(199, 156);
            pctAngulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAngulo.TabIndex = 15;
            pctAngulo.TabStop = false;
            // 
            // lblClassificacaoAngulo
            // 
            lblClassificacaoAngulo.AutoSize = true;
            lblClassificacaoAngulo.Location = new Point(475, 285);
            lblClassificacaoAngulo.Name = "lblClassificacaoAngulo";
            lblClassificacaoAngulo.Size = new Size(78, 15);
            lblClassificacaoAngulo.TabIndex = 16;
            lblClassificacaoAngulo.Text = "Classificação:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(713, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Forms1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(713, 484);
            Controls.Add(lblClassificacaoAngulo);
            Controls.Add(pctAngulo);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Forms1";
            Text = "Triângulos";
            ((System.ComponentModel.ISupportInitialize)pctTriangulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAngulo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private PictureBox pctAngulo;
        private Label lblClassificacaoAngulo;
        private ImageList imageList1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}