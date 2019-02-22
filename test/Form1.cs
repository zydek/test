using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //private string tekst, tekst2 = "";
        public Thread trd;
        private void button1_Click(object sender, EventArgs e)
        {

            //DR();
            //ThreadTask();

        }


        /*public void DR()
        {
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
            toolStripStatusLabel1.Text = "watek start";
        }
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ThreadTask();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ThreadTask()
        {
            while (outputBox.Text!=inputBox.Text)
            {
                outputBox.Text = inputBox.Text;
            }

        }

    }
}
