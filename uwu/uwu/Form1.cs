namespace uwu
{
    public partial class uwu : Form
    {
        public uwu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, soma, veze, sub;
            n1 = Double.Parse(textBox1.Text);
            n2 = Double.Parse(textBox2.Text);
            soma = n1 + n2;
            veze= n1 * n2;
            sub = n1 - n2;
            label5.Text = soma.ToString();
            vezes.Text = veze.ToString();
            subtra.Text = sub.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            vezes.Text = " ";
            subtra.Text = " ";
            label5.Text = " ";
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void vezes_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}