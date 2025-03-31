
namespace EM_WinForm
{
    partial class CfrmEditEmployee
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
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.txtEditGrossSalary = new System.Windows.Forms.TextBox();
            this.lblEditGrossSalary = new System.Windows.Forms.Label();
            this.dtpEditBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblEditDOB = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditN = new System.Windows.Forms.Label();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.lblEditSur = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.lblEditIDNo = new System.Windows.Forms.Label();
            this.grpEditEmployeeType = new System.Windows.Forms.GroupBox();
            this.radEditSalaried = new System.Windows.Forms.RadioButton();
            this.radEditCommissioned = new System.Windows.Forms.RadioButton();
            this.grpEditEmployeeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditCancel.Location = new System.Drawing.Point(188, 301);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 49;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditAdd.Location = new System.Drawing.Point(12, 301);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEditAdd.TabIndex = 48;
            this.btnEditAdd.Text = "Edit";
            this.btnEditAdd.UseVisualStyleBackColor = true;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // txtEditGrossSalary
            // 
            this.txtEditGrossSalary.Location = new System.Drawing.Point(110, 253);
            this.txtEditGrossSalary.Name = "txtEditGrossSalary";
            this.txtEditGrossSalary.Size = new System.Drawing.Size(153, 20);
            this.txtEditGrossSalary.TabIndex = 47;
            // 
            // lblEditGrossSalary
            // 
            this.lblEditGrossSalary.AutoSize = true;
            this.lblEditGrossSalary.Location = new System.Drawing.Point(15, 260);
            this.lblEditGrossSalary.Name = "lblEditGrossSalary";
            this.lblEditGrossSalary.Size = new System.Drawing.Size(69, 13);
            this.lblEditGrossSalary.TabIndex = 46;
            this.lblEditGrossSalary.Text = "Gross Salary:";
            // 
            // dtpEditBirthDate
            // 
            this.dtpEditBirthDate.Location = new System.Drawing.Point(110, 215);
            this.dtpEditBirthDate.Name = "dtpEditBirthDate";
            this.dtpEditBirthDate.Size = new System.Drawing.Size(153, 20);
            this.dtpEditBirthDate.TabIndex = 45;
            // 
            // lblEditDOB
            // 
            this.lblEditDOB.AutoSize = true;
            this.lblEditDOB.Location = new System.Drawing.Point(15, 222);
            this.lblEditDOB.Name = "lblEditDOB";
            this.lblEditDOB.Size = new System.Drawing.Size(69, 13);
            this.lblEditDOB.TabIndex = 44;
            this.lblEditDOB.Text = "Date of Birth:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(110, 174);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(153, 20);
            this.txtEditName.TabIndex = 43;
            // 
            // lblEditN
            // 
            this.lblEditN.AutoSize = true;
            this.lblEditN.Location = new System.Drawing.Point(15, 181);
            this.lblEditN.Name = "lblEditN";
            this.lblEditN.Size = new System.Drawing.Size(38, 13);
            this.lblEditN.TabIndex = 42;
            this.lblEditN.Text = "Name:";
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(110, 136);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(153, 20);
            this.txtEditSurname.TabIndex = 41;
            // 
            // lblEditSur
            // 
            this.lblEditSur.AutoSize = true;
            this.lblEditSur.Location = new System.Drawing.Point(15, 143);
            this.lblEditSur.Name = "lblEditSur";
            this.lblEditSur.Size = new System.Drawing.Size(52, 13);
            this.lblEditSur.TabIndex = 40;
            this.lblEditSur.Text = "Surname:";
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(110, 99);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(153, 20);
            this.txtEditID.TabIndex = 39;
            // 
            // lblEditIDNo
            // 
            this.lblEditIDNo.AutoSize = true;
            this.lblEditIDNo.Location = new System.Drawing.Point(15, 106);
            this.lblEditIDNo.Name = "lblEditIDNo";
            this.lblEditIDNo.Size = new System.Drawing.Size(21, 13);
            this.lblEditIDNo.TabIndex = 38;
            this.lblEditIDNo.Text = "ID:";
            // 
            // grpEditEmployeeType
            // 
            this.grpEditEmployeeType.Controls.Add(this.radEditSalaried);
            this.grpEditEmployeeType.Controls.Add(this.radEditCommissioned);
            this.grpEditEmployeeType.Location = new System.Drawing.Point(12, 12);
            this.grpEditEmployeeType.Name = "grpEditEmployeeType";
            this.grpEditEmployeeType.Size = new System.Drawing.Size(251, 78);
            this.grpEditEmployeeType.TabIndex = 37;
            this.grpEditEmployeeType.TabStop = false;
            this.grpEditEmployeeType.Text = "Type of employee";
            // 
            // radEditSalaried
            // 
            this.radEditSalaried.AutoSize = true;
            this.radEditSalaried.Checked = true;
            this.radEditSalaried.Location = new System.Drawing.Point(6, 19);
            this.radEditSalaried.Name = "radEditSalaried";
            this.radEditSalaried.Size = new System.Drawing.Size(112, 17);
            this.radEditSalaried.TabIndex = 0;
            this.radEditSalaried.TabStop = true;
            this.radEditSalaried.Text = "Salaried Employee";
            this.radEditSalaried.UseVisualStyleBackColor = true;
            // 
            // radEditCommissioned
            // 
            this.radEditCommissioned.AutoSize = true;
            this.radEditCommissioned.Location = new System.Drawing.Point(6, 52);
            this.radEditCommissioned.Name = "radEditCommissioned";
            this.radEditCommissioned.Size = new System.Drawing.Size(141, 17);
            this.radEditCommissioned.TabIndex = 1;
            this.radEditCommissioned.Text = "Commissioned Employee";
            this.radEditCommissioned.UseVisualStyleBackColor = true;
            this.radEditCommissioned.CheckedChanged += new System.EventHandler(this.radEditCommissioned_CheckedChanged);
            // 
            // CfrmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 341);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditAdd);
            this.Controls.Add(this.txtEditGrossSalary);
            this.Controls.Add(this.lblEditGrossSalary);
            this.Controls.Add(this.dtpEditBirthDate);
            this.Controls.Add(this.lblEditDOB);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblEditN);
            this.Controls.Add(this.txtEditSurname);
            this.Controls.Add(this.lblEditSur);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.lblEditIDNo);
            this.Controls.Add(this.grpEditEmployeeType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmEditEmployee";
            this.Text = "Edit";
            this.grpEditEmployeeType.ResumeLayout(false);
            this.grpEditEmployeeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.TextBox txtEditGrossSalary;
        private System.Windows.Forms.Label lblEditGrossSalary;
        private System.Windows.Forms.DateTimePicker dtpEditBirthDate;
        private System.Windows.Forms.Label lblEditDOB;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditN;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.Label lblEditSur;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Label lblEditIDNo;
        private System.Windows.Forms.GroupBox grpEditEmployeeType;
        public System.Windows.Forms.RadioButton radEditSalaried;
        private System.Windows.Forms.RadioButton radEditCommissioned;
    }
}