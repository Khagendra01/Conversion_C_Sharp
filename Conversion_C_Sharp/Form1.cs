using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_C_Sharp
{
    /**
     * @author Khagendra Khatri
     * Conversion
     * 
     */
    public partial class Form1 : Form
    {
        private double kilometer, liter, kilogram, meter;
        private double parseDouble = 0.0d;


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation, you have found easter egg of this program", "Easter Egg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = true;
        }

        public Form1()
        {
            kilometer = 1.60934;
            liter = 0.946353;
            kilogram = 0.453592;
            meter = 0.3048;
            InitializeComponent() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                parseDouble = Convert.ToDouble(textBox1.Text);
                if (radioButton1.Checked == true)
                {
                    textBox2.Text = Convert.ToString(parseDouble * kilometer);
                }
                else if (radioButton2.Checked == true)
                {
                    textBox2.Text = Convert.ToString(parseDouble * liter);
                }
                else if (radioButton3.Checked == true)
                {
                    textBox2.Text = Convert.ToString(parseDouble * kilogram);
                }
                else if (radioButton4.Checked == true)
                {
                    textBox2.Text = Convert.ToString(parseDouble * meter);
                }
                else if (radioButton5.Checked == true)
                {
                    textBox2.Text = Convert.ToString( (parseDouble - 32.0) / 1.8);
                }
            }
            catch
            {
                MessageBox.Show("Please input the valid number, Thank You");
                textBox1.Text = "";
                textBox2.Text = "";
                radioButton1.Checked = true;
            }
        }
    }
}
