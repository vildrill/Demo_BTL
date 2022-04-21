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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel1 = new System.Windows.Forms.Panel();
            this.Btn_Hopdong = new System.Windows.Forms.Button();
            this.Btn_Thuephong = new System.Windows.Forms.Button();
            this.Btn_Timkiem = new System.Windows.Forms.Button();
            this.Btn_Qlyktx = new System.Windows.Forms.Button();
            this.Btn_trangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Dangxuat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trangchu1 = new Demo_BTL.Trangchu();
            this.timKiem3 = new Demo_BTL.TimKiem();
            this.thuePhong2 = new Demo_BTL.ThuePhong();
            this.qliKTX2 = new Demo_BTL.QliKTX();
            this.hopDong2 = new Demo_BTL.HopDong();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.sidepanel1);
            this.panel1.Controls.Add(this.Btn_Hopdong);
            this.panel1.Controls.Add(this.Btn_Thuephong);
            this.panel1.Controls.Add(this.Btn_Timkiem);
            this.panel1.Controls.Add(this.Btn_Qlyktx);
            this.panel1.Controls.Add(this.Btn_trangchu);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 481);
            this.panel1.TabIndex = 0;
            // 
            // sidepanel1
            // 
            this.sidepanel1.BackColor = System.Drawing.Color.IndianRed;
            this.sidepanel1.Location = new System.Drawing.Point(0, 65);
            this.sidepanel1.Name = "sidepanel1";
            this.sidepanel1.Size = new System.Drawing.Size(10, 52);
            this.sidepanel1.TabIndex = 0;
            // 
            // Btn_Hopdong
            // 
            this.Btn_Hopdong.FlatAppearance.BorderSize = 0;
            this.Btn_Hopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Hopdong.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hopdong.ForeColor = System.Drawing.Color.White;
            this.Btn_Hopdong.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Hopdong.Image")));
            this.Btn_Hopdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Hopdong.Location = new System.Drawing.Point(7, 256);
            this.Btn_Hopdong.Name = "Btn_Hopdong";
            this.Btn_Hopdong.Size = new System.Drawing.Size(173, 52);
            this.Btn_Hopdong.TabIndex = 4;
            this.Btn_Hopdong.Text = "Hợp đồng";
            this.Btn_Hopdong.UseVisualStyleBackColor = true;
            this.Btn_Hopdong.Click += new System.EventHandler(this.Btn_Hopdong_Click);
            // 
            // Btn_Thuephong
            // 
            this.Btn_Thuephong.FlatAppearance.BorderSize = 0;
            this.Btn_Thuephong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Thuephong.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Thuephong.ForeColor = System.Drawing.Color.White;
            this.Btn_Thuephong.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Thuephong.Image")));
            this.Btn_Thuephong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Thuephong.Location = new System.Drawing.Point(7, 204);
            this.Btn_Thuephong.Name = "Btn_Thuephong";
            this.Btn_Thuephong.Size = new System.Drawing.Size(173, 52);
            this.Btn_Thuephong.TabIndex = 3;
            this.Btn_Thuephong.Text = "Thuê Phòng";
            this.Btn_Thuephong.UseVisualStyleBackColor = true;
            this.Btn_Thuephong.Click += new System.EventHandler(this.Btn_Thuephong_Click);
            // 
            // Btn_Timkiem
            // 
            this.Btn_Timkiem.FlatAppearance.BorderSize = 0;
            this.Btn_Timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Timkiem.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Timkiem.ForeColor = System.Drawing.Color.White;
            this.Btn_Timkiem.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Timkiem.Image")));
            this.Btn_Timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Timkiem.Location = new System.Drawing.Point(7, 161);
            this.Btn_Timkiem.Name = "Btn_Timkiem";
            this.Btn_Timkiem.Size = new System.Drawing.Size(173, 52);
            this.Btn_Timkiem.TabIndex = 2;
            this.Btn_Timkiem.Text = "Tìm kiếm";
            this.Btn_Timkiem.UseVisualStyleBackColor = true;
            this.Btn_Timkiem.Click += new System.EventHandler(this.Btn_Timkiem_Click);
            // 
            // Btn_Qlyktx
            // 
            this.Btn_Qlyktx.FlatAppearance.BorderSize = 0;
            this.Btn_Qlyktx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Qlyktx.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Qlyktx.ForeColor = System.Drawing.Color.White;
            this.Btn_Qlyktx.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Qlyktx.Image")));
            this.Btn_Qlyktx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Qlyktx.Location = new System.Drawing.Point(7, 114);
            this.Btn_Qlyktx.Name = "Btn_Qlyktx";
            this.Btn_Qlyktx.Size = new System.Drawing.Size(173, 52);
            this.Btn_Qlyktx.TabIndex = 1;
            this.Btn_Qlyktx.Text = "Quản lý KTX";
            this.Btn_Qlyktx.UseVisualStyleBackColor = true;
            this.Btn_Qlyktx.Click += new System.EventHandler(this.Btn_Qlyktx_Click);
            // 
            // Btn_trangchu
            // 
            this.Btn_trangchu.CausesValidation = false;
            this.Btn_trangchu.FlatAppearance.BorderSize = 0;
            this.Btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_trangchu.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_trangchu.ForeColor = System.Drawing.Color.White;
            this.Btn_trangchu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_trangchu.Image")));
            this.Btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_trangchu.Location = new System.Drawing.Point(7, 65);
            this.Btn_trangchu.Name = "Btn_trangchu";
            this.Btn_trangchu.Size = new System.Drawing.Size(177, 52);
            this.Btn_trangchu.TabIndex = 0;
            this.Btn_trangchu.Text = "Trang chủ";
            this.Btn_trangchu.UseVisualStyleBackColor = true;
            this.Btn_trangchu.Click += new System.EventHandler(this.Btn_trangchu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 117);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.Btn_Dangxuat);
            this.panel3.Location = new System.Drawing.Point(423, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 63);
            this.panel3.TabIndex = 2;
            // 
            // Btn_Dangxuat
            // 
            this.Btn_Dangxuat.FlatAppearance.BorderSize = 0;
            this.Btn_Dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dangxuat.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dangxuat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dangxuat.Image")));
            this.Btn_Dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Dangxuat.Location = new System.Drawing.Point(420, 11);
            this.Btn_Dangxuat.Name = "Btn_Dangxuat";
            this.Btn_Dangxuat.Size = new System.Drawing.Size(116, 39);
            this.Btn_Dangxuat.TabIndex = 0;
            this.Btn_Dangxuat.Text = "Đăng xuất";
            this.Btn_Dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dangxuat.UseVisualStyleBackColor = true;
            this.Btn_Dangxuat.Click += new System.EventHandler(this.Btn_Dangxuat_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.trangchu1);
            this.panel4.Controls.Add(this.timKiem3);
            this.panel4.Controls.Add(this.thuePhong2);
            this.panel4.Controls.Add(this.qliKTX2);
            this.panel4.Controls.Add(this.hopDong2);
            this.panel4.Location = new System.Drawing.Point(185, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 366);
            this.panel4.TabIndex = 3;
            // 
            // trangchu1
            // 
            this.trangchu1.BackColor = System.Drawing.Color.IndianRed;
            this.trangchu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangchu1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.trangchu1.Location = new System.Drawing.Point(0, 0);
            this.trangchu1.Name = "trangchu1";
            this.trangchu1.Size = new System.Drawing.Size(782, 366);
            this.trangchu1.TabIndex = 4;
            // 
            // timKiem3
            // 
            this.timKiem3.Location = new System.Drawing.Point(0, 2);
            this.timKiem3.Margin = new System.Windows.Forms.Padding(2);
            this.timKiem3.Name = "timKiem3";
            this.timKiem3.Size = new System.Drawing.Size(783, 362);
            this.timKiem3.TabIndex = 3;
            // 
            // thuePhong2
            // 
            this.thuePhong2.Location = new System.Drawing.Point(0, 2);
            this.thuePhong2.Margin = new System.Windows.Forms.Padding(2);
            this.thuePhong2.Name = "thuePhong2";
            this.thuePhong2.Size = new System.Drawing.Size(783, 362);
            this.thuePhong2.TabIndex = 2;
            // 
            // qliKTX2
            // 
            this.qliKTX2.Location = new System.Drawing.Point(0, 0);
            this.qliKTX2.Margin = new System.Windows.Forms.Padding(2);
            this.qliKTX2.Name = "qliKTX2";
            this.qliKTX2.Size = new System.Drawing.Size(783, 366);
            this.qliKTX2.TabIndex = 1;
            // 
            // hopDong2
            // 
            this.hopDong2.Location = new System.Drawing.Point(0, 0);
            this.hopDong2.Margin = new System.Windows.Forms.Padding(2);
            this.hopDong2.Name = "hopDong2";
            this.hopDong2.Size = new System.Drawing.Size(783, 366);
            this.hopDong2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(17, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 476);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.Text = "Ký túc xá UTC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ThuePhong thuePhong1;
        private TimKiem timKiem1;
        private HopDong hopDong1;
        private QliKTX qliKTX1;
        private TimKiem timKiem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidepanel1;
        private System.Windows.Forms.Button Btn_Hopdong;
        private System.Windows.Forms.Button Btn_Thuephong;
        private System.Windows.Forms.Button Btn_Timkiem;
        private System.Windows.Forms.Button Btn_Qlyktx;
        private System.Windows.Forms.Button Btn_trangchu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_Dangxuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TimKiem timKiem3;
        private ThuePhong thuePhong2;
        private QliKTX qliKTX2;
        private HopDong hopDong2;
        private Trangchu trangchu1;
        private System.Windows.Forms.Button button4;
    }
}

