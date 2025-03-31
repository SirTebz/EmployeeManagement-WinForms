
namespace EM_WinForm
{
    partial class CfrmAbout
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
            this.btnAboutOk = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAboutOk
            // 
            this.btnAboutOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAboutOk.Location = new System.Drawing.Point(106, 139);
            this.btnAboutOk.Name = "btnAboutOk";
            this.btnAboutOk.Size = new System.Drawing.Size(75, 23);
            this.btnAboutOk.TabIndex = 3;
            this.btnAboutOk.Text = "OK";
            this.btnAboutOk.UseVisualStyleBackColor = true;
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(12, 9);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(263, 115);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "About";
            // 
            // CfrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 172);
            this.Controls.Add(this.btnAboutOk);
            this.Controls.Add(this.lblAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAboutOk;
        private System.Windows.Forms.Label lblAbout;
    }
}