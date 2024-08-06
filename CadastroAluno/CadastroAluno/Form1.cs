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
            if(cmbCurso.SelectedIndex == 0)
            {
                rdbManha.Enabled = true;
                rdbTarde.Enabled = true;
                rdbNoite.Enabled = false;
            }
            if (cmbCurso.SelectedIndex == 1)
            {
                rdbManha.Enabled = false;
                rdbTarde.Enabled = true;
                rdbNoite.Enabled = true;
            }
            if (cmbCurso.SelectedIndex == 2)
            {
                rdbManha.Enabled = true;
                rdbTarde.Enabled = true;
                rdbNoite.Enabled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstMesInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}