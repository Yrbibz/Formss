namespace descontoinss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtNomeEmpregado.Text != String.Empty && txtSalBruto.Text != String.Empty)
            {
                string nomeEmpregado = txtNomeEmpregado.Text;
                double SalarioBruto = Double.Parse(txtSalBruto.Text);
                double salarioLiquido;
                double descontoInss;
                double descontadoInss;
                double descontoIR;
                double descontadoIR;

                //sequencia if inss ladrao
                if (SalarioBruto <= 1412.00) {
                    descontoInss = 7.50/100;
                    descontadoInss = SalarioBruto * descontoInss;
                        }
                if (SalarioBruto > 1412.00 && SalarioBruto <=2666.68)
                {
                    descontoInss = 9.00 / 100;
                    descontadoInss = SalarioBruto * descontoInss;
                }
                if (SalarioBruto > 2666.68 && SalarioBruto <= 4000.03)
                {
                    descontoInss = 12.00 / 100;
                    descontadoInss = SalarioBruto * descontoInss;
                }
                if (SalarioBruto > 4000.03) 
                {
                    descontoInss = 14.00 / 100;
                    descontadoInss = SalarioBruto * descontoInss;
                }

                //sequencia if maldito imposto de renda

                if (SalarioBruto > 2112.00 && SalarioBruto<=2826.65) 
                {
                    descontoIR = 7.50 / 100; 
                    descontadoIR= SalarioBruto* descontoIR; 
                }



                
                //lblResultado.Text = "O Salário Liquido é de R$" + salarioLiquido.ToString("n2");
            }
        
            else
            {
                MessageBox.Show("Preencha TODOS os dados corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}