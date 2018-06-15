using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoIT_Scripts
{
    public partial class frmHome : Form
    {

        AutoIT Au3 = new AutoIT();
        OtherClasses OClasses = new OtherClasses();


        public frmHome()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string jobType;
            if (rboJobTypeA.Checked == true)
            {
                jobType = "A";
            }
            else if (rboJobTypeB.Checked == true)
            {
                jobType = "B";
            }

            else if (rboJobTypeC.Checked == true)
            {
                jobType = "C";
            }

            else if (rboJobTypeD.Checked == true)
            {
                jobType = "D";
            }

            else
            {
                MessageBox.Show("Something went wrong!");
            }

            int numberOfPhases = 1;

            if (rboOnePhase.Checked == true)
            {
                numberOfPhases = 1;
            }

            else if(rboTwoPhases.Checked == true)
            {
                numberOfPhases = 2;
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }

            if (chkBookJob.Checked == true)
            {
                
            }

            OClasses.BookJob(numberOfPhases);


            //var checkedButton = pnlJobTypes.Controls.OfType<RadioButton>()
            //    .FirstOrDefault(r => r.Checked);





        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void wait_Tick(object ender, EventArgs e)
        {
            string division = Au3.GetDivision();

            if (division == null)
            {
                lblTestOrProdState.Text = "YOU ARE NOT IN TEST";
            }
            else
            {
                lblCurrentDivision.Text = "Current Division: " + division;
                lblTestOrProdState.Text = "Current Environment: Test";
            }
            
        }

        private void rboJobTypeA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboJobTypeB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboJobTypeC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboJobTypeD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboOnePhase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboTwoPhases_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCreateJob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBookJob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCreateCO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkInvoiceJob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRunDailySalesReport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
