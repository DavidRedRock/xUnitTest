using UnitTestLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btResetTestCase_Click(object sender, EventArgs e)
        {
            rTxtBxTestData.Text = "";
            txtBxTestingResult.Text = "";
            txtExpectedResult.Text = "";
            cBxTestingResultMatch.Text = " ";
            cBxTestingResultMatch.Checked=false;
            cBxTestingResultMatch.Visible = false;
        }

        private void btRunTest_Click(object sender, EventArgs e)
        {
            txtBxTestingResult.Text = Calculator.Longest_sub(rTxtBxTestData.Text);
         
            if (txtBxTestingResult.Text != null)
            {
                if (txtBxTestingResult.Text.Trim() == txtExpectedResult.Text.Trim())
                {
                    cBxTestingResultMatch.Text = "Testing Result is matched with Expected Result";
                    cBxTestingResultMatch.Checked = true;
                    cBxTestingResultMatch.Visible = true;
                }
                else
                {
                    cBxTestingResultMatch.Text = "Testing Result is Not matched with Expected Result";
                    cBxTestingResultMatch.Checked = false;
                    cBxTestingResultMatch.Visible = true;
                }
            }
        }

    }
}
