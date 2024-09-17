namespace ControleDeViagem
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
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblFunc = new Label();
            txtFunc = new TextBox();
            lblOrigem = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            gpbIdaeVolta = new GroupBox();
            rdbVolta = new RadioButton();
            rdbIda = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            btnCalc = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            gpbValor = new GroupBox();
            btnTrocar = new Button();
            btnOk = new Button();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gpbIdaeVolta.SuspendLayout();
            gpbValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(342, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Controle De Viagem";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(17, 71);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 2;
            // 
            // lblFunc
            // 
            lblFunc.AutoSize = true;
            lblFunc.Location = new Point(17, 112);
            lblFunc.Name = "lblFunc";
            lblFunc.Size = new Size(62, 15);
            lblFunc.TabIndex = 3;
            lblFunc.Text = "Funcional:";
            // 
            // txtFunc
            // 
            txtFunc.Location = new Point(85, 109);
            txtFunc.Name = "txtFunc";
            txtFunc.Size = new Size(113, 23);
            txtFunc.TabIndex = 4;
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(66, 155);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(50, 15);
            lblOrigem.TabIndex = 5;
            lblOrigem.Text = "Origem:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondôndia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocatins" });
            comboBox1.Location = new Point(33, 173);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondôndia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocatins" });
            comboBox2.Location = new Point(214, 173);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 155);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 10;
            label1.Text = "Destino:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(208, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 89);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(33, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 89);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // gpbIdaeVolta
            // 
            gpbIdaeVolta.Controls.Add(rdbVolta);
            gpbIdaeVolta.Controls.Add(rdbIda);
            gpbIdaeVolta.Location = new Point(358, 187);
            gpbIdaeVolta.Name = "gpbIdaeVolta";
            gpbIdaeVolta.Size = new Size(177, 119);
            gpbIdaeVolta.TabIndex = 13;
            gpbIdaeVolta.TabStop = false;
            gpbIdaeVolta.Text = "Ida e Volta";
            // 
            // rdbVolta
            // 
            rdbVolta.AutoSize = true;
            rdbVolta.Location = new Point(19, 69);
            rdbVolta.Name = "rdbVolta";
            rdbVolta.Size = new Size(79, 19);
            rdbVolta.TabIndex = 1;
            rdbVolta.TabStop = true;
            rdbVolta.Text = "Ida e Volta";
            rdbVolta.UseVisualStyleBackColor = true;
            // 
            // rdbIda
            // 
            rdbIda.AutoSize = true;
            rdbIda.Location = new Point(19, 32);
            rdbIda.Name = "rdbIda";
            rdbIda.Size = new Size(41, 19);
            rdbIda.TabIndex = 0;
            rdbIda.TabStop = true;
            rdbIda.Text = "Ida";
            rdbIda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 357);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 402);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(317, 357);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(81, 60);
            btnCalc.TabIndex = 16;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(428, 358);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(79, 60);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(539, 358);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(79, 60);
            btnSair.TabIndex = 18;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // gpbValor
            // 
            gpbValor.Controls.Add(btnTrocar);
            gpbValor.Controls.Add(btnOk);
            gpbValor.Controls.Add(textBox1);
            gpbValor.Location = new Point(541, 173);
            gpbValor.Name = "gpbValor";
            gpbValor.Size = new Size(200, 133);
            gpbValor.TabIndex = 19;
            gpbValor.TabStop = false;
            gpbValor.Text = "Valor pago por KM";
            // 
            // btnTrocar
            // 
            btnTrocar.Location = new Point(49, 107);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(107, 23);
            btnTrocar.TabIndex = 2;
            btnTrocar.Text = "Trocar Valor";
            btnTrocar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(64, 75);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(747, 82);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(253, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 450);
            Controls.Add(pictureBox3);
            Controls.Add(gpbValor);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gpbIdaeVolta);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblOrigem);
            Controls.Add(txtFunc);
            Controls.Add(lblFunc);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gpbIdaeVolta.ResumeLayout(false);
            gpbIdaeVolta.PerformLayout();
            gpbValor.ResumeLayout(false);
            gpbValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblFunc;
        private TextBox txtFunc;
        private Label lblOrigem;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox gpbIdaeVolta;
        private RadioButton rdbVolta;
        private RadioButton rdbIda;
        private Label label2;
        private Label label3;
        private Button btnCalc;
        private Button btnLimpar;
        private Button btnSair;
        private GroupBox gpbValor;
        private Button btnTrocar;
        private Button btnOk;
        private TextBox textBox1;
        private PictureBox pictureBox3;
    }
}