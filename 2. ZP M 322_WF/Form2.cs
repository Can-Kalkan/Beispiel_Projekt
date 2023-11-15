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

namespace _2.ZP_M_322_WF
{
    public partial class Form2 : Form
    {
        public Form1 mainForm = null;

        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }
           string psw = "1234", psw1 = "4321";
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text == psw && textBox1.Text == "Batman" && textBox2.Text == "Jack") || (textBox3.Text == psw1 && textBox1.Text == "Ironman" && textBox2.Text == "Tony"))
            {
                mainForm.lbl_Antwort.Text = "Guten Tag Herr " + textBox1.Text + " Korrektes Login !!";
                Close();
            }
            else
            {
                mainForm.lbl_Antwort.Text = "Flasches Login !!!";
                Close();
            }
        }
    }
}
