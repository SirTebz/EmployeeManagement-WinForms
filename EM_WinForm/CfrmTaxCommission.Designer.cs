
namespace EM_WinForm
{
    partial class CfrmTaxCommission
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
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.grpAllEmployees = new System.Windows.Forms.GroupBox();
            this.lblCommissionPercentage = new System.Windows.Forms.Label();
            this.lblTaxPercentage = new System.Windows.Forms.Label();
            this.nudCommission = new System.Windows.Forms.NumericUpDown();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.grpAllEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCanc
            // 
            this.btnCanc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanc.Location = new System.Drawing.Point(150, 138);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 11;
            this.btnCanc.Text = "Cancel";
            this.btnCanc.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSet.Location = new System.Drawing.Point(12, 138);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // grpAllEmployees
            // 
            this.grpAllEmployees.Controls.Add(this.lblCommissionPercentage);
            this.grpAllEmployees.Controls.Add(this.lblTaxPercentage);
            this.grpAllEmployees.Controls.Add(this.nudCommission);
            this.grpAllEmployees.Controls.Add(this.nudTax);
            this.grpAllEmployees.Location = new System.Drawing.Point(12, 12);
            this.grpAllEmployees.Name = "grpAllEmployees";
            this.grpAllEmployees.Size = new System.Drawing.Size(213, 110);
            this.grpAllEmployees.TabIndex = 9;
            this.grpAllEmployees.TabStop = false;
            this.grpAllEmployees.Text = "Apply to all employees";
            // 
            // lblCommissionPercentage
            // 
            this.lblCommissionPercentage.AutoSize = true;
            this.lblCommissionPercentage.Location = new System.Drawing.Point(6, 74);
            this.lblCommissionPercentage.Name = "lblCommissionPercentage";
            this.lblCommissionPercentage.Size = new System.Drawing.Size(120, 13);
            this.lblCommissionPercentage.TabIndex = 3;
            this.lblCommissionPercentage.Text = "Commission Percentage";
            // 
            // lblTaxPercentage
            // 
            this.lblTaxPercentage.AutoSize = true;
            this.lblTaxPercentage.Location = new System.Drawing.Point(6, 26);
            this.lblTaxPercentage.Name = "lblTaxPercentage";
            this.lblTaxPercentage.Size = new System.Drawing.Size(83, 13);
            this.lblTaxPercentage.TabIndex = 2;
            this.lblTaxPercentage.Text = "Tax Percentage";
            // 
            // nudCommission
            // 
            this.nudCommission.Location = new System.Drawing.Point(132, 67);
            this.nudCommission.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCommission.Name = "nudCommission";
            this.nudCommission.Size = new System.Drawing.Size(70, 20);
            this.nudCommission.TabIndex = 1;
            this.nudCommission.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudTax
            // 
            this.nudTax.Location = new System.Drawing.Point(132, 26);
            this.nudTax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(70, 20);
            this.nudTax.TabIndex = 0;
            this.nudTax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CfrmTaxCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 172);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.grpAllEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmTaxCommission";
            this.Text = "Tax and Commission";
            this.grpAllEmployees.ResumeLayout(false);
            this.grpAllEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox grpAllEmployees;
        private System.Windows.Forms.Label lblCommissionPercentage;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.NumericUpDown nudCommission;
        private System.Windows.Forms.NumericUpDown nudTax;
    }
}