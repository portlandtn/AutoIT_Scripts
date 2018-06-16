using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AutoIT_Scripts
{
    class OtherClasses
    {
        AutoIT Au3Class = new AutoIT();
        AutoItX3 Au3 = new AutoItX3();

        private Timer DivisionCodeTimer;
        public void InitDivisionCodeTimer()
        {
            DivisionCodeTimer = new Timer();
            DivisionCodeTimer.Tick += new EventHandler(DivisionCodeTimer_Tick);
            DivisionCodeTimer.Interval = 1000;
            DivisionCodeTimer.Start();
        }

        public void DivisionCodeTimer_Tick(object sender, EventArgs e)
        {
            Au3Class.GetDivision();
        }

        private void SetNumberOfPhases(int numberOfPhases)
        {

        }

        private void SetJobType(string jobType)
        {

        }

        public void BookJob(int numberOfPhases)
        {
            Au3.Opt("WinTitleMatchMode", 2);
            string windowTitle = "Order Entry";
            Au3Class.CheckIfWindowExists(windowTitle);

            string currentJobName = Au3.ControlGetText(windowTitle, "", "[NAME:txtOrderName]");
                      
            
            Au3Class.InputProjectInfo(windowTitle, currentJobName,numberOfPhases);
        }


    }
}
