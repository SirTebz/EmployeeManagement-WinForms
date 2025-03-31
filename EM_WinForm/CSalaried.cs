using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_WinForm
{
    [Serializable]
    class CSalaried : CEmployee
    {
        public decimal GrossSalary { get; set; }

        public override decimal NetSalary()
        {
            decimal mSalary = 0m;

            decimal mTax = ((decimal)Tax / 100) * GrossSalary; //Tax from GrossSalary
            mSalary = GrossSalary - mTax;                      //Grosssalary - Tax = Salary
            return mSalary;
        }

        public override string Details()
        {
            return "ID: " + IDNumber + "\n\nSurname: " + Surname + "\n\nName: " + Name
                          + "\n\nDate of Birth: " + DateOfBirth.ToString("dd MMMM yyyy")
                          + "\n\nGrossSalary: " + GrossSalary.ToString("C");
        }
    }
}
