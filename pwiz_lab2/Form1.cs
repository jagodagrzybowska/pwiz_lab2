namespace pwiz_lab2
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form2 form2)
        {
            this.form2 = form2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.form2.monitorPrice = int.Parse(textBox1.Text);
            this.form2.textBox1.Text = (this.form2.monitorPrice + this.form2.computerPrice).ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    if (item.Text == "Monitor 1")
                        textBox1.Text = 100.ToString();
                    else if (item.Text == "Monitor 2")
                        textBox1.Text = 200.ToString();
                    else if (item.Text == "Monitor 3")
                        textBox1.Text = 300.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
