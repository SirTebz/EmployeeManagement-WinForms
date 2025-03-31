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
    public partial class CfrmAbout : Form
    {
        public CfrmAbout()
        {
            InitializeComponent();
            lblAbout.Text = "Teboho Mokgosi" +
                            "\n© 2025";
        }
    }
}
