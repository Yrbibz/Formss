namespace diretórioTeste
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
            label1 = new Label();
            label2 = new Label();
            txtCaminho = new TextBox();
            txtConteudo = new TextBox();
            btnAbrir = new Button();
            btnSalvar = new Button();
            btnCriar = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtCaminhar = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Caminho:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Conteúdo:";
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(84, 35);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(286, 23);
            txtCaminho.TabIndex = 2;
            // 
            // txtConteudo
            // 
            txtConteudo.Location = new Point(84, 122);
            txtConteudo.Multiline = true;
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(367, 193);
            txtConteudo.TabIndex = 3;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(150, 384);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir TXT";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(289, 384);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar TXT";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(131, 223);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCaminhar);
            groupBox1.Controls.Add(btnCriar);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(457, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 280);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 47);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Caminho:";
            // 
            // txtCaminhar
            // 
            txtCaminhar.Location = new Point(73, 44);
            txtCaminhar.Name = "txtCaminhar";
            txtCaminhar.Size = new Size(252, 23);
            txtCaminhar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnAbrir);
            Controls.Add(txtConteudo);
            Controls.Add(txtCaminho);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCaminho;
        private TextBox txtConteudo;
        private Button btnAbrir;
        private Button btnSalvar;
        private Button btnCriar;
        private GroupBox groupBox1;
        private TextBox txtCaminhar;
        private Label label3;
    }
}