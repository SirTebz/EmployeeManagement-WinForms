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
    public partial class CfrmConfirmRemoval : Form
    {
        public CfrmConfirmRemoval()
        {
            InitializeComponent();
            lblConfirmRemoval.Text = "Are you sure you want to remove the employee ?";
        }
    }
}
