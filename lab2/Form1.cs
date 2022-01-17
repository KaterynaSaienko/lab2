using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox1.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox2.Text;
            int intKey = Convert.ToInt32(strKey, 16);

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox3.Text = strC;

            int int2code = intP ^ intKey;
            string str2code = Convert.ToString(int2code, 2);
            textBox4.Text = str2code;

            int int10code = intP ^ intKey;
            string str10code = Convert.ToString(int10code, 10);
            textBox5.Text = str10code;

            int int16code = intP ^ intKey;
            string str16code = Convert.ToString(int16code, 16);
            textBox6.Text = str16code;

        }
    }
}
