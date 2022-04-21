namespace Demo_BTL
{
    partial class Login
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangnhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.labelMK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(159, 125);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(103, 22);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDangnhap
            // 
            this.buttonDangnhap.Location = new System.Drawing.Point(27, 125);
            this.buttonDangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDangnhap.Name = "buttonDangnhap";
            this.buttonDangnhap.Size = new System.Drawing.Size(103, 22);
            this.buttonDangnhap.TabIndex = 2;
            this.buttonDangnhap.Text = "Đăng nhập";
            this.buttonDangnhap.UseVisualStyleBackColor = true;
            this.buttonDangnhap.Click += new System.EventHandler(this.buttonDangnhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(112, 83);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(120, 20);
            this.txtMK.TabIndex = 1;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(112, 45);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(120, 20);
            this.txtTK.TabIndex = 0;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Location = new System.Drawing.Point(46, 88);
            this.labelMK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(52, 13);
            this.labelMK.TabIndex = 3;
            this.labelMK.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng nhập ";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(46, 50);
            this.labelTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(55, 13);
            this.labelTK.TabIndex = 5;
            this.labelTK.Text = "Tài khoản";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(304, 176);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangnhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.labelMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangnhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTK;
    }
}