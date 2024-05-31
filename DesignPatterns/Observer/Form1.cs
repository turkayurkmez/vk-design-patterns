namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox1.Text;
            label3.Text = textBox1.Text;
            label4.Text = textBox1.Text;
            label5.Text = textBox1.Text;
            label6.Text = textBox1.Text;
            label7.Text = textBox1.Text;
            label8.Text = textBox1.Text;


        }

        private ColorObservable colorObservable = new ColorObservable();
        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(colorObservable);
            form2.Show();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                colorObservable.Color = colorDialog.Color;
            }
        }
    }
}
