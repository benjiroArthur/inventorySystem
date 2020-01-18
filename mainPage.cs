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

    
      
    public partial class mainPage : Form
    {
        DataTable dt = new DataTable();
        MySqlDataAdapter ad = new MySqlDataAdapter();
        //BindingSource bs = new BindingSource();
        //private BindingSource bs;

        


        public mainPage()
        {
            InitializeComponent();
            //Execute command

            loadProduct();
            loadPsProduct();
            loadEmployee();
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide(); 
        }

        private void PointOfSale_Click(object sender, EventArgs e)
        {

        }

        //Load products from database into the datagridview
        private void loadPsProduct() 
        {
            try
            {
                dbConnect db = new dbConnect();
                String query = "SELECT * FROM group_five.products WHERE QUANTITY > 0";

                dgvEProduct.DataSource = db.Select(query);
                ad.Update(dt);
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
            
        }

        //Load products from database into the datagridview
        private void loadProduct()
        {
            try
            {
                String query = "SELECT * FROM group_five.products";
                dbConnect db = new dbConnect();

                dgvPDBase.DataSource = db.Select(query);
                ad.Update(dt);
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
        }

        //Load employees from database into the datagridview
        private void loadEmployee()
        {
            try
            {
                String query = "SELECT * FROM group_five.employee";
                dbConnect db = new dbConnect();

                dgvEmployee.DataSource = db.Select(query);

                ad.Update(dt);
            }
            catch (Exception error)
            {
                
               MessageBox.Show(error.Message);
            }
        }

        //Search forProduct
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbConnect db = new dbConnect();
                String searchKye = txtSearch.Text;
                String query = "SELECT * FROM group_five.products WHERE PRODUCT_ID LIKE ('" + searchKye + "%') OR PRODUCT_NAME LIKE ('" + searchKye + "%')";

                dgvEProduct.DataSource = db.Select(query);
                ad.Update(dt);

                if (txtSearch.Text == "")
                {
                    loadPsProduct();
                }
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
        }

        private void dgvEProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                if (e.RowIndex >= 0)
                {
                    row = this.dgvEProduct.Rows[e.RowIndex];

                    txt_pid.Text = row.Cells["PRODUCT_ID"].Value.ToString();
                    txt_Pname.Text = row.Cells["PRODUCT_NAME"].Value.ToString();
                    txt_Price.Text = row.Cells["PRICE"].Value.ToString();
                    txtActualQty.Text = row.Cells["QUANTITY"].Value.ToString();
                }
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
        }

        private void btnCart_Emp_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txt_Qty.Text, out int quantity);
            Int32.TryParse(txtActualQty.Text, out int totalQuantity);

            //quantity <= totalQuantity && quantity > 0 && txt_Qty.Text != ""

            try
            {
                if (quantity <= totalQuantity && quantity > 0 && txt_Qty.Text != "")
                {
                    Double.TryParse(txt_Price.Text, out Double price);
                    Double.TryParse(txt_Qty.Text, out Double qty);
                    Int32.TryParse(txt_Qty.Text, out int qty_1);

                    double total = price * qty;

                    string stringTotal = total.ToString();

                    //MessageBox.Show(txt_Qty.Text + ' ' + txtActualQty.Text);

                    dgvInvoice.Rows.Add(txt_Pname.Text, txt_Price.Text, txt_Qty.Text, stringTotal);

                    double addSum = 0.0;

                    for (int x = 0; x < dgvInvoice.Rows.Count; x++)
                    {
                        addSum = addSum + Convert.ToDouble(dgvInvoice.Rows[x].Cells[3].Value);
                    }

                    txtGTotal.Text = Convert.ToString(addSum);

                    String updateQuery = "UPDATE products SET QUANTITY = QUANTITY - '" + qty_1 + "' WHERE PRODUCT_ID = '" + txt_pid.Text + "' ";

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

            txt_Qty.Text = "";
            loadPsProduct();
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvInvoice.SelectedRows)
                {
                    dgvInvoice.Rows.Remove(row);
                    double addSum = 0.0;

                    for (int x = 0; x < dgvInvoice.Rows.Count; x++)
                    {
                        addSum = addSum + Convert.ToDouble(dgvInvoice.Rows[x].Cells[3].Value);
                    }

                    txtGTotal.Text = Convert.ToString(addSum);

                    String updateQuery = "UPDATE products SET QUANTITY = QUANTITY + '" + txtq1.Text + "' WHERE PRODUCT_NAME = '" + txtpn1.Text + "' ";

                    dbConnect connect = new dbConnect();
                    connect.Update(updateQuery);
                }

                

                txtq1.Text = "";
                loadPsProduct();
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = this.dgvInvoice.Rows[e.RowIndex];
                    txtpn1.Text = Convert.ToString(row.Cells["item"].Value);
                    txtpr1.Text = Convert.ToString(row.Cells["price"].Value);
                    txtq1.Text = Convert.ToString(row.Cells["qty"].Value);
                }
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
        }

        //Add employee Data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String insertQuery = "INSERT INTO employee(STAFF_ID, FIRST_NAME, LAST_NAME, GENDER, DATE_OF_BIRTH, USER_TYPE, USER_PASSWORD, SECURITY_QUESTION, ANSWER) VALUES ('" + txtStaff_id.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + cmbGender.Text + "','" + dtpDod.Text + "','" + cmbUserType.Text + "','" + txtPassword.Text + "','" + cmbSQ.Text + "','" + txtAnswer.Text + "') ";
                dbConnect connect = new dbConnect();
                connect.Insert(insertQuery);
                MessageBox.Show("Data Inserted Successfully");

            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.Message);
            }
            loadEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String deleteQuery = "DELETE FROM employee WHERE STAFF_ID = '" + txtStaff_id.Text + "' ";
                dbConnect connect = new dbConnect();
                connect.Delete(deleteQuery);
                MessageBox.Show("Employee Data Deleted Successfully");
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            loadEmployee();
        }

       

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex >= 0)
                {
                    row = this.dgvEmployee.Rows[e.RowIndex];
                    txtStaff_id.Text = Convert.ToString(row.Cells["item"].Value);
                    txtpr1.Text = Convert.ToString(row.Cells["price"].Value);
                    txtq1.Text = Convert.ToString(row.Cells["qty"].Value);
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        //Add Product
        private void btnInsertP_Click(object sender, EventArgs e)
        {
            String insertQuery  = "INSERT INTO products(PRODUCT_ID, PRODUCT_NAME, QUANTITY, PRICE ) VALUES ('" + txtPID.Text + "','" + txtPName.Text + "','" + txtQty.Text + "','" + txtPrice.Text + "') ";
            dbConnect connect = new dbConnect();
            if (txtPID.Text != "" && txtPName.Text != "" && txtQty.Text != "" && txtPrice.Text != "")
            {
                connect.Insert(insertQuery);

                MessageBox.Show("Product Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }
            loadProduct();
        }

        //Delete Product
        private void btnDeleP_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgvPDBase.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPDBase.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["PRODUCT_ID"].Value);
           
            String deleteQuery = "DELETE FROM products WHERE PRODUCT_ID = '" + a + "' ";


           

            if (txtPID.Text != "")
            {
                dbConnect connect = new dbConnect();
                connect.Delete(deleteQuery);

                MessageBox.Show("Property Records Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }
            loadProduct();
        }

        private void btnU_Quantity_Click(object sender, EventArgs e)
        {
            String updateQuery = "UPDATE products SET QUANTITY = QUANTITY + '" + txtQty.Text + "'  WHERE PRODUCT_ID = '" + txtPID.Text + "' ";

            if (txtQty.Text != "" && txtPID.Text != "")
            {
                dbConnect connect = new dbConnect();
                connect.Update(updateQuery);
            }

            else
            {
                MessageBox.Show("Invalid Entry");
            }
            loadProduct();
        }

        private void btnU_Price_Click(object sender, EventArgs e)
        {
            String updateQuery = "UPDATE products SET PRICE = '" + txtPrice.Text + "' WHERE PRODUCT_ID= '" + txtPID.Text + "' ";

            if (txtPrice.Text != "" && txtPID.Text != "")
            {
                dbConnect connect = new dbConnect();
                connect.Update(updateQuery);
            }

            else
            {
                MessageBox.Show("Invalid Entry");
            }
            loadProduct();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            PrintArea printArea = new PrintArea();
            //Transfering content of dgvInvoice and txtGTotal to PrintArea.dgvPrint and PrintArea.txtPrintTotal
            String dateNow = DateTime.Now.ToString(), tDate = DateTime.Now.ToShortDateString();
            String tTime = DateTime.Now.ToShortTimeString();



            String transactionId = "TTc" + dateNow;
            foreach (DataGridViewRow dr in this.dgvInvoice.SelectedRows)
            {
                String insertQuery = "INSERT INTO business_transaction(TRANSACTION_ID, TRANSACTION_DATE, TRANSACTION_TIME, ITEM_SOLD, QUANTITY_SOLD) VALUES ('" + transactionId + "','" + tDate + "','" + tTime + "','" + dr.Cells[0].Value + "', '" + dr.Cells[2].Value + "') ";

                dbConnect connect = new dbConnect();
                connect.Insert(insertQuery);

               
                //printArea.dgvPrintF.Rows.Add(dr.Cells[0].Value, dr.Cells[1].Value, dr.Cells[2].Value, dr.Cells[3].Value);
            }


            //printArea.txtPrintTotal.Text = this.txtGTotal.Text;
            dgvInvoice.Rows.Clear();
            txtGTotal.Text = "";
            MessageBox.Show("Transaction Completed Successfully");
            //printArea.Show();
            //this.Hide();
        }

        private void DgvEProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
