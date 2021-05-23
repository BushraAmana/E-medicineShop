using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration r1 = new Registration();
            r1.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string query = "select * from userInfo where phone = '" + txtPhoneNumber.Text + "' and pass = '" + txtPassword.Text+ "'";
            DataTable dt = db.Table(query);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                UserHomepage l1 = new UserHomepage();
                l1.Show();
            }
            else MessageBox.Show("Wrong username or password");
        }
    }
}
