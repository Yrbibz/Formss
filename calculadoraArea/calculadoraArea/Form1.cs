using System.Globalization;

namespace calculadoraArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbCirculo_CheckedChanged(object sender, EventArgs e)
        {

            txtValorTres.Visible = true;
            lblValorTres.Visible = true;

            lblLado.Visible = false;
            lblBaseD.Visible = false;

            txtValorUm.Visible = false;
            lblValorUm.Visible = false;

            txtValorDois.Visible = false;
            lblValorDois.Visible = false;

            lblAviso.Visible = true;
            BackColor = Color.CadetBlue;
            txtValorTres.Focus();
            txtValorTres.Text = "";
            txtResultado.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdbCirculo.Checked)
            {
                if (txtValorTres.Text != String.Empty)
                {
                    txtValorTres.Visible = true;
                    double raio = Double.Parse(txtValorTres.Text);
                    if (raio > 0)
                    {
                        double resultado;
                        resultado = (raio * raio) * 3.14;
                        resultado = Math.Round(resultado, 2);
                        txtResultado.Text = "3,14*" + raio.ToString() + "² = " + resultado + "cm²";
                    }
                    else
                    {
                        MessageBox.Show("Preencha com NÚMEROS POSITIVOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha TODOS os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbQuadrado.Checked)
            {
                if (txtValorTres.Text != String.Empty)
                {
                    double lado = Double.Parse(txtValorTres.Text);
                    if (lado > 0)
                    {
                        double resultado;
                        resultado = (lado * lado);
                        resultado = Math.Round(resultado, 2);
                        txtResultado.Text = lado + "*" + lado.ToString() + " = " + resultado + "cm²";
                    }
                    else
                    {
                        MessageBox.Show("Preencha com NÚMEROS POSITIVOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha TODOS os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbRetangulo.Checked)
            {
                if (txtValorDois.Text != String.Empty && txtValorTres.Text != String.Empty)
                {
                    double altura = Double.Parse(txtValorTres.Text);
                    double basee = Double.Parse(txtValorDois.Text);
                    if (basee > 0 && altura > 0)
                    {
                        double resultado;
                        resultado = (basee * altura);
                        resultado = Math.Round(resultado, 2);
                        txtResultado.Text = basee + "*" + altura.ToString() + " = " + resultado + "cm²";
                    }
                    else
                    {
                        MessageBox.Show("Preencha com NÚMEROS POSITIVOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha TODOS os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbTriangulo.Checked)
            {
                if (txtValorDois.Text != String.Empty && txtValorTres.Text != String.Empty)
                {
                    double altura = Double.Parse(txtValorTres.Text);
                    double basee = Double.Parse(txtValorDois.Text);
                    if (altura >0 && basee>0)
                    {
                        double resultado;
                        resultado = (basee * altura) / 2;
                        resultado = Math.Round(resultado, 2);
                        txtResultado.Text = basee + "*" + altura.ToString() + "/2 = " + resultado + "cm²";
                    }
                    else  
                    {
                        MessageBox.Show("Preencha com NÚMEROS POSITIVOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Preencha TODOS os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdbTrapezio.Checked)
            {
                if (txtValorDois.Text != String.Empty && txtValorUm.Text != String.Empty && txtValorUm.Text != String.Empty)
                {
                    double basee2 = Double.Parse(txtValorDois.Text);
                    double altura = Double.Parse(txtValorTres.Text);
                    double basee = Double.Parse(txtValorUm.Text);
                    if (basee > 0 && altura > 0 && basee2 > 0)
                    {
                        double resultado;
                        resultado = ((basee + basee2) * altura) / 2;
                        resultado = Math.Round(resultado, 2);
                        txtResultado.Text = basee + "+" + basee2 + "*" + altura.ToString() + "/2 = " + resultado + "cm²";
                    }
                    else
                    {
                     MessageBox.Show("Preencha com NÚMEROS POSITIVOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha TODOS os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void rdbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            lblLado.Visible = true;
            lblBaseD.Visible = false;

            txtValorTres.Visible = true;
            lblValorTres.Visible = false;

            txtValorUm.Visible = false;
            lblValorUm.Visible = false;

            txtValorDois.Visible = false;
            lblValorDois.Visible = false;

            lblAviso.Visible = true;

            BackColor = Color.RosyBrown;
            txtValorDois.Focus();
            txtValorDois.Text = "";
            txtResultado.Text = "";
        }

        private void lblValorDois_Click(object sender, EventArgs e)
        {

        }

        private void lblLado_Click(object sender, EventArgs e)
        {

        }

        private void rdbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblLado.Visible = false;
            lblBaseD.Visible = true;

            txtValorTres.Visible = true;
            lblValorTres.Visible = false;

            txtValorUm.Visible = false;
            lblValorUm.Visible = false;

            txtValorDois.Visible = true;
            lblValorDois.Visible = true;

            lblAviso.Visible = true;
            BackColor = Color.Chocolate;
            txtValorDois.Focus();
            txtValorUm.Text = "";
            txtValorDois.Text = "";
            txtValorTres.Text = "";
            txtResultado.Text = "";

        }

        private void rdbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblLado.Visible = false;
            lblBaseD.Visible = true;

            txtValorTres.Visible = true;
            lblValorTres.Visible = false;

            txtValorUm.Visible = false;
            lblValorUm.Visible = false;

            txtValorDois.Visible = true;
            lblValorDois.Visible = true;

            lblAviso.Visible = true;
            BackColor = Color.Bisque;
            txtValorDois.Focus();
            txtValorUm.Text = "";
            txtValorDois.Text = "";
            txtValorTres.Text = "";
            txtResultado.Text = "";
        }

        private void rdbTrapezio_CheckedChanged(object sender, EventArgs e)
        {

            lblLado.Visible = false;
            lblBaseD.Visible = true;

            txtValorTres.Visible = true;
            lblValorTres.Visible = false;

            txtValorUm.Visible = true;
            lblValorUm.Visible = true;

            txtValorDois.Visible = true;
            lblValorDois.Visible = true;

            lblAviso.Visible = true;
            BackColor = Color.RebeccaPurple;
            txtValorUm.Focus();
            txtValorUm.Text = "";
            txtValorDois.Text = "";
            txtValorTres.Text = "";
            txtResultado.Text = "";
        }

        private void lblAviso_Click(object sender, EventArgs e)
        {

        }
    }
}