namespace FormConnecting
{
    partial class UserImFormation
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
            this.userForm1 = new FormConnecting.UserForm();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userForm1
            // 
            this.userForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userForm1.Location = new System.Drawing.Point(0, 0);
            this.userForm1.Name = "userForm1";
            this.userForm1.Size = new System.Drawing.Size(284, 166);
            this.userForm1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "SingUp Complete ^-^.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserImFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userForm1);
            this.Name = "UserImFormation";
            this.Text = "UserImFormation";
            this.ResumeLayout(false);

        }

        #endregion

        private UserForm userForm1;
        private System.Windows.Forms.Label label1;
    }
}