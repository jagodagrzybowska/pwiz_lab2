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
    public partial class Form2 : Form
    {
        public int computerPrice;
        public int monitorPrice;

        private Form2 form2;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form2 form2)
        {
            this.form2 = form2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(this);
            frm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3= new Form3(this);
            frm3.Show();
        }
    }
}
