namespace BarraDeProgresso
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblNumero = new Label();
            prgNumeros = new ProgressBar();
            mtbNumero = new MaskedTextBox();
            btnOk = new Button();
            rtbNumeros = new RichTextBox();
            lblP = new Label();
            errorTextos = new ErrorProvider(components);
            txtNum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorTextos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(242, 36);
            label1.TabIndex = 0;
            label1.Text = "Insira 10 números";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(28, 116);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número:";
            // 
            // prgNumeros
            // 
            prgNumeros.Location = new Point(-3, 325);
            prgNumeros.Name = "prgNumeros";
            prgNumeros.Size = new Size(434, 31);
            prgNumeros.TabIndex = 3;
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(88, 113);
            mtbNumero.Mask = "99";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 23);
            mtbNumero.TabIndex = 4;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(88, 227);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 5;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // rtbNumeros
            // 
            rtbNumeros.Location = new Point(254, 104);
            rtbNumeros.Name = "rtbNumeros";
            rtbNumeros.Size = new Size(138, 179);
            rtbNumeros.TabIndex = 6;
            rtbNumeros.Text = "";
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Location = new Point(193, 307);
            lblP.Name = "lblP";
            lblP.Size = new Size(0, 15);
            lblP.TabIndex = 7;
            // 
            // errorTextos
            // 
            errorTextos.ContainerControl = this;
            errorTextos.RightToLeftChanged += mtbNumero_TextChanged;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(88, 142);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 8;
            txtNum.TextChanged += txtNum_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 354);
            Controls.Add(txtNum);
            Controls.Add(lblP);
            Controls.Add(rtbNumeros);
            Controls.Add(btnOk);
            Controls.Add(mtbNumero);
            Controls.Add(prgNumeros);
            Controls.Add(lblNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorTextos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumero;
        private ProgressBar prgNumeros;
        private MaskedTextBox mtbNumero;
        private Button btnOk;
        private RichTextBox rtbNumeros;
        private Label lblP;
        private ErrorProvider errorTextos;
        private TextBox txtNum;
    }
}