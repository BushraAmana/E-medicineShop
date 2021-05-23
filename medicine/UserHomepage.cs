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
    public partial class UserHomepage : Form
    {
        public UserHomepage()
        {
            InitializeComponent();
            loadMedicine();
        }
        private void loadMedicine()
        {
            string query = "select * from MedicineInfo";
            Database db = new Database();
            DataTable dt = db.Table(query);
            dgvSearchMedicine.DataSource = dt;
            dgvSearchMedicine.ClearSelection();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            double tPrice = Double.Parse(txtPrice.Text) * Double.Parse(txtQuantity.Text);
           
            OrderMedicine om = new OrderMedicine(txtMName.Text, txtPrice.Text, txtQuantity.Text, tPrice);
            om.Show();
        }

        private void showSearchResult(object sender, EventArgs e)
        {
            string query = "select * from MedicineInfo where MedicineName = '" + txtSearch.Text + "'";
            DataTable dt = new Database().Table(query);
            if (dt.Rows.Count == 0) MessageBox.Show("No such medicine found");
            else
            {
                dgvSearchMedicine.DataSource = dt;
                dgvSearchMedicine.ClearSelection();
            }
        }

        private void searchEmpty(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                loadMedicine();
        }

        private void showInfo(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            string query = "select * from MedicineInfo where MedicineName = '" + dgvSearchMedicine.Rows[index].Cells["MedicineName"].Value.ToString() + "'";
        
            DataTable dt = new Database().Table(query);
            txtMName.Text = dt.Rows[0]["MedicineName"].ToString();
            txtPrice.Text = dt.Rows[0]["Price"].ToString();
        }
    }
}
