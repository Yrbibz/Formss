using System.Security.Cryptography;

namespace ChapeuSeletor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChapeu_Click(object sender, EventArgs e)
        {
            //1 a 4 ai 1 pa e 2 pa
            string nome = txtNome.Text;



            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, insira o nome do aluno.");
                return;
            }


            Random numAlt = new Random();
            int num = numAlt.Next(5);


            switch (num)
            {
                case 1:
                    lstGrif.Items.Add(nome);
                    break;
                case 2:
                    lstCorv.Items.Add(nome);
                    break;
                case 3:
                    lstSon.Items.Add(nome);
                    break;
                case 4:
                    lstLuf.Items.Add(nome);
                    break;
            }

            txtNome.Clear();
            txtNome.Focus();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }

}