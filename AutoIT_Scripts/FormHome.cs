using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace AutoIT_Scripts
{
    public partial class FormHome : Form
    {

        AutoIT _Au3 = new AutoIT();
        AutoItX3 _Au3Lib = new AutoItX3();
        OtherClasses _OClasses = new OtherClasses();
        Settings _RunSettings = new Settings();


        public FormHome()
        {
            InitializeComponent();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (CheckBox_BookJob.Checked)
            {
                _OClasses.BookJob(_RunSettings.NumberOfPhases);
            }

            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

            ComboBox_JobType.Items.Add(new KeyValuePair<string, string>("A", "Job Type A"));
            ComboBox_JobType.Items.Add(new KeyValuePair<string, string>("B", "Job Type B"));
            ComboBox_JobType.Items.Add(new KeyValuePair<string, string>("C", "Job Type C"));
            ComboBox_JobType.Items.Add(new KeyValuePair<string, string>("D", "Job Type D"));

            

            ComboBox_JobType.DisplayMember = "Value";
            ComboBox_JobType.ValueMember = "Key";
        }

        private void Wait_Tick(object ender, EventArgs e)
        {
            string division = _Au3.GetDivision();

            if (division == null)
            {
                Label_EnvironmentState.Text = "YOU ARE NOT IN TEST";
            }
            else
            {
                Label_CurrentDivision.Text = "Current Division: " + division;
                Label_EnvironmentState.Text = "Current Environment: Test";
            }
            
        }

        private void RadioButton_JobTypeA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_JobTypeB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_JobTypeC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_JobTypeD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_OnePhase_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_OnePhase.Checked)
            {
                _RunSettings.NumberOfPhases = 1;
            }

        }

        private void RadioButton_TwoPhases_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_TwoPhases.Checked)
            {
                _RunSettings.NumberOfPhases = 2;
            }
        }

        private void CheckBox_CreateJob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_BookJob_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_BookJob.Checked)
            {
                _RunSettings.BookJob = true;
            }
            else if (CheckBox_BookJob.Checked == false)
            {
                _RunSettings.BookJob = false;
            }
        }

        private void CheckBox_CreateChangeOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_CreateChangeOrder.Checked)
            {
                _RunSettings.CreateChangeOrder = true;
            }
            else if (CheckBox_CreateChangeOrder.Checked == false)
            {
                _RunSettings.CreateChangeOrder = false;
            }
        }

        private void CheckBox_InvoiceJob_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_InvoiceJob.Checked)
            {
                _RunSettings.InvoiceJob = true;
            }
            else if (CheckBox_InvoiceJob.Checked == false)
            {
                _RunSettings.InvoiceJob = false;
            }
        }

        private void CheckBox_RunDailySalesReport_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_RunDailySalesReport.Checked)
            {
                _RunSettings.RunDailySalesReport = true;
            }
            else if (CheckBox_RunDailySalesReport.Checked == false)
            {
                _RunSettings.RunDailySalesReport = false;
            }
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            CheckBox_CreateJob.Checked = true;
            CheckBox_BookJob.Checked = true;
            CheckBox_CreateChangeOrder.Checked = false;
            CheckBox_InvoiceJob.Checked = false;
            CheckBox_RunDailySalesReport.Checked = false;
            RadioButton_OnePhase.Checked = true;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBox_JobType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = (KeyValuePair<string,string>)(ComboBox_JobType.SelectedItem);
            _RunSettings.JobType = selection.Key;
            
        }
    }
}
