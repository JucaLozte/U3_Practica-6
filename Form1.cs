namespace U3_Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if (num % 2 == 0)
            {
                listBox1.Items.Add(num + " Par");
            }
            else
            {
                listBox1.Items.Add(num + " Impar");
            }
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}