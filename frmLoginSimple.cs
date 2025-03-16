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
    public partial class frmLoginSimple : Form
    {
        public frmLoginSimple()
        {
            InitializeComponent();
        }

        private void frmLoginSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;

            // Danh sách tài khoản hợp lệ
            var accounts = new Dictionary<string, string>
    {
        { "Do Tuan Kiet", "1234" },
        { "Huỳnh Đăng Khoa", "4444" },
        { "Huỳnh Trung Tín", "4321" },
        { "Đinh Tấn Minh", "0987" }
    };

            // Kiểm tra xem tài khoản có trong danh sách không
            if (accounts.ContainsKey(username) && accounts[username] == password)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
