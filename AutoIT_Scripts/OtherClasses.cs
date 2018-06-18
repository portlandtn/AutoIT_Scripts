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
        AutoIT _Au3 = new AutoIT();
        AutoItX3 _Au3Lib = new AutoItX3();
        Settings _RunSettings = new Settings();

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
            _Au3.GetDivision();
        }

        public void BookJob(int numberOfPhases)
        {
            _Au3Lib.Opt("WinTitleMatchMode", 2);

            //determines if Order Log is open. Terminates program if it isn't.
            string windowTitle = "Order Entry";
            _Au3.CheckIfWindowExists(windowTitle);


            string currentJobName = _Au3Lib.ControlGetText(windowTitle, "", "[NAME:txtOrderName]");
            _Au3.InputProjectInfo(windowTitle, currentJobName);

            _Au3Lib.ControlFocus(windowTitle, "", "[NAME:cboPriceType]");
            string division = _Au3.GetDivision();
            _Au3.GetPriceType(division);

            _Au3.SetEndUseCode(windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnSaveProject]", "left", 1);
            _Au3.DetermineControlVisibility("[NAME:PictureBoxHappy]", windowTitle);

            //Phasings/Buildings Screen (for Prebook)
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:ProjectFeaturesTab]", "left", 1, 116, 12);
            _Au3.DetermineControlVisibility("[NAME:btnSaveBldgInfo]", windowTitle);
            _Au3Lib.WinActivate(windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:FpSpread_Bldg]", "left", 1, 293, 52);

            //Adds 1,000 to each subsequent category, choosing the first value based on division (hard-coded at the moment)
            _Au3.InputBuildingInfoWeightDollars(division);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnSaveBldgInfo]");
            _Au3.DetermineControlVisibility("[NAME:picboxHappy_BldgInfo]", windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnPrebookFromBldg]");
            _Au3.DetermineControlVisibility("[NAME:btnSaveMultiPhasesToDB]", windowTitle);
            _Au3.DisableEmail(windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnSaveMultiPhasesToDB]");

            //transfer $$ and ## to Phases
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:ProjectFeaturesTab]", "left", 116, 12);
            _Au3.DetermineControlVisibility("[NAME:btnSaveBldgInfo]", windowTitle);
            _Au3Lib.WinActivate(windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:FpPhaseTool]", "left", 1, 34, 27);


            if (_RunSettings.NumberOfPhases == 1)
            {
                _Au3Lib.Send("A{TAB}1{TAB}100{ENTER}");
                _Au3Lib.Sleep(250);
            }
            else if (_RunSettings.NumberOfPhases == 2)
            {
                _Au3Lib.Send("A{TAB}1{TAB}70{ENTER}");
                _Au3Lib.Sleep(250);
                _Au3Lib.Send("{DOWN}30+{TAB}1+{TAB}B{ENTER}");
                _Au3Lib.Sleep(250);
            }

            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnSaveBldgInfo]");
            _Au3.DetermineControlVisibility("[NAME:picboxHappy_BldgInfo]", windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnTsfrToPhases]");
            _Au3.DetermineControlVisibility("[NAME:btnSaveMultiPhasesToDB]",windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnSaveMultiPhasesToDB]");

            //Project Dates Screen
            _Au3.DetermineControlVisibility("[NAME:btnSaveProjectDates2]", windowTitle);
            string[] arraycoordinates = _Au3.GetCoordinatesForProjectDates(division).Split(',');
            int[] coordinates = new int[arraycoordinates.Length];
            //for (int i = 0; i < arraycoordinates.Length; i++)
            //{
            //    coordinates[i] = Integer.parseInt(arraycoordinates[i]);
            //}
  
            //$Coords = StringSplit(Call("GetCoords",$Division), ",")

            _Au3Lib.ControlClick(windowTitle, "", "[NAME:FpSpreadProjDates]", "LEFT", 1, coordinates[0], coordinates[1]);

            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();
            _Au3Lib.Send(formattedDate);
            _Au3Lib.Send("{ENTER}");
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnSaveProjectDates2]");
            _Au3.DetermineControlVisibility("[NAME:picboxHappy_Dates]", windowTitle);

            //Making phases Active
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:ProjectFeaturesTab]", "", 1, 118, 9);
            _Au3.DetermineControlVisibility("[NAME:btnSaveBldgInfo]",windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:TabControl4]", "", 1, 171, 12);
            _Au3.DetermineControlVisibility("[NAME:chkBookTonsDoll_ViewTons]",windowTitle);

            _Au3Lib.ControlClick(windowTitle, "", "[NAME:lvwSalesSummary]", "right", 1, 180, 70);
            _Au3Lib.Sleep(250);
            _Au3Lib.Send("{DOWN 4}");
            _Au3Lib.Send("{ENTER}");
            _Au3Lib.Sleep(3000);

            if(_RunSettings.NumberOfPhases == 2)
            {
                _Au3Lib.ControlClick(windowTitle, "", "[NAME:lvwSalesSummary]", "right", 1, 180, 138);
                _Au3Lib.Sleep(250);
                _Au3Lib.Send("{DOWN 4}");
                _Au3Lib.Send("{ENTER}");
            }


        }

        public void CreateJob()
        {
            _Au3Lib.Opt("WinTitleMatchMode", 2);

            //Checks if the Order Log is open
            string windowTitle = "Order Log";
            _Au3.CheckIfWindowExists(windowTitle);

            string windowNewOrderNumber = "New Order Number";
            _Au3.ClickNewJobButton("Order Log",windowNewOrderNumber);

            //Determines customer number based on division
            _Au3Lib.ControlSetText(windowNewOrderNumber, "", "[NAME:txtCustNbr]", _Au3.GetCustomerNumber());
            _Au3Lib.Send("{TAB}");
            _Au3.DetermineControlVisibility("[NAME:lblCustName]", windowNewOrderNumber);

            //Sets the job name based on chosen job type
            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();
            _Au3Lib.ControlClick(windowNewOrderNumber, "", "[NAME:txtOrdName]");

            ///////MUST GET WITH RALPH ON HOW TO GET THIS TO READ COMBO BOX//////////

            //switch (ComboBox_jobType)
            //{

            //    default:

            //}

            string jobType = "A";

            _Au3Lib.ControlSetText(windowNewOrderNumber, "", "[Name:txtOrdName]", "Test " + jobType + ",C:" + formattedDate);
            _Au3.SetCustomerContact(windowNewOrderNumber);

            //Call("Visibility", "[NAME:lblCustName]",$WindowTitle)

            //; Set Job Name and sets blank customer contact
            //$CurrentDate = _NowDate()
            //ControlClick($WindowTitle, "", "[NAME:txtOrdName]")
            //ControlSetText($WindowTitle, "", "[Name:txtOrdName]", "Test A, C:" & $CurrentDate)
            //Call("CustomerContact",$WindowTitle)

            //Sets category and Order type based on jobType chosen in ComboBox
            string category = "1";
            string scheduleType = "O"; // sets to OSD
            _Au3.SetCatSchedType(category, scheduleType, windowNewOrderNumber);

            //Sets Order Entry date, primer to red, and saves the job
            _Au3.SetPrimerAndSave(windowNewOrderNumber);

            //If a pop-up shows up, warning there is no delivery schedule information, this dismisses it.
            _Au3.DismissNewOrderNumberPopUp(windowNewOrderNumber);
            _Au3.DetermineControlVisibility("[NAME:btnOrderEntry]", windowNewOrderNumber);

            _Au3.GoToOrderEntry(windowNewOrderNumber, "Order Log");

            _Au3.DetermineControlVisibility("[NAME:btnNewJob]", "Order Log");
            _Au3Lib.WinClose(windowNewOrderNumber);


        }


    }
}
