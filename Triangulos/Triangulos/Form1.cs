namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTerceiro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (txtPrimeiro.Text != string.Empty && txtSegundo.Text != string.Empty && txtTerceiro.Text != string.Empty) {

                /* 1= equilatero; 2= escaleno; 3=isocilisisisisi*/

                if (txtPrimeiro.Text == txtSegundo.Text && txtSegundo.Text == txtTerceiro.Text)
                {
                    lblClassificacao.Text = "Equilátero";
                }
                if (txtPrimeiro.Text != txtSegundo.Text && txtPrimeiro.Text != txtTerceiro.Text && txtTerceiro.Text != txtSegundo.Text)
                {
                    lblClassificacao.Text = "Escaleno";
                }
                if ((txtPrimeiro.Text == txtSegundo.Text || txtPrimeiro.Text == txtTerceiro.Text || txtSegundo.Text == txtTerceiro.Text) && (txtPrimeiro.Text != txtSegundo.Text || txtPrimeiro.Text != txtTerceiro.Text || txtTerceiro.Text != txtSegundo.Text))
                {
                    lblClassificacao.Text = "Isósceles";
                }
            }
            else
            {
                lblClassificacao.Text = "nnn";
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiro.Text = string.Empty;
            txtSegundo.Text = string.Empty;
            txtTerceiro.Text = string.Empty;
        }
    }
}