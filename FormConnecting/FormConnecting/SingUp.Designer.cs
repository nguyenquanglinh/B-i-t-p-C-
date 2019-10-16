namespace FormConnecting
{
    partial class SingUp
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
            this.grbService = new System.Windows.Forms.GroupBox();
            this.btnSingUp = new System.Windows.Forms.Button();
            this.checkboxGmailTrport = new System.Windows.Forms.CheckBox();
            this.checkBoxReport = new System.Windows.Forms.CheckBox();
            this.checkBoxSms = new System.Windows.Forms.CheckBox();
            this.userForm1 = new FormConnecting.UserForm();
            this.grbService.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbService
            // 
            this.grbService.Controls.Add(this.btnSingUp);
            this.grbService.Controls.Add(this.checkboxGmailTrport);
            this.grbService.Controls.Add(this.checkBoxReport);
            this.grbService.Controls.Add(this.checkBoxSms);
            this.grbService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbService.Location = new System.Drawing.Point(0, 132);
            this.grbService.Name = "grbService";
            this.grbService.Size = new System.Drawing.Size(322, 120);
            this.grbService.TabIndex = 1;
            this.grbService.TabStop = false;
            this.grbService.Text = "Select service";
            // 
            // btnSingUp
            // 
            this.btnSingUp.Location = new System.Drawing.Point(197, 91);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(75, 23);
            this.btnSingUp.TabIndex = 3;
            this.btnSingUp.Text = "SingUp";
            this.btnSingUp.UseVisualStyleBackColor = true;
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // checkboxGmailTrport
            // 
            this.checkboxGmailTrport.AutoSize = true;
            this.checkboxGmailTrport.Location = new System.Drawing.Point(3, 80);
            this.checkboxGmailTrport.Name = "checkboxGmailTrport";
            this.checkboxGmailTrport.Size = new System.Drawing.Size(82, 17);
            this.checkboxGmailTrport.TabIndex = 2;
            this.checkboxGmailTrport.Text = "Gmail report";
            this.checkboxGmailTrport.UseVisualStyleBackColor = true;
            // 
            // checkBoxReport
            // 
            this.checkBoxReport.AutoSize = true;
            this.checkBoxReport.Location = new System.Drawing.Point(3, 48);
            this.checkBoxReport.Name = "checkBoxReport";
            this.checkBoxReport.Size = new System.Drawing.Size(58, 17);
            this.checkBoxReport.TabIndex = 1;
            this.checkBoxReport.Text = "Report";
            this.checkBoxReport.UseVisualStyleBackColor = true;
            // 
            // checkBoxSms
            // 
            this.checkBoxSms.AutoSize = true;
            this.checkBoxSms.Location = new System.Drawing.Point(2, 19);
            this.checkBoxSms.Name = "checkBoxSms";
            this.checkBoxSms.Size = new System.Drawing.Size(83, 17);
            this.checkBoxSms.TabIndex = 0;
            this.checkBoxSms.Text = "Sms service";
            this.checkBoxSms.UseVisualStyleBackColor = true;
            // 
            // userForm1
            // 
            this.userForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userForm1.Location = new System.Drawing.Point(0, 0);
            this.userForm1.Name = "userForm1";
            this.userForm1.Size = new System.Drawing.Size(322, 123);
            this.userForm1.TabIndex = 0;
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 252);
            this.Controls.Add(this.grbService);
            this.Controls.Add(this.userForm1);
            this.Name = "SingUp";
            this.Text = "SingUp";
            this.grbService.ResumeLayout(false);
            this.grbService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserForm userForm1;
        private System.Windows.Forms.GroupBox grbService;
        private System.Windows.Forms.CheckBox checkboxGmailTrport;
        private System.Windows.Forms.CheckBox checkBoxReport;
        private System.Windows.Forms.CheckBox checkBoxSms;
        private System.Windows.Forms.Button btnSingUp;
    }
}

