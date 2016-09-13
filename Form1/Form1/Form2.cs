using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public string name1
        {
            get
            {
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
                {
                    string a, b, c, d, e, f, g;

                    if (checkBox1.Checked == true)
                    {
                        b = checkBox1.Name;
                        return b;
                    } else if (checkBox2.Checked) {
                        c = checkBox2.Name;
                        return c;
                    } else if (checkBox3.Checked)
                    {
                        d = checkBox3.Name;
                        return d;
                    }
                    else if (checkBox4.Checked)
                    {
                        e = checkBox4.Name;
                        return e;
                    }
                    else if (checkBox5.Checked)
                    {
                        f = checkBox5.Name;
                        return f;
                    }
                    else if (checkBox6.Checked)
                    {
                        g = checkBox6.Name;
                        return g;
                    } else
                    {
                        return null;
                    }

                    a = b + " " + c + " " + d + " " + e + " " + f + " " + g + " ";
                
                    return a;
                
                }else
                {
                    return "nothing";
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
