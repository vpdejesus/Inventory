using System;
using System.Windows.Forms;
using Inventory.DataAccessLayer;

namespace Inventory.PresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region "Form Procedures"

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                EnableControls(false);
                ShowLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Procedure to disable right above X button on this form
        protected override CreateParams CreateParams
        {
            get
            {
                var IsClose = false;
                var CloseButton = 0x200;
                var Param = base.CreateParams;

                if (IsClose)
                {
                    Param.ClassStyle = Param.ClassStyle & CloseButton;
                }
                else
                {
                    Param.ClassStyle = Param.ClassStyle | CloseButton;
                }
                return Param;
            }
        }

        #endregion

        #region "Private Procedures"

        private void ShowLoginForm()
        {
            try
            {
                var frm = new frmLogin();
                frm.btnOK.Click += ReEnableControls;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetFormState()
        {
            try
            {
                if (AppInfo.CurrentUserID == -1)
                {
                    LBLBottomLeft.Text = "";
                }
                else
                {
                    LBLBottomLeft.Text = AppInfo.CurrentUserName.ToUpper() + (AppInfo.CurrentUserIsAdmin == true ? " - (Administrator)" : "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EnableMenuItems(bool isEnabled)
        {
            try
            {
                if (isEnabled == false | AppInfo.CurrentUserID == -1)
                {
                    mnLogin.Enabled = true;
                    mnLogout.Enabled = false;
                    mnExit.Enabled = true;
                    mnTransaction.Enabled = false;
                    mnReport.Enabled = false;
                    mnSetup.Enabled = false;
                    mnLogout.Enabled = false;
                }
                else if (AppInfo.CurrentUserIsAdmin == false)
                {
                    mnLogin.Enabled = false;
                    mnLogout.Enabled = true;
                    mnExit.Enabled = false;
                    mnTransaction.Enabled = true;
                    mnSetup.Enabled = false;
                    mnReport.Enabled = true;
                }
                else if (AppInfo.CurrentUserIsAdmin == true)
                {
                    mnLogin.Enabled = false;
                    mnLogout.Enabled = true;
                    mnExit.Enabled = false;
                    mnTransaction.Enabled = true;
                    mnSetup.Enabled = true;
                    mnReport.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EnableToolBarButtons(bool isEnabled)
        {
            try
            {
                if (isEnabled == false | AppInfo.CurrentUserID == -1)
                {
                    tsbLogin.Enabled = true;
                    tsbLogout.Enabled = false;
                    tsbInventory.Enabled = false;
                    tsbInquiry.Enabled = false;
                    tsbReport.Enabled = false;
                    tsbExit.Enabled = true;
                }
                else
                {
                    tsbLogin.Enabled = false;
                    tsbLogout.Enabled = true;
                    tsbInventory.Enabled = true;
                    tsbInquiry.Enabled = true;
                    tsbReport.Enabled = true;
                    tsbExit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EnableControls(bool isEnable)
        {
            try
            {
                EnableMenuItems(isEnable);
                EnableToolBarButtons(isEnable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReEnableControls(object sender, EventArgs e)
        {
            try
            {
                if (AppInfo.CurrentUserID != -1)
                {
                    EnableControls(true);
                    SetFormState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseAllActiveForms()
        {
            try
            {
                foreach (var frm in this.MdiChildren)
                {
                    if (!frm.Focused)
                    {
                        frm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "Menu Procedures"
        private void mnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                EnableControls(false);
                CloseAllActiveForms();
                ShowLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region "ToolStripButton Procedures"

        private void tsbLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            try
            {
                EnableControls(false);
                CloseAllActiveForms();
                ShowLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
