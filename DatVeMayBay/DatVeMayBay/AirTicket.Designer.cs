namespace DatVeMayBay
{
    partial class AirTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.monthCalendarTo = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDCard = new System.Windows.Forms.CheckBox();
            this.Passport = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Baggage = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendarFrom = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(82, 19);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(399, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // monthCalendarTo
            // 
            this.monthCalendarTo.Location = new System.Drawing.Point(33, 81);
            this.monthCalendarTo.Name = "monthCalendarTo";
            this.monthCalendarTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendarTo.RightToLeftLayout = true;
            this.monthCalendarTo.TabIndex = 4;
            this.monthCalendarTo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarTo_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(82, 256);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(409, 260);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDCard);
            this.groupBox1.Controls.Add(this.Passport);
            this.groupBox1.Location = new System.Drawing.Point(15, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Document:";
            // 
            // IDCard
            // 
            this.IDCard.AutoSize = true;
            this.IDCard.Location = new System.Drawing.Point(113, 20);
            this.IDCard.Name = "IDCard";
            this.IDCard.Size = new System.Drawing.Size(62, 17);
            this.IDCard.TabIndex = 1;
            this.IDCard.Text = "ID Card";
            this.IDCard.UseVisualStyleBackColor = true;
            this.IDCard.CheckedChanged += new System.EventHandler(this.IDCard_CheckedChanged);
            // 
            // Passport
            // 
            this.Passport.AutoSize = true;
            this.Passport.Location = new System.Drawing.Point(7, 20);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(67, 17);
            this.Passport.TabIndex = 0;
            this.Passport.Text = "Passport";
            this.Passport.UseVisualStyleBackColor = true;
            this.Passport.CheckedChanged += new System.EventHandler(this.Passport_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Issue Date:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(15, 389);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerTo.TabIndex = 14;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(318, 389);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerFrom.TabIndex = 16;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expiry Date:";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(318, 315);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(76, 13);
            this.lb8.TabIndex = 17;
            this.lb8.Text = "Document No:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(409, 313);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 18;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBook.Location = new System.Drawing.Point(0, 465);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(642, 23);
            this.btnBook.TabIndex = 19;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Baggage:";
            // 
            // Baggage
            // 
            this.Baggage.FormattingEnabled = true;
            this.Baggage.Location = new System.Drawing.Point(82, 421);
            this.Baggage.Name = "Baggage";
            this.Baggage.Size = new System.Drawing.Size(120, 17);
            this.Baggage.TabIndex = 21;
            this.Baggage.SelectedIndexChanged += new System.EventHandler(this.Baggage_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ngày về";
            // 
            // monthCalendarFrom
            // 
            this.monthCalendarFrom.Location = new System.Drawing.Point(352, 81);
            this.monthCalendarFrom.Name = "monthCalendarFrom";
            this.monthCalendarFrom.TabIndex = 6;
            this.monthCalendarFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarFrom_DateChanged);
            // 
            // AirTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 488);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Baggage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendarFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendarTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AirTicket";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.MonthCalendar monthCalendarTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IDCard;
        private System.Windows.Forms.CheckBox Passport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox Baggage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar monthCalendarFrom;
    }
}

