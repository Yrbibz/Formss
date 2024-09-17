namespace CalculoIMC
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
            lblAltura = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblImc = new Label();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            rdbHomem = new RadioButton();
            rdbFemea = new RadioButton();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(21, 66);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 110);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 162);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 110);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 4;
            label5.Text = "Kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 71);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "metros";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(48, 222);
            label7.Name = "label7";
            label7.Size = new Size(142, 30);
            label7.TabIndex = 6;
            label7.Text = "O SEU IMC É:";
            label7.Click += label7_Click;
            // 
            // lblImc
            // 
            lblImc.AutoSize = true;
            lblImc.Location = new Point(59, 290);
            lblImc.Name = "lblImc";
            lblImc.Size = new Size(0, 15);
            lblImc.TabIndex = 7;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(65, 63);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(63, 23);
            txtAltura.TabIndex = 8;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(65, 102);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(64, 23);
            txtPeso.TabIndex = 9;
            // 
            // rdbHomem
            // 
            rdbHomem.AutoSize = true;
            rdbHomem.Location = new Point(65, 162);
            rdbHomem.Name = "rdbHomem";
            rdbHomem.Size = new Size(80, 19);
            rdbHomem.TabIndex = 10;
            rdbHomem.TabStop = true;
            rdbHomem.Text = "Masculino";
            rdbHomem.UseVisualStyleBackColor = true;
            // 
            // rdbFemea
            // 
            rdbFemea.AutoSize = true;
            rdbFemea.Location = new Point(148, 162);
            rdbFemea.Name = "rdbFemea";
            rdbFemea.Size = new Size(75, 19);
            rdbFemea.TabIndex = 11;
            rdbFemea.TabStop = true;
            rdbFemea.Text = "Feminino";
            rdbFemea.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(446, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 404);
            Controls.Add(pictureBox1);
            Controls.Add(rdbFemea);
            Controls.Add(rdbHomem);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(lblImc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblAltura);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculadora de IMC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltura;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblImc;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private RadioButton rdbHomem;
        private RadioButton rdbFemea;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
    }
}