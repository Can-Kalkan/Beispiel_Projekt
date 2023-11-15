using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2.ZP_M_322_WF
{
    public partial class Form1 : Form
    {
        Form2 f2 = null;
        Form3 f3 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_leave(object sender, EventArgs e)
        {
            button1.Text = "?1";
        }

        private void btn_1_enter(object sender, EventArgs e)
        {
            button1.Text = "PSW Login";
        }

        private void btn_2_enter(object sender, EventArgs e)
        {
            button2.Text = "Login mti Fragen";
        }

        private void btn_2_leave(object sender, EventArgs e)
        {
            button2.Text = "?2";
        }

        private void btn_3_enter(object sender, EventArgs e)
        {
            button3.Text = "Exit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3 = new Form3(this);
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_3_leave(object sender, EventArgs e)
        {
            button3.Text = "?3";
        }
    }
}

