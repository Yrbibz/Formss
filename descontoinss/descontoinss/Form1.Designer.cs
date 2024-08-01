namespace descontoinss
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
            lblNomeEmpregado = new Label();
            lblSalBruto = new Label();
            txtNomeEmpregado = new TextBox();
            txtSalBruto = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNomeEmpregado
            // 
            lblNomeEmpregado.AutoSize = true;
            lblNomeEmpregado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeEmpregado.Location = new Point(21, 46);
            lblNomeEmpregado.Name = "lblNomeEmpregado";
            lblNomeEmpregado.Size = new Size(198, 25);
            lblNomeEmpregado.TabIndex = 0;
            lblNomeEmpregado.Text = "Nome Do Empregado:";
            // 
            // lblSalBruto
            // 
            lblSalBruto.AutoSize = true;
            lblSalBruto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalBruto.Location = new Point(94, 92);
            lblSalBruto.Name = "lblSalBruto";
            lblSalBruto.Size = new Size(125, 25);
            lblSalBruto.TabIndex = 1;
            lblSalBruto.Text = "Salário Bruto:";
            // 
            // txtNomeEmpregado
            // 
            txtNomeEmpregado.BackColor = SystemColors.Info;
            txtNomeEmpregado.Location = new Point(225, 51);
            txtNomeEmpregado.Name = "txtNomeEmpregado";
            txtNomeEmpregado.Size = new Size(547, 23);
            txtNomeEmpregado.TabIndex = 2;
            // 
            // txtSalBruto
            // 
            txtSalBruto.BackColor = SystemColors.Info;
            txtSalBruto.Location = new Point(225, 92);
            txtSalBruto.Name = "txtSalBruto";
            txtSalBruto.Size = new Size(179, 23);
            txtSalBruto.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(125, 158);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(212, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular o salário";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(30, 272);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 350);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalBruto);
            Controls.Add(txtNomeEmpregado);
            Controls.Add(lblSalBruto);
            Controls.Add(lblNomeEmpregado);
            Name = "Form1";
            Text = "Calculadora de salário liquído";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeEmpregado;
        private Label lblSalBruto;
        private TextBox txtNomeEmpregado;
        private TextBox txtSalBruto;
        private Button btnCalcular;
        private Label lblResultado;
    }
}