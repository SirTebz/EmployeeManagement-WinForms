using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_WinForm
{
    public partial class CfrmMessages : Form
    {
        public CfrmMessages()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string sTitle, string sMessage)
        {
            this.Text = sTitle;
            lblMessages.Text = sMessage;
            ShowDialog();
        }
    }
}
