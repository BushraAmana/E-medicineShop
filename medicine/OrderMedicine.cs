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
    public partial class OrderMedicine : Form
    {
        private string name, price, quantity;
        private double tPrice;
        public OrderMedicine(string name, string price, string quantity, double tPrice)
        {
            InitializeComponent();
            this.name = name;
            txtMName.Text = name;
            this.price = price;
            txtPrice.Text = price;
            this.quantity = quantity; 
            txtQuantity.Text = quantity;
            this.tPrice = tPrice;
            txtTPrice.Text = tPrice.ToString();
            loadPreviousOrder();
        }

        private void confirmOrder(object sender, EventArgs e)
        {
            if (txtMName.Text == "")
            {
                return;
            }
            string query = "insert into OrderInfo values ('" + name + "'," + price + "," + txtQuantity.Text + "," + tPrice + ",'" + rtxtDAddress.Text + "')";
            new Database().update(query);
            loadPreviousOrder();
            txtMName.Text = txtPrice.Text = txtQuantity.Text = txtTPrice.Text = rtxtDAddress.Text = "";
        }
        private void loadPreviousOrder()
        {
            string query = "select * from OrderInfo";
            DataTable dt = new Database().Table(query);
            dgvOrderInfo.DataSource = dt;
            dgvOrderInfo.Refresh();
            dgvOrderInfo.ClearSelection();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomepage l1 = new UserHomepage();
            l1.Show();
        }
    }
}
