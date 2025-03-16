using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiet_265
{
    public partial class frmCalculateSum : Form
    {
        public frmCalculateSum()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n) && n > 0)
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                }
                txtResult.Text = sum.ToString("F6");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtResult.Clear();
            txtN.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
