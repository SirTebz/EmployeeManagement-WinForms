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
    public partial class CfrmPaySlip : Form
    {
        public CfrmPaySlip()
        {
            InitializeComponent();
        }

        public void DisplayPaySlip(CEmployee _Employee)
        {
            if (_Employee is CCommissioned)
            {
                CCommissioned Commissioned = _Employee as CCommissioned;

                lblDetails.Text = "ID: " + Commissioned.IDNumber + "\n\nSurname: " + Commissioned.Surname
                                  + "\n\nName: " + Commissioned.Name
                                  + "\n\nDate of Birth: " + Commissioned.DateOfBirth.ToString("dd MMMM yyyy")
                                  + "\n\nMonthly Sales: " + Commissioned.MonthlySales.ToString("C")
                                  + "\n\nNetSalary: " + Commissioned.NetSalary().ToString("C");
            }
            else
            {
                CSalaried Salaried = _Employee as CSalaried;

                lblDetails.Text = "ID: " + Salaried.IDNumber + "\n\n" + "Surname: " + Salaried.Surname
                                  + "\n\nName: " + Salaried.Name
                                  + "\n\nDate of Birth: " + Salaried.DateOfBirth.ToString("dd MMMM yyyy")
                                  + "\n\nGross Salary: " + Salaried.GrossSalary.ToString("C")
                                  + "\n\nNetSalary: " + Salaried.NetSalary().ToString("C");
            }
            ShowDialog();
        }
    }
}
