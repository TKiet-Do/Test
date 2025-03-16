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
    public partial class frmcaculate : Form
    {
        public frmcaculate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị nhập vào từ TextBox
                double A = double.Parse(txtA.Text);
                double B = double.Parse(txtB.Text);

                // Thực hiện phép toán
                double sum = A + B;
                double difference = A - B;
                double product = A * B;
                double quotient = B != 0 ? A / B : double.NaN;

                // Gán kết quả vào TextBox thay vì Label
                txtSum.Text = sum.ToString();
                txtDiff.Text = difference.ToString();
                txtProduct.Text = product.ToString();
                txtQuotient.Text = B != 0 ? quotient.ToString("F2") : "Không thể chia cho 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong tất cả các TextBox
            txtA.Clear();
            txtB.Clear();
            txtSum.Clear();
            txtDiff.Clear();
            txtProduct.Clear();
            txtQuotient.Clear();

            // Đưa con trỏ về ô nhập A
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }

        private void frmcaculate_Load(object sender, EventArgs e)
        {

        }
    }
}
