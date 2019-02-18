using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Inventory.Configuration;
using Inventory.DataAccessLayer;

namespace Inventory.PresentationLayer
{
    public partial class frmLogin : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        public frmLogin()
        {
            InitializeComponent();
        }

        #region "Form Procedures"

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    da = new SqlDataAdapter();
                    da = UserDataAccess.UserDA(con);
                    da.TableMappings.Add("Table", "Employees");
                    ds = new DataSet();
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = "";
                txtPassword.Multiline = false;
                txtPassword.UseSystemPasswordChar = false;
                cmbUsername.SelectedIndex = -1;
                cmbUsername.Focus();
                lblStatus.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "ComboBox Procedures"

        private void BindComboBox()
        {
            try
            {
                using (var con = new SqlConnection(Config.Instance.Connection))
                {
                    using (var da = new SqlDataAdapter("SELECT * FROM dbo.Employees ORDER BY EmployeeName", con))
                    {
                        da.TableMappings.Add("Table", "Employees");

                        using (var ds = new DataSet())
                        {
                            da.Fill(ds, "Employees");
                            cmbUsername.DataSource = ds.Tables["Employees"];
                            cmbUsername.DisplayMember = "Username";
                            cmbUsername.ValueMember = "Username";
                            cmbUsername.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                using (var dvUser = new DataView(ds.Tables[0]))
                {
                    var strUsername = this.cmbUsername.Text;

                    if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
                    {
                        e.SuppressKeyPress = true;
                        dvUser.RowFilter = string.Format("Username='{0}'", strUsername);

                        if (dvUser.Count > 0)
                        {
                            txtPassword.Focus();
                        }
                        else
                        {
                            lblStatus.Text = "You must choose a Valid Username!";
                            cmbUsername.Focus();
                            cmbUsername.Select();
                            cmbUsername.Text = "";
                        }
                    }
                    else if (e.KeyCode == Keys.Back | e.KeyCode == Keys.Delete)
                    {
                        return;
                    }
                    else if (e.KeyCode == Keys.Escape)
                    {
                        cmbUsername.Text = "";
                        cmbUsername.SelectedIndex = -1;
                        cmbUsername.Focus();
                        cmbUsername.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUsername_Enter(object sender, EventArgs e)
        {
            try
            {
                BindComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUsername_DropDown(object sender, EventArgs e)
        {
            try
            {
                BindComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "Button Procedures"
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbUsername.Text) | string.IsNullOrEmpty(txtPassword.Text))
                {
                    lblStatus.Text = "Please choose username and enter your password to login!";
                    cmbUsername.Focus();
                    cmbUsername.Select();
                    AppInfo.CurrentUserID = -1;
                }
                else
                {
                    // Get the userId or EmployeeID from the function that was created on UserDataAccess class
                    var userId = UserDataAccess.VerifyCredentials(cmbUsername.Text, txtPassword.Text);

                    if (userId > 0)
                    {
                        AppInfo.CurrentUserID = userId;
                        AppInfo.CurrentUserName = cmbUsername.Text;
                        AppInfo.LocalComputerName = Environment.MachineName;
                        AppInfo.CurrentUserIsAdmin = UserDataAccess.IsAdmin(userId);
                        UserDataAccess.LogIn();
                        this.Close();
                    }
                    else
                    {
                        lblStatus.Text = "Password is incorrect! Try again.";
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion

        
        
    }
}
