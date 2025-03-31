
namespace EM_WinForm
{
    partial class CfrmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CfrmEmployees));
            this.btnTaxCommission = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbxEmployees = new System.Windows.Forms.ListBox();
            this.lblTaxCommission = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPayslip = new System.Windows.Forms.Label();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.lblEmployeeDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTaxCommission
            // 
            this.btnTaxCommission.BackColor = System.Drawing.Color.White;
            this.btnTaxCommission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaxCommission.BackgroundImage")));
            this.btnTaxCommission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTaxCommission.Location = new System.Drawing.Point(183, 219);
            this.btnTaxCommission.Name = "btnTaxCommission";
            this.btnTaxCommission.Size = new System.Drawing.Size(61, 47);
            this.btnTaxCommission.TabIndex = 27;
            this.btnTaxCommission.UseVisualStyleBackColor = false;
            this.btnTaxCommission.Click += new System.EventHandler(this.btnTaxCommission_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(250, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 47);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstbxEmployees
            // 
            this.lstbxEmployees.FormattingEnabled = true;
            this.lstbxEmployees.Location = new System.Drawing.Point(12, 12);
            this.lstbxEmployees.Name = "lstbxEmployees";
            this.lstbxEmployees.Size = new System.Drawing.Size(165, 290);
            this.lstbxEmployees.TabIndex = 34;
            this.lstbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lstbxEmployees_SelectedIndexChanged);
            // 
            // lblTaxCommission
            // 
            this.lblTaxCommission.Location = new System.Drawing.Point(181, 269);
            this.lblTaxCommission.Name = "lblTaxCommission";
            this.lblTaxCommission.Size = new System.Drawing.Size(64, 33);
            this.lblTaxCommission.TabIndex = 35;
            this.lblTaxCommission.Text = "Tax and Commission";
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(252, 269);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(57, 28);
            this.lblAdd.TabIndex = 36;
            this.lblAdd.Text = " Add Employee";
            // 
            // lblEdit
            // 
            this.lblEdit.Location = new System.Drawing.Point(321, 269);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(52, 33);
            this.lblEdit.TabIndex = 51;
            this.lblEdit.Text = "Edit Details";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Location = new System.Drawing.Point(317, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 47);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(598, 267);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(35, 13);
            this.lblAbout.TabIndex = 59;
            this.lblAbout.Text = "About";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.Location = new System.Drawing.Point(585, 219);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(61, 45);
            this.btnAbout.TabIndex = 58;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(388, 269);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(52, 33);
            this.lblSave.TabIndex = 57;
            this.lblSave.Text = "Save Changes";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(384, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 47);
            this.btnSave.TabIndex = 56;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.Location = new System.Drawing.Point(454, 267);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(55, 32);
            this.lblRemove.TabIndex = 55;
            this.lblRemove.Text = "Remove Employee";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemove.Location = new System.Drawing.Point(451, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 46);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblPayslip
            // 
            this.lblPayslip.AutoSize = true;
            this.lblPayslip.Location = new System.Drawing.Point(528, 270);
            this.lblPayslip.Name = "lblPayslip";
            this.lblPayslip.Size = new System.Drawing.Size(40, 13);
            this.lblPayslip.TabIndex = 53;
            this.lblPayslip.Text = "Payslip";
            // 
            // btnPayslip
            // 
            this.btnPayslip.BackColor = System.Drawing.Color.White;
            this.btnPayslip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayslip.BackgroundImage")));
            this.btnPayslip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayslip.Location = new System.Drawing.Point(518, 219);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(61, 45);
            this.btnPayslip.TabIndex = 52;
            this.btnPayslip.UseVisualStyleBackColor = false;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // lblEmployeeDetails
            // 
            this.lblEmployeeDetails.AutoSize = true;
            this.lblEmployeeDetails.Location = new System.Drawing.Point(183, 12);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(85, 13);
            this.lblEmployeeDetails.TabIndex = 60;
            this.lblEmployeeDetails.Text = "EmployeeDetails";
            // 
            // CfrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 315);
            this.Controls.Add(this.lblEmployeeDetails);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPayslip);
            this.Controls.Add(this.btnPayslip);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblTaxCommission);
            this.Controls.Add(this.lstbxEmployees);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTaxCommission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CfrmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.CfrmEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaxCommission;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstbxEmployees;
        private System.Windows.Forms.Label lblTaxCommission;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblPayslip;
        private System.Windows.Forms.Button btnPayslip;
        private System.Windows.Forms.Label lblEmployeeDetails;
    }
}

