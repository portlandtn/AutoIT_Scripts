﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AutoItX3Lib;

namespace AutoIT_Scripts
{
    class AutoIT
    {
        AutoItX3 au3 = new AutoItX3();

        public void CheckIfWindowExists(string windowTitle)
        {
            if (au3.WinExists(windowTitle, "") == 0)
            {
                MessageBox.Show("Please open the " + windowTitle + " screen and try to run this script again.");
            }
        }

        public void ClickNewJobButton(string windowTitle, string windowTitle2)
        {
            au3.WinActivate(windowTitle);
            au3.WinWaitActive(windowTitle);
            au3.ControlClick(windowTitle, "", "[NAME:btnNewJob]");
            au3.WinWaitActive(windowTitle2);
            au3.Sleep(250);
        }

        public void CustomerNumber(string windowTitle, string customerNumber)
        {
            au3.ControlClick(windowTitle, "", "[NAME:txtCustNbr]");
            au3.ControlSetText(windowTitle, "", "[NAME:txtCustNbr]", customerNumber);
            au3.Send("{TAB}");
        }

        public void DetermineControlVisibility(string visibleControl, string windowTitle)
        {
            string isvisible = "0";

            while (isvisible == "0")
            {
                au3.Sleep(250);
                isvisible = au3.ControlCommand(windowTitle, "", visibleControl, "IsVisible", "");
            }
            isvisible = "0";
        }

        public string GetCustomerNumber()
        {
            string Division = au3.WinGetTitle("Order Log");

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
                    string DivisionLetter = au3.ControlGetText("New Order Number", "", "[NAME:lblDivision]");
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

        public void InputProjectInfo(string windowTitle, string currentJobName, int phase)
        {
            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();

            au3.ControlSetText(windowTitle, "", "[NAME:txtOrderName]", currentJobName + ", " + phase + ", " + formattedDate);
            au3.ControlSetText(windowTitle, "", "[NAME:txtShipAddr1]", "1111 Generic Address");
            au3.ControlSetText(windowTitle, "", "[NAME:cboShipCity]", "Nashville");
            au3.ControlSetText(windowTitle, "", "[NAME:txtShipState]", "TN");
            au3.ControlSetText(windowTitle, "", "[NAME:txtShipZip]", "37217");
            au3.ControlSetText(windowTitle, "", "[NAME:txtshipcounty]", "Davidson");
            au3.ControlSetText(windowTitle, "", "[NAME:txtFreightMiles]", "850");
            au3.ControlSetText(windowTitle, "", "[NAME:txtSqFeet]", "5000");
            au3.ControlSetText(windowTitle, "", "[NAME:cboDept]", "CSR");
        }

        public void SetNewJobName(string windowTitle)
        {
            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();

            au3.ControlClick(windowTitle, "", "[NAME:txtOrdName]");
            au3.ControlSetText(windowTitle, "", "[Name:txtOrdName]", "Test A, C:" + formattedDate);

        }

        public void SetCustomerContact(string windowTitle)
        {
            au3.ControlClick(windowTitle, "", "[NAME:btnContactLookUp]");
            au3.WinWaitActive("Customer Contact Info");
            au3.Sleep(1000);
            au3.ControlClick("Customer Contact Info", "", "[NAME:btnExitNoSelect]");
        }

        public void SetCatSchedType(string category, string scheduleType, string windowTitle)
        {
            au3.WinWaitActive(windowTitle);
            au3.ControlClick(windowTitle, "", "[NAME:cboCategory]");
            au3.Send(category);
            au3.Send("{TAB}");
            au3.Send(scheduleType);
            au3.Send("{TAB}");
        }

        public void SetPrimerAndSave(string windowTitle)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToShortDateString();
            au3.ControlSetText(windowTitle, "", "[NAME:txtOERecDate]", formattedDate);
            au3.Send("{TAB 2}");
            au3.Sleep(500);
            au3.Send("R{TAB}");
            au3.Sleep(500);
            au3.Send("R");
            au3.ControlClick(windowTitle, "", "[NAME:cmdSave]");
            au3.Sleep(1000);
        }

        public void DismissNewOrderNumberPopUp(string windowTitle)
        {
            string PopUpWindowTitle = "New Order Number";
            string PopUpWindowText = "No Delivery Schedule";

            if (au3.WinExists(PopUpWindowTitle, PopUpWindowText) == 1)
            {
                au3.WinActivate(PopUpWindowTitle, PopUpWindowText);
                au3.WinWaitActive(PopUpWindowTitle, PopUpWindowText);
                au3.Sleep(500);
                au3.Send("{ENTER}");
                au3.Sleep(500);
            }
            au3.WinWaitActive(windowTitle);
            au3.WinWaitActive(windowTitle);
        }

        public void GoToOrderEntry(string windowTitle, string windowTitle2)
        {
            au3.Opt("WinTitleMatchMode", 2);
            au3.Sleep(250);
            au3.ControlClick(windowTitle, "", "[NAME:btnOrderEntry]");

            au3.Sleep(500);
            au3.WinActivate("Order Entry");
            au3.WinWaitActive("Order Entry");
            au3.WinActivate(windowTitle2);
            au3.WinWaitActive(windowTitle2);
            au3.WinClose(windowTitle);
            au3.WinActivate("Order Entry");
        }

        public void InputChangeOrderCostWeight(int weight, int dollars)
        {
            for (int i = 0; i < 4; i++)
            {
                string weightString = weight.ToString();
                string dollarsString = dollars.ToString();
                au3.Send(weightString);
                au3.Sleep(50);
                au3.Send("{TAB}");
                au3.Sleep(50);
                au3.Send(dollarsString);
                au3.Sleep(50);
                au3.Send("{ENTER}");
                au3.Sleep(50);
                au3.Send("{LEFT}");
                au3.Sleep(50);
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
                au3.Send(poundsString);
                au3.Sleep(50);
                au3.Send("{TAB}");
                au3.Sleep(50);
                au3.Send(dollarsString);
                au3.Sleep(50);
                au3.Send("{ENTER}");
                au3.Sleep(50);
                au3.Send("{LEFT}");
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
                au3.Send(tonsString);
                au3.Sleep(50);
                au3.Send("{TAB 2}");
                au3.Sleep(50);
                au3.Send(tonsString);
                au3.Sleep(50);
                au3.Send("{TAB}");
                au3.Sleep(50);
                au3.Send(dollarsString);
                au3.Sleep(50);
                au3.Send("{DOWN}");
                au3.Sleep(50);
                au3.Send("{LEFT 3}");
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
                    au3.Send("Y");
                    break;

                case "GSMMS":
                    au3.Send("Y");
                    break;

                case "CBCCA":
                    au3.Send("Y");
                    break;

                case "NBSIN":
                    au3.Send("Y");
                    break;

                case "NBSUT":
                    au3.Send("Y");
                    break;

                case "NBSSC":
                    au3.Send("Y");
                    break;

                case "NBSTX":
                    au3.Send("Y");
                    break;

                case "ABCNV":
                    au3.Send("A");
                    break;

                case "ABCAL":
                    au3.Send("A");
                    break;

                case "ABCVA":
                    au3.Send("A");
                    break;
                case "ABCIL":
                    au3.Send("A");
                    break;

                default: MessageBox.Show("The division has not been detected correctly. You may not be in a test environment.");
                    break;
            }
        }
        public void SetEndUseCode(string windowTitle)
        {
            au3.ControlFocus(windowTitle, "", "[NAME:cboEndUse]");
            au3.Send("2");
        }

        public void DisableEmail(string windowTitle)
        {
            au3.ControlClick(windowTitle, "", "[NAME:chkEmail_JobInfo]");
            au3.Sleep(250);
        }
    }


}
