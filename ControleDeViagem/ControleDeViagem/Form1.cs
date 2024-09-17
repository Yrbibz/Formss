namespace ControleDeViagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var BSp = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\bandeira-sao-paulo1-105x70.png");
            var BRio = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\bandeira-rio-de-janeiro1-105x74.png");
            var BEspi = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\bandeira-espirito-santo-105x74.png");
            var BMinas = Image.FromFile(@"C:\Users\gabrielly.fsplaza\Pictures\bandeira-minas-gerais-105x74.png");

        }

    }
}