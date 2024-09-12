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
            if (!string.IsNullOrEmpty(nome))
            {
                Random numero = new Random();

                int numeroAleatorio = numero.Next(1, 5);

                switch (numeroAleatorio)
                {
                    case 1:
                        lstGrif.Text = nome;
                        break;
                    case 2:
                        lstCorv.Text = nome;
                        break;
                    case 3:
                        lstSon.Text = nome; 
                        break;
                    case 4:
                        lstLuf.Text = nome;
                        break;
                }
            }


        }

    }

}