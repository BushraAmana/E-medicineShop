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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtCPassword.Text)
            {

                string fname, lname, phone, email, add, gender, pass;
                fname = txtfname.Text;
                lname = txtlname.Text;
                phone = txtphone.Text;
                email = txtEmail.Text;
                add = rtxtAddress.Text;
                pass = txtPassword.Text;
                if (rbtnFemale.Checked) gender = "Female";
                else gender = "Male";

                string query = "insert into userInfo values ('" + fname + "','" + lname + "','" + phone + "','" + email + "','" + gender + "','" + add + "','" + pass + "')";
                Database db = new Database();
                db.update(query);
                MessageBox.Show("Successful registration");

                this.Hide();
                Login l1 = new Login();
                l1.Show();
            }
            else MessageBox.Show("Passwords didn't match");
        }
    }
}
