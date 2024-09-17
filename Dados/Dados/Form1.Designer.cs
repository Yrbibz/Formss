namespace Dados
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
            btnComecar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            grpPlacar = new GroupBox();
            pcbFinal = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            grpNomeComeco = new GroupBox();
            grpUsuario = new GroupBox();
            pctDadoUser = new PictureBox();
            lblNumDadin = new Label();
            grpComputador = new GroupBox();
            pctDadoComp = new PictureBox();
            lblNumDadao = new Label();
            pctFim = new PictureBox();
            grpPlacar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpNomeComeco.SuspendLayout();
            grpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDadoUser).BeginInit();
            grpComputador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctDadoComp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFim).BeginInit();
            SuspendLayout();
            // 
            // btnComecar
            // 
            btnComecar.Image = (Image)resources.GetObject("btnComecar.Image");
            btnComecar.Location = new Point(66, 94);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(174, 169);
            btnComecar.TabIndex = 0;
            btnComecar.UseVisualStyleBackColor = true;
            btnComecar.Click += btnComecar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(16, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome do Usuário";
            lblNome.Click += lblNome_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(114, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(183, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // grpPlacar
            // 
            grpPlacar.Controls.Add(pcbFinal);
            grpPlacar.Controls.Add(pictureBox3);
            grpPlacar.Controls.Add(pictureBox2);
            grpPlacar.Controls.Add(pictureBox1);
            grpPlacar.Location = new Point(332, 42);
            grpPlacar.Name = "grpPlacar";
            grpPlacar.Size = new Size(557, 262);
            grpPlacar.TabIndex = 4;
            grpPlacar.TabStop = false;
            grpPlacar.Text = "Placar";
            // 
            // pcbFinal
            // 
            pcbFinal.Location = new Point(-63, 304);
            pcbFinal.Name = "pcbFinal";
            pcbFinal.Size = new Size(284, 244);
            pcbFinal.TabIndex = 8;
            pcbFinal.TabStop = false;
            pcbFinal.Click += pcbFinal_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(222, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(366, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 164);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpNomeComeco
            // 
            grpNomeComeco.Controls.Add(btnComecar);
            grpNomeComeco.Controls.Add(txtNome);
            grpNomeComeco.Controls.Add(lblNome);
            grpNomeComeco.Location = new Point(23, 12);
            grpNomeComeco.Name = "grpNomeComeco";
            grpNomeComeco.Size = new Size(303, 292);
            grpNomeComeco.TabIndex = 5;
            grpNomeComeco.TabStop = false;
            // 
            // grpUsuario
            // 
            grpUsuario.Controls.Add(pctDadoUser);
            grpUsuario.Controls.Add(lblNumDadin);
            grpUsuario.Location = new Point(332, 324);
            grpUsuario.Name = "grpUsuario";
            grpUsuario.Size = new Size(252, 252);
            grpUsuario.TabIndex = 6;
            grpUsuario.TabStop = false;
            grpUsuario.Text = "Usuário";
            // 
            // pctDadoUser
            // 
            pctDadoUser.Location = new Point(31, 37);
            pctDadoUser.Name = "pctDadoUser";
            pctDadoUser.Size = new Size(168, 168);
            pctDadoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDadoUser.TabIndex = 1;
            pctDadoUser.TabStop = false;
            // 
            // lblNumDadin
            // 
            lblNumDadin.AutoSize = true;
            lblNumDadin.Location = new Point(6, 234);
            lblNumDadin.Name = "lblNumDadin";
            lblNumDadin.Size = new Size(0, 15);
            lblNumDadin.TabIndex = 0;
            // 
            // grpComputador
            // 
            grpComputador.Controls.Add(pctDadoComp);
            grpComputador.Controls.Add(lblNumDadao);
            grpComputador.Location = new Point(625, 324);
            grpComputador.Name = "grpComputador";
            grpComputador.Size = new Size(252, 252);
            grpComputador.TabIndex = 7;
            grpComputador.TabStop = false;
            grpComputador.Text = "Computador";
            // 
            // pctDadoComp
            // 
            pctDadoComp.Location = new Point(44, 37);
            pctDadoComp.Name = "pctDadoComp";
            pctDadoComp.Size = new Size(168, 168);
            pctDadoComp.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDadoComp.TabIndex = 1;
            pctDadoComp.TabStop = false;
            // 
            // lblNumDadao
            // 
            lblNumDadao.AutoSize = true;
            lblNumDadao.Location = new Point(6, 234);
            lblNumDadao.Name = "lblNumDadao";
            lblNumDadao.Size = new Size(0, 15);
            lblNumDadao.TabIndex = 0;
            // 
            // pctFim
            // 
            pctFim.Location = new Point(65, 350);
            pctFim.Name = "pctFim";
            pctFim.Size = new Size(198, 179);
            pctFim.TabIndex = 8;
            pctFim.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 588);
            Controls.Add(pctFim);
            Controls.Add(grpComputador);
            Controls.Add(grpUsuario);
            Controls.Add(grpNomeComeco);
            Controls.Add(grpPlacar);
            Name = "Form1";
            Text = "Jogo de Dados";
            grpPlacar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpNomeComeco.ResumeLayout(false);
            grpNomeComeco.PerformLayout();
            grpUsuario.ResumeLayout(false);
            grpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctDadoUser).EndInit();
            grpComputador.ResumeLayout(false);
            grpComputador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctDadoComp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnComecar;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox grpPlacar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox grpNomeComeco;
        private GroupBox grpUsuario;
        private PictureBox pctDadoUser;
        private Label lblNumDadin;
        private GroupBox grpComputador;
        private PictureBox pctDadoComp;
        private Label lblNumDadao;
        private PictureBox pcbFinal;
        private PictureBox pctFim;
    }
}