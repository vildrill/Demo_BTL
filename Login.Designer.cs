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
            this.buttonThoat.Location = new System.Drawing.Point(212, 154);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(137, 27);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDangnhap
            // 
            this.buttonDangnhap.Location = new System.Drawing.Point(36, 154);
            this.buttonDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDangnhap.Name = "buttonDangnhap";
            this.buttonDangnhap.Size = new System.Drawing.Size(137, 27);
            this.buttonDangnhap.TabIndex = 9;
            this.buttonDangnhap.Text = "Đăng nhập";
            this.buttonDangnhap.UseVisualStyleBackColor = true;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(150, 102);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(159, 22);
            this.txtMK.TabIndex = 6;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(150, 55);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(159, 22);
            this.txtTK.TabIndex = 7;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Location = new System.Drawing.Point(62, 108);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(61, 16);
            this.labelMK.TabIndex = 3;
            this.labelMK.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng nhập ";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(62, 61);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(67, 16);
            this.labelTK.TabIndex = 5;
            this.labelTK.Text = "Tài khoản";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 216);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangnhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.labelMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTK);
            this.Name = "Login";
            this.Text = "Đăng nhập";
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