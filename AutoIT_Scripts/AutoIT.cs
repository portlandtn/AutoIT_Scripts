using AutoItX3Lib;
using System;
using System.IO;
using System.Windows.Forms;

namespace AutoIT_Scripts
{
    class AutoIT
    {
        AutoItX3 _Au3Lib = new AutoItX3();
        Settings _RunSettings = new Settings();

        public void CheckIfWindowExists(string windowTitle)
        {
            if (_Au3Lib.WinExists(windowTitle, "") == 0)
            {
                MessageBox.Show("Please open the " + windowTitle + " screen and try to run this script again.");
            }
        }

        public void ClickNewJobButton(string windowNewOrderEntry, string windowOrderLog)
        {
            _Au3Lib.WinActivate(windowNewOrderEntry);
            _Au3Lib.WinWaitActive(windowNewOrderEntry);
            _Au3Lib.ControlClick(windowNewOrderEntry, "", "[NAME:btnNewJob]");
            _Au3Lib.WinWaitActive(windowOrderLog);
            _Au3Lib.Sleep(250);
        }

        public void CustomerNumber(string windowTitle, string customerNumber)
        {
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:txtCustNbr]");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtCustNbr]", customerNumber);
            _Au3Lib.Send("{TAB}");
        }

        public void DetermineControlVisibility(string visibleControl, string windowTitle)
        {
            string isvisible = "0";

            while (isvisible == "0")
            {
                _Au3Lib.Sleep(250);
                isvisible = _Au3Lib.ControlCommand(windowTitle, "", visibleControl, "IsVisible", "");
            }
            isvisible = "0";
        }

        public string GetCustomerNumber()
        {
            string Division = _Au3Lib.WinGetTitle("Order Log");

            switch (Division)
            {
                case "Order Log - Kirby (Test)":
                    return "7825";

                case "Order Log - GSM (Test)":
                    return "00771";

                case "Order Log - CBC (Test)":
                    return "030117";


                case "Order Log - Waterloo":
                    return "FAC100";

                case "Order Log - Utah":
                    string DivisionLetter = _Au3Lib.ControlGetText("New Order Number", "", "[NAME:lblDivision]");
                    if (DivisionLetter == "U")
                        return "FIS200";
                    else return "694998";

                case "Order Log - Swansea":
                    return "STEELMASTER";

                case "Order Log - Terrell":
                    return "MET120";


                case "Order Log - IT DEVELOPMENT SOUTH":
                    return "555999";

                case "Order Log - IT DEVELOPMENT ATL":
                    return "0000692";

                case "Order Log - IT DEVELOPMENT MW":
                    return "794999";

                case "Order Log - IT DEVELOPMENT WEST":
                    return "007160";

                default:
                    MessageBox.Show("The customer number is determined from the title of the Order Log. Either the Order Log is not open, the title has been changed, or you are not in a Testing environment.");
                    return null;


            }
        }

        public void InputProjectInfo(string windowTitle, string currentJobName)
        {
            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();

            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtOrderName]", currentJobName + ", " + _RunSettings.NumberOfPhases + "Ph, " + formattedDate);
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtShipAddr1]", "1111 Generic Address");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:cboShipCity]", "Nashville");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtShipState]", "TN");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtShipZip]", "37217");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtshipcounty]", "Davidson");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtFreightMiles]", "850");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtSqFeet]", "5000");
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:cboDept]", "CSR");
        }

        public void SetNewJobName(string windowTitle)
        {
            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();

            _Au3Lib.ControlClick(windowTitle, "", "[NAME:txtOrdName]");
            _Au3Lib.ControlSetText(windowTitle, "", "[Name:txtOrdName]", "Test A, C:" + formattedDate);

        }

        public void SetCustomerContact(string windowTitle)
        {
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnContactLookUp]");
            _Au3Lib.WinWaitActive("Customer Contact Info");
            _Au3Lib.Sleep(1000);
            _Au3Lib.ControlClick("Customer Contact Info", "", "[NAME:btnExitNoSelect]");
        }

        public void SetCatSchedType(string category, string scheduleType, string windowTitle)
        {
            _Au3Lib.WinWaitActive(windowTitle);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:cboCategory]");
            _Au3Lib.Send(category);
            _Au3Lib.Send("{TAB}");
            _Au3Lib.Send(scheduleType);
            _Au3Lib.Send("{TAB}");
        }

        public void SetPrimerAndSave(string windowTitle)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToShortDateString();
            _Au3Lib.ControlSetText(windowTitle, "", "[NAME:txtOERecDate]", formattedDate);
            _Au3Lib.Sleep(500);
            _Au3Lib.Send("{TAB 2}");
            _Au3Lib.Sleep(500);
            _Au3Lib.Send("R{TAB}");
            _Au3Lib.Sleep(500);
            _Au3Lib.Send("R");
            _Au3Lib.Sleep(500);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:cmdSave]");
            _Au3Lib.Sleep(1000);
        }

        public void DismissNewOrderNumberPopUp(string windowTitle)
        {
            string PopUpWindowTitle = "New Order Number";
            string PopUpWindowText = "No Delivery Schedule";

            if (_Au3Lib.WinExists(PopUpWindowTitle, PopUpWindowText) == 1)
            {
                _Au3Lib.WinActivate(PopUpWindowTitle, PopUpWindowText);
                _Au3Lib.WinWaitActive(PopUpWindowTitle, PopUpWindowText);
                _Au3Lib.Sleep(500);
                _Au3Lib.Send("{ENTER}");
                _Au3Lib.Sleep(500);
            }
            _Au3Lib.WinWaitActive(windowTitle);
            _Au3Lib.WinWaitActive(windowTitle);
        }

        public void GoToOrderEntry(string windowTitle, string windowTitle2)
        {
            _Au3Lib.Opt("WinTitleMatchMode", 2);
            _Au3Lib.Sleep(250);
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:btnOrderEntry]");

            _Au3Lib.Sleep(500);
            _Au3Lib.WinActivate("Order Entry");
            _Au3Lib.WinWaitActive("Order Entry");
            _Au3Lib.WinActivate(windowTitle2);
            _Au3Lib.WinWaitActive(windowTitle2);
            _Au3Lib.WinClose(windowTitle);
            _Au3Lib.WinActivate("Order Entry");
        }

        public void InputChangeOrderCostWeight(int weight, int dollars)
        {
            for (int i = 0; i < 4; i++)
            {
                string weightString = weight.ToString();
                string dollarsString = dollars.ToString();
                _Au3Lib.Send(weightString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{TAB}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send(dollarsString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{ENTER}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{LEFT}");
                _Au3Lib.Sleep(50);
                weight = weight + 1300;
                dollars = dollars + 1850;

            }

        }

        public string GetDivision()
        {
            TextReader tr = new StreamReader(@"C:\ProgramData\Nucor\NBGSettings.config");
            //skips first line
            for (var i = 0; i < 1; i++)
            {
                tr.ReadLine();
            }

            string divisionString = tr.ReadToEnd();

            //rather than do it this way, Kent suggested using " as string splitters to make it more dynamic. Research how to find and start string splits there.
            string divisionCode = divisionString.Substring(33, 5);
            string divisionLocation = divisionString.Substring(54, 5);

            if (divisionLocation == divisionCode)
            {
                tr.Close();
                return null;
            }
            else
            {
                tr.Close();
                return divisionCode;
            }

        }

        public void InputBuildingInfoWeightDollars(string division)
        {

            switch (division)
            {
                case "KBSTN":
                    GetWeightDollarsBooking(1000, 2500);
                    break;

                case "GSMMS":
                    GetWeightDollarsBooking(2200, 3700);
                    break;

                case "CBCCA":
                    GetWeightDollarsBooking(3400, 4900);
                    break;


                case "NBSIN":
                    GetWeightDollarsBooking(4600, 6100);
                    break;

                case "NBSUT":
                    GetWeightDollarsBooking(5800, 7300);
                    break;

                case "NBSSC":
                    GetWeightDollarsBooking(7000, 8500);
                    break;

                case "NBSTX":
                    GetWeightDollarsBooking(8200, 9700);
                    break;


                case "ABCNV":
                    GetWeightDollarsBooking(9400, 10900);
                    break;

                case "ABCAL":
                    GetWeightDollarsBooking(10600, 12100);
                    break;

                case "ABCVA":
                    GetWeightDollarsBooking(11800, 13300);
                    break;

                case "ABCIL":
                    GetWeightDollarsBooking(13000, 14500);
                    break;

                default:
                    MessageBox.Show("The division has not been detected correctly. You may not be in a test environment.");
                    break;


            }
        }
            public void InputInvoiceTonsDollars(string division)
            {

                switch (division)
                {
                    case "KBSTN":
                        GetWeightDollarsInvoiceInput(0.5, 2500);
                        break;

                    case "GSMMS":
                        GetWeightDollarsInvoiceInput(1.1, 3700);
                        break;

                    case "CBCCA":
                        GetWeightDollarsInvoiceInput(1.7, 4900);
                        break;


                    case "NBSIN":
                        GetWeightDollarsInvoiceInput(2.3, 6100);
                        break;

                    case "NBSUT":
                        GetWeightDollarsInvoiceInput(2.9, 7300);
                        break;

                    case "NBSSC":
                        GetWeightDollarsInvoiceInput(3.5, 8500);
                        break;

                    case "NBSTX":
                        GetWeightDollarsInvoiceInput(4.1, 9700);
                        break;


                    case "ABCNV":
                        GetWeightDollarsInvoiceInput(4.7, 10900);
                        break;

                    case "ABCAL":
                        GetWeightDollarsInvoiceInput(5.3, 12100);
                        break;

                    case "ABCVA":
                        GetWeightDollarsInvoiceInput(5.9,13300);
                        break;

                    case "ABCIL":
                        GetWeightDollarsInvoiceInput(6.5, 14500);
                        break;

                    default:
                        MessageBox.Show("The division has not been detected correctly. You may not be in a test environment.");
                        break;


                }

            }

        public void GetWeightDollarsBooking(int pounds, int dollars)
        {
            for (int i = 0; i < 7; i++)
            {
                string poundsString = pounds.ToString();
                string dollarsString = dollars.ToString();
                _Au3Lib.Send(poundsString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{TAB}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send(dollarsString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{ENTER}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{LEFT}");
                pounds = pounds + 1000;
                dollars = dollars + 1000;

            }
        }

        public void GetWeightDollarsInvoiceInput(double tons, int dollars)
        {
            for (int i = 0; i < 7; i++)
            {
                string tonsString = tons.ToString();
                string dollarsString = dollars.ToString();
                _Au3Lib.Send(tonsString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{TAB 2}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send(tonsString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{TAB}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send(dollarsString);
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{DOWN}");
                _Au3Lib.Sleep(50);
                _Au3Lib.Send("{LEFT 3}");
                tons = tons + 0.5;
                dollars = dollars + 1000;

            }
        }



        public string GetCoordinatesForProjectDates(string division)
        {
            switch (division)
            {
                case "NBSUT":
                    return "286, 367";

                case "NBSTX":
                    return "298,385";

                case "NBSIN":
                    return "286,367";

                case "NBSSC":
                    return "299,344";

                case "ABCAL":
                    return "286,367";

                case "ABCNV":
                    return "286,367";

                case "ABCIL":
                    return "286,367";

                case "ABCVA":
                    return "286,367";

                case "KBSTN":
                    return "299,344";

                case "CBCCA":
                    return "299,344";
                default:
                    MessageBox.Show("The division has not been detected correctly. You may not be in a test environment.");
                    return null;
            }
        }

        public void GetPriceType(string division)
        {
            switch (division)
            {

                case "KBSTN":
                    _Au3Lib.Send("Y");
                    break;

                case "GSMMS":
                    _Au3Lib.Send("Y");
                    break;

                case "CBCCA":
                    _Au3Lib.Send("Y");
                    break;

                case "NBSIN":
                    _Au3Lib.Send("Y");
                    break;

                case "NBSUT":
                    _Au3Lib.Send("Y");
                    break;

                case "NBSSC":
                    _Au3Lib.Send("Y");
                    break;

                case "NBSTX":
                    _Au3Lib.Send("Y");
                    break;

                case "ABCNV":
                    _Au3Lib.Send("A");
                    break;

                case "ABCAL":
                    _Au3Lib.Send("A");
                    break;

                case "ABCVA":
                    _Au3Lib.Send("A");
                    break;
                case "ABCIL":
                    _Au3Lib.Send("A");
                    break;

                default: MessageBox.Show("The division has not been detected correctly. You may not be in a test environment.");
                    break;
            }
        }
        public void SetEndUseCode(string windowTitle)
        {
            _Au3Lib.ControlFocus(windowTitle, "", "[NAME:cboEndUse]");
            _Au3Lib.Send("2");
        }

        public void DisableEmail(string windowTitle)
        {
            _Au3Lib.ControlClick(windowTitle, "", "[NAME:chkEmail_JobInfo]");
            _Au3Lib.Sleep(250);
        }
    }


}
