namespace TesteTimer
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
            btnIniciar = new Button();
            btnPausar = new Button();
            btnZerar = new Button();
            lblPorcentagem = new Label();
            prgTimer = new ProgressBar();
            tmrProgresso = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(43, 240);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(83, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Enabled = false;
            btnPausar.Location = new Point(179, 240);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(83, 29);
            btnPausar.TabIndex = 1;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnZerar
            // 
            btnZerar.Enabled = false;
            btnZerar.Location = new Point(316, 240);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(83, 29);
            btnZerar.TabIndex = 2;
            btnZerar.Text = "Zerar";
            btnZerar.UseVisualStyleBackColor = true;
            btnZerar.Click += btnZerar_Click;
            // 
            // lblPorcentagem
            // 
            lblPorcentagem.AutoSize = true;
            lblPorcentagem.Location = new Point(203, 181);
            lblPorcentagem.Name = "lblPorcentagem";
            lblPorcentagem.Size = new Size(23, 15);
            lblPorcentagem.TabIndex = 3;
            lblPorcentagem.Text = "0%";
            // 
            // prgTimer
            // 
            prgTimer.Location = new Point(60, 106);
            prgTimer.Name = "prgTimer";
            prgTimer.Size = new Size(316, 28);
            prgTimer.TabIndex = 4;
            prgTimer.Click += prgTimer_Click;
            // 
            // tmrProgresso
            // 
            tmrProgresso.Tick += tmrProgresso_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 298);
            Controls.Add(prgTimer);
            Controls.Add(lblPorcentagem);
            Controls.Add(btnZerar);
            Controls.Add(btnPausar);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnPausar;
        private Button btnZerar;
        private Label lblPorcentagem;
        private ProgressBar prgTimer;
        private System.Windows.Forms.Timer tmrProgresso;
    }
}