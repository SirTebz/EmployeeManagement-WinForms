using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace EM_WinForm
{
    [Serializable]
    public partial class CfrmEmployees : Form
    {
        public static List<CEmployee> lstEmployees = new List<CEmployee>();

        public CfrmEmployees()
        {
            InitializeComponent();
        }

        private void btnTaxCommission_Click(object sender, EventArgs e)
        {
            CfrmTaxCommission frmTaxCommission = new CfrmTaxCommission();
            if (frmTaxCommission.ShowDialog() == DialogResult.OK)
            {
                CEmployee.dTax = frmTaxCommission.TaxPercentage;
                CCommissioned.dCommission = frmTaxCommission.CommissionPercentage;
            }
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create an Employee by retrieving infomation from CfrmAdd

            bool isAddedEmployee;
            CfrmAddEmployee frmAddEmployee = new CfrmAddEmployee();
            if (frmAddEmployee.ShowDialog() == DialogResult.OK)
            {
                isAddedEmployee = true;
                if (frmAddEmployee.CommissionedEmployee) //value is true
                {
                    CCommissioned CommissionedEmployee = new CCommissioned(); // Create a Commissioned Employee & assign values to its properies
                    CommissionedEmployee.IDNumber = frmAddEmployee.IDNumber;
                    CommissionedEmployee.Surname = frmAddEmployee.Surname;
                    CommissionedEmployee.Name = frmAddEmployee.Name;
                    CommissionedEmployee.DateOfBirth = frmAddEmployee.BirthDate;
                    CommissionedEmployee.MonthlySales = frmAddEmployee.GrossSalary;
                    CommissionedEmployee.NetSalary();
                    lstEmployees.Add(CommissionedEmployee); //add the employee to the employee list
                }
                else if (frmAddEmployee.SalariedEmployee) //value is true
                {
                    CSalaried SalariedEmployee = new CSalaried(); //create a Salaried Employee & assign values to its properties
                    SalariedEmployee.IDNumber = frmAddEmployee.IDNumber;
                    SalariedEmployee.Surname = frmAddEmployee.Surname;
                    SalariedEmployee.Name = frmAddEmployee.Name;
                    SalariedEmployee.DateOfBirth = frmAddEmployee.BirthDate;
                    SalariedEmployee.GrossSalary = frmAddEmployee.GrossSalary;
                    SalariedEmployee.NetSalary();
                    lstEmployees.Add(SalariedEmployee); //add the employee to the employee list
                }
                if (isAddedEmployee)
                {
                    UpdateListbox(); //Display Employee list on listbox 

                    CfrmMessages frmMessage = new CfrmMessages();
                    frmMessage.DisplayMessage("Add Successful", "An employee is successfully added");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int iIndex = lstbxEmployees.SelectedIndex;
            bool isSelected;

            if (iIndex >= 0)
            {
                CfrmEditEmployee frmEditEmployee = new CfrmEditEmployee(lstEmployees[iIndex]);
                if (frmEditEmployee.ShowDialog() == DialogResult.OK)
                {
                    isSelected = true;

                    if (lstEmployees[iIndex] is CCommissioned)
                    {
                        //Display Employee details in appropriate fields on the Edit Employee form
                        CCommissioned CommissionedEmployee = new CCommissioned();
                        CommissionedEmployee.IDNumber = frmEditEmployee.IDNumber;
                        CommissionedEmployee.Surname = frmEditEmployee.Surname;
                        CommissionedEmployee.Name = frmEditEmployee.Name;
                        CommissionedEmployee.DateOfBirth = frmEditEmployee.BirthDate;
                        CommissionedEmployee.MonthlySales = frmEditEmployee.GrossSalary;
                        CommissionedEmployee.NetSalary();
                        lstEmployees[iIndex] = CommissionedEmployee;
                    }
                    else if (lstEmployees[iIndex] is CSalaried)
                    {
                        //Display Employee details in appropriate fields on the Edit Employee form
                        CSalaried SalariedEmployee = new CSalaried();
                        SalariedEmployee.IDNumber = frmEditEmployee.IDNumber;
                        SalariedEmployee.Surname = frmEditEmployee.Surname;
                        SalariedEmployee.Name = frmEditEmployee.Name;
                        SalariedEmployee.DateOfBirth = frmEditEmployee.BirthDate;
                        SalariedEmployee.GrossSalary = frmEditEmployee.GrossSalary;
                        SalariedEmployee.NetSalary();
                        lstEmployees[iIndex] = SalariedEmployee;
                    }
                    UpdateListbox();
                    lblEmployeeDetails.Text = " ";

                    if (isSelected)
                    {
                        //Display this message only when an employee is edited
                        CfrmMessages frmMessage = new CfrmMessages();
                        frmMessage.DisplayMessage("Editing Succesful", "Successfully edited the employee details");
                    }
                }

            }
            else
            {
                //Display this message when no employee is selected to edit
                CfrmMessages frmMessage = new CfrmMessages();
                frmMessage.DisplayMessage("Error", "Select an employee to edit");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDetails();
            CfrmMessages frmMessage = new CfrmMessages();
            frmMessage.DisplayMessage("Succesfully Saved", "Employees details are successfully saved");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool isEmployeeSelected;

            if (lstbxEmployees.SelectedIndex >= 0)
            {

                CfrmConfirmRemoval frmRemoveEmployee = new CfrmConfirmRemoval();
                if (frmRemoveEmployee.ShowDialog() == DialogResult.Yes)
                {
                    isEmployeeSelected = true;

                    lstEmployees.RemoveAt(lstbxEmployees.SelectedIndex); //Remove the selcted employee

                    if (isEmployeeSelected)
                    {
                        lblEmployeeDetails.Text = " "; //Removed employee details no longer appear
                        UpdateListbox();              // update the listbox to show employees without the removed employee

                        //Display this successfully removed message only when an employee was selected 
                        CfrmMessages frmMessages = new CfrmMessages();
                        frmMessages.DisplayMessage("Removal Successful", "Employee is successfully removed");
                    }
                }
            }
            else
            {
                //Display this message if no employee is selected to remove
                CfrmMessages cfrmMessages = new CfrmMessages();
                cfrmMessages.DisplayMessage("Error", "No employee is selected. \n\nSelect an employee to remove.");
            }
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            if (lstbxEmployees.SelectedIndex >= 0)
            {
                CfrmPaySlip frmPayslip = new CfrmPaySlip();
                frmPayslip.DisplayPaySlip(lstEmployees[lstbxEmployees.SelectedIndex]); //Show Payslip of employee selected in listbox
            }
            else
            {
                CfrmMessages frmMessage = new CfrmMessages();
                frmMessage.DisplayMessage("Error", "Select an employee to dislay payslip"); //display error message when no employee is selected

            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            CfrmAbout frmAbout = new CfrmAbout();
            frmAbout.ShowDialog();
        }

        
        private void lstbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxEmployees.SelectedIndex >= 0)
            {
                lblEmployeeDetails.Text = lstEmployees[lstbxEmployees.SelectedIndex].Details(); //Display details of selected employee
            }
            else
            {
                lblEmployeeDetails.Text = " "; //Display an empty string if no employee is selected
            }
        }

        
        private void CfrmEmployees_Load(object sender, EventArgs e)
        {
            ReadDetails();
            UpdateListbox();
        }

        public void UpdateListbox()
        {
            lstbxEmployees.Items.Clear();

            foreach (CEmployee employee in lstEmployees)
            {
                string sNameSurname = employee.Name + " " + employee.Surname;
                lstbxEmployees.Items.Add(sNameSurname); //only display name and surname of employee on listbox
            }
        }

        public void SaveDetails()
        {
            string sFile1 = "Employee.bin", sFile2 = "TaxCom.txt"; //File1 to save Employee list AND File2 to save the Tax and Commission percentages

            //Saving list of employees to a binary file
            using (FileStream fs = new FileStream(sFile1, FileMode.Create))
            {
                IFormatter f = new BinaryFormatter();
                f.Serialize(fs, lstEmployees);
            }

            //Saving Tax and Commission values to a text file
            using (FileStream fs = new FileStream(sFile2, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(CEmployee.dTax.ToString());
                    sw.WriteLine(CCommissioned.dCommission.ToString());
                }
            }
        }

        public void ReadDetails()
        {
            string sFile1 = "Employee.bin", sFile2 = "TaxCom.txt";
            if (File.Exists(sFile1))
            {
                FileStream fs = new FileStream(sFile1, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                lstEmployees = (List<CEmployee>)formatter.Deserialize(fs); //Read Employee list back from binary file
                fs.Close();
            }

            if (File.Exists(sFile2))
            {
                FileStream fs = new FileStream(sFile2, FileMode.Open);
                StreamReader sr = new StreamReader(fs);                     //Read Tax and Commission values back from text file
                CEmployee.dTax = double.Parse(sr.ReadLine());
                CCommissioned.dCommission = double.Parse(sr.ReadLine());
                sr.Close();
                fs.Close();
            }
        }

        
    }
}
