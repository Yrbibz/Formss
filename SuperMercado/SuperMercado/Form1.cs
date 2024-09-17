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
            if (!string.IsNullOrEmpty(txtCodBarras.Text))
            {
                string codigoBarras = txtCodBarras.Text;
                string[] linhasCupom = rtbCupom.Lines;

                for (int i = 0; i < linhasCupom.Length; i++)
                {
                    if (linhasCupom[i].Contains(codigoBarras))
                    {
                        string linha = linhasCupom[i];
                        string[] partes = linha.Split('=');

                        if (partes.Length == 2 && double.TryParse(partes[1], out double valorItem))
                        {

                            if (double.TryParse(lblTotalCompra.Text, out double totalCompra))
                            {
                                totalCompra -= valorItem;
                                lblTotalCompra.Text = totalCompra.ToString("F2");
                            }

                            List<string> listaLinhas = new List<string>(linhasCupom);
                            listaLinhas.RemoveAt(i);
                            rtbCupom.Lines = listaLinhas.ToArray();

                            MessageBox.Show("Item removido.");
                        }
                        break;
                    }
                }
            }

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            lblTotalCompra.Visible = true;

            if (!string.IsNullOrEmpty(txtCodBarras.Text) && !string.IsNullOrEmpty(txtDesc.Text) && !string.IsNullOrEmpty(txtQuant.Text) && !string.IsNullOrEmpty(txtPrecoUnitario.Text))
            {
                if (double.TryParse(txtPrecoUnitario.Text, out double precoIndiv) && double.TryParse(txtQuant.Text, out double quanti))
                {
                    double total = quanti * precoIndiv;
                    string CodBarra = txtCodBarras.Text;
                    rtbCupom.Text = $"{precoIndiv:F2} x {quanti} = {total:F2}\n" + rtbCupom.Text;

                    if (double.TryParse(lblTotalCompra.Text, out double totalCompraAtual))
                    {
                        totalCompraAtual += total;
                        lblTotalCompra.Text = totalCompraAtual.ToString("F2");
                    }
                    else
                    {
                        lblTotalCompra.Text = total.ToString("F2");
                    }
                }
                else
                {
                    MessageBox.Show("Valores inválidos.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }



        }

        private void txtRemoverProduto_TextChanged(object sender, EventArgs e)
        {

            txtRemoverProduto.PasswordChar = '*';
        }

        private void txtCodigoApagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtRemoverProduto.Text != "1234")
            {
                MessageBox.Show("Senha incorreta");
            }
            else
            {
                btnRemove.Visible = true;
                txtCodigoApagar.Visible = true;
                lblCodApaga.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Recebido = double.Parse(txtValorRecebido.Text);
            double Total = double.Parse(lblTotalCompra.Text);
            double Troco;

            Troco = Recebido - Total;

            txtTroco.Text = "R$" + Troco.ToString("F2");
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            txtValorRecebido.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            txtCodBarras.Text = string.Empty;
            txtQuant.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtRemoverProduto.Text = string.Empty;
            txtCodigoApagar.Text = string.Empty;
            txtValorRecebido.Text = string.Empty;
            txtTroco.Text = string.Empty;
            msbCpf.Text = string.Empty;
            rtbCupom.Text = string.Empty;
        }
    }
}