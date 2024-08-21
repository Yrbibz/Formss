namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text != string.Empty && txtPeso.Text != string.Empty)
            {

                Double peso = Double.Parse(txtPeso.Text);
                Double altura = Double.Parse(txtAltura.Text);
                Double imc;

                imc = peso / (altura * altura);

                lblImc.Text = "IMC: " + imc.ToString();

            }
        }
    }
}