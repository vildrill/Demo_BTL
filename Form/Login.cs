using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_BTL
{
    public partial class Login : Form
    {
        string ConnectionName = @"Data Source=LAPTOP-C2K0J1R6\SQLEXPRESS;Initial Catalog=QLKT;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);
            try
            {
                conn.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from Account where Username = '" + tk+ "' and Password = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    FormHome form1 = new FormHome();
                    this.Hide();
                    form1.ShowDialog();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu rồi, vui lòng nhập lại!");
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
                conn.Close();
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
