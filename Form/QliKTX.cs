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
    public partial class QliKTX : UserControl
    {
        public QliKTX()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QliSV h = new QliSV();
            h.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QlyKhuNha qlyKhuNha = new QlyKhuNha();
            qlyKhuNha.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QliThietBi qliThietBi = new QliThietBi();
            qliThietBi.ShowDialog();
        }
    }
}
