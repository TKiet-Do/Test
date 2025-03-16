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
    public partial class frmmonth : Form
    {
        public frmmonth()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(txtMonth.Text);
                int year = int.Parse(txtYear.Text);

                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ! Nhập từ 1 đến 12.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int days;
                // Kiểm tra số ngày theo tháng
                if (month == 2)
                {
                    // Kiểm tra năm nhuận
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                        days = 29;
                    else
                        days = 28;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    days = 30;
                }
                else
                {
                    days = 31;
                }

                lbResult.Text = $"Số ngày của tháng {month} năm {year} là: {days} ngày.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnAgain_Click(object sender, EventArgs e)
        {
            txtMonth.Clear();
            txtYear.Clear();
            lbResult.Text = "";
            txtMonth.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmmonth_Load(object sender, EventArgs e)
        {

        }
    }
}
