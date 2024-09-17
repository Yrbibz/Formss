namespace ChapeuSeletor
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
            lblNome = new Label();
            btnChapeu = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lstLuf = new ListBox();
            lstSon = new ListBox();
            lstCorv = new ListBox();
            lstGrif = new ListBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grpNome = new GroupBox();
            label1 = new Label();
            txtNome = new TextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpNome.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(13, 112);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(103, 17);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do aluno:";
            // 
            // btnChapeu
            // 
            btnChapeu.Image = (Image)resources.GetObject("btnChapeu.Image");
            btnChapeu.Location = new Point(726, 12);
            btnChapeu.Name = "btnChapeu";
            btnChapeu.Size = new Size(182, 160);
            btnChapeu.TabIndex = 1;
            btnChapeu.UseVisualStyleBackColor = true;
            btnChapeu.Click += btnChapeu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLuf);
            groupBox1.Controls.Add(lstSon);
            groupBox1.Controls.Add(lstCorv);
            groupBox1.Controls.Add(lstGrif);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 379);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Casas";
            // 
            // lstLuf
            // 
            lstLuf.FormattingEnabled = true;
            lstLuf.ItemHeight = 15;
            lstLuf.Location = new Point(677, 200);
            lstLuf.Name = "lstLuf";
            lstLuf.Size = new Size(141, 139);
            lstLuf.TabIndex = 11;
            // 
            // lstSon
            // 
            lstSon.FormattingEnabled = true;
            lstSon.ItemHeight = 15;
            lstSon.Location = new Point(484, 200);
            lstSon.Name = "lstSon";
            lstSon.Size = new Size(141, 139);
            lstSon.TabIndex = 10;
            // 
            // lstCorv
            // 
            lstCorv.FormattingEnabled = true;
            lstCorv.ItemHeight = 15;
            lstCorv.Location = new Point(270, 200);
            lstCorv.Name = "lstCorv";
            lstCorv.Size = new Size(141, 139);
            lstCorv.TabIndex = 9;
            // 
            // lstGrif
            // 
            lstGrif.FormattingEnabled = true;
            lstGrif.ItemHeight = 15;
            lstGrif.Location = new Point(49, 200);
            lstGrif.Name = "lstGrif";
            lstGrif.Size = new Size(141, 139);
            lstGrif.TabIndex = 8;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(677, 47);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(141, 131);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(484, 48);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(141, 130);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(270, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(141, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(690, 19);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 3;
            label5.Text = "Lufa-Lufa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(498, 19);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 2;
            label4.Text = "Sonserina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(287, 20);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 1;
            label3.Text = "Corvinal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 19);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 0;
            label2.Text = "Grifinória";
            // 
            // grpNome
            // 
            grpNome.Controls.Add(label1);
            grpNome.Controls.Add(txtNome);
            grpNome.Controls.Add(lblNome);
            grpNome.Location = new Point(198, 12);
            grpNome.Name = "grpNome";
            grpNome.Size = new Size(510, 160);
            grpNome.TabIndex = 4;
            grpNome.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(134, 40);
            label1.Name = "label1";
            label1.Size = new Size(236, 30);
            label1.TabIndex = 2;
            label1.Text = "Chapéu Seletor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 106);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(382, 23);
            txtNome.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 569);
            Controls.Add(grpNome);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnChapeu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpNome.ResumeLayout(false);
            grpNome.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btnChapeu;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ListBox lstLuf;
        private ListBox lstSon;
        private ListBox lstCorv;
        private ListBox lstGrif;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grpNome;
        private Label label1;
        private TextBox txtNome;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}