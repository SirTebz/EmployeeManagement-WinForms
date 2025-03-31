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
    public partial class CfrmTaxCommission : Form
    {
        public CfrmTaxCommission()
        {
            InitializeComponent();
            nudCommission.Value = (decimal)CCommissioned.dCommission;
            nudTax.Value = (decimal)CEmployee.dTax;
        }

        public double TaxPercentage { get; set; }
        public double CommissionPercentage { get; set; }

        private void btnSet_Click(object sender, EventArgs e)
        {
            TaxPercentage = (double)nudTax.Value;
            CommissionPercentage = (double)nudCommission.Value;
        }
    }
}
