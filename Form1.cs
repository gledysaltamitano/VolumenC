namespace VolumenC
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cili_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(textBox4.Text);
            double altura = double.Parse(textBox5.Text);
            double primero = 3.1416 * altura;
            double elevado = radio * radio;
            double ultimo = primero * elevado;
            resultadocili.Text = ultimo.ToString();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultadocili_Click(object sender, EventArgs e)
        {

        }

        private void prisma_Click(object sender, EventArgs e)
        {
            double largo = double.Parse(textBox1.Text);
            double apotema = double.Parse(textBox2.Text);
            double altura = double.Parse(textBox3.Text);
            double resultado = 3 * largo * apotema * altura;
            resultadopris.Text = resultado.ToString();
        }
    }
}
