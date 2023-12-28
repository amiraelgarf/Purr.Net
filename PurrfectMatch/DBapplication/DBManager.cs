using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class DBManager
    {
        static string DB_Connection_String = @"Data Source=DANAH\SQLEXPRESS01;Initial Catalog=PurrfectMatch;Integrated Security=True";
        SqlConnection myConnection;
        static bool check=false;
        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open();
                if (!check)
                {
                    MessageBox.Show("The DB connection is opened successfully");
                    check = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The DB connection is failed");
                //MessageBox.Show(e.ToString());
            }
        }

        //no return value
        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public object ExecuteStoredProcedure(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in parameters)
                    {
                        myCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    return myCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int ExecuteStoredProcedureNOReturn(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in parameters)
                    {
                        myCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    
                    return myCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteStoredProcedureDataTable(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in parameters)
                    {
                        myCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    
                    SqlDataReader reader = myCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();
                        return dt;
                    }
                    else
                    {
                        reader.Close();
                        return new DataTable(); 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
;