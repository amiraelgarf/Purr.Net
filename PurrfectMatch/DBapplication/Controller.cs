using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        ///AmiraBEGIN
        public string AuthenticateUser(string username, string password)
        {
            try
            {
                string storedProcedureName = "AuthenticateUserProcedure";

                // parameters
                var parameters = new Dictionary<string, object>
        {
            { "@Username", username },
            { "@Password", password }
        };

                // Execute 
                string result = Convert.ToString(dbMan.ExecuteStoredProcedure(storedProcedureName, parameters));
                return result;
            }
            catch (Exception ex)
            {
                // Handle exceptions 
                MessageBox.Show("Error authenticating user. Please try again later.");
                // Log exception 
                return null;
            }
        }

        //public DataTable SelectAllCenters()
        //{
        //    string query = "SELECT * FROM Center;";
        //    return dbMan.ExecuteReader(query);
        //}

        //public DataTable SelectAllManager()
        //{
        //    string query = " SELECT u.UserID, u.FirstName FROM [User] u, Authentication a, Manager m WHERE a.Type= 'Manager' AND m.Username = a.Username  AND u.UserID = m.ManagerID  ;";
        //    return dbMan.ExecuteReader(query);
        //}

        
        public DataTable SelectAllManager()
        {
            try
            {
                string storedProcedureName = "GetAllManagers";
                return dbMan.ExecuteStoredProcedureDataTable(storedProcedureName, new Dictionary<string, object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving all vets: {ex.Message}");
                return null;
            }
        }

        public DataTable SelectAllCenters()
        {
            try
            {
                string storedProcedureName = "GetAllCenters";
                return dbMan.ExecuteStoredProcedureDataTable(storedProcedureName, new Dictionary<string, object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving all centers: {ex.Message}");
                return null;
            }
        }

        //public DataTable SelectAllVets()
        //{
        //    string query = " SELECT u.UserID, u.FirstName FROM [User] u, Authentication a, Vet v WHERE a.Type= 'Vet' AND v.Username = a.Username  AND u.UserID = v.VetID  ;";
        //    return dbMan.ExecuteReader(query);
        //}


        public DataTable SelectAllVets()
        {
            try
            {
                string storedProcedureName = "GetAllVets";
                return dbMan.ExecuteStoredProcedureDataTable(storedProcedureName, new Dictionary<string, object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving all vets: {ex.Message}");
                return null;
            }
        }

        public int InsertCenter(string CenterName, int BuldingNumber, int streetNumber, string city, string FQA)
        {
            string query = "INSERT INTO Center (CenterName, BuildingNum, StreetNum ,City ,FAQ)" +
                            "Values ('" + CenterName + "'," + BuldingNumber + "," + streetNumber + ",'" + city + "','" + FQA + "');";
            return dbMan.ExecuteNonQuery(query);
        }




        public int DeleteCenter(int CenterID)
        {
            try
            {
                string storedProcedureName = "DeleteCenterProcedure";

                // Use parameters
                var parameters = new Dictionary<string, object>
        {
            { "@CenterID", CenterID }
        };

                // Execute procedure
                int result = dbMan.ExecuteStoredProcedureNOReturn(storedProcedureName, parameters);
                return result;


            }
            catch (Exception ex)
            {
                // Handle exceptions 
                MessageBox.Show("Error deleting center. Please try again later.");
                return 0;
            }
        }

        //public int DeleteManager(int managerID, string username)
        //{
        //    try
        //    {
        //        string storedProcedureName = "DeleteManagerProcedure";

        //        var parameters = new Dictionary<string, object>
        //{
        //    { "@ManagerID", managerID },
        //    { "@Username", username }
        //};

        //        // Execute 
        //        dbMan.ExecuteStoredProcedureNOReturn(storedProcedureName, parameters);


        //        return 1; 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error deleting manager. Please try again later.");

        //        return 0; 
        //    }
        //}


        //public int DeleteManager(int managerID, string username)
        //{
        //    string query = "DELETE FROM [User]"
        //        + " WHERE UserID = " + managerID + ";";
        //    int e = dbMan.ExecuteNonQuery(query);

        //    query = "DELETE FROM Authentication"
        //        + " WHERE Username = '" + username + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int DeleteManager(int managerID, string username)
        {
            try
            {
                string storedProcedureName = "DeleteManager";

                // Use parameters
                var parameters = new Dictionary<string, object>
        {
            { "@ManagerID", managerID },
            { "@Username", username }
        };

                // Execute procedure
                int result = dbMan.ExecuteStoredProcedureNOReturn(storedProcedureName, parameters);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting manager. Please try again later.");
                return 0;
            }
        }

        //public int DeleteVet(int VetID, string username)
        //{
        //    string query = "DELETE FROM [User]"
        //        + " WHERE UserID = " + VetID + ";";
        //    int e = dbMan.ExecuteNonQuery(query);

        //    query = "DELETE FROM Authentication"
        //        + " WHERE Username = '" + username + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public int DeleteVet(int VetID, string username)
        {
            try
            {
                string storedProcedureName = "DeleteVet";

                // Use parameters
                var parameters = new Dictionary<string, object>
        {
            { "@VetID", VetID },
            { "@Username", username }
        };

                // Execute procedure
                int result = dbMan.ExecuteStoredProcedureNOReturn(storedProcedureName, parameters);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting vet. Please try again later.");
                return 0;
            }
        }


        public int InsertAuthen(string username, string password, string type)
        {
            string query = "INSERT INTO Authentication (Username, Password, Type)" +
                            "Values ('" + username + "','" + password + "','" + type + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        public int InsertUser(int id, string fName, string lName, string DOF, string gender)
        {
            string query = "INSERT INTO [User] (UserID, FirstName, LastName, DateOfBirth, Gender)" +
                            "Values (" + id + ",'" + fName + "','" + lName + "','" + DOF + "','" + gender + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GenerateID()
        {
            string query = "SELECT MAX(UserID) FROM [User];";

            int id = Convert.ToInt32(dbMan.ExecuteScalar(query));
            return (id + 1);
        }


        public string GetManagerUsername(int ID)
        {
            string query = "SELECT Username FROM Manager "
                + "WHERE ManagerID= " + ID + ";";

            string username = Convert.ToString(dbMan.ExecuteScalar(query));
            return username;
        }

        public string GetVetUsername(int ID)
        {
            string query = "SELECT Username FROM Vet "
                + "WHERE VetID= " + ID + ";";

            string username = Convert.ToString(dbMan.ExecuteScalar(query));
            return username;
        }

        public int InsertManager(int ID, int centerID, string Username)
        {
            string query = "INSERT INTO Manager (ManagerID, CenterID, Username)" +
                            "Values (" + ID + "," + centerID + ",'" + Username + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCustromer(int ID, string Username)
        {
            string query = "INSERT INTO Customer (CustomerID, Username)" +
                            "Values (" + ID + ",'" + Username + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertVet(int vetID, int centerID, string speciality, string schedule, string username)
        {

            string query = $"INSERT INTO Vet (VetID, BuildingNum, StreetNum, City, Speciality, Schedule, CenterID, Username) " +
                           $"SELECT {vetID}, BuildingNum, StreetNum, City, '{speciality}', '{schedule}', {centerID}, '{username}' " +
                           $"FROM Center WHERE CenterID = {centerID};";

            return dbMan.ExecuteNonQuery(query);
        }

        //public DataTable AverageAppointmentsPerMonth()
        //{
        //    string query = "SELECT v.VetID, v.FirstName, v.LastName, MONTH(a.[Date]) AS Month, COUNT(*) AS AppointmentsCount " +
        //                   "FROM Vet v " +
        //                   "JOIN Appointment a ON v.VetID = a.VetID " +
        //                   "GROUP BY v.VetID, v.FirstName, v.LastName, MONTH(a.[Date]) " +
        //                   "ORDER BY v.VetID, MONTH(a.[Date]);";

        //    return dbMan.ExecuteReader(query);
        //}





        public DataTable GetAverageAppointmentsPerMonth()
        {
            try
            {
                string storedProcedureName = "GetAverageAppointmentsPerMonth";

                return dbMan.ExecuteStoredProcedureDataTable(storedProcedureName, new Dictionary<string, object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving average appointments per month: {ex.Message}");
                return null;
            }
        }

        public int ChangePassword(string username, string password)
        {
            string query = "UPDATE Authentication SET Password = '" + password + "' WHERE Username = '" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetTotalSalesPerCenter()
        {
            try
            {
                string storedProcedureName = "GetTotalSalesPerCenter";
                return dbMan.ExecuteStoredProcedureDataTable(storedProcedureName, new Dictionary<string, object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving total sales per center: {ex.Message}");
                return null;
            }
        }



        public List<string> GetLeastSellingItemsLastMonth(int numItems)
        {
            string query = "SELECT ProductID, SUM(Quantity) AS TotalQuantity FROM Purchase " +
                "WHERE PurchaseDate >= DATEADD(month, -1, GETDATE()) " +
                "GROUP BY ProductID";
            DataTable lastMonthData = dbMan.ExecuteReader(query);

            var leastSellingItems = FindLeastSellingItems(lastMonthData, numItems);

            return leastSellingItems;
        }


        private List<string> FindLeastSellingItems(DataTable data, int numItems)
        {
            var leastSellingItems = data.AsEnumerable()
                .OrderBy(row => row.Field<int>("TotalQuantity"))
                .Take(numItems)
                .Select(row => GetProductNameById(row.Field<int>("ProductID")))
                .ToList();

            return leastSellingItems;
        }

        private string GetProductNameById(int productId)
        {
            
            string query = $"SELECT [Name] FROM Product WHERE ProductID = {productId}";
            DataTable productData = dbMan.ExecuteReader(query);
            return productData?.Rows[0]?.Field<string>("Name");
        }

        public string GetBestSellingItemLastMonth()
        {
            string query = "SELECT ProductID, SUM(Quantity) AS TotalQuantity FROM Purchase " +
                "WHERE PurchaseDate >= DATEADD(month, -1, GETDATE()) " +
                "GROUP BY ProductID";
            DataTable lastMonthData = dbMan.ExecuteReader(query);

            string bestSellingItem = FindBestSellingItem(lastMonthData);

            return bestSellingItem;
        }
        private string FindBestSellingItem(DataTable data)
        {
            string bestSellingItem = data.AsEnumerable()
                .OrderByDescending(row => row.Field<int>("TotalQuantity"))
                .Select(row => GetProductNameById(row.Field<int>("ProductID")))
                .FirstOrDefault();

            return bestSellingItem;
        }

        public int GetProductQuantity(string productName)
        {
            // Fetch product quantity from the Purchase table
            DataTable productData = dbMan.ExecuteReader($"SELECT SUM(Quantity) AS TotalQuantity FROM Purchase " +
                                                            $"WHERE ProductID IN (SELECT ProductID FROM Product WHERE [Name] = '{productName}') " +
                                                            $"AND PurchaseDate >= DATEADD(month, -1, GETDATE()) " +
                                                            $"GROUP BY ProductID");

            return productData?.Rows[0]?.Field<int>("TotalQuantity") ?? 0;
        }

        public DataTable SelectAllAdoptionRequests(string username)
        {
            string query = " SELECT Pet.PetID, Pet.Name" +
            " FROM Pet " +
            "JOIN Ownership ON Pet.PetID = Ownership.PetID " +
            "JOIN Manager ON Pet.CenterID = Manager.CenterID " +
            "WHERE Manager.Username = '" + username + "' AND Ownership.Accept = 'NO';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCustomerInfoForpetadoption(int petID)
        {
            string query = "SELECT DISTINCT u.FirstName, u.LastName " +
                   "FROM [User] u " +
                   "JOIN Ownership ON u.UserID = Ownership.CustomerID " +
                   "JOIN Pet ON " + petID + " = Pet.PetID;";
            return dbMan.ExecuteReader(query);

        }

        public int AcceptAdoptionRequests(int userID, int petID)
        {
            string query = "UPDATE Ownership SET Accept = 'YES' WHERE CustomerID = " + userID + " AND PetID = " + petID + ";";
            dbMan.ExecuteNonQuery(query);

            query = "UPDATE Pet SET CenterID = NULL WHERE PetID = " + petID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeclineAdoptionRequests(int userID, int petID)
        {
            string query = "DELETE FROM Ownership WHERE CustomerID = " + userID + " AND PetID = " + petID + ";";

            return dbMan.ExecuteNonQuery(query);
        }

        public int GetCustomerIDForpetadoption(int petID)
        {
            string query = "SELECT u.UserID " +
                   "FROM [User] u " +
                   "JOIN Ownership ON u.UserID = Ownership.CustomerID " +
                   "JOIN Pet ON " + petID + " = Pet.PetID;";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }



        ///AmiraEnd





        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //TAWFIK////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int[] MyPetsID(string user)
        {
            string p = "SELECT CustomerID FROM Customer WHERE username = '" + user + "';";
            int y = Convert.ToInt32(dbMan.ExecuteScalar(p));

            string q = "SELECT PetID FROM Ownership WHERE CustomerID = " + y + " AND Accept = 'YES';";
            DataTable test = dbMan.ExecuteReader(q);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("PetID")).ToArray();
            return intArr;
        }

        public int MyPetsCount(string user)
        {
            string p = "SELECT CustomerID FROM Customer WHERE username = '" + user + "';";
            int z = Convert.ToInt32(dbMan.ExecuteScalar(p));

            string q = "SELECT COUNT(*) FROM Ownership WHERE CustomerID = " + z + " AND Accept = 'YES';";
            DataTable test = dbMan.ExecuteReader(q);


            int y = Convert.ToInt32(dbMan.ExecuteScalar(q));
            return y;
        }

        public string PetName(int id)
        {
            string q = "SELECT Name FROM Pet WHERE PetID = " + id + ";";

            return Convert.ToString(dbMan.ExecuteScalar(q));
        }

        public DataTable VetSchedule(int id)
        {
            string q = "SELECT Date FROM VetSchedule WHERE VetID = " + id + ";";

            return dbMan.ExecuteReader(q);
        }

        public string ProductName(int id)
        {
            string q = "SELECT Name FROM Product WHERE ProductID = " + id + ";";

            return Convert.ToString(dbMan.ExecuteScalar(q));
        }

        public string CenterName(int id)
        {
            string q = "SELECT CenterName FROM Center WHERE CenterID = " + id + ";";

            return Convert.ToString(dbMan.ExecuteScalar(q));
        }

        public string VetFirstName(int id)
        {
            string q = "SELECT FirstName FROM User WHERE UserID = " + id + ";";

            return Convert.ToString(dbMan.ExecuteScalar(q));
        }

        public string VetLastName(int id)
        {
            string q = "SELECT LastName FROM [User] WHERE UserID = " + id + ";";

            return Convert.ToString(dbMan.ExecuteScalar(q));
        }


        public DataTable SelectPet(int x)
        {
            string query = "SELECT * FROM Pet WHERE PetID = " + x + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCustomer(int x)
        {
            string query = "SELECT * FROM Customer WHERE CustomerID = " + x + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectUser(int x)
        {
            string query = "SELECT * FROM [User] WHERE UserID = " + x + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAuth(string x)
        {
            string query = "SELECT * FROM Authentication WHERE username = '" + x + "';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdatePassword(string user, string pass)
        {
            string q = "UPDATE Authentication SET Password = '" + pass + "' WHERE Username = '" + user + "';";
            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdateDateOfBirth(int user, DateTime date)
        {
            string q = "UPDATE [User] SET DateOfBirth = '" + date.ToString("yyyy-MM-dd") + "' WHERE UserID = " + user + ";";
            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdateName(int user, string fname, string lname)
        {
            string q = "UPDATE [User] SET FirstName = '" + fname + "', LastName = '" + lname + "' WHERE UserID = " + user + ";";
            return dbMan.ExecuteNonQuery(q);
        }


        public int SetAppointment(int user, int vetid, DateTime d, int center, int petid)
        {
            string q = "INSERT INTO Appointment(Date, VetID, PetID, CustomerID, CenterID) VALUES ('" + d.ToString("yyyy-MM-dd") + "', " + vetid + ", " + petid + ", " + user + ", " + center + ");";
            return dbMan.ExecuteNonQuery(q);
        }

        public DataTable SelectProduct(int x)
        {
            string query = "SELECT * FROM Product WHERE ProductID = " + x + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCenter(int x)
        {
            string query = "SELECT * FROM Center WHERE CenterID = " + x + ";";
            return dbMan.ExecuteReader(query);
        }

        public int GetCenterPetsCount(int x)
        {
            string q = "SELECT COUNT(*) FROM Pet WHERE CenterID = " + x + ";";
            return Convert.ToInt32(dbMan.ExecuteScalar(q));
        }

        public DataTable SelectVet(int x)
        {
            string query = "SELECT * FROM Vet WHERE VetID = " + x + ";";
            return dbMan.ExecuteReader(query);
        }

        public int GetCustomerID(string username)
        {
            string q = "SELECT CustomerID FROM Customer WHERE Username = '" + username + "';";
            return Convert.ToInt32(dbMan.ExecuteScalar(q));
        }

        public int GetStock(int id)
        {
            string q = "SELECT Stock FROM Product WHERE ProductID = '" + id + "';";
            return Convert.ToInt32(dbMan.ExecuteScalar(q));
        }
        public int GetVetCenter(int id)
        {
            string q = "SELECT CenterID FROM Vet WHERE VetID = '" + id + "';";
            return Convert.ToInt32(dbMan.ExecuteScalar(q));
        }
        public int Purchase(string username, int ProductID, int quantity)
        {
            string p = "UPDATE Product SET Stock = " + (GetStock(ProductID) - quantity) + " WHERE ProductID = " + ProductID + ";";
            dbMan.ExecuteNonQuery(p);
            string q = "INSERT INTO Purchase(CustomerID, ProductID, Quantity, PurchaseDate) VALUES (" + GetCustomerID(username) + ", " + ProductID + ", " + quantity + ", getdate());";
            return dbMan.ExecuteNonQuery(q);
        }
        public string getType(int x)
        {
            string q = "SELECT TypeName FROM Type WHERE TypeID = " + x + ";";
            return Convert.ToString(dbMan.ExecuteScalar(q));
        }


        public string[] TypeNames()
        {
            string query = "SELECT TypeName FROM Type;";
            DataTable test = dbMan.ExecuteReader(query);

            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("TypeName")).ToArray();
            return stringArr;
        }

        public string[] SpecialitiesNames()
        {
            string query = "SELECT Speciality FROM Vet;";
            DataTable test = dbMan.ExecuteReader(query);

            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("Speciality")).ToArray();
            return stringArr;
        }

        public string[] CityNames()
        {
            string query = "SELECT City FROM Center;";
            DataTable test = dbMan.ExecuteReader(query);

            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("City")).ToArray();
            return stringArr;
        }


        public string[] CenterNames()
        {
            string query = "SELECT * FROM Center;";
            DataTable test = dbMan.ExecuteReader(query);

            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("CenterName")).ToArray();
            return stringArr;
        }


        public string[] PetNameSearch(string x)
        {
            string q = "SELECT Name FROM Pet WHERE Name LIKE '" + x + "%' AND CenterID IS NOT NULL;";

            DataTable test = dbMan.ExecuteReader(q);


            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            return stringArr;
        }


        public int[] VetIDsSearch(string x)
        {
            string q = "SELECT u.UserID FROM [User] u, Authentication a, Vet v WHERE u.LastName LIKE '" + x + "%' AND v.CenterID IS NOT NULL AND a.Type = 'Vet' AND a.username = v.username AND v.VetID = u.UserID;";

            DataTable test = dbMan.ExecuteReader(q);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("UserID")).ToArray();
            return intArr;
        }

        public int[] CenterIDsSearch(string x)
        {
            string q = "SELECT CenterID FROM Center WHERE CenterName LIKE '" + x + "%';";

            DataTable test = dbMan.ExecuteReader(q);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("CenterID")).ToArray();
            return intArr;
        }

        public int VetNumberSearch(string x)
        {
            string q = "SELECT COUNT(*) FROM [User] u, Authentication a, Vet v WHERE u.LastName LIKE '" + x + "%' AND v.CenterID IS NOT NULL AND a.Type = 'Vet' AND a.username = v.username AND v.VetID = u.UserID;";


            int y = Convert.ToInt32(dbMan.ExecuteScalar(q));
            return y;
        }
        public int CenterNumberSearch(string x)
        {
            string q = "SELECT COUNT(*) FROM Center WHERE CenterName LIKE '" + x + "%';";

            int y = Convert.ToInt32(dbMan.ExecuteScalar(q));
            return y;
        }


        public int[] PetIDsSearch(string x)
        {
            string q = "SELECT PetID FROM Pet WHERE Name LIKE '" + x + "%' AND CenterID IS NOT NULL;";

            DataTable test = dbMan.ExecuteReader(q);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("PetID")).ToArray();
            return intArr;
        }

        public int[] ProductIDsSearch(string x)
        {
            string q = "SELECT ProductID FROM Product WHERE Name LIKE '" + x + "%' AND CenterID IS NOT NULL;";

            DataTable test = dbMan.ExecuteReader(q);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("ProductID")).ToArray();
            return intArr;
        }

        public int PetNumberSearch(string x)
        {
            string q = "SELECT Count(*) FROM Pet WHERE Name LIKE '" + x + "%' AND CenterID IS NOT NULL;";

            int y = Convert.ToInt16(dbMan.ExecuteScalar(q));
            return y;
        }

        public int ProductNumberSearch(string x)
        {
            string q = "SELECT Count(*) FROM Product WHERE Name LIKE '" + x + "%' AND CenterID IS NOT NULL;";

            int y = Convert.ToInt16(dbMan.ExecuteScalar(q));
            return y;
        }

        public int VetNumberFiltered(List<string> spec, List<int> center)
        {
            string query = "SELECT COUNT(*) FROM Vet v";
            if (center.Count != 0)
            {
                query += ", Center c";
            }
            query += " WHERE ";

            if (spec.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < spec.Count)
            {

                query += ("v.Speciality = '" + spec[x] + "'");
                if (x < (spec.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 0;
            while (x < center.Count)
            {
                if (spec.Count != 0 && x == 0)
                {
                    query += ") AND (";
                }
                query += ("(c.CenterID = '" + center[x] + "' AND c.CenterID = v.CenterID) ");
                if (x < (center.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (spec.Count != 0)
            {
                query += ")";
            }

            if (spec.Count > 0 || center.Count > 0)
            {
                query += " AND ";
            }
            query += " v.CenterID IS NOT NULL;";

            int y = Convert.ToInt16(dbMan.ExecuteScalar(query));
            return y;
        }

        public int CenterNumberFiltered(List<string> city)
        {
            string query = "SELECT COUNT(*) FROM Center ";


            int x = 0;
            while (x < city.Count)
            {
                if (x == 0)
                {
                    query += "WHERE ";
                }

                query += ("City = '" + city[x] + "'");
                if (x < (city.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            query += ";";

            int y = Convert.ToInt16(dbMan.ExecuteScalar(query));
            return y;
        }

        public int[] CenterIDsFiltered(List<string> city)
        {
            string query = "SELECT CenterID FROM Center ";


            int x = 0;
            while (x < city.Count)
            {
                if (x == 0)
                {
                    query += "WHERE ";
                }
                query += ("City = '" + city[x] + "'");
                if (x < (city.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            query += ";";

            DataTable test = dbMan.ExecuteReader(query);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("CenterID")).ToArray();
            return intArr;
        }

        public int[] VetIDsFiltered(List<string> spec, List<int> center)
        {
            string query = "SELECT v.VetID FROM Vet v";
            if (center.Count != 0)
            {
                query += ", Center c";
            }
            query += " WHERE ";

            if (spec.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < spec.Count)
            {

                query += ("v.Speciality = '" + spec[x] + "'");
                if (x < (spec.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 0;
            while (x < center.Count)
            {
                if (spec.Count != 0 && x == 0)
                {
                    query += ") AND (";
                }
                query += ("(c.CenterID = '" + center[x] + "' AND c.CenterID = v.CenterID) ");
                if (x < (center.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (spec.Count != 0)
            {
                query += ")";
            }

            if (spec.Count > 0 || center.Count > 0)
            {
                query += " AND ";
            }
            query += " v.CenterID IS NOT NULL;";

            DataTable test = dbMan.ExecuteReader(query);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("VetID")).ToArray();
            return intArr;
        }


        public int[] PetIDsFiltered(List<string> type, List<string> gender, List<int> age)
        {
            string query = "SELECT PetID FROM Pet p";
            if (type.Count != 0)
            {
                query += ", Type t";
            }
            query += " WHERE ";
            if (type.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < type.Count)
            {

                query += ("(t.TypeName = '" + type[x] + "' AND t.TypeID = p.TypeID)");
                if (x < (type.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 0;
            while (x < gender.Count)
            {
                if (type.Count != 0 && x == 0)
                {
                    query += ") AND (";
                }
                if (age.Count > 1)
                {
                    query += "(";
                }
                query += ("(p.Gender = '" + gender[x] + "') ");
                if (x < (gender.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }
            x = 1;
            while (x < age.Count)
            {
                if ((gender.Count != 0 || type.Count != 0) && x == 1)
                {
                    query += ") AND (";
                }
                query += ("(p.AgeInMonths <= " + age[x] + " AND p.AgeInMonths > " + age[x - 1] + ") ");
                if (x < (age.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (gender.Count != 0 && age.Count > 1)
            {
                query += ")";
            }

            if (type.Count != 0)
            {
                query += ")";
            }

            if (type.Count > 0 || gender.Count > 0 || age.Count > 1)
            {
                query += " AND ";
            }
            query += " CenterID IS NOT NULL;";



            DataTable test = dbMan.ExecuteReader(query);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("PetID")).ToArray();
            return intArr;
        }
        public string[] PetNamesFiltered(List<string> type, List<string> gender, List<int> age)
        {
            string query = "SELECT Name FROM Pet p";
            if (type.Count != 0)
            {
                query += ", Type t";
            }
            query += " WHERE ";
            if (type.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < type.Count)
            {

                query += ("(t.TypeName = '" + type[x] + "' AND t.TypeID = p.TypeID)");
                if (x < (type.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 0;
            while (x < gender.Count)
            {
                if (type.Count != 0 && x == 0)
                {
                    query += ") AND (";
                }
                if (age.Count > 1)
                {
                    query += "(";
                }
                query += ("(p.Gender = '" + gender[x] + "') ");
                if (x < (gender.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }
            x = 1;
            while (x < age.Count)
            {
                if ((gender.Count != 0 || type.Count != 0) && x == 1)
                {
                    query += ") AND (";
                }
                query += ("(p.AgeInMonths <= " + age[x] + " AND p.AgeInMonths > " + age[x - 1] + ") ");
                if (x < (age.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (gender.Count != 0 && age.Count > 1)
            {
                query += ")";
            }

            if (type.Count != 0)
            {
                query += ")";
            }

            if (type.Count > 0 || gender.Count > 0 || age.Count > 1)
            {
                query += " AND ";
            }
            query += " CenterID IS NOT NULL;";



            DataTable test = dbMan.ExecuteReader(query);


            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            return stringArr;
        }

        public int pets_number_filtered(List<string> type, List<string> gender, List<int> age)
        {
            string query = "SELECT COUNT(*) FROM Pet p";
            if (type.Count != 0)
            {
                query += ", Type t";
            }

            query += " WHERE ";

            if (type.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < type.Count)
            {

                query += ("(t.TypeName = '" + type[x] + "' AND t.TypeID = p.TypeID)");
                if (x < (type.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 0;
            while (x < gender.Count)
            {
                if (type.Count != 0 && x == 0)
                {
                    query += ") AND (";
                }
                if (age.Count > 1)
                {
                    query += "(";
                }
                query += ("(p.Gender = '" + gender[x] + "') ");
                if (x < (gender.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }
            x = 1;
            while (x < age.Count)
            {
                if ((gender.Count != 0 || type.Count != 0) && x == 1)
                {
                    query += ") AND (";
                }
                query += ("(p.AgeInMonths <= " + age[x] + " AND p.AgeInMonths > " + age[x - 1] + ") ");
                if (x < (age.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (gender.Count != 0 && age.Count > 1)
            {
                query += ")";
            }

            if (type.Count != 0)
            {
                query += ")";
            }

            if (type.Count > 0 || gender.Count > 0 || age.Count > 1)
            {
                query += " AND ";
            }
            query += " CenterID IS NOT NULL;";

            int y = Convert.ToInt16(dbMan.ExecuteScalar(query));
            return y;
        }


        public int ProductsNumberFiltered(List<string> type, List<int> price)
        {
            string query = "SELECT COUNT(*) FROM Product p";
            if (type.Count != 0)
            {
                query += ", Type t";
            }

            query += " WHERE ";

            if (type.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < type.Count)
            {

                query += ("(t.TypeName = '" + type[x] + "' AND t.TypeID = p.ForTypeID)");
                if (x < (type.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 1;
            while (x < price.Count)
            {
                if ((type.Count != 0) && x == 1)
                {
                    query += ") AND (";
                }
                query += ("(p.Cost <= " + price[x] + " AND p.Cost > " + price[x - 1] + ") ");
                if (x < (price.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (type.Count != 0)
            {
                query += ")";
            }

            if (type.Count > 0 || price.Count > 1)
            {
                query += " AND ";
            }
            query += " CenterID IS NOT NULL AND p.Stock > 0;";

            int y = Convert.ToInt16(dbMan.ExecuteScalar(query));
            return y;
        }


        public int[] ProductIDsFiltered(List<string> type, List<int> price)
        {
            string query = "SELECT ProductID FROM Product p";
            if (type.Count != 0)
            {
                query += ", Type t";
            }

            query += " WHERE ";

            if (type.Count != 0)
            {
                query += "(";
            }
            int x = 0;
            while (x < type.Count)
            {

                query += ("(t.TypeName = '" + type[x] + "' AND t.TypeID = p.ForTypeID)");
                if (x < (type.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            x = 1;
            while (x < price.Count)
            {
                if ((type.Count != 0) && x == 1)
                {
                    query += ") AND (";
                }
                query += ("(p.Cost <= " + price[x] + " AND p.Cost > " + price[x - 1] + ") ");
                if (x < (price.Count - 1))
                {
                    query += "OR ";
                }
                x++;
            }

            if (type.Count != 0)
            {
                query += ")";
            }

            if (type.Count > 0 || price.Count > 1)
            {
                query += " AND ";
            }
            query += " CenterID IS NOT NULL AND p.Stock > 0;";

            DataTable test = dbMan.ExecuteReader(query);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("ProductID")).ToArray();
            return intArr;
        }

        public int Adopt(string username, int petid)
        {
            int user = Convert.ToInt16(dbMan.ExecuteScalar("SELECT CustomerID FROM Customer WHERE username = '" + username + "';"));
            string q = "INSERT INTO Ownership (CustomerID, PetID) VALUES (" + user + ", " + petid + ");";
            return dbMan.ExecuteNonQuery(q);
        }

        public int PetNumber()
        {
            string q = "SELECT COUNT(*) FROM Pet;";
            int x = Convert.ToInt16(dbMan.ExecuteScalar(q));
            return x;
        }

        public int RemoveOwnership(int id)
        {
            string q = "DELETE FROM Ownership WHERE PetID = " + id + ";";
            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdatePetCenter(int id, int centerid)
        {
            string q = "UPDATE Pet SET CenterID = " + centerid + " WHERE PetID = " + id + ";";
            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdatePetName(int id, string name)
        {
            string q = "UPDATE Pet SET Name = '" + name + "' WHERE PetID = " + id + ";";
            return dbMan.ExecuteNonQuery(q);
        }


        public int DeleteUser(int id)
        {
            string q = "DELETE FROM [User] WHERE UserID = " + id + ";";
            return dbMan.ExecuteNonQuery(q);
        }
        public int DeleteAuth(string name)
        {
            string q = "DELETE FROM Authentication WHERE Username = '" + name + "';";
            return dbMan.ExecuteNonQuery(q);
        }

        public int VetAverageRating(int id)
        {
            string q = "SELECT AVG(Score) FROM VetRating WHERE VetID = " + id + ";";
            int x = Convert.ToInt32(dbMan.ExecuteScalar(q));
            return x;
        }


        public DataTable GetVetData(int id)
        {
            try
            {
                string storedProcedureName = "GetVetInformation";

                // Use parameters
                var parameters = new Dictionary<string, object>
        {
            { "@VetID", id }
        };

                // Execute procedure
                DataTable result = dbMan.ExecuteStoredProcedureDataTable(storedProcedureName, parameters);
                return result;


            }
            catch (Exception ex)
            {
                // Handle exceptions 
                MessageBox.Show("Error deleting center. Please try again later.");
                return null;
            }
        }



        public int[] PetBestForIDs(string x)
        {
            string q = "SELECT PetID FROM Pet WHERE BestFor = '" + x + "';";


            DataTable test = dbMan.ExecuteReader(q);

            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("PetID")).ToArray();
            return intArr;
        }

        public int PetBestForNumber(string x)
        {
            string q = "SELECT Count(*) FROM Pet WHERE BestFor = '" + x + "';";


            int y = Convert.ToInt16(dbMan.ExecuteScalar(q));
            return y;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //TAWFIK DONE///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public DataTable SelectSchedule(int vetID)
        {
            string query = "SELECT A.[Date], A.[Time], P.Name, U.FirstName " +
                "FROM [dbo].[Appointment] A " +
                "INNER JOIN [dbo].[Pet] P ON A.PetID = P.PetID " +
                "INNER JOIN [dbo].[User] U ON A.CustomerID = U.UserID " +
                "WHERE A.VetID =" + vetID + ";";

            return dbMan.ExecuteReader(query);
        }
        public int GetVetID(string username)
        {
            string query = "SELECT VetID FROM Vet WHERE Username='" + username + "';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable AvgRatings(int vetID)
        {
            string query = "SELECT AVG(CAST(Score AS DECIMAL(10, 2))) AS AverageRatings " +
                            "FROM[dbo].[VetRating] " +
                             "WHERE VetID =" + vetID +
                             "GROUP BY VetID ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable insertverylow(int customerID, string pers)
        {
            string query = "UPDATE Customer " +
                        "SET " + pers + " = 15 " +
                        "WHERE CustomerID = " + customerID + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable insertlow(int customerID, string pers)
        {
            string query = "UPDATE Customer " +
                        "SET " + pers + " = 35 " +
                        "WHERE CustomerID = " + customerID + ";";
            return dbMan.ExecuteReader(query);
        }

      public DataTable insertmedium(int customerID, string pers)
{
    string query = "UPDATE Customer " +
                "SET " + pers + "= 50 " +
                "WHERE CustomerID = " + customerID + ";";
    return dbMan.ExecuteReader(query);
}

        public DataTable inserthigh(int customerID, string pers)
        {
            string query = "UPDATE Customer " +
                        "SET " + pers + " = 75 " +
                        "WHERE CustomerID = " + customerID + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable insertveryhigh(int customerID, string pers)
        {
            string query = "UPDATE Customer " +
                        "SET " + pers + " = 90 " +
                        "WHERE CustomerID = " + customerID + ";";
            return dbMan.ExecuteReader(query);
        }

        public Dictionary<string, double> GetAdoptionPercentageByType()
        {
            string query = "SELECT TypeName, " +
                           "(COUNT(Pet.PetID) * 100.0 / " +
                           "(SELECT COUNT(*) FROM Pet WHERE CenterID IS NULL)) AS AdoptionPercentage " +
                           "FROM Pet " +
                           "INNER JOIN Type ON Pet.TypeID = Type.TypeID " +
                           "WHERE CenterID IS NULL " +
                           "GROUP BY TypeName;";

            DataTable result = dbMan.ExecuteReader(query);
            Dictionary<string, double> adoptionPercentages = new Dictionary<string, double>();
            foreach (DataRow row in result.Rows)
            {
                adoptionPercentages[row["TypeName"].ToString()] = Convert.ToDouble(row["AdoptionPercentage"]);
            }

            return adoptionPercentages;
        }

        public int GetTypeID(string typeName)
        {
            string q = "SELECT TypeID FROM Type WHERE TypeName = '" + typeName + "'";
            object result = dbMan.ExecuteScalar(q);
            return result != null ? Convert.ToInt32(result) : -1; // Assuming -1 as an invalid ID
        }

        public int GetCenterID(string centerName)
        {
            string q = "SELECT CenterID FROM Center WHERE CenterName = '" + centerName + "'";
            object result = dbMan.ExecuteScalar(q);
            return result != null ? Convert.ToInt32(result) : -1; // Assuming -1 as an invalid ID
        }

        public string[] PetNames()
        {
            string query = "SELECT Name FROM Pet;";
            DataTable test = dbMan.ExecuteReader(query);

            var stringArr = test.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            return stringArr;
        }

        public int[] PetIDs()
        {
            string q = "SELECT PetID FROM Pet;";
            DataTable test = dbMan.ExecuteReader(q);


            int[] intArr = test.AsEnumerable().Select(row => row.Field<int>("PetID")).ToArray();
            return intArr;
        }

        public DataTable SelectAllTypes()
        {
            string query = "SELECT * FROM Type;";
            return dbMan.ExecuteReader(query);
        }

        public int UpdatePet(int PetID, string Name, string Gender, string Breed, int TypeID, string BestFor, string History, int CenterID)
        {
            string query = "UPDATE Pet " +
                           "SET Name = '" + Name + "', Gender = '" + Gender + "', Breed = '" + Breed + "', TypeID = " + TypeID +
                           ", CenterID = " + CenterID +
                           ", BestFor = '" + BestFor + "', History = '" + History + "' " +
                           "WHERE PetID = " + PetID;

            return dbMan.ExecuteNonQuery(query);
        }

        public int DeletePet(int PetID)
        {
            string query = "DELETE FROM Pet"
                + " WHERE PetID = " + PetID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateAge(int PetID, DateTime DateOfBirth)
        {
            string query = "UPDATE Pet " +
                           "SET DateOfBirth = '" + DateOfBirth.ToString("yyyy-MM-dd") +
                           "' WHERE PetID = " + PetID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPet(string Name, string Gender, string Breed, string Type, DateTime DateOfBirth, string BestFor, string History, string Center)
        {
            int typeID = GetTypeID(Type);
            int centerID = GetCenterID(Center);

            string query = "INSERT INTO Pet (Name, Gender, Breed, TypeID, DateOfBirth, CenterID, BestFor, History) " +
                           "VALUES ('" + Name + "', '" + Gender + "', '" + Breed + "', " + typeID +
                           ", '" + DateOfBirth.ToString("yyyy-MM-dd") + "', " + centerID + ", '" + BestFor + "', '" + History + "')";
            return dbMan.ExecuteNonQuery(query);
        }



        public int InsertProduct(string Name, string Description, int Stock, DateTime ProductionDate, DateTime ExpirationDate, decimal Price, string Center, string Type)
        {
            int typeID = GetTypeID(Type);
            int centerID = GetCenterID(Center);

            string query = "INSERT INTO Product (Name, Description, Stock, ProductionDate, ExpirationDate, Cost, CenterID, ForTypeID) " +
                           "VALUES ('" + Name + "', '" + Description + "', " + Stock + ", '" + ProductionDate.ToString("yyyy-MM-dd") + "', '" +
                           ExpirationDate.ToString("yyyy-MM-dd") + "', " + Price.ToString("0.00") + ", " + centerID + ", " + typeID + ")";

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateProduct(int ProductID, string Name, string Description, int Stock, decimal Cost, int CenterID, int ForTypeID)
        {

            string query = "UPDATE Product " +
                           "SET Name = '" + Name + "', Description = '" + Description + "', Stock = " + Stock + ", Cost = " + Cost +
                           ", CenterID = " + CenterID + ", ForTypeID = " + ForTypeID +
                           " WHERE ProductID = " + ProductID;

            return dbMan.ExecuteNonQuery(query);
        }



        public int DeleteProduct(int ProductID)
        {
            string query = "DELETE FROM Product WHERE ProductID = " + ProductID;
            return dbMan.ExecuteNonQuery(query);
        }



        public int InsertType(string TypeName)
        {
            string query = "INSERT INTO Type (TypeName) " +
                           "VALUES ( '" + TypeName + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public string FirstName(string username)
        {
            string query = "SELECT FirstName FROM [User]  U, Customer C WHERE C.Username = '" + username + "' AND C.CustomerID = U.UserID;";
            string result = Convert.ToString(dbMan.ExecuteScalar(query));
            return result;

        }

        public string LastName(string username)
        {
            string query = "SELECT LastName FROM [User]  U, Customer C WHERE C.Username = '" + username + "' AND C.CustomerID = U.UserID;";
            string result = Convert.ToString(dbMan.ExecuteScalar(query));
            return result;

        }






        public int getcustomerenergy(int custid)
        {
            string query = "SELECT Energy FROM Customer "
                    + "WHERE CustomerID= " + custid + ";";

           return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int getcustomermind(int custid)
        {
            string query = "SELECT Mind FROM Customer "
                    + "WHERE CustomerID= " + custid + ";";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int getcustomernature(int custid)
        {
            string query = "SELECT Nature FROM Customer "
                     + "WHERE CustomerID= " + custid + ";";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int getcustomeridentity(int custid)
 {
     string query = "SELECT Identityy FROM Customer "
             + "WHERE CustomerID= " + custid + ";";

     return Convert.ToInt32(dbMan.ExecuteScalar(query));
 }

        public string returnPersonality(int custid)
        {
            int e = getcustomerenergy(custid);
            int m = getcustomermind(custid);
            int n = getcustomernature(custid);
            int i = getcustomeridentity(custid);
            if (e> 50 && n > 50 && m > 50 && i > 50) //1
            {
                return "ENFP";
            }
            else if (e> 50 && m> 50 && n > 50 && i <= 50) //2
            {
                return "ENFJ";
             }
            else if (e> 50 && m> 50 && n <= 50 && i> 50) //3
            {
                return "ENTP";
            }
            else if (e > 50 && m > 50 && n <= 50 && i <= 50) //4
            {
                return "ENTJ";
            }
            else if (e > 50 && m <= 50 && n > 50 && i > 50) // 5
            {
                return "ESFP";
            }
            else if (e > 50 && m <= 50 && n > 50 && i <= 50) //6
            {
                return "ESFJ";
            }
            else if (e > 50 && m <= 50 && n <= 50 && i > 50) //7
            {
                return "ESTP";
            }
            else if (e > 50 && m <= 50 && n <= 50 && i <= 50) //8
            {
                return "ESTJ";
            }
            else if (e <= 50 && n > 50 && m > 50 && i > 50) //9
            {
                return "INFP";
            }
            else if (e <= 50 && m > 50 && n > 50 && i <= 50) //10
            {
                return "INFJ";
            }
            else if (e <= 50 && m > 50 && n <= 50 && i > 50) //11
            {
                return "INTP";
            }
            else if (e <= 50 && m > 50 && n <= 50 && i <= 50) //12
            {
                return "INTJ";
            }
            else if (e <= 50 && m <= 50 && n > 50 && i > 50) // 13
            {
                return "ISFP";
            }
            else if (e <= 50 && m <= 50 && n > 50 && i <= 50) //14
            {
                return "ISFJ";
            }
            else if (e <= 50 && m <= 50 && n <= 50 && i > 50) //15
            {
                return "ISTP";
            }
            else if (e <= 50 && m <= 50 && n <= 50 && i <= 50) //16
            {
                return "ISTJ";
            }
            else
            {
                return "INFJ";
            }
        }

        public int getyourpurrfectmatch( string pers)
        {
            string query = "SELECT PetID FROM Pet WHERE BestFor =" + pers + ";";
            return dbMan.ExecuteNonQuery(query);
        }


       

        public int FliterPetByBestFor(string x)
{
    string q = "SELECT Count(*) FROM Pet WHERE BestFor LIKE '" + x + "%' AND CenterID IS NOT NULL;";

    int y = Convert.ToInt16(dbMan.ExecuteScalar(q));
    return y;
}


        public DataTable SelectAvailableDates(int vetID)
        {
            string query = "SELECT Datee FROM VetSchedule WHERE VetID= " + vetID +  ";";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteAvailableDate(int VetID, string datee)
        {
            string query = "DELETE FROM [VetSchedule]"
                + " WHERE VetID = " + VetID + "AND Datee = '"+datee+"';";
          return dbMan.ExecuteNonQuery(query);

        }

        public int InsertAvailableDate(int vetid, string date)
        {
            string query = "INSERT INTO [VetSchedule] (VetID, Datee)" +
                            "Values (" + vetid + ",'" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }



    }
    



}
