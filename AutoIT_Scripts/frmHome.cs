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
        AutoIT CautoIT = new AutoIT();
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CautoIT.mClick("RIGHT", 1, 1, 1, -1);
        }
    }
}
