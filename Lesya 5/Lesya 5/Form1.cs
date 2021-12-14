using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesya_5
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Питание:";
            label4.Text = "Имя модели:";
            label5.Text = "Уровень заряда:";
            label7.Text = "Размер экрана:";
            try
            {
                Model m = new Model(richTextBox2.Text, Int32.Parse(richTextBox3.Text), Int32.Parse(richTextBox1.Text));
                m.Power = checkBox1.Checked;
                label3.Text += m.Power.ToString();
                label4.Text += m.get_name();
                label5.Text += m.get_battery();
                label7.Text += m.get_screen_size();
            }
            catch
            {
                return;
            }
        }
    }
}
