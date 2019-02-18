using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.Configuration;

namespace Inventory.DataAccessLayer
{
    class UserDataAccess
    {
        #region "Get Procedures"

        public static string GetUserName(int employeeId)
        {
            var user = string.Empty;

            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    using (var cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT EmployeeName FROM dbo.Employees WHERE EmployeeID = @EmployeeID";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100)).Value = employeeId;

                        var rowId = cmd.ExecuteScalar();
                        user = (string)rowId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return user;
        }

        #endregion

        #region "User Verification"

        public static int VerifyCredentials(string username, string password)
        {
            var id = 0;

            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    using (var cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT EmployeeID FROM dbo.Employees WHERE Username = @Username And Password = @Password";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 255)).Value = username;
                        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 255)).Value = password;

                        var userId = cmd.ExecuteScalar();

                        if (userId == null)
                        {
                            id = 0;
                        }
                        else
                        {
                            id = (Int32)userId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id; // Return the ID            
        }

        public static void LogIn()
        {
            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    con.Open();

                    if (IsStationExist())
                    {
                        using (var cmdUpdate = new SqlCommand())
                        {
                            cmdUpdate.CommandText = "UPDATE dbo.LogStatus Set LogStatusID = @LogStatusID WHERE (EmployeeID = @EmployeeID AND StationName = @StationName)";
                            cmdUpdate.CommandType = CommandType.Text;
                            cmdUpdate.Connection = con;
                            cmdUpdate.CommandTimeout = 120;
                            cmdUpdate.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100)).Value = AppInfo.CurrentUserID;
                            cmdUpdate.Parameters.Add(new SqlParameter("@StationName", SqlDbType.NVarChar, 100)).Value = AppInfo.LocalComputerName;
                            cmdUpdate.Parameters.Add(new SqlParameter("@LogStatusID", SqlDbType.Int, 100)).Value = 1;
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (var cmdInsert = new SqlCommand())
                        {
                            cmdInsert.CommandText = "INSERT dbo.LogStatus (EmployeeID, StationName, LogStatusID) VALUES  (@EmployeeID, @StationName, @LogStatusID)";
                            cmdInsert.CommandType = CommandType.Text;
                            cmdInsert.Connection = con;
                            cmdInsert.CommandTimeout = 120;
                            cmdInsert.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100)).Value = AppInfo.CurrentUserID;
                            cmdInsert.Parameters.Add(new SqlParameter("@StationName", SqlDbType.NVarChar, 100)).Value = AppInfo.LocalComputerName;
                            cmdInsert.Parameters.Add(new SqlParameter("@LogStatusID", SqlDbType.Int, 100)).Value = 1;
                            cmdInsert.ExecuteNonQuery();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LogOut()
        {
            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    using (var cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandText = "UPDATE dbo.LogStatus Set LogStatusID = @LogStatusID WHERE (EmployeeID = @EmployeeID AND StationName = @StationName)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100)).Value = AppInfo.CurrentUserID;
                        cmd.Parameters.Add(new SqlParameter("@StationName", SqlDbType.NVarChar, 100)).Value = AppInfo.LocalComputerName;
                        cmd.Parameters.Add(new SqlParameter("@LogStatusID", SqlDbType.Int, 100)).Value = 0;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsStationExist()
        {
            var status = false;

            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    using (var cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT EmployeeID FROM dbo.LogStatus WHERE (EmployeeID = @EmployeeID AND StationName = @StationName)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100)).Value = AppInfo.CurrentUserID;
                        cmd.Parameters.Add(new SqlParameter("@StationName", SqlDbType.NVarChar, 100)).Value = AppInfo.LocalComputerName;

                        var rowId = cmd.ExecuteScalar();
                        var rows = (Int32)rowId;

                        if (rows != 0)
                        {
                            status = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return status; // Returning Boolean Value
        }

        public static bool IsAdmin(int employeeId)
        {
            var status = false;

            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    using (var cmd = new SqlCommand())
                    {
                        con.Open();
                        cmd.CommandText = "SELECT UserType FROM dbo.Employees WHERE EmployeeID = @EmployeeID";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100)).Value = employeeId;

                        var right = cmd.ExecuteScalar();
                        var userRight = (String)right;

                        if (userRight == "Administrator")
                        {
                            status = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return status;
        }

        #endregion

        #region "CRUD Procedures"

        public static SqlDataAdapter UserDA(SqlConnection dbConnection)
        {
            var da = new SqlDataAdapter();

            try
            {
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "[usp_Employee_Select]";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = dbConnection;
                da.SelectCommand.CommandTimeout = 120;

                da.InsertCommand = new SqlCommand();
                da.InsertCommand.CommandText = "[usp_Employee_Insert]";
                da.InsertCommand.CommandType = CommandType.StoredProcedure;
                da.InsertCommand.Connection = dbConnection;
                da.InsertCommand.CommandTimeout = 120;
                da.InsertCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100, "EmployeeID"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 50, "EmployeeName"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50, "Username"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50, "Password"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@UserType", SqlDbType.NVarChar, 25, "UserType"));

                da.DeleteCommand = new SqlCommand();
                da.DeleteCommand.CommandText = "[usp_Employee_Delete]";
                da.DeleteCommand.CommandType = CommandType.StoredProcedure;
                da.DeleteCommand.Connection = dbConnection;
                da.DeleteCommand.CommandTimeout = 120;
                da.DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 100, "ID"));

                da.UpdateCommand = new SqlCommand();
                da.UpdateCommand.CommandText = "[usp_Employee_Update]";
                da.UpdateCommand.CommandType = CommandType.StoredProcedure;
                da.UpdateCommand.Connection = dbConnection;
                da.UpdateCommand.CommandTimeout = 120;
                da.UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 100, "ID"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 100, "EmployeeID"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 50, "EmployeeName"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50, "Username"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50, "Password"));
                da.InsertCommand.Parameters.Add(new SqlParameter("@UserType", SqlDbType.NVarChar, 25, "UserType"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return da; // Return Data Adapter
        }

        #endregion
    }
}