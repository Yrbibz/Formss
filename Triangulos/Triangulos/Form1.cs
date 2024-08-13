using Microsoft.VisualBasic.ApplicationServices;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Forms1 : Form
    {
        public Forms1()
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


            if (txtPrimeiro.Text != string.Empty && txtSegundo.Text != string.Empty && txtTerceiro.Text != string.Empty)
            {
                double lado1 = Double.Parse(txtPrimeiro.Text);
                double lado2 = Double.Parse(txtSegundo.Text);
                double lado3 = Double.Parse(txtTerceiro.Text);

                double anga, angb, angc;
                //lado1 - ladoA  ; lado2 - laboB ; lado3 - ladoC
                anga = Math.Acos(((lado2 * lado2) + (lado3 * lado3) - (lado1 * lado1)) / (2 * lado2 * lado3)) * (180.0 / Math.PI);
                angb = Math.Acos(((lado1 * lado1) + (lado3 * lado3) - (lado2 * lado2)) / (2 * lado1 * lado3)) * (180.0 / Math.PI);
                angc = Math.Acos(((lado1 * lado1) + (lado2 * lado2) - (lado3 * lado3)) / (2 * lado1 * lado2)) * (180.0 / Math.PI);

                var imagemequilatero = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\caracteristicas-de-um-triangulo-equilatero-2-768x717.jpg");
                var imagemisosceles = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\R (1).jfif");
                var imagemescaleno = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\OIP (1).PNG");
                var imagemAcutangulo = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\baixados.jfif");
                var imagemRetangulo = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\reto (1).jfif");
                var imagemObts = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\baixados (1).jfif");

                if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
                {

                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        lblClassificacao.Text = "Classificação: Equilátero";
                        pctTriangulo.Image = imagemequilatero;

                    }

                    else if (lado1 != lado2 && lado1 != lado3 && lado3 != lado2)
                    {
                        lblClassificacao.Text = "Classificação: Escaleno";
                        pctTriangulo.Image = imagemescaleno;
                    }

                    else if ((lado1 == lado2 || lado1 == lado3 || lado2 == lado3) && (lado1 != lado2 || lado1 != lado3 || lado3 != lado2))
                    {
                        lblClassificacao.Text = "Classificação: Isósceles";
                        pctTriangulo.Image = imagemisosceles;
                    }


                    if (anga < 90 && angb < 90 && angc < 90)
                    {
                        lblClassificacaoAngulo.Text = "Classificação: Acutângulo";
                        pctAngulo.Image = imagemAcutangulo;
                    }
                    else if (anga == 90 || angb == 90 || angc == 90)
                    {
                        lblClassificacaoAngulo.Text = "Classificação: Retângulo";
                        pctAngulo.Image = imagemRetangulo;
                    }
                    else if (anga > 90 || angb > 90 || angc > 90)
                    {
                        lblClassificacaoAngulo.Text = "Classificação: Obtusângulo";
                        pctAngulo.Image = imagemObts;
                    }
                }
                else
                {
                    pctTriangulo.Image = null;
                    lblClassificacao.Text = "Isso não é um triângulo";
                    lblClassificacaoAngulo.Text = "Não foi possível calcular";
                }

                /* um de seus lados deve ser maior que o valor absoluto da diferença dos outros dois lados e menor que a soma dos outros dois lados123.*/

            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiro.Text = string.Empty;
            txtSegundo.Text = string.Empty;
            txtTerceiro.Text = string.Empty;
            lblClassificacao.Text = "Classificação:";
            lblClassificacaoAngulo.Text = "Classificação:";
            pctTriangulo.Image = null;
            pctAngulo.Image = null;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.ShowDialog();
        }
    }
}