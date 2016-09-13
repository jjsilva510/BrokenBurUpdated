using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Form1
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                form2 = new Form2();
                form2.ShowDialog();
               
            }
            else
            {

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = form2.name1;
            
            
            
            //this will allow you to save files
            SaveFileDialog sfd = new SaveFileDialog(); 
            sfd.Filter = "Text File | *txt"; //this makes it only file type .txt
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String path = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write(
                    label1.Text + " " + textBox1.Text + "\r\n" +
                    label2.Text + " " + textBox2.Text + "\r\n" +
                    label3.Text + " " + textBox3.Text + "\r\n" +
                    "Type of Bur: " + a + "\r\n" +
                    label5.Text + " " + textBox4.Text);
                bw.Dispose();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
