using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarketingTask
{
    public partial class Form1 : Form
    {
        public static string GKPrice = "0";
        public static string Price = "0";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var temp = (RadioButton)sender;
            GKPrice = temp.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton8.Checked || radioButton9.Checked || radioButton15.Checked || radioButton16.Checked || radioButton22.Checked || radioButton23.Checked ||
                radioButton29.Checked || radioButton30.Checked)
            {
                GK gk = new GK();
                gk.ShowDialog();
                
            }
            if (radioButton3.Checked || radioButton4.Checked || radioButton10.Checked || radioButton11.Checked || radioButton17.Checked || radioButton18.Checked || radioButton24.Checked || radioButton25.Checked ||
                radioButton31.Checked || radioButton32.Checked)
            {
                HK hk = new HK();
                hk.ShowDialog();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = (TextBox)sender;
            Price = temp.Text;
        }
    }
}
