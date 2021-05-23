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
    public partial class Admin : Form
    {
        public Admin()
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

        private void btnSearch_Click(object sender, EventArgs e)
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

        
    }
}
