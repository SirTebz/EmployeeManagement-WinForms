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
    public partial class CfrmAddEmployee : Form
    {
        public CfrmAddEmployee()
        {
            InitializeComponent();
        }

        public bool CommissionedEmployee { get; set; }
        public bool SalariedEmployee { get; set; }
        public string IDNumber { get; set; }
        public string Surname { get; set; }
        public new string Name { get; set; } //new keyword hides inherited memeber "Control.Name"
        public DateTime BirthDate { get; set; }
        public decimal GrossSalary { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Assign respective values to the properties
            CommissionedEmployee = radCommissioned.Checked;
            SalariedEmployee = radSalaried.Checked;
            IDNumber = txtID.Text;
            Surname = txtSurname.Text;
            Name = txtName.Text;
            BirthDate = dtpBirthDate.Value;

            //Try-Catch to ensure that the input for the GrossSalary/Monthly is numeric(of type decimal)
            try
            {
                GrossSalary = decimal.Parse(txtGrossSalary.Text);

            }
            catch
            {
                CfrmMessages frmMessage = new CfrmMessages();
                frmMessage.DisplayMessage("Error", "Enter a numeric value in the GrossSalary/MonthlySales textbox.");
            }
        }

        private void radCommissioned_CheckedChanged(object sender, EventArgs e)
        {
            if (radCommissioned.Checked)
                lblGrossSalary.Text = "Monthly Sales";
            else
                lblGrossSalary.Text = "Gross Salary";
        }
    }
}
