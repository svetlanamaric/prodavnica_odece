using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodavnica_odece
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string velicina = textBox1.Text;
            string s = "Naručili ste: " + '\n';
            if (radioButton1.Checked)
            {
                //Ako smo odabrali prvi radioButton, biramo žensku garderobu

                if (checkBox1.Checked)
                    //Ako smo odabrali prvi checkBox
                    s = s + "Žensku majicu veličine " + velicina + '\n';
                if (checkBox2.Checked)
                    //Ako smo odabrali drugi checkBox
                    s = s + "ženski šorc veličine " + velicina + '\n';
                if (checkBox3.Checked)
                    //Ako smo odabrali treći checkBox
                    s = s + "ženske pantalone veličine " + velicina + '\n';
                if (checkBox4.Checked)
                    //Ako smo odabrali četvrti checkBox
                    s = s + "žensku jaknu veličine " + velicina + '\n';
                label2.Text = s;
            }

            else if (radioButton2.Checked)
            {
                //Ako smo odabrali drugi radioButton, biramo mušku garderobu

                if (checkBox1.Checked)
                    //Ako smo odabrali prvi checkBox
                    s = s + "Mušku majicu veličine " + velicina + '\n';
                if (checkBox2.Checked)
                    //Ako smo odabrali drugi checkBox
                    s = s + "Muški šorc veličine " + velicina + '\n';
                if (checkBox3.Checked)
                    //Ako smo odabrali treći checkBox
                    s = s + "Muške pantalone veličine " + velicina + '\n';
                if (checkBox4.Checked)
                    //Ako smo odabrali četvrti checkBox
                    s = s + "Mušku jaknu veličine " + velicina + '\n';
                label2.Text = s;
            }

        }
            }
        }
