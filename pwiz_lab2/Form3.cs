using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwiz_lab2
{
    public partial class Form3 : Form
    {
        private Form2 form2;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.form2.computerPrice= (int.Parse(textBox1.Text)+int.Parse(textBox2.Text));
            this.form2.textBox1.Text=(int.Parse(this.textBox1.Text) + int.Parse(this.textBox2.Text)).ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(160);
            list.Add(270);
            list.Add(380);
            textBox1.Text = list[comboBox1.SelectedIndex].ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = 199.ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = 299.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = 399.ToString();
        }
    }
}
