using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon.Classes
{
    /// <summary>
    /// FOR DISPLAYING EMPLOYEE INFORMATION AND PRINTNG IT
    /// </summary>
    class clsSinglePosting
    {
        /* ALGORITHM
         * 1. USER WILL TYPE THE EMPLOYEE ID ON THE SEARCH BAR
         * 2. THE USER WILL CLICK SEARCH
         * 3. DETAILS WILL POP UP ON THE pnlSinglePosting AREA
         * 4. USER WILL CLICK PRINT
         * 5. USER CLICK YES THEN PROCEED TO PRINT
         */

        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();

        /// <summary>
        /// GETS THE employeeID AND RETURNS THE VALUES FOR THE USER TO PRINT
        /// </summary>
        public void searchAndDisplayEmployee(
            string targetEmployeeID,
            Label lblEmployeeID,
            Label lblEmployeeFullName,
            Label lblEmployeeDepartment,
            Label lblEmployeeContactNumber,
            Label lblEmployeeEmailAddress,
            Label lblEmployeeHomeAddress,
            Label lblAccountUsername,
            Label lblDateProcessed,
            Label lblPayrollNetPay)
        {
            /* ALGORITHM
             * 1. GETS ALL THE NECESSARY DATA
             * 2. REFLECT THAT DATA BACK ON THE CONTENTS OF pnlSinglePosting
             */

            // VALIDATE FIRST HERE IF SUCH AN EMPLOYEE ID EXISTS
            int employeeID = int.Parse(targetEmployeeID);

            if (verifyIfEmployeeIDExists(employeeID) == true) { 
                /*DO NOTHING AND PROCEED BELOW*/
                MessageBox.Show(null, "Employee ID found.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else{
                MessageBox.Show(null, "No employee ID found.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; /*IMMEDIATELY EXIT THE PROGRAM*/ 
            }

            // EMPLOYEE ID
            string employeeIDText = String.Concat("Employee ID: ", targetEmployeeID); // PREP THE TEXT
            lblEmployeeID.Text = employeeIDText;

            // FULL NAME
            string queryEmployeeFirstName = @"
            SELECT employeeFirstName 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            string queryEmployeeMiddleInitial = @"
            SELECT employeeMiddleInitial 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            string queryEmployeeLastName = @"
            SELECT employeeLastName 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            DataTable dtEmployeeFirstName = getParticularData(queryEmployeeFirstName, "@targetEmployeeID", employeeID);
            DataTable dtEmployeeMiddleInitial = getParticularData(queryEmployeeMiddleInitial, "@targetEmployeeID", employeeID);
            DataTable dtEmployeeLastName = getParticularData(queryEmployeeLastName, "@targetEmployeeID", employeeID);
            string employeeFirstNameText = dtEmployeeFirstName.Rows[0].Field<String>(0);
            string employeeMiddleInitialText = dtEmployeeMiddleInitial.Rows[0].Field<String>(0);
            string employeeLastNameText = dtEmployeeLastName.Rows[0].Field<String>(0);
            string employeeFullNameText = "";
            if (String.IsNullOrEmpty(employeeMiddleInitialText) == true)
            {
                employeeFullNameText = String.Concat(employeeLastNameText, ", ", employeeFirstNameText, " ", employeeMiddleInitialText);
            }
            else
            {
                employeeFullNameText = String.Concat(employeeLastNameText, ", ", employeeFirstNameText, " ", employeeMiddleInitialText, ".");
            }

            lblEmployeeFullName.Text = employeeFullNameText;

            // EMPLOYEE DEPARTMENT
            string queryEmployeeDepartment = @"
            SELECT employeeDepartment 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            DataTable dtEmployeeDepartment = getParticularData(queryEmployeeDepartment, "@targetEmployeeID", employeeID);
            string employeeDepartmentText = dtEmployeeDepartment.Rows[0].Field<String>(0);
            lblEmployeeDepartment.Text = employeeDepartmentText;

            // CONTACT NUMBER
            string queryEmployeeContactNumber = @"
            SELECT employeeContactNumber 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            DataTable dtEmployeeContactNumber = getParticularData(queryEmployeeContactNumber, "@targetEmployeeID", employeeID);
            string employeeContactNumberText = dtEmployeeContactNumber.Rows[0].Field<Int64>(0).ToString();
            employeeContactNumberText = String.Concat("+63 ", employeeContactNumberText);
            //+63 923 615 4110, 7 AND 12 POSITIONS WHERE THE SPACE SHOULD BE PLACED
            employeeContactNumberText = employeeContactNumberText.Insert(7, " ");
            employeeContactNumberText = employeeContactNumberText.Insert(11, " ");
            lblEmployeeContactNumber.Text = employeeContactNumberText;

            // EMAIL ADDRESS
            string queryEmployeeEmailAddress = @"
            SELECT employeeEmailAddress 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            DataTable dtEmployeeEmailAddress = getParticularData(queryEmployeeEmailAddress, "@targetEmployeeID", employeeID);
            string employeeEmailAddressText = dtEmployeeEmailAddress.Rows[0].Field<String>(0);
            lblEmployeeEmailAddress.Text = employeeEmailAddressText;

            // HOME ADDRESS
            string queryEmployeeHomeAddress = @"
            SELECT employeeHomeAddress 
            FROM fireon.tbl_employee
            WHERE employeeID = @targetEmployeeID;
            ";
            DataTable dtEmployeeHomeAddress = getParticularData(queryEmployeeHomeAddress, "@targetEmployeeID", employeeID);
            string employeeHomeAddressText = dtEmployeeHomeAddress.Rows[0].Field<String>(0);
            lblEmployeeHomeAddress.Text = employeeHomeAddressText;

            // ACCOUNT USERNAME
            String accountUsernameText = Properties.Settings.Default.lastLoggedInUsername.ToString();
            lblAccountUsername.Text = accountUsernameText;

            // DATE PROCESSED
            string dateProcessedText = DateTime.Today.ToLongDateString();
            lblDateProcessed.Text = dateProcessedText;

            // PAYROLL NET PAY
            string queryPayrollNetPay = @"
            SELECT payrollNetPay 
            FROM fireon.tbl_employee_details
            WHERE idtbl_employee_details = @targetEmployeeID;
            ";
            DataTable dtPayrollNetPay = getParticularData(queryPayrollNetPay, "@targetEmployeeID", employeeID);
            int payrollNetPayInt = dtPayrollNetPay.Rows[0].Field<int>(0);
            string payrollNetPayTextFormatted = String.Format("{0:n0}", payrollNetPayInt);
            payrollNetPayTextFormatted = String.Concat("₱ ", payrollNetPayTextFormatted, ".00");
            lblPayrollNetPay.Text = payrollNetPayTextFormatted;

            //string signatureLocation = "";

        }
        private DataTable getParticularData(String query, String addWithValue, object value)
        {
            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            dbCmd.Parameters.AddWithValue(addWithValue, value); // ADDS THE employeeID FROM THE PASSED VALUE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();
            return dbDataTable;
        }
        private bool verifyIfEmployeeIDExists(int employeeID)
        {
            String query = @"
            SELECT employeeID
            FROM fireon.tbl_employee
            WHERE employeeID = @employeeID;
            ";
            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();

            return dbDataTable.Rows.Count != 0; // RETURNS TRUE IF THERE IS ENTRY, FALSE OTHERWISE IF COUNT = 0 OR NO ENTRIES
        }
    }
}
