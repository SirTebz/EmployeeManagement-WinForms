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
    public partial class CfrmEditEmployee : Form
    {
        public CfrmEditEmployee(CEmployee _Employee)
        {
            InitializeComponent();

            //A saved employee's details are called to show in the respective input fields
            txtEditID.Text = _Employee.IDNumber;
            txtEditSurname.Text = _Employee.Surname;
            txtEditName.Text = _Employee.Name;

            if (_Employee is CSalaried) //If the employee that is selected is a salried employee, his/her gross salry can be edited
            {
                CSalaried SalariedEmployee = _Employee as CSalaried;
                txtEditGrossSalary.Text = SalariedEmployee.GrossSalary.ToString();
            }
            else if (_Employee is CCommissioned) //If the employee that is selected is a commissioned employee, his/her monthly sales can be edited
            {
                CCommissioned CommissionedEmployee = _Employee as CCommissioned;
                txtEditGrossSalary.Text = CommissionedEmployee.MonthlySales.ToString();
            }
        }

        public bool CommissionedEmployee { get; set; }
        public bool SalariedEmployee { get; set; }
        public string IDNumber { get; set; }
        public string Surname { get; set; }
        public new string Name { get; set; } //new keyword hides inherited memeber "Control.Name"
        public DateTime BirthDate { get; set; }
        public decimal GrossSalary { get; set; }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            //Assign respective values of the input fields to the properties
            CommissionedEmployee = radEditCommissioned.Checked;
            SalariedEmployee = radEditSalaried.Checked;
            IDNumber = txtEditID.Text;
            Surname = txtEditSurname.Text;
            Name = txtEditName.Text;
            BirthDate = dtpEditBirthDate.Value;

            //Try-Catch to ensure that the input for the GrossSalary/MonthlySales is numeric(of type decimal)
            try
            {

                GrossSalary = decimal.Parse(txtEditGrossSalary.Text);
            }
            catch
            {
                CfrmMessages frmMessage = new CfrmMessages();
                frmMessage.DisplayMessage("Error", "Enter a numeric value in the GrossSalary/MonthlySales textbox.");
            }
        }

        private void radEditCommissioned_CheckedChanged(object sender, EventArgs e)
        {
            if (radEditCommissioned.Checked)
                lblEditGrossSalary.Text = "Monthly Sales";
            else
                lblEditGrossSalary.Text = "Gross Salary";
        }
    }
}
