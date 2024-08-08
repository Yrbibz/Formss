using Microsoft.VisualBasic.ApplicationServices;
using System.Linq.Expressions;
using System.Windows.Forms;

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


            if (txtPrimeiro.Text != string.Empty && txtSegundo.Text != string.Empty && txtTerceiro.Text != string.Empty)
            {


                double lado1 = Double.Parse(txtPrimeiro.Text);
                double lado2 = Double.Parse(txtSegundo.Text);
                double lado3 = Double.Parse(txtTerceiro.Text);

                if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
                {

                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        var imagemequilatero = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\caracteristicas-de-um-triangulo-equilatero-2-768x717.jpg");
                        lblClassificacao.Text = "Classifica��o: Equil�tero";
                        pctTriangulo.Image = imagemequilatero;


                    }

                    else if (lado1 != lado2 && lado1 != lado3 && lado3 != lado2)
                    {
                        var imagemisosceles = Image.FromFile(@"C: \Users\gabrielly.fsplaza\Downloads\formula - para - o - perimetro - de - um - triangulo - isosceles.png");

                        lblClassificacao.Text = "Classifica��o: Is�sceles";
                        pctTriangulo.Image = imagemisosceles;
                    }

                    else if ((lado1 == lado2 || lado1 == lado3 || lado2 == lado3) && (lado1 != lado2 || lado1 != lado3 || lado3 != lado2))
                    {

                        var imagemescaleno = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\OIP (1).PNG");
                        lblClassificacao.Text = "Classifica��o: Escaleno";
                        pctTriangulo.Image = imagemescaleno;
                    }
                }
                else
                {
                    pctTriangulo.Image = null;
                    lblClassificacao.Text = "Isso n�o � um tri�ngulo";
                }

                /* um de seus lados deve ser maior que o valor absoluto da diferen�a dos outros dois lados e menor que a soma dos outros dois lados123.*/

            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiro.Text = string.Empty;
            txtSegundo.Text = string.Empty;
            txtTerceiro.Text = string.Empty;
            lblClassificacao.Text = "Classifica��o:";
            pctTriangulo.Image = null;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}