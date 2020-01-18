using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class EmployeePage : Form
    {
        DataTable dt = new DataTable();
        MySqlDataAdapter ad = new MySqlDataAdapter();
        public EmployeePage()
        {
            InitializeComponent();
            
            loadPsProduct();
            
        }

        //Load products from database into the datagridview
        private void loadPsProduct()
        {
            try
            {
                dbConnect db = new dbConnect();
                String query = "SELECT * FROM group_five.products WHERE QUANTITY > 0";

                dgvEProduct2.DataSource = db.Select(query);
                ad.Update(dt);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

        }

        private void TxtSearch2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbConnect db = new dbConnect();
                String searchKye = txtSearch2.Text;
                String query = "SELECT * FROM group_five.products WHERE PRODUCT_ID LIKE ('" + searchKye + "%') OR PRODUCT_NAME LIKE ('" + searchKye + "%')";

                dgvEProduct2.DataSource = db.Select(query);
                ad.Update(dt);

                if (txtSearch2.Text == "")
                {
                    loadPsProduct();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void DgvEProduct2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                if (e.RowIndex >= 0)
                {
                    row = this.dgvEProduct2.Rows[e.RowIndex];

                    txt_pid2.Text = row.Cells["PRODUCT_ID"].Value.ToString();
                    txt_Pname2.Text = row.Cells["PRODUCT_NAME"].Value.ToString();
                    txt_Price2.Text = row.Cells["PRICE"].Value.ToString();
                    txtActualQty2.Text = row.Cells["QUANTITY"].Value.ToString();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void BtnCart_Emp2_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txt_Qty2.Text, out int quantity);
            Int32.TryParse(txtActualQty2.Text, out int totalQuantity);

            //quantity <= totalQuantity && quantity > 0 && txt_Qty.Text != ""

            try
            {
                if (quantity <= totalQuantity && quantity > 0 && txt_Qty2.Text != "")
                {
                    Double.TryParse(txt_Price2.Text, out Double price);
                    Double.TryParse(txt_Qty2.Text, out Double qty);
                    Int32.TryParse(txt_Qty2.Text, out int qty_1);

                    double total = price * qty;

                    string stringTotal = total.ToString();

                    //MessageBox.Show(txt_Qty.Text + ' ' + txtActualQty.Text);

                    dgvInvoice2.Rows.Add(txt_Pname2.Text, txt_Price2.Text, txt_Qty2.Text, stringTotal);

                    double addSum = 0.0;

                    for (int x = 0; x < dgvInvoice2.Rows.Count; x++)
                    {
                        addSum = addSum + Convert.ToDouble(dgvInvoice2.Rows[x].Cells[3].Value);
                    }

                    txtGTotal2.Text = Convert.ToString(addSum);

                    String updateQuery = "UPDATE products SET QUANTITY = QUANTITY - '" + qty_1 + "' WHERE PRODUCT_ID = '" + txt_pid2.Text + "' ";

                    dbConnect connect = new dbConnect();
                    connect.Update(updateQuery);
                }
                else
                {
                    MessageBox.Show("Invalid value for the quantity");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            txt_Qty2.Text = "";
            loadPsProduct();
        }

        private void BtnDelRow2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvInvoice2.SelectedRows)
                {
                    dgvInvoice2.Rows.Remove(row);
                    double addSum = 0.0;

                    for (int x = 0; x < dgvInvoice2.Rows.Count; x++)
                    {
                        addSum = addSum + Convert.ToDouble(dgvInvoice2.Rows[x].Cells[3].Value);
                    }

                    txtGTotal2.Text = Convert.ToString(addSum);

                    String updateQuery = "UPDATE products SET QUANTITY = QUANTITY + '" + txtq2.Text + "' WHERE PRODUCT_NAME = '" + txtpn2.Text + "' ";

                    dbConnect connect = new dbConnect();
                    connect.Update(updateQuery);
                }



                txtq2.Text = "";
                loadPsProduct();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void DgvInvoice2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = this.dgvInvoice2.Rows[e.RowIndex];
                    txtpn2.Text = Convert.ToString(row.Cells["item"].Value);
                    txtpr2.Text = Convert.ToString(row.Cells["price"].Value);
                    txtq2.Text = Convert.ToString(row.Cells["qty"].Value);
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void BtnLogout2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            String dateNow = DateTime.Now.ToString(), tDate = DateTime.Now.ToShortDateString();
            String tTime = DateTime.Now.ToShortTimeString();



            String transactionId = "TTc" + dateNow;
            foreach (DataGridViewRow dr in this.dgvInvoice2.SelectedRows)
            {
                String insertQuery = "INSERT INTO business_transaction(TRANSACTION_ID, TRANSACTION_DATE, TRANSACTION_TIME, ITEM_SOLD, QUANTITY_SOLD) VALUES ('" + transactionId + "','" + tDate + "','" + tTime + "','" + dr.Cells[0].Value + "', '" + dr.Cells[2].Value + "') ";

                dbConnect connect = new dbConnect();
                connect.Insert(insertQuery);
                //printArea.dgvPrintF.Rows.Add(dr.Cells[0].Value, dr.Cells[1].Value, dr.Cells[2].Value, dr.Cells[3].Value);
            }
            //printArea.txtPrintTotal.Text = this.txtGTotal2.Text;
                 dgvInvoice2.Rows.Clear();
                 txtGTotal2.Text = "";
            MessageBox.Show("Transaction Completed Successfully");
            // printArea.Show();
            // this.Hide();
        }
    }
}
