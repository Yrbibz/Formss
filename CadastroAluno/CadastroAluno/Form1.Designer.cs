namespace CadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCadastro = new Label();
            grpDados = new GroupBox();
            lblEmail = new Label();
            lblNome = new Label();
            lblMatricula = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            grpHobbies = new GroupBox();
            chcVolei = new CheckBox();
            chcProgramar = new CheckBox();
            chcSeries = new CheckBox();
            chcXadrez = new CheckBox();
            chcFut = new CheckBox();
            grpSexo = new GroupBox();
            rdbMasc = new RadioButton();
            rdbFem = new RadioButton();
            grpCurso = new GroupBox();
            label2 = new Label();
            lstMesInicio = new ListBox();
            grpPeriodo = new GroupBox();
            rdbNoite = new RadioButton();
            rdbTarde = new RadioButton();
            rdbManha = new RadioButton();
            cmbCurso = new ComboBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            grpDados.SuspendLayout();
            grpHobbies.SuspendLayout();
            grpSexo.SuspendLayout();
            grpCurso.SuspendLayout();
            grpPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastro.ForeColor = Color.Red;
            lblCadastro.Location = new Point(263, 53);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(237, 32);
            lblCadastro.TabIndex = 0;
            lblCadastro.Text = "Cadastro de Alunos";
            // 
            // grpDados
            // 
            grpDados.Controls.Add(lblEmail);
            grpDados.Controls.Add(lblNome);
            grpDados.Controls.Add(lblMatricula);
            grpDados.Controls.Add(txtEmail);
            grpDados.Controls.Add(txtNome);
            grpDados.Controls.Add(txtMatricula);
            grpDados.Controls.Add(grpHobbies);
            grpDados.Controls.Add(grpSexo);
            grpDados.Location = new Point(12, 138);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(531, 246);
            grpDados.TabIndex = 1;
            grpDados.TabStop = false;
            grpDados.Text = "Dados Pessoais:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 105);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 71);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(20, 37);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 5;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(432, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(432, 23);
            txtNome.TabIndex = 2;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(86, 34);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(133, 23);
            txtMatricula.TabIndex = 1;
            // 
            // grpHobbies
            // 
            grpHobbies.Controls.Add(chcVolei);
            grpHobbies.Controls.Add(chcProgramar);
            grpHobbies.Controls.Add(chcSeries);
            grpHobbies.Controls.Add(chcXadrez);
            grpHobbies.Controls.Add(chcFut);
            grpHobbies.Location = new Point(170, 155);
            grpHobbies.Name = "grpHobbies";
            grpHobbies.Size = new Size(353, 83);
            grpHobbies.TabIndex = 1;
            grpHobbies.TabStop = false;
            grpHobbies.Text = "Hobbies:";
            // 
            // chcVolei
            // 
            chcVolei.AutoSize = true;
            chcVolei.Location = new Point(246, 23);
            chcVolei.Name = "chcVolei";
            chcVolei.Size = new Size(51, 19);
            chcVolei.TabIndex = 10;
            chcVolei.Text = "Vôlei";
            chcVolei.UseVisualStyleBackColor = true;
            // 
            // chcProgramar
            // 
            chcProgramar.AutoSize = true;
            chcProgramar.Location = new Point(126, 52);
            chcProgramar.Name = "chcProgramar";
            chcProgramar.Size = new Size(120, 19);
            chcProgramar.TabIndex = 9;
            chcProgramar.Text = "Programar em C#";
            chcProgramar.UseVisualStyleBackColor = true;
            // 
            // chcSeries
            // 
            chcSeries.AutoSize = true;
            chcSeries.Location = new Point(18, 52);
            chcSeries.Name = "chcSeries";
            chcSeries.Size = new Size(56, 19);
            chcSeries.TabIndex = 7;
            chcSeries.Text = "Séries";
            chcSeries.UseVisualStyleBackColor = true;
            // 
            // chcXadrez
            // 
            chcXadrez.AutoSize = true;
            chcXadrez.Location = new Point(126, 22);
            chcXadrez.Name = "chcXadrez";
            chcXadrez.Size = new Size(61, 19);
            chcXadrez.TabIndex = 8;
            chcXadrez.Text = "Xadrez";
            chcXadrez.UseVisualStyleBackColor = true;
            // 
            // chcFut
            // 
            chcFut.AutoSize = true;
            chcFut.Location = new Point(18, 22);
            chcFut.Name = "chcFut";
            chcFut.Size = new Size(66, 19);
            chcFut.TabIndex = 6;
            chcFut.Text = "Futebol";
            chcFut.UseVisualStyleBackColor = true;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(rdbMasc);
            grpSexo.Controls.Add(rdbFem);
            grpSexo.Location = new Point(6, 155);
            grpSexo.Name = "grpSexo";
            grpSexo.Size = new Size(145, 83);
            grpSexo.TabIndex = 0;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo:";
            // 
            // rdbMasc
            // 
            rdbMasc.AutoSize = true;
            rdbMasc.Location = new Point(6, 22);
            rdbMasc.Name = "rdbMasc";
            rdbMasc.Size = new Size(80, 19);
            rdbMasc.TabIndex = 4;
            rdbMasc.TabStop = true;
            rdbMasc.Text = "Masculino";
            rdbMasc.UseVisualStyleBackColor = true;
            rdbMasc.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbFem
            // 
            rdbFem.AutoSize = true;
            rdbFem.Location = new Point(6, 47);
            rdbFem.Name = "rdbFem";
            rdbFem.Size = new Size(75, 19);
            rdbFem.TabIndex = 5;
            rdbFem.TabStop = true;
            rdbFem.Text = "Feminino";
            rdbFem.UseVisualStyleBackColor = true;
            // 
            // grpCurso
            // 
            grpCurso.Controls.Add(label2);
            grpCurso.Controls.Add(lstMesInicio);
            grpCurso.Controls.Add(grpPeriodo);
            grpCurso.Controls.Add(cmbCurso);
            grpCurso.Location = new Point(12, 405);
            grpCurso.Name = "grpCurso";
            grpCurso.Size = new Size(531, 186);
            grpCurso.TabIndex = 2;
            grpCurso.TabStop = false;
            grpCurso.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 22);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "Mês de início:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstMesInicio
            // 
            lstMesInicio.FormattingEnabled = true;
            lstMesInicio.ItemHeight = 15;
            lstMesInicio.Location = new Point(392, 22);
            lstMesInicio.Name = "lstMesInicio";
            lstMesInicio.Size = new Size(131, 34);
            lstMesInicio.TabIndex = 15;
            lstMesInicio.SelectedIndexChanged += lstMesInicio_SelectedIndexChanged;
            // 
            // grpPeriodo
            // 
            grpPeriodo.Controls.Add(rdbNoite);
            grpPeriodo.Controls.Add(rdbTarde);
            grpPeriodo.Controls.Add(rdbManha);
            grpPeriodo.Location = new Point(6, 61);
            grpPeriodo.Name = "grpPeriodo";
            grpPeriodo.Size = new Size(110, 106);
            grpPeriodo.TabIndex = 1;
            grpPeriodo.TabStop = false;
            grpPeriodo.Text = "Período:";
            // 
            // rdbNoite
            // 
            rdbNoite.AutoSize = true;
            rdbNoite.Location = new Point(19, 72);
            rdbNoite.Name = "rdbNoite";
            rdbNoite.Size = new Size(54, 19);
            rdbNoite.TabIndex = 14;
            rdbNoite.TabStop = true;
            rdbNoite.Text = "Noite";
            rdbNoite.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(19, 47);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(53, 19);
            rdbTarde.TabIndex = 13;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "Tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbManha
            // 
            rdbManha.AutoSize = true;
            rdbManha.Location = new Point(19, 22);
            rdbManha.Name = "rdbManha";
            rdbManha.Size = new Size(62, 19);
            rdbManha.TabIndex = 12;
            rdbManha.TabStop = true;
            rdbManha.Text = "Manhã";
            rdbManha.UseVisualStyleBackColor = true;
            // 
            // cmbCurso
            // 
            cmbCurso.BackColor = SystemColors.Window;
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Técnico em Desenvolvimento de Sistemas", "Técnico em Informática para internet", "Técnico em Design Gráfico" });
            cmbCurso.Location = new Point(6, 22);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(249, 23);
            cmbCurso.TabIndex = 11;
            cmbCurso.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.TopCenter;
            btnSalvar.Location = new Point(115, 601);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 84);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnSalvar, "Apere para salvar o cadastro");
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.TopCenter;
            btnLimpar.Location = new Point(223, 601);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(79, 84);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnLimpar, "Aperte para limpar todos os campos");
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(332, 601);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(79, 84);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnSair, "Aperte para sair");
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 693);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(grpCurso);
            Controls.Add(grpDados);
            Controls.Add(lblCadastro);
            Name = "Form1";
            Text = "Form1";
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            grpHobbies.ResumeLayout(false);
            grpHobbies.PerformLayout();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            grpCurso.ResumeLayout(false);
            grpCurso.PerformLayout();
            grpPeriodo.ResumeLayout(false);
            grpPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastro;
        private GroupBox grpDados;
        private GroupBox grpHobbies;
        private GroupBox grpSexo;
        private GroupBox grpCurso;
        private ComboBox cmbCurso;
        private RadioButton rdbMasc;
        private RadioButton rdbFem;
        private RadioButton rdbNoite;
        private GroupBox grpPeriodo;
        private RadioButton rdbTarde;
        private RadioButton rdbManha;
        private Label lblEmail;
        private Label lblNome;
        private Label lblMatricula;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private CheckBox chcVolei;
        private CheckBox chcProgramar;
        private CheckBox chcSeries;
        private CheckBox chcXadrez;
        private CheckBox chcFut;
        private ListBox lstMesInicio;
        private Label label2;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnSair;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
    }
}