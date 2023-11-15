using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ZP_M_322_WF
{
    public partial class Form3 : Form
    {
        public Form1 mainForm = null;

        public Form3(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btn_bestätigen_F3_Click(object sender, EventArgs e)
        {
            if(rdb_A22.Checked && rdb_M322.Checked && rdb_Note.Checked && rdb_Stertsos.Checked && rdb_Stertsos2.Checked)
            {
                mainForm.lbl_Antwort.Text = "Hallo Schüler von A22, " +
                    "M322 mit der Note >4,5-5,5<! " +
                    "Sie programmieren mit Stertsos und Sie mögen Stertsos! " +
                    "Korrektes Login!!!";
                Close();
            }
        }
    }
}
