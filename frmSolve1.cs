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
    public partial class frmSolve1 : Form
    {
        public frmSolve1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị a và b từ TextBox
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                // Kiểm tra nếu a = 0
                if (a == 0)
                {
                    if (b == 0)
                        txtResult.Text = "Phương trình vô số nghiệm";
                    else
                        txtResult.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -b / a;
                    txtResult.Text = $" x = {x:F2}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lbResult.Text = "";
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
