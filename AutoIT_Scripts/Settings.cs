using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AutoIT_Scripts
{
    class Settings
    {
        public string JobType
        {
            get; set;
        }

        public int NumberOfPhases
        {
            get; set;
        }

        public bool CreateJob
        {
            get; set;
        }

        public bool BookJob
        {
            get; set;
        }

        public bool CreateChangeOrder
        {
            get; set;
        }

        public bool InvoiceJob
        {
            get; set;
        }

        public bool RunDailySalesReport
        {
            get; set;
        }
        
    }
}
