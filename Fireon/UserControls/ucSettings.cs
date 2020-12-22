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
        public ucSettings()
        {
            InitializeComponent();
            db.dbRead("SELECT accountID, accountUsername, accountType FROM tbl_account", this.dtgvAccounts); // LOAD THE DTGV
            verifyLevelOfAccess();
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

        }

        private void normalUserMode()
        {

        }



















        //private void stuffInit()
        //{
        //    this.dtgvAccounts.Visible = false;
        //    lblCurrentPw.Visible = false;
        //    txtbxCurrentPw.Visible = false;
        //    btnSeeCurrentPw.Visible = false;

        //    lblNewPw.Visible = false;
        //    txtbxNewPw.Visible = false;
        //    btnSeeNewPw.Visible = false;

        //    lblConfirmNewPw.Visible = false;
        //    txtbxConfirmNewPw.Visible = false;
        //    btnSeeCurrentPw.Visible = false;

        //    btnUpdateAccount.Visible = true;
        //    btnAddAccount.Visible = true;
        //}

        //public bool verifyUsernameIfUnique(String username)
        //{
        //    var x = 0;
        //    foreach (DataGridViewRow item in dtgvAccounts.Rows) // LOOPS ON EACH ITEM OF DTGV ACCOUNTS EACH ROW IS VERIFIED
        //    {
        //        string testedName = item.Cells[1].Value.ToString();
        //        if (String.Compare(username, testedName) == 0) // COMPARES WITH THE CURRENT LIST OF EMPLOYEE USERNAME
        //        {
        //            return false; // IF THEY ARE THE SAME THEN EXIT IMMEDIATELY AND SAY FALSE
        //        }
        //        x++;
        //    }
        //    return true; // IF NOT BEEN RETURNED, THEN TELL TRUE
        //}
        //public void updateMode()
        //{
        //    this.dtgvAccounts.Visible = true;
        //    lblCurrentPw.Visible = true;
        //    txtbxCurrentPw.Visible = true;
        //    btnSeeCurrentPw.Visible = true;

        //    lblNewPw.Visible = true;
        //    txtbxNewPw.Visible = true;
        //    btnSeeNewPw.Visible = true;

        //    lblConfirmNewPw.Visible = true;
        //    txtbxConfirmNewPw.Visible = true;
        //    btnSeeCurrentPw.Visible = true;

        //    btnUpdateAccount.Visible = true;
        //    btnAddAccount.Visible = false;
        //    MessageBox.Show(null, "Update an account.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //public void addMode()
        //{
        //    this.dtgvAccounts.Visible = false;
        //    lblCurrentPw.Visible = false;
        //    txtbxCurrentPw.Visible = false;
        //    btnSeeCurrentPw.Visible = false;

        //    lblNewPw.Visible = true;
        //    txtbxNewPw.Visible = true;
        //    btnSeeNewPw.Visible = true;

        //    lblConfirmNewPw.Visible = true;
        //    txtbxConfirmNewPw.Visible = true;
        //    btnSeeCurrentPw.Visible = true;

        //    btnUpdateAccount.Visible = false;
        //    btnAddAccount.Visible = true;
        //    MessageBox.Show(null, "Add new account.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}






        //#region VALIDATIONS ON FIELDS
        //private void txtbxUpdateUserName_Leave(object sender, EventArgs e)
        //{
        //    sf.cleanText((TextBox)sender);
        //}
        //private void txtbxUpdateUserName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    sf.firstRegex(e);
        //}
        //#endregion
        //#region PASSWORD LOGIC ON THOSE THREE EYES
        //private void btnSeeCurrentPw_MouseHover(object sender, EventArgs e)
        //{
        //    Button theSender = (Button)sender; // CAST THE SENDER 
        //    theSender.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //}
        //private void btnSeeCurrentPw_MouseLeave(object sender, EventArgs e)
        //{
        //    Button theSender = (Button)sender; // CAST THE SENDER 
        //    // CHANGES THE IMAGE WHEN MOUSE LEAVES THE EYE
        //    // IF THE MOUSE LEAVES THE EYE ON AN ACTIVATED STATE, KEEP THE ACTIVATED STATE, ELSE DEACTIVATE THE EYE
        //    if (String.Compare(txtbxCurrentPw.Tag.ToString(), "FALSE") == 0)
        //    {
        //        btnSeeCurrentPw.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //    }
        //    else
        //    {
        //        btnSeeCurrentPw.BackgroundImage = Properties.Resources.btnIconEye;
        //    }

        //    if (String.Compare(txtbxNewPw.Tag.ToString(), "FALSE") == 0)
        //    {
        //        btnSeeNewPw.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //    }
        //    else
        //    {
        //        btnSeeNewPw.BackgroundImage = Properties.Resources.btnIconEye;
        //    }

        //    if (String.Compare(txtbxConfirmNewPw.Tag.ToString(), "FALSE") == 0)
        //    {
        //        btnSeeConfirmNewPw.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //    }
        //    else
        //    {
        //        btnSeeConfirmNewPw.BackgroundImage = Properties.Resources.btnIconEye;
        //    }
        //}
        //private void btnSeeCurrentPw_Click(object sender, EventArgs e)
        //{
        //    /* ALGORITHM
        //     * "TRUE" MEANS USER CAN'T SEE PASSWORD, "FALSE" MEANS USER CAN SEE PASSWORD
        //     * #1 DEFAULT TAG PROPERTY OF txtbx_pw IS SET TO "TRUE" AND UseSystemPasswordChar = true.
        //     * #2 CHECK WHETHER THE Tag PROPERTY OF txtbx_pw IS "TRUE".
        //     * #3 IF THE VALUE IS "TRUE" THEN SET THE UseSystemPasswordChar PROPERTY OF txtbx_pw TO "FALSE" and the Tag PROPERTY to "FALSE" AS WELL SO THAT USER CAN SEE PASSWORD.
        //     * #4 IF THE VALUE IS ALREADY "FALSE", THEN SET BACK Tag PROPERTY TO "TRUE" AND UseSystemPasswordChar PROPERTY OF txtbx_pw TO "TRUE" AGAIN.
        //     */
        //    // #2
        //    if (String.Compare(txtbxCurrentPw.Tag.ToString(), "TRUE") == 0)
        //    {
        //        // #3
        //        txtbxCurrentPw.Tag = "FALSE";
        //        txtbxCurrentPw.UseSystemPasswordChar = false;
        //        // CHANGE EYE LOGO TO ACTIVATED
        //        btnSeeCurrentPw.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //    }
        //    // #4
        //    else
        //    {
        //        txtbxCurrentPw.Tag = "TRUE";
        //        txtbxCurrentPw.UseSystemPasswordChar = true;
        //        // CHANGE EYE LOGO TO DEACTIVATED
        //        btnSeeCurrentPw.BackgroundImage = Properties.Resources.btnIconEye;
        //    }


        //    /* ALGORITHM
        //     * "TRUE" MEANS USER CAN'T SEE PASSWORD, "FALSE" MEANS USER CAN SEE PASSWORD
        //     * #1 DEFAULT TAG PROPERTY OF txtbx_pw IS SET TO "TRUE" AND UseSystemPasswordChar = true.
        //     * #2 CHECK WHETHER THE Tag PROPERTY OF txtbx_pw IS "TRUE".
        //     * #3 IF THE VALUE IS "TRUE" THEN SET THE UseSystemPasswordChar PROPERTY OF txtbx_pw TO "FALSE" and the Tag PROPERTY to "FALSE" AS WELL SO THAT USER CAN SEE PASSWORD.
        //     * #4 IF THE VALUE IS ALREADY "FALSE", THEN SET BACK Tag PROPERTY TO "TRUE" AND UseSystemPasswordChar PROPERTY OF txtbx_pw TO "TRUE" AGAIN.
        //     */
        //    // #2
        //    if (String.Compare(txtbxNewPw.Tag.ToString(), "TRUE") == 0)
        //    {
        //        // #3
        //        txtbxNewPw.Tag = "FALSE";
        //        txtbxNewPw.UseSystemPasswordChar = false;
        //        // CHANGE EYE LOGO TO ACTIVATED
        //        btnSeeNewPw.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //    }
        //    // #4
        //    else
        //    {
        //        txtbxNewPw.Tag = "TRUE";
        //        txtbxNewPw.UseSystemPasswordChar = true;
        //        // CHANGE EYE LOGO TO DEACTIVATED
        //        btnSeeNewPw.BackgroundImage = Properties.Resources.btnIconEye;
        //    }

        //    /* ALGORITHM
        //     * "TRUE" MEANS USER CAN'T SEE PASSWORD, "FALSE" MEANS USER CAN SEE PASSWORD
        //     * #1 DEFAULT TAG PROPERTY OF txtbx_pw IS SET TO "TRUE" AND UseSystemPasswordChar = true.
        //     * #2 CHECK WHETHER THE Tag PROPERTY OF txtbx_pw IS "TRUE".
        //     * #3 IF THE VALUE IS "TRUE" THEN SET THE UseSystemPasswordChar PROPERTY OF txtbx_pw TO "FALSE" and the Tag PROPERTY to "FALSE" AS WELL SO THAT USER CAN SEE PASSWORD.
        //     * #4 IF THE VALUE IS ALREADY "FALSE", THEN SET BACK Tag PROPERTY TO "TRUE" AND UseSystemPasswordChar PROPERTY OF txtbx_pw TO "TRUE" AGAIN.
        //     */
        //    // #2
        //    if (String.Compare(txtbxConfirmNewPw.Tag.ToString(), "TRUE") == 0)
        //    {
        //        // #3
        //        txtbxConfirmNewPw.Tag = "FALSE";
        //        txtbxConfirmNewPw.UseSystemPasswordChar = false;
        //        // CHANGE EYE LOGO TO ACTIVATED
        //        btnSeeConfirmNewPw.BackgroundImage = Properties.Resources.btnIconEyeHover;
        //    }
        //    // #4
        //    else
        //    {
        //        txtbxConfirmNewPw.Tag = "TRUE";
        //        txtbxConfirmNewPw.UseSystemPasswordChar = true;
        //        // CHANGE EYE LOGO TO DEACTIVATED
        //        btnSeeConfirmNewPw.BackgroundImage = Properties.Resources.btnIconEye;
        //    }
        //}
        //#endregion
        //#region ADD ACCOUNT
        //private void btnAddAccount_Click(object sender, EventArgs e)
        //{
        ////1. Validate input first
        ////    a. i. User type should have a selected value ii. unique 
        ////    b. i. Apply validations on the username, ii. should not be empty
        ////    c. i. Current password should be the same with the logged in password
        ////    d. i. New password should be differnt from the old one
        ////    e. i. New Password should be the same with the new password one


        //if (String.IsNullOrEmpty(txtbxUpdateUserName.Text) == false &&
        //    String.IsNullOrEmpty(txtbxNewPw.Text) == false &&
        //    verifyUsernameIfUnique(txtbxUpdateUserName.Text) == true &&
        //    String.Compare(txtbxNewPw.Text, txtbxConfirmNewPw.Text) == 0)
        //{
        //    //ADD TO DATABASE
        //    Console.WriteLine("Validation success");
        //    db.addAccountInfo(txtbxUpdateUserName.Text, txtbxNewPw.Text);
        //    db.dbRead("SELECT accountID, accountUsername FROM tbl_account", this.dtgvAccounts); // LOAD THE DTGV
        //    MessageBox.Show(null, "Account successfully added", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //else
        //{
        //    MessageBox.Show(null, "Validation fail", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //}
        //#endregion


        //// CODE TO ACTIVATE THE CURRENT PASSWORD AND REENTER PASSWORD FOR UPDATE HERE
        //// CODE TO ACTIVATE THE CURRENT PASSWORD AND REENTER PASSWORD FOR UPDATE HERE
        //// CODE TO ACTIVATE THE CURRENT PASSWORD AND REENTER PASSWORD FOR UPDATE HERE
        //// CODE TO ACTIVATE THE CURRENT PASSWORD AND REENTER PASSWORD FOR UPDATE HERE
        ////VERIFY IS SAME LOGGED ON ACCOUNT IF YES THEN PROMPT FOR EDIT
    }
}
