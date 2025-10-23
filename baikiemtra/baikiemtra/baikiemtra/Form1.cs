using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baikiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoatdong frm = new frmhoatdong();
            frm.Show();
            this.Hide();
        }

        private void quảnLýHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthanhvien frm = new frmthanhvien();
            frm.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
