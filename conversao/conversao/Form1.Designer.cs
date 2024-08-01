namespace conversao
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
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            txtValorDollar = new TextBox();
            txtCotacao = new TextBox();
            lblValorDollar = new Label();
            lblCotacaoAtual = new Label();
            btnConverter = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeProduto.Location = new Point(13, 49);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(169, 25);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome Do Produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = SystemColors.Info;
            txtNomeProduto.Location = new Point(188, 51);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(160, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // txtValorDollar
            // 
            txtValorDollar.BackColor = SystemColors.Info;
            txtValorDollar.Location = new Point(188, 102);
            txtValorDollar.Name = "txtValorDollar";
            txtValorDollar.Size = new Size(160, 23);
            txtValorDollar.TabIndex = 1;
            // 
            // txtCotacao
            // 
            txtCotacao.BackColor = SystemColors.Info;
            txtCotacao.Location = new Point(188, 158);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(160, 23);
            txtCotacao.TabIndex = 2;
            // 
            // lblValorDollar
            // 
            lblValorDollar.AutoSize = true;
            lblValorDollar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDollar.Location = new Point(35, 102);
            lblValorDollar.Name = "lblValorDollar";
            lblValorDollar.Size = new Size(147, 25);
            lblValorDollar.TabIndex = 4;
            lblValorDollar.Text = "Valor Em Dollar:";
            // 
            // lblCotacaoAtual
            // 
            lblCotacaoAtual.AutoSize = true;
            lblCotacaoAtual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCotacaoAtual.Location = new Point(48, 158);
            lblCotacaoAtual.Name = "lblCotacaoAtual";
            lblCotacaoAtual.Size = new Size(134, 25);
            lblCotacaoAtual.TabIndex = 5;
            lblCotacaoAtual.Text = "Cotação Atual:";
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConverter.Location = new Point(127, 241);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(188, 36);
            btnConverter.TabIndex = 6;
            btnConverter.Text = "&Converter Em Reais";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(35, 328);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 453);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(lblCotacaoAtual);
            Controls.Add(lblValorDollar);
            Controls.Add(txtCotacao);
            Controls.Add(txtValorDollar);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Name = "Form1";
            Text = "Conversão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorDollar;
        private TextBox txtCotacao;
        private Label lblValorDollar;
        private Label lblCotacaoAtual;
        private Button btnConverter;
        private Label lblResultado;
    }
}