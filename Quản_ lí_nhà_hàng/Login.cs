using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản__lí_nhà_hàng.DAO;

namespace Quản__lí_nhà_hàng
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //xử lí sự kiện click button "Đăng nhập" 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            AccountDAO login = new AccountDAO();
            if ((login.Login(username, password) == true) & (login.check_admin(username, password) == false))
            {
                Staff st = new Staff();
                this.Hide();
                st.ShowDialog();
                this.Show();
            }
            //check quyền login là staff hay là manager
            else if ((login.Login(username, password) == true) & (login.check_admin(username, password) == true))
            {
                Admin ad = new Admin();
                this.Hide();
                ad.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");
            }
        }
        //xử lí sự kiện click button "Thoát" 
        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
