using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_WinForm
{
    [Serializable]
    class CCommissioned : CEmployee
    {
        public static double dCommission;

        public double Commisssion
        {
            get { return dCommission; }
            set { dCommission = value; }
        }
        public decimal MonthlySales { get; set; }

        public override decimal NetSalary()
        {
            decimal mSalary = 0m;

            decimal mGrossCommission = ((decimal)Commisssion / 100) * MonthlySales; //Commission from Monthly Sales
            decimal mTax = ((decimal)Tax / 100) * mGrossCommission;                   //Tax from commission
            mSalary = mGrossCommission - mTax;                                      //Commission - Tax = Salary
            return mSalary;
        }
        public override string Details()
        {
            return "ID: " + IDNumber + "\n\nSurname: " + Surname + "\n\nName: " + Name
                            + "\n\nDate of Birth: " + DateOfBirth.ToString("dd MMMM yyyy")
                            + "\n\nMonthly Sales: " + MonthlySales.ToString("C");

        }
    }
}
