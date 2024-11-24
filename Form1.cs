using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Zhityaykina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tariff = 0;
            int baggage = 0;
            int time = 0;
            if(comboBox1.SelectedItem.ToString() == "Бизнес")
            {
                tariff = 20;
            }
            if (comboBox1.SelectedItem.ToString() == "Комфорт")
            {
                tariff = 10;
            }
            if (comboBox1.SelectedItem.ToString() == "Эконом")
            {
                tariff = 5;
            }
            if (checkBox1.Checked)
                baggage = 100;
            time = (int)numericUpDown1.Value;
            int sum = tariff * time + baggage;
            textBox1.Text = sum.ToString();
        }
    }
}
