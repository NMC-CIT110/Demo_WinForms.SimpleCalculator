using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms.SimpleCalculator
{
    public partial class HelpForm : Form
    {
        public HelpForm(string instructions)
        {
            InitializeComponent();
            
            lbl_Instructions.Text = instructions;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
