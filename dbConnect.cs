using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    class dbConnect
    {
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private string server;
        private string database;
        private string uid;
        private string password;

        DataTable dt = new DataTable();
        MySqlDataAdapter ad = new MySqlDataAdapter();
        BindingSource bs = new BindingSource();

        //Constructor
        public dbConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "group_five";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
    
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Select Statement
        public object Select(String query)
        {
            
                this.OpenConnection();
                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);

                ad.SelectCommand = cmd;
                ad.Fill(dt);
                bs.DataSource = dt;
               
                //close connection
                this.CloseConnection();

                return bs.DataSource;
            
            
        }

        //Insert statement
        public void Insert(string query)
        {
            

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Update statement
        public void Update(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public String Login(String userName, String Password, String userType)
        {
            String confirmUserType = "";
            //open connection
            if (this.OpenConnection() == true)
            {
                String query = "SELECT * FROM employee WHERE STAFF_ID ='" + userName + "' AND USER_PASSWORD ='" + Password + "' AND USER_TYPE ='" + userType + "' ";

                //create command and assign the query and connection from the constructor
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                reader = cmd.ExecuteReader();

                //check for correct credentials
                int counter = 0;
                while (reader.Read())
                {
                    counter = 1;
                }

                if (counter == 1)
                {
                    if(userType == "Admin")
                    {
                        confirmUserType = "Admin";
                    }
                    else if(userType == "Employee")
                    {
                        confirmUserType = "Employee";
                    }
                }
                else
                { 
                    confirmUserType = "Invalid Credentials"; 
                }
                //close connection
                this.CloseConnection();
            }

            return confirmUserType;
        }
    }
}
