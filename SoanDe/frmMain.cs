using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoanDe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSoanDe_Click(object sender, EventArgs e)
        {
            frmSoan_De frmSoan = new frmSoan_De();
            this.Visible = false;
            frmSoan.ShowDialog();
        }

        private void btnChamthi_Click(object sender, EventArgs e)
        {
            frmChamThi frmCham = new frmChamThi();
            this.Visible = false;
            frmCham.ShowDialog();
        }
    }
}
