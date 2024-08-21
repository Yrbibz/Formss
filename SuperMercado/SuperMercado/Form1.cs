namespace SuperMercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIrPagamento_Click(object sender, EventArgs e)
        {
            gpbFormaPagamento.Enabled = true;
        }

        private void btnAbreCupom_Click(object sender, EventArgs e)
        {
            gpbCupom.Enabled = true;
            gpbProdutoAtual.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtRemoverProduto.Text != string.Empty)
            {
                // MessageBox
            }

            if (txtRemoverProduto.Text != "1234")
            {
                MessageBox.Show("Senha incorreta");
            }
            //else 
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (txtCodBarras.Text != null && txtDesc.Text != null && txtQuant.Text != null && txtPrecoUnitario.Text != null)
            {

                double totalporproduto, total;
                double precoindiv = double.Parse(txtPrecoUnitario.Text);
                double quanti = double.Parse(txtQuant.Text);

                totalporproduto = 0;


                rtbCupom.Text = txtPrecoUnitario.Text + "X" + txtQuant.Text + "=" + quanti*precoindiv + "\n" + rtbCupom.Text;
                total = (quanti*precoindiv) + totalporproduto;

                lblTotalCompra.Text = total.ToString("F2");
            }
                
        }

        private void txtRemoverProduto_TextChanged(object sender, EventArgs e)
        {
             txtRemoverProduto.PasswordChar = '*';  
        }
    }
}