using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fireon.Classes;

namespace Fireon
{
    public partial class ucSettings : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();
        public ucSettings()
        {
            InitializeComponent();
            db.dbRead(dq.queryAccount[1], this.dtgvAccounts); // LOAD THE DTGV
            verifyLevelOfAccess();

            if (Properties.Settings.Default.keepLoggedIn == true)
            {
                chkbxKeepMeLoggedIn.Checked = true;
            }
            lblDefaultFileLocation.Text = Properties.Settings.Default.defaultFileLocation.ToString(); // REFRESHES THE FILE LOCATION FIRST
        }

        private void verifyLevelOfAccess()
        {
            // CHECK IF isSuperUser bool in the settings is true
            if (Properties.Settings.Default.isSuperUser == true)
            {
                superUserMode();
            }
            else
            {
                normalUserMode();
            }
        }

        private void superUserMode()
        {
            lblUsername.Visible = true;
            lblPassword.Visible = true;
            lblConfirmPassword.Visible = true;
            lblYourPassword.Visible = true;

            txtbxUsername.Visible = true;
            txtbxPassword.Visible = true;
            txtbxConfirmPassword.Visible = true;
            txtbxYourPassword.Visible = true;

            dtgvAccounts.Enabled = true;
            dtgvAccounts.Visible = true;

            btnDelete.Visible = true;
            btnAdd.Visible = true;

            btnDefaultFileLocation.Visible = true;
            lblDefaultFileLocation.Visible = true;
        }

        private void normalUserMode()
        {
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            lblConfirmPassword.Visible = false;
            lblYourPassword.Visible = false;

            txtbxUsername.Visible = false;
            txtbxPassword.Visible = false;
            txtbxConfirmPassword.Visible = false;
            txtbxYourPassword.Visible = false;

            dtgvAccounts.Enabled = false;
            dtgvAccounts.Visible = false;

            btnDelete.Visible = false;
            btnAdd.Visible = false;

            btnDefaultFileLocation.Visible = false;
            lblDefaultFileLocation.Visible = false;
        }


        #region ADD ACCOUNT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1. Validate input first
            //    a. i. User type should have a selected value ii. unique 
            //    b. i. Apply validations on the username, ii. should not be empty
            //    c. i. Current password should be the same with the logged in password
            //    d. i. New password should be differnt from the old one
            //    e. i. New Password should be the same with the new password one


            if (String.IsNullOrEmpty(txtbxUsername.Text) == false &&
                String.IsNullOrEmpty(txtbxPassword.Text) == false &&
                verifyUsernameIfUnique(txtbxUsername.Text) == true &&
                String.Compare(txtbxConfirmPassword.Text, txtbxPassword.Text) == 0 &&
                String.Compare(Properties.Settings.Default.lastLoggedInPassword.ToString(), txtbxYourPassword.Text) == 0)
            {
                //ADD TO DATABASE
                Console.WriteLine("Validation success");
                db.addAccountInfo(txtbxUsername.Text, txtbxPassword.Text);
                db.dbRead(dq.queryAccount[1], this.dtgvAccounts); // LOAD THE DTGV
                MessageBox.Show(null, Properties.Resources.msg_account_added, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtbxYourPassword.Clear();
                txtbxUsername.Clear();
                txtbxConfirmPassword.Clear();
                txtbxPassword.Clear();
            }
            else
            {
                MessageBox.Show(null, Properties.Resources.msg_validation_fail, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public bool verifyUsernameIfUnique(String username)
        {
            foreach (DataGridViewRow item in dtgvAccounts.Rows) // LOOPS ON EACH ITEM OF DTGV ACCOUNTS EACH ROW IS VERIFIED
            {
                string testedName = item.Cells[1].Value.ToString();

                if (String.Compare(username, testedName) == 0) // COMPARES WITH THE CURRENT LIST OF EMPLOYEE USERNAME
                {
                    return false; // IF THEY ARE THE SAME THEN EXIT IMMEDIATELY AND SAY FALSE
                }

            }
            return true; // IF NOT BEEN RETURNED, THEN TELL TRUE
        }


        #region VALIDATIONS ON FIELDS
        private void txtbxUpdateUserName_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxUpdateUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String accountType= dtgvAccounts.SelectedRows[0].Cells[2].Value.ToString();

            if (String.Compare(accountType, dp.accountTypes[1].ToString()) == 0)
            {
                MessageBox.Show(null, Properties.Resources.msg_account_cant_delete, Properties.Resources.str_program_title, MessageBoxButtons.OK); 
                return;
            }

            String username = dtgvAccounts.SelectedRows[0].Cells[1].Value.ToString();
            int accountID = int.Parse(dtgvAccounts.SelectedRows[0].Cells[0].Value.ToString());

            var result = MessageBox.Show(null, Properties.Resources.msg_account_confirm_delete1 + username + Properties.Resources.msg_account_confirm_delete2 + accountID.ToString() + "'?", Properties.Resources.str_program_title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // delete
                db.deleteAccountInfo(accountID);
                db.dbRead(dq.queryAccount[1], this.dtgvAccounts); // LOAD THE DTGV
                MessageBox.Show(null, Properties.Resources.msg_account_deleted, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // dont
            }
        }

        private void chkbxKeepMeLoggedIn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxKeepMeLoggedIn.Checked == true)
            {
                Properties.Settings.Default.keepLoggedIn = true;
            }
            else
            {
                Properties.Settings.Default.keepLoggedIn = false;
            }
        }


        private void btnDefaultFileLocation_Click(object sender, EventArgs e)
        {
            // THERE IS ALSO THE LOAD LINE ON THE LOAD() EVENT HERE
            if (fbdDefaultFileLocation.ShowDialog() == DialogResult.OK) // OPENS FOLDER CHOOSER DIALOG
            {
                fo.saveDefaultFileLocation(fbdDefaultFileLocation.SelectedPath, this.lblDefaultFileLocation); // PASSES THE FILENAME TO BE PROCESSED THERE
            }
        }
    }
}
