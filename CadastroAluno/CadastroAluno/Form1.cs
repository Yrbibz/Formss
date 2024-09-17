namespace CadastroAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedIndex == 0)
            {
                rdbNoite.Checked = false;
                lstMesInicio.Items.Clear();
                rdbManha.Enabled = true;
                rdbTarde.Enabled = true;
                rdbNoite.Enabled = false;

                lstMesInicio.Items.Add("Agosto");
                lstMesInicio.Items.Add("Novembro");
            }
            if (cmbCurso.SelectedIndex == 1)
            {
                rdbManha.Checked = false;
                cmbCurso.SelectedIndex = -1;
                lstMesInicio.Items.Clear();
                rdbManha.Enabled = false;
                rdbTarde.Enabled = true;
                rdbNoite.Enabled = true;

                lstMesInicio.Items.Add("Setembro");
                lstMesInicio.Items.Add("Outubro");
            }
            if (cmbCurso.SelectedIndex == 2)
            {
                cmbCurso.SelectedIndex = -1;
                lstMesInicio.Items.Clear();
                rdbManha.Enabled = true;
                rdbTarde.Enabled = true;
                rdbNoite.Enabled = true;

                lstMesInicio.Items.Add("Setembro");
                lstMesInicio.Items.Add("Outubro");
                lstMesInicio.Items.Add("Novembro");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstMesInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtMatricula.Text != string.Empty && txtNome.Text != string.Empty && txtEmail.Text != string.Empty && (rdbFem.Checked || rdbMasc.Checked) && (rdbManha.Checked || rdbTarde.Checked || rdbNoite.Checked) && lstMesInicio.SelectedItem != null && (chcFut.Checked || chcXadrez.Checked || chcVolei.Checked || chcProgramar.Checked || chcSeries.Checked))
            {
                MessageBox.Show("Parabéns, o Aluno foi cadastrado com sucesso!", "Aluno Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("O Aluno não pode ser cadastrado", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Isso fechará o programa!", "!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Focus();
            lstMesInicio.Items.Clear();
            rdbManha.Checked = false;
            rdbTarde.Checked = false;
            rdbNoite.Checked = false;
            cmbCurso.SelectedIndex = -1;
            rdbFem.Checked = false;
            rdbMasc.Checked = false;
            chcFut.Checked = false;
            chcXadrez.Checked = false;
            chcVolei.Checked = false;
            chcProgramar.Checked = false;
            chcSeries.Checked = false;
            txtMatricula.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}