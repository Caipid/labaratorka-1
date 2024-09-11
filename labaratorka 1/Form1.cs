namespace labaratorka_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)// ïëîùàäü
        {
            double side1;
            double side2;
            double gradus1;
            double s;
            if (!(double.TryParse(shrina.Text, out side1) && double.TryParse(dlina.Text, out side2) && double.TryParse(gradus.Text, out gradus1) ))
            {
                MessageBox.Show("Ошибка, введите правильные данные");
            }
            else
            {
                gradus1 = gradus1 * Math.PI / 180;
                s = side1 * side2 * Math.Sin(gradus1);
                label2.Text = s.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)// ïåðèìåòð
        {
            double side1;
            double side2;
            double gradus1;
            double p;
            if (!(double.TryParse(shrina.Text, out side1) && double.TryParse(dlina.Text, out side2) && double.TryParse(gradus.Text, out gradus1)))
            {
                MessageBox.Show("Ошибка, введите правильные данные");
            }
            else
            {

            }
        }
        private void shrina_Leave(object sender, EventArgs e)
        {
            double side1;
            double side2;
            double gradus1;
            double s;
            double p;
           if (!double.TryParse(shrina.Text, out side1))
                {
                    MessageBox.Show("Ошибка, введите правильные данные");
                    shrina.Focus();
                }
            else if (dlina.Text != "" && gradus.Text != "")
            {
                    double.TryParse(dlina.Text, out side2);
                    double.TryParse(gradus.Text, out gradus1);
                    gradus1 = gradus1 * Math.PI / 180;
                    s = side1 * side2 * Math.Sin(gradus1);
                    label2.Text = s.ToString();
                    p = 2 * side1 + 2 * side2;
                    label1.Text = p.ToString();
                }
            }

        private void dlina_Leave(object sender, EventArgs e)
        {
            double side1;
            double side2;
            double gradus1;
            double s;
            double p;
                    if (!double.TryParse(dlina.Text, out side2))
                    {
                        MessageBox.Show("Ошибка, введите правильные данные");
                        dlina.Focus();
                    }
                    else if (shrina.Text != ""  && gradus.Text != "")
                    {   
                        double.TryParse(shrina.Text, out side1);
                        double.TryParse(gradus.Text, out gradus1);
                        gradus1 = gradus1 * Math.PI / 180;
                        s = side1 * side2 * Math.Sin(gradus1);
                        label2.Text = s.ToString();
                        p = 2 * side1 + 2 * side2;
                        label1.Text = p.ToString();
                    }
                }
        private void gradus_Leave(object sender, EventArgs e)
        {
            double side1;
            double side2;
            double gradus1;
            double s;
            double p;
                if (!double.TryParse(gradus.Text, out gradus1))
                {
                    
                    MessageBox.Show("Ошибка, введите правильные данные");
                    gradus.Focus();
                }
                else if (shrina.Text != "" && dlina.Text != "" )
                {
                    double.TryParse(shrina.Text, out side1);
                    double.TryParse(dlina.Text, out side2);
                    gradus1 = gradus1 * Math.PI / 180;
                    s = side1 * side2 * Math.Sin(gradus1);
                    label2.Text = s.ToString();
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