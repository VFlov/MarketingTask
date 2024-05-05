using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MarketingTask
{
    public partial class HK : Form
    {
        private static int Thickness = 0;
        private static int PercentS = 0;
        private static int PercentBG = 0;
        private static int PercentCredit = 0;
        public HK()
        {
            InitializeComponent();
            label2.Text = Form1.GKPrice;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var temp = (RadioButton)sender;
            var temp2 = temp.Text.Split(' ');
            int index = Array.IndexOf(temp2, "=");
            Thickness = int.Parse(temp2[index + 1]);
        }
        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            var temp = (RadioButton)sender;
            var temp2 = temp.Text.Split(' ');
            int index = Array.IndexOf(temp2, "=");
            PercentS = int.Parse(temp2[index + 1]);
        }
        private void radioButtonBG_CheckedChanged(object sender, EventArgs e)
        {
            var temp = (RadioButton)sender;
            var temp2 = temp.Text.Split(' ');
            int index = Array.IndexOf(temp2, "=");
            PercentBG = int.Parse(temp2[index + 1]);
        }
        private void radioButtonCredit_CheckedChanged(object sender, EventArgs e)
        {
            var temp = (RadioButton)sender;
            var temp2 = temp.Text.Split(' ');
            int index = Array.IndexOf(temp2, "=");
            PercentCredit = int.Parse(temp2[index + 1]);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var indices = checkedListBox1.SelectedIndices;
            //checkedList.GetEnumerator().MoveNext();
            int result = 5;
            if (textBox1.Text != "" || int.TryParse(textBox1.Text, out result))
            {
                foreach (string line in checkedListBox1.SelectedItems)
                {
                    var temp = line.Split(' ');
                    int index = Array.IndexOf(temp, "=");
                    Thickness += int.Parse(temp[index + 1]);

                }
                MessageBox.Show($"Кол-во изделий: {result} * (Цену за изделие {Form1.GKPrice} + (усл ед {Thickness} * цену ед {Form1.Price})) * Обьем надбавки: {PercentS}% + Приплата за кредит: {PercentCredit}% + Приплата за БГ: {PercentBG}% \n = \n {result * (int.Parse(Form1.GKPrice) + (Thickness * int.Parse(Form1.Price)) * ((PercentBG + PercentCredit + PercentS) / 100))}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
