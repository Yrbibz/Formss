using Microsoft.VisualBasic.ApplicationServices;

namespace Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComecar_Click(object sender, EventArgs e)
        {

            //fazer if pra verifca bagulho
            var dadoUm = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Downloads\1 - Um.JPG");
            var dadoDois = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Downloads\2 - Dois.JPG");
            var dadoTres = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Downloads\3 - Três.jpg");
            var dadoQuatro = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Downloads\4 - Quatro.JPG");
            var dadoCinco = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Downloads\5 - Cinco.JPG");
            var dadoSeis = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Downloads\6 - Seis.JPG");
            var fimbom = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\OIP (4).jfif");
            var fimruim = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\OIP (5).jfif");


            Random dado = new Random();

            int ValorDadoUser = dado.Next(1, 7);
            int ValorDadoComp = dado.Next(1, 7);

            int vdu, vdc;
            vdu = 0;
            vdc = 0;

            if (txtNome.Text != string.Empty)
            {

                //do usuarioo
                if (ValorDadoUser == 1)
                {
                    pctDadoUser.Image = dadoUm;
                    lblNumDadin.Text = "1";
                    vdu = 1;
                }
                else if (ValorDadoUser == 2)
                {
                    pctDadoUser.Image = dadoDois;
                    lblNumDadin.Text = "2";
                    vdu = 2;
                }
                else if (ValorDadoUser == 3)
                {
                    pctDadoUser.Image = dadoTres;
                    lblNumDadin.Text = "3";
                    vdu = 3;
                }
                else if (ValorDadoUser == 4)
                {
                    pctDadoUser.Image = dadoQuatro;
                    lblNumDadin.Text = "4";
                    vdu = 4;
                }
                else if (ValorDadoUser == 5)
                {
                    pctDadoUser.Image = dadoCinco;
                    lblNumDadin.Text = "5";
                    vdu = 5;
                }
                else
                {
                    pctDadoUser.Image = dadoSeis;
                    lblNumDadin.Text = "6";
                    vdu = 6;
                }

                //do pc
                if (ValorDadoComp == 1)
                {
                    pctDadoComp.Image = dadoUm;
                    lblNumDadao.Text = "1";
                    vdc = 1;
                }
                else if (ValorDadoComp == 2)
                {
                    pctDadoComp.Image = dadoDois;
                    lblNumDadao.Text = "2";
                    vdc = 2;
                }
                else if (ValorDadoComp == 3)
                {
                    pctDadoComp.Image = dadoTres;
                    lblNumDadao.Text = "3";
                    vdc = 3;
                }
                else if (ValorDadoComp == 4)
                {
                    pctDadoComp.Image = dadoQuatro;
                    lblNumDadao.Text = "4";
                    vdc = 4;
                }
                else if (ValorDadoComp == 5)
                {
                    pctDadoComp.Image = dadoCinco;
                    lblNumDadao.Text = "5";
                    vdc = 5;
                }
                else
                {
                    pctDadoComp.Image = dadoSeis;
                    lblNumDadao.Text = "6";
                    vdc = 6;
                }

                if (vdc > vdu)
                {
                    pctFim.Image = fimbom;
                    MessageBox.Show("Você perdeu!");


                }

                else if (vdc < vdu)
                {
                    pctFim.Image = fimruim;
                    MessageBox.Show("Você ganhou.");
                   
                }

                if (vdc == vdu)
                {
                    MessageBox.Show("O mundo precisa de um salvador... pois para ter um vencedor tem que haver um perdedor...");
                }

            }
            else
            {
                MessageBox.Show("Preencha o nome");
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {

        }

        private void pcbFinal_Click(object sender, EventArgs e)
        {

        }
    }
}