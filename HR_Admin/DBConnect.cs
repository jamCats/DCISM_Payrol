using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HR_Admin
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "DCISM_Payrol";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);           
        }
        //CREATE USER
        public void CreateUser(String query1,String query2)
        {
            OpenConnection();
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            CloseConnection();
        }
        public void UpdateUser(String query1,String query2)
        {
            OpenConnection();
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            CloseConnection();
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

       

        //Delete statement
        public void Delete()
        {
        }


        //read
        public List<VM_User> Select(String sqlQuery)
        {
            string query = sqlQuery;

            var list = new List<VM_User>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(new VM_User
                    {
                        Email = dataReader["Email"].ToString(),
                        Password = dataReader["Description"].ToString(),
                        Status = dataReader["Status"].ToString()
                    });
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed                
                return list;
            }
            else
            {
                return list;
            }
        }
        public void getItem(Transucc1 x,String query)
        {
            if (this.OpenConnection() == true){
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows) {
                    if ((int)dataReader["product_qty"]>0) {
                        x.ID = Convert.ToInt32(dataReader["ID"]);
                        x.itemName = dataReader["product_name"].ToString();
                        x.qty = Convert.ToInt32(dataReader["product_qty"]);
                        x.price = Convert.ToDouble(dataReader["product_price"]);
                        x.barCode = Convert.ToInt32(dataReader["bar_code"]);
                        dataReader.Close();
                    }
                }
                this.connection.Close();
            }
        }
        public void getTransID(String query,out int ID)
        {
            ID = -1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    ID = Convert.ToInt32(dataReader["transactionID"]);
                }
                else
                {
                    MessageBox.Show("transaction error");
                }
            }
            this.CloseConnection();
        }

        public void getInv(List<Transucc1>x,String query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Transucc1 local = new Transucc1();
                    while (dataReader.Read())
                    {
                        x.Add(new Transucc1
                        {
                            ID = Convert.ToInt32(dataReader["ID"]),
                            itemName=dataReader["product_name"].ToString(),
                            prodDesc=dataReader["product_description"].ToString(),
                            qty=Convert.ToInt32(dataReader["product_qty"]),
                            price=Convert.ToDouble(dataReader["product_price"]),
                            category=Convert.ToInt32(dataReader["category_id"]),
                            barCode=Convert.ToInt32(dataReader["bar_code"]),
                            sales=Convert.ToInt32(dataReader["sales"])
                        });
                    }
                    dataReader.Close();
                    this.CloseConnection();
            }

        }
        

        public String checkUser(String sqlQuery)
        {                        
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                String password = dataReader["Password"].ToString();
                String status = dataReader["Status"].ToString();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed   
                if (status == "inactive")
                {
                    return "";
                }
                else
                {
                    return password;
                }
            }
            else
            {
                return null;
            }
        }
        public void transaction(List<Transucc1>x,String prodId,int qty,Transucc1 item)
        {
            if (this.OpenConnection() == true)
            {
                String sqlMod = "UPDATE product SET product_qty=product_qty-'" + qty + "'WHERE bar_code='"+item.barCode+"'";
                //Check if stocks are enough
                    MySqlCommand cmd1 = new MySqlCommand(sqlMod, connection);//modify db product quantity
                    cmd1.ExecuteNonQuery();
                    x.Add(item);    //ITEM GETS ADDED TO THE LIST
                    this.CloseConnection();
            }

        }
        //Update statement
        public bool Update(String sqlQuery)
        {

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                //Create a data reader and Execute the command
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

                //return list to be displayed                
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertLog(String sqlQuery)
        {

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                //Create a data reader and Execute the command
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

                //return list to be displayed                
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
