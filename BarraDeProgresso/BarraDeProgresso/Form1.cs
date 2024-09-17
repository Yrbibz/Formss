namespace BarraDeProgresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            rtbNumeros.Text = mtbNumero.Text + "\n" + rtbNumeros.Text ;

            lblP.Text = prgNumeros.Value.ToString() + "%";
            mtbNumero.Focus();
            mtbNumero.Text = null;
            prgNumeros.Value = prgNumeros.Value + 10;

            if (prgNumeros.Value == 100)
            {
                mtbNumero.Enabled = false;  
                btnOk.Enabled = false;
                rtbNumeros.Enabled = false;
                MessageBox.Show("Atingiu 100%");
            }

        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.TextLength < 2)
            {
                errorTextos.SetError(txtNum, "Quantidade de caracteres insulficiente");
            }
           else if (txtNum.TextLength > 2)
            {
                errorTextos.SetError(txtNum, "Quantidade de caracteres ultrapassada");
            }
            else
            {
                errorTextos.Clear();
            }
        }
    }
}