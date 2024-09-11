namespace labaratorka_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// площадь
        {
            double side1;
            double side2;
            double gradus1;
            double s;
            if (!(double.TryParse(shrina.Text, out side1) && double.TryParse(dlina.Text, out side2) && double.TryParse(gradus.Text, out gradus1)))
            {
                MessageBox.Show("¬ведите правильные числовые значени€");
            }
            else
            {
                gradus1 = gradus1 * Math.PI / 180;
                s = side1 * side2 * Math.Sin(gradus1);
                label2.Text = s.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)// периметр
        {
            double side1;
            double side2;
            double gradus1;
            double p;
            if (!(double.TryParse(shrina.Text, out side1) && double.TryParse(dlina.Text, out side2) && double.TryParse(gradus.Text, out gradus1)))
            {
                MessageBox.Show("¬ведите правильные числовые значени€");
            }
            else
            {
                p = 2 * side1 + 2 * side2;
                label1.Text = p.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
