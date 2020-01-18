using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME TO BENJIRO SUPERMARKET";
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUsername.Text;
            String password = txtPassword.Text;
            String userType = cmbUserType.Text;

           try
           {
               dbConnect connect = new dbConnect();
           String result = connect.Login(userName, password, userType);

               if (result == "Admin")
               {

                    mainPage main_page = new mainPage();
                    main_page.Show();
                   this.Hide();
                   
               }
               else if (result == "Employee")
               {

                    EmployeePage Employee_Page = new EmployeePage();
                    Employee_Page.Show();
                   this.Hide();
                   
               }
               else
               {
                   MessageBox.Show("Invalid Cridentials");
               }
           }
           catch (Exception error)
           {
               
               MessageBox.Show(error.Message);
           }
        }

        
    }
}
