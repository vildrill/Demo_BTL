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
    public partial class Timkiem : UserControl
    {
        public Timkiem()
        {
            InitializeComponent();
        }

        private void Timkiem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimkiemSV a = new TimkiemSV();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimkiemPhong b = new TimkiemPhong();
            b.Show();
        }
    }
}
