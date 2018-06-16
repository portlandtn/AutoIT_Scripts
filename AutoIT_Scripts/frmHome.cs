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

        AutoIT _Au3 = new AutoIT();
        OtherClasses _OClasses = new OtherClasses();
        Settings _RunSettings = new Settings();


        public frmHome()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            


        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            cboJobTypeComboBox.Items.Add(new KeyValuePair<string, string>("A", "Job Type A"));
            cboJobTypeComboBox.Items.Add(new KeyValuePair<string, string>("B", "Job Type B"));
            cboJobTypeComboBox.Items.Add(new KeyValuePair<string, string>("C", "Job Type C"));
            cboJobTypeComboBox.Items.Add(new KeyValuePair<string, string>("D", "Job Type D"));

            

            cboJobTypeComboBox.DisplayMember = "Value";
            cboJobTypeComboBox.ValueMember = "Key";
        }

        private void wait_Tick(object ender, EventArgs e)
        {
            string division = _Au3.GetDivision();

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

        private void cboJobTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = (KeyValuePair<string,string>)(cboJobTypeComboBox.SelectedItem);
            _RunSettings.JobType = selection.Key;
            
        }
    }
}
