using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_WinForm
{
    [Serializable]
    public abstract class CEmployee
    {
        public static double dTax;

        public double Tax
        {
            get { return dTax; }
            set { dTax = value; }
        }
        public string IDNumber { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual decimal NetSalary()
        {
            decimal mSalary = 0;
            return mSalary;
        }
        public abstract string Details();
    }
}
