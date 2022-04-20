namespace Demo_BTL
{
    partial class FormHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHopdong = new System.Windows.Forms.Button();
            this.btThue = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btKTX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDangxuat = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btHopdong);
            this.panel1.Controls.Add(this.btThue);
            this.panel1.Controls.Add(this.btTim);
            this.panel1.Controls.Add(this.btKTX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 435);
            this.panel1.TabIndex = 3;
            // 
            // btHopdong
            // 
            this.btHopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHopdong.Location = new System.Drawing.Point(0, 198);
            this.btHopdong.Name = "btHopdong";
            this.btHopdong.Size = new System.Drawing.Size(215, 54);
            this.btHopdong.TabIndex = 1;
            this.btHopdong.Text = "Hợp đồng";
            this.btHopdong.UseVisualStyleBackColor = true;
            // 
            // btThue
            // 
            this.btThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThue.Location = new System.Drawing.Point(0, 138);
            this.btThue.Name = "btThue";
            this.btThue.Size = new System.Drawing.Size(215, 54);
            this.btThue.TabIndex = 1;
            this.btThue.Text = "Thuê phòng";
            this.btThue.UseVisualStyleBackColor = true;
            // 
            // btTim
            // 
            this.btTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTim.Location = new System.Drawing.Point(0, 78);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(215, 54);
            this.btTim.TabIndex = 1;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // btKTX
            // 
            this.btKTX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKTX.Location = new System.Drawing.Point(0, 18);
            this.btKTX.Name = "btKTX";
            this.btKTX.Size = new System.Drawing.Size(215, 54);
            this.btKTX.TabIndex = 1;
            this.btKTX.Text = "Quản lí ký túc xá";
            this.btKTX.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btDangxuat);
            this.panel2.Controls.Add(this.btHome);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 72);
            this.panel2.TabIndex = 4;
            // 
            // btDangxuat
            // 
            this.btDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangxuat.Location = new System.Drawing.Point(784, 9);
            this.btDangxuat.Name = "btDangxuat";
            this.btDangxuat.Size = new System.Drawing.Size(161, 53);
            this.btDangxuat.TabIndex = 2;
            this.btDangxuat.Text = "Đăng xuất";
            this.btDangxuat.UseVisualStyleBackColor = true;
            // 
            // btHome
            // 
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Location = new System.Drawing.Point(29, 9);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(161, 53);
            this.btHome.TabIndex = 2;
            this.btHome.Text = "Trang chủ";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(465, 41);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(488, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(215, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 435);
            this.panel3.TabIndex = 5;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 507);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormHome";
            this.Text = "Ký túc xá UTC";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btHopdong;
        private System.Windows.Forms.Button btThue;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btKTX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDangxuat;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel3;
    }
}

