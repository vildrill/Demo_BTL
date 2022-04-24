using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_BTL
{
    public partial class FormHome : Form
    {
        bool thoat = true;
        public FormHome()
        {
            InitializeComponent();
            sidepanel1.Height = Btn_trangchu.Height;
            sidepanel1.Top = Btn_trangchu.Top;
        }

        private void Btn_Qlyktx_Click(object sender, EventArgs e)
        {
            sidepanel1.Height = Btn_Qlyktx.Height;
            sidepanel1.Top = Btn_Qlyktx.Top;
            sidepanel1.BackColor = Color.Tomato;
            qliKTX2.BringToFront();
           

        }

        

        private void Btn_Timkiem_Click(object sender, EventArgs e)
        {
            sidepanel1.Height = Btn_TimKiem.Height;
            sidepanel1.Top = Btn_TimKiem.Top;
            sidepanel1.BackColor = Color.Teal;
            timkiem1.BringToFront();

        }

        private void Btn_Thuephong_Click(object sender, EventArgs e)
        {
            sidepanel1.Height = Btn_Thuephong.Height;
            sidepanel1.Top =Btn_Thuephong.Top;
            sidepanel1.BackColor = Color.Khaki;
            thuePhong2.BringToFront();
        }

        private void Btn_Hopdong_Click(object sender, EventArgs e)
        {
            sidepanel1.Height = Btn_Hopdong.Height;
            sidepanel1.Top = Btn_Hopdong.Top;
            sidepanel1.BackColor = Color.Wheat;
            hopDong2.BringToFront();
        }

        private void Btn_trangchu_Click(object sender, EventArgs e)
        {
            sidepanel1.Height = Btn_trangchu.Height;
            sidepanel1.Top = Btn_trangchu.Top;
            sidepanel1.BackColor= Color.IndianRed;
            trangchu1.BringToFront();
        }

        private void Btn_Dangxuat_Click(object sender, EventArgs e)
        {
            thoat = false;
            
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(thoat)
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
