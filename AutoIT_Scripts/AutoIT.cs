using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace AutoIT_Scripts
{
    class AutoIT
    {
        AutoItX3 au3 = new AutoItX3();

        public void mClick(string Clickside, int x, int y, int numClicks, int Speed) { 
        
            au3.MouseClick(Clickside,x,y,numClicks,Speed);
            
        }

        public void CheckWindowExists(string WindowTitle)
        {
            if (au3.WinExists(WindowTitle,"") == 0)
                    MessageBox.Show("Please open the " + WindowTitle + " screen and try to run this script again.");
        }

        public void NewJobButton(string WindowTitle, string WindowTitle2)
        {
            au3.WinActivate(WindowTitle);
            au3.WinWaitActive(WindowTitle);
            au3.ControlClick(WindowTitle, "", "[NAME:btnNewJob]");
            au3.WinWaitActive(WindowTitle2);
            au3.Sleep(250);
        }

        public void CustomerNumber(string WindowTitle, string CustomerNumber)
        {
            au3.ControlClick(WindowTitle, "", "[NAME:txtCustNbr]");
            au3.ControlSetText(WindowTitle, "", "[NAME:txtCustNbr]", CustomerNumber);
            au3.Send("{TAB}");
        }

        public void Visibility(string VisibleControl, string WindowTitle)
        {
            string isvisible = "0";

            while (isvisible == "0")
            {
                au3.Sleep(250);
                isvisible = au3.ControlCommand(WindowTitle, "", VisibleControl, "IsVisible","");
            }
            isvisible = "0";
        }

        public void CustomerLookUpOrderLog(string CustomerNumber)
        {
            string Division = au3.WinGetTitle("Order Log");
            //string CustomerNumber;
            //**********************************************************************************************
            //**********THIS NEEDS TO RETURN A VALUE - IT'S NOT WORKING CORRECTLY!!!!!!*********************
            //**********************************************************************************************
            switch (Division)
            {
                case "Order Log - Kirby (Test)":
                    CustomerNumber = "7825";
                    break;

                case "Order Log - GSM (Test)":
                    CustomerNumber = "00771";
                    break;

                case "Order Log - CBC (Test)":
                    CustomerNumber = "030117";
                    break;


                case "Order Log - Waterloo":
                    CustomerNumber = "FAC100";
                    break;

                case "Order Log - Utah":
                    string DivisionLetter = au3.ControlGetText("New Order Number", "", "[NAME:lblDivision]");
                    if (DivisionLetter == "U")
                        CustomerNumber = "FIS200";
                    else CustomerNumber = "694998";    
                    break;

                case "Order Log - Swansea":
                    CustomerNumber = "STEELMASTER";
                    break;

                case "Order Log - Terrell":
                    CustomerNumber = "MET120";
                    break;


                case "Order Log - IT DEVELOPMENT SOUTH":
                    CustomerNumber = "555999";
                    break;

                case "Order Log - IT DEVELOPMENT ATL":
                    CustomerNumber = "0000692";
                    break;

                case "Order Log - IT DEVELOPMENT MW":
                    CustomerNumber = "794999";
                    break;

                case "Order Log - IT DEVELOPMENT WEST":
                    CustomerNumber = "007160";
                    break;

                default: MessageBox.Show("The customer number is determined from the title of the Order Log. Either the Order Log is not open, the title has been changed, or you are not in a Testing environment.");
                    break;
            }
        }

        public void NewJobName(string WindowTitle)
        {
            DateTime currentDate = DateTime.Now;
            //string format = "m/d/yy";
            string formattedDate = currentDate.ToShortDateString();

            au3.ControlClick(WindowTitle, "", "[NAME:txtOrdName]");
            au3.ControlSetText(WindowTitle, "", "[Name:txtOrdName]", "Test A, C:" + formattedDate);

        }

        public void CustomerContact(string WindowTitle)
        {
            au3.ControlClick(WindowTitle, "", "[NAME:btnContactLookUp]");
            au3.WinWaitActive("Customer Contact Info");
            au3.Sleep(1000);
            au3.ControlClick("Customer Contact Info", "", "[NAME:btnExitNoSelect]");
        }

        public void CatSchedType(string Category, string ScheduleType, string WindowTitle)
        {
            au3.WinWaitActive(WindowTitle);
            au3.ControlClick(WindowTitle, "", "[NAME:cboCategory]");
            au3.Send(Category);
            au3.Send("{TAB}");
            au3.Send(ScheduleType);
            au3.Send("{TAB}");
        }

        public void SetPrimerAndSave(string WindowTitle)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToShortDateString();
            au3.ControlSetText(WindowTitle, "", "[NAME:txtOERecDate]", formattedDate);
            au3.Send("{TAB 2}");
            au3.Sleep(500);
            au3.Send("R{TAB}");
            au3.Sleep(500);
            au3.Send("R");
            au3.ControlClick(WindowTitle, "", "[NAME:cmdSave]");
            au3.Sleep(1000);
        }

        public void DismissNewOrderNumberPopUp(string WindowTitle)
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
                au3.WinWaitActive(WindowTitle);
                au3.WinWaitActive(WindowTitle);
        }

        public void GoToOrderEntry(string WindowTitle, string WindowTitle2)
        {
            au3.Opt("WinTitleMatchMode", 2);
            au3.Sleep(250);
            au3.ControlClick(WindowTitle, "", "[NAME:btnOrderEntry]");

            au3.Sleep(500);
            au3.WinActivate("Order Entry");
            au3.WinWaitActive("Order Entry");
            au3.WinActivate(WindowTitle2);
            au3.WinWaitActive(WindowTitle2);
            au3.WinClose(WindowTitle);
            au3.WinActivate("Order Entry");
        }

        public void ChangeOrderCostWeightInput(int weight, int dollars)
        {
            for (int i = 0; i<4; i++)
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
    }


}
