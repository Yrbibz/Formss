using System.DirectoryServices.ActiveDirectory;

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            if (txtNomeProduto.Text != String.Empty && txtValorDollar.Text != String.Empty && txtCotacao.Text != String.Empty)
            {
                if (Double.Parse(txtValorDollar.Text) > 0 && Double.Parse(txtCotacao.Text) > 0)
                {
                    double valorProduto = Double.Parse(txtValorDollar.Text);
                    double cotacaoAtual = Double.Parse(txtCotacao.Text);
                    string nomeProduto = txtNomeProduto.Text;
                    double valorProdutoReal;

                    valorProdutoReal = (valorProduto * cotacaoAtual);

                    lblResultado.Text = "O valor do produto '" + nomeProduto + "' é de R$" + valorProdutoReal.ToString("n2");
                }
            }
            else
            {
                MessageBox.Show("Preencha TODOS os dados corretamente!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}