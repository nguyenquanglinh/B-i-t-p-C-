namespace XayDungUngDungDatVeXemPhim
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.comboBoxThoiGian = new System.Windows.Forms.ComboBox();
            this.comboBoxChonPhim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxHangGhe = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CGV";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBoxPhong);
            this.groupBox1.Controls.Add(this.comboBoxThoiGian);
            this.groupBox1.Controls.Add(this.comboBoxChonPhim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-2, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giá vé/ghế:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "70.000 vnđ";
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(125, 84);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(81, 21);
            this.comboBoxPhong.TabIndex = 12;
            // 
            // comboBoxThoiGian
            // 
            this.comboBoxThoiGian.FormattingEnabled = true;
            this.comboBoxThoiGian.Location = new System.Drawing.Point(125, 43);
            this.comboBoxThoiGian.Name = "comboBoxThoiGian";
            this.comboBoxThoiGian.Size = new System.Drawing.Size(303, 21);
            this.comboBoxThoiGian.TabIndex = 11;
            // 
            // comboBoxChonPhim
            // 
            this.comboBoxChonPhim.FormattingEnabled = true;
            this.comboBoxChonPhim.Location = new System.Drawing.Point(125, 10);
            this.comboBoxChonPhim.Name = "comboBoxChonPhim";
            this.comboBoxChonPhim.Size = new System.Drawing.Size(303, 21);
            this.comboBoxChonPhim.TabIndex = 10;
            this.comboBoxChonPhim.SelectedIndexChanged += new System.EventHandler(this.comboBoxChonPhim_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn phim:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(-2, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hang:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(307, 23);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(121, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "SDT:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(125, 23);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(121, 20);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên khách hàng:";
            // 
            // groupBoxHangGhe
            // 
            this.groupBoxHangGhe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxHangGhe.Location = new System.Drawing.Point(-2, 243);
            this.groupBoxHangGhe.Name = "groupBoxHangGhe";
            this.groupBoxHangGhe.Size = new System.Drawing.Size(437, 168);
            this.groupBoxHangGhe.TabIndex = 3;
            this.groupBoxHangGhe.TabStop = false;
            this.groupBoxHangGhe.Text = "Hàng ghế:";
            this.groupBoxHangGhe.Enter += new System.EventHandler(this.groupBoxHangGhe_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đặt vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(438, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxHangGhe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.ComboBox comboBoxThoiGian;
        private System.Windows.Forms.ComboBox comboBoxChonPhim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxHangGhe;
        private System.Windows.Forms.Button button1;
    }
}

