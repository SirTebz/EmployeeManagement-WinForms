
namespace EM_WinForm
{
    partial class CfrmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGrossSalary = new System.Windows.Forms.TextBox();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSur = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.grpEmployeeType = new System.Windows.Forms.GroupBox();
            this.radSalaried = new System.Windows.Forms.RadioButton();
            this.radCommissioned = new System.Windows.Forms.RadioButton();
            this.grpEmployeeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(188, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(12, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.Location = new System.Drawing.Point(110, 253);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.Size = new System.Drawing.Size(153, 20);
            this.txtGrossSalary.TabIndex = 34;
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.Location = new System.Drawing.Point(15, 260);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(69, 13);
            this.lblGrossSalary.TabIndex = 33;
            this.lblGrossSalary.Text = "Gross Salary:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(110, 215);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(153, 20);
            this.dtpBirthDate.TabIndex = 32;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(15, 222);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(69, 13);
            this.lblDOB.TabIndex = 31;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 174);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 30;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(15, 181);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(38, 13);
            this.lblN.TabIndex = 29;
            this.lblN.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 136);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(153, 20);
            this.txtSurname.TabIndex = 28;
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Location = new System.Drawing.Point(15, 143);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(52, 13);
            this.lblSur.TabIndex = 27;
            this.lblSur.Text = "Surname:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 20);
            this.txtID.TabIndex = 26;
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Location = new System.Drawing.Point(15, 106);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(21, 13);
            this.lblIDNo.TabIndex = 25;
            this.lblIDNo.Text = "ID:";
            // 
            // grpEmployeeType
            // 
            this.grpEmployeeType.Controls.Add(this.radSalaried);
            this.grpEmployeeType.Controls.Add(this.radCommissioned);
            this.grpEmployeeType.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeType.Name = "grpEmployeeType";
            this.grpEmployeeType.Size = new System.Drawing.Size(251, 78);
            this.grpEmployeeType.TabIndex = 24;
            this.grpEmployeeType.TabStop = false;
            this.grpEmployeeType.Text = "Type of employee";
            // 
            // radSalaried
            // 
            this.radSalaried.AutoSize = true;
            this.radSalaried.Checked = true;
            this.radSalaried.Location = new System.Drawing.Point(6, 19);
            this.radSalaried.Name = "radSalaried";
            this.radSalaried.Size = new System.Drawing.Size(112, 17);
            this.radSalaried.TabIndex = 0;
            this.radSalaried.TabStop = true;
            this.radSalaried.Text = "Salaried Employee";
            this.radSalaried.UseVisualStyleBackColor = true;
            // 
            // radCommissioned
            // 
            this.radCommissioned.AutoSize = true;
            this.radCommissioned.Location = new System.Drawing.Point(6, 52);
            this.radCommissioned.Name = "radCommissioned";
            this.radCommissioned.Size = new System.Drawing.Size(141, 17);
            this.radCommissioned.TabIndex = 1;
            this.radCommissioned.Text = "Commissioned Employee";
            this.radCommissioned.UseVisualStyleBackColor = true;
            this.radCommissioned.CheckedChanged += new System.EventHandler(this.radCommissioned_CheckedChanged);
            // 
            // CfrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGrossSalary);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDNo);
            this.Controls.Add(this.grpEmployeeType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmAddEmployee";
            this.Text = "Add Employee";
            this.grpEmployeeType.ResumeLayout(false);
            this.grpEmployeeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGrossSalary;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.GroupBox grpEmployeeType;
        public System.Windows.Forms.RadioButton radSalaried;
        private System.Windows.Forms.RadioButton radCommissioned;
    }
}