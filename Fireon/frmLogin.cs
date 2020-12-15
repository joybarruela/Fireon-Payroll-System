﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // FOR MySQL CONNECTION. THIS IS A PREREQUISITE.

namespace Fireon
{
    public partial class frmLogin : Form
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions(); // CREATE AN INSTANCE OF clsDatabaseFunctions.
        int loginAttempts = int.Parse(Properties.Resources.int_login_attempts); // DECREMENTS BY 1 EVERY TIME THE USER FAILS TO LOG IN THE SYSTEM.
        frmFireonPayroll main_form = new frmFireonPayroll(); // CREATE INSTANCE OF THE MAIN FORM 


        /// <summary>
        /// THIS METHOD IS CALLED EVERY TIME new frmLogin(); IS CALLED EVERYWHERE THE PROGRAM. THIS IS CALLED A CONSTRUCTOR.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent(); // LOADS ALL COMPONENTS OF THE frmLogin. THIS IS A SYSTEM PREREQUISITE.
        }

        /// <summary>
        /// THIS METHOD GETS CALLED EVERY TIME THE frmLogin FORM OBJECT GETS LOADED IN THE MEMORY.
        /// THIS LOGIN FORM WILL ONLY LOAD ONCE, WHEN THE USER LOGS IN SUCCESSFULLY, THIS FORM IS ONLY HIDDEN, NOT DISPOSED.
        /// </summary>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            main_form.Hide(); // HIDE FIRST THE MAIN FORM.
        }

        /// <summary>
        /// BARRUELA, VIBIESCA
        /// THIS METHOD GETS CALLED WHEN THE USER CLICKS THE LOGIN BUTTON FROM THE LOGIN FORM.
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            /* ALGORITHM
             * #1 IF THE USER CLICKS LOGIN, THIS METHOD WILL CALL THE dbLogin METHOD THAT WILL CHECK ON THE DATABASE IF USERNAME AND PASSWORDS MATCH.
             * #2 IF THERE IS MATCHING USERNAME, CLOSE THE LOGIN AND PROCEED TO DASHBOARD
             * #3 IF NOT THEN DECREMENT THE VALUE OF LOGIN ATTEMPTS. AT 
             */
            if (db.dbLogin(txtbx_username.Text, txtbx_pw.Text) == true) // IF USERNAME AND PASSWORD MATCH
            {
                MessageBox.Show(Properties.Resources.str_login_match, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(Properties.Resources.str_loading_message,Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // HIDES THIS LOGIN FORM.

                // TRY: SHOWING THE MAIN FORM
                // BUT IN CASE NO MAIN FORM OBJECT EXISTS (WHICH HAPPEN WHEN YOU LOG OUT BECAUSE THAT KILLS THE INSTANCE OF LOGIN)
                // DO WHAT IS IN THE CATCH SECTION WHICH IS REINSTANTIATING THE FORM OBJECT.
                try
                {
                    main_form.Show(); // SHOWS THE MAIN FORM OF THE PROGRAM.
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    frmFireonPayroll main_form = new frmFireonPayroll(); // CREATE INSTANCE OF THE MAIN FORM 
                    main_form.Show();
                }
            }
            if (db.dbLogin(txtbx_username.Text, txtbx_pw.Text) == false) // IF USERNAME AND PASSWORD MISMATCH
            {
                MessageBox.Show(Properties.Resources.str_login_mismatch, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginAttempts--; // DECREASE THE ATTEMPT
            }
            if (loginAttempts == 0) // IF NO MORE ATTEMPTS
            {
                MessageBox.Show(Properties.Resources.str_login_terminate, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // EXIT THE LOGIN WINDOW.
            }
        }

        #region EYE PASSWORD VISIBILITY TOGGLER
        /// <summary>
        /// THIS METHOD IS CALLED WHEN THE USER CLICKS ON THE EYE LOGO OF THE LOGIN PASSWORD FORM
        /// </summary>
        private void btn_see_pw_Click(object sender, EventArgs e)
        {
            /* ALGORITHM
             * "TRUE" MEANS USER CAN'T SEE PASSWORD, "FALSE" MEANS USER CAN SEE PASSWORD
             * #1 DEFAULT TAG PROPERTY OF txtbx_pw IS SET TO "TRUE" AND UseSystemPasswordChar = true.
             * #2 CHECK WHETHER THE Tag PROPERTY OF txtbx_pw IS "TRUE".
             * #3 IF THE VALUE IS "TRUE" THEN SET THE UseSystemPasswordChar PROPERTY OF txtbx_pw TO "FALSE" and the Tag PROPERTY to "FALSE" AS WELL SO THAT USER CAN SEE PASSWORD.
             * #4 IF THE VALUE IS ALREADY "FALSE", THEN SET BACK Tag PROPERTY TO "TRUE" AND UseSystemPasswordChar PROPERTY OF txtbx_pw TO "TRUE" AGAIN.
             */
            // #2
            if (String.Compare(txtbx_pw.Tag.ToString(), "TRUE") == 0)
            {
                // #3
                txtbx_pw.Tag = "FALSE";
                txtbx_pw.UseSystemPasswordChar = false;
                // CHANGE EYE LOGO TO ACTIVATED
                btn_see_pw.BackgroundImage = Properties.Resources.btn_eye_hover;
            }
            // #4
            else
            {
                txtbx_pw.Tag = "TRUE";
                txtbx_pw.UseSystemPasswordChar = true;
                // CHANGE EYE LOGO TO DEACTIVATED
                btn_see_pw.BackgroundImage = Properties.Resources.btn_eye;
            }
        }
        /// <summary>
        /// VIBIESCA
        /// THIS METHOD IS CALLED WHEN THE USER MOUSES OVER ON THE EYE LOGO OF THE LOGIN PASSWORD FORM
        /// </summary>
        private void btn_see_pw_MouseHover(object sender, EventArgs e)
        {
                // CHANGES THE IMAGE WHEN MOUSE ENTERS THE EYE
                btn_see_pw.BackgroundImage = Properties.Resources.btn_eye_hover;
        }
        /// <summary>
        /// VIBIESCA
        /// THIS METHOD IS CALLED WHEN THE USER MOUSELEAVES OVER THE EYE LOGO OF THE LOGIN PASSWORD FORM
        /// </summary>
        private void btn_see_pw_MouseLeave(object sender, EventArgs e)
        {
            // CHANGES THE IMAGE WHEN MOUSE LEAVES THE EYE
            // IF THE MOUSE LEAVES THE EYE ON AN ACTIVATED STATE, KEEP THE ACTIVATED STATE, ELSE DEACTIVATE THE EYE.
            if (String.Compare(txtbx_pw.Tag.ToString(), "FALSE") == 0)
            {
                btn_see_pw.BackgroundImage = Properties.Resources.btn_eye_hover;
            }
            else
            {
                btn_see_pw.BackgroundImage = Properties.Resources.btn_eye;
            }
        }
        #endregion
        /// <summary>
        /// VIBIESCA
        /// THIS METHOD GETS CALLED EVERY TIME THE VISIBILITY STATE OF THIS FORM CHANGES
        /// </summary>
        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                db.dbRead("SELECT * FROM tbl_account", dgv_accounts); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                txtbx_username.Clear(); // CLEAR USERNAME TEXT
                txtbx_pw.Clear(); // CLEAR PASSWORD TEXT
                loginAttempts = int.Parse(Properties.Resources.int_login_attempts); // REFRESH THE VALUE.
            }
        }
        #region Validation on Username and Password creation
        ///// <summary>
        ///// VILLANUEVA
        ///// THIS METHOD GETS CALLED EVERY TIME THE USER PRESSES A KEY (KEYPRESS EVENT) IN THE TXTBX_USERNAME OBJECT.
        ///// </summary>
        ///// <param name="e">THE E VARIABLE REFERS TO THE ACTUAL KEY PRESSED. EXAMPLE, WHEN THE USER PRESSES LETTER "S", THEN THE E WILL HOLD THE VALUE OF "S".</param>
        //private void txtbx_username_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // THIS CODE ALLOWS UPPERCASE & LOWERCASE LETTERS ONLY
        //    // IF THE KEY PRESSED IS NOT A LETTER AND NOT A CONTROL CHARACTER, THEN "e.Handled = true;"
        //    // CONTROL CHARACTERS ARE: SPACES, BACKSPACES, ENTER KEY, AND OTHER STUFF TO CONTROL TEXT.
        //    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        // "e.Handled = true" MEANS THAT SYSTEM WILL HANDLE THE INPUT AND NOT SHOW IT IN THE TEXTBOX.
        //        e.Handled = true;
        //    }
        //}
        ///// <summary>
        ///// VILLANUEVA
        ///// THIS METHOD GETS CALLED EVERY TIME THE USER PRESSES A KEY (KEYPRESS EVENT) IN THE TXTBX_PW OBJECT.
        ///// </summary>
        ///// <param name="e">THE E VARIABLE REFERS TO THE ACTUAL KEY PRESSED. EXAMPLE, WHEN THE USER PRESSES LETTER "S", THEN THE E WILL HOLD THE VALUE OF "S".</param>
        //private void txtbx_pw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // THIS CODE ALLOWS CHARS AND INTEGERS ONLY, NO SPACES, AND NO SPECIAL CHARS
        //    // IF THE KEY PRESSED IS NOT A LETTER AND NOT A CONTROL CHARACTER, THEN "e.Handled = true;"
        //    // CONTROL CHARACTERS ARE: SPACES, BACKSPACES, ENTER KEY, AND OTHER STUFF TO CONTROL TEXT.
        //    if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        // "e.Handled = true" MEANS THAT SYSTEM WILL HANDLE THE INPUT AND NOT SHOW IT IN THE TEXTBOX.
        //        e.Handled = true;
        //    }
        //}
        #endregion
    }
}
