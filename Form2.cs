using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
     public static int labir;
     public static  int walls;
     public static int forma;
     public static string mycol="Black";
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Черный")
            {
                mycol="Black";
            }
            if (comboBox1.SelectedItem.ToString() == "Красный")
            {
                mycol = "Red";
            }
            if (comboBox1.SelectedItem.ToString() == "Желтый")
            {
                mycol = "Yellow";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                walls = 1;
            }
            else
            {
                walls = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form1 Form1 = new Form1();
       //     Form2.ActiveForm.Hide();
            Form1.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedItem.ToString() == "Квадраты")
            {
            forma = 0;
            }
            if (comboBox2.SelectedItem.ToString() == "Круги")
            {
                 forma = 1;
            }
            if (comboBox2.SelectedItem.ToString() == "Треугольники")
            {
                forma = 2;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                labir = 1;
            }
            else
            {
                labir = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
