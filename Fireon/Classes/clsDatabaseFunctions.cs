using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // FOR MySQL CONNECTION. THIS IS A PREREQUISITE

namespace Fireon
{
    /// <summary>
    /// THE CLASS TO HANDLE ALL DATABASE CONNECTIONS
    /// IN CASE THAT YOU WANT TO COMMUNICATE WITH THE DATABASE, JUST CREATE AN INSTANCE OF THIS CLASS SOMEWHERE IN YOUR STUFF.
    /// </summary>
    class clsDatabaseFunctions
    {
        // THE CONNECTION STRING. REFER TO THE PROPERTIES TO SEE THE CONNECTION STRING. FOR FORMALITY, AS MUCH AS POSSIBLE, WE SHOULD PUT ALL DEFAULT STRINGS ON THE RESOURCES PANEL
        static string dbConnectionString = Properties.Resources.db_connection_string;
        // dbCon WILL BE YOUR MYSQL CONNECTION INSTANCE. WE WILL PUT NEW MySqlConnection TO OUR dbCon OBJECT. STATIC BECAUSE THIS IS THE ONLY INSTANCE
        static MySqlConnection dbCon= new MySqlConnection(dbConnectionString);
        /// <summary>
        /// THIS METHOD VALIDATES THE USERNAME AND PASSWORD ENTERED ON LOGIN. WILL RETURN TRUE IF LOGIN CREDENTIALS MATCH
        /// </summary>
        /// <param name="username">THE USERNAME TO BE EVALUATED</param>
        /// <param name="password">THE PASSWORD TO BE EVALUATED</param>
        public bool dbLogin(string username, string password)
        {
            /* ALGORITHM
             * #1 LOOP THRU THE DATABASE TABLE OF ACCOUNTS AND SEE IF THERE IS A MATCHING USERNAME VS. WHAT'S ON THE LOGIN USERNAME TEXTBOX
             * #2 IF THE LOOP FINDS A MATCHING USERNAME, THEN COMPARE THAT DATABASE ENTRY PASSWORD VS. WHAT'S ON THE LOGIN PASSWORD TEXTBOX
             * #3 IF NO USERNAME FOUND AT ALL OR PASSWORD MISMATCH THEN PROMPT A MESSAGE AND DECREMENT BY 1 THE TRY COUNTER (WHEN 0, MEANS AUTOMATICALLY CLOSE PROGRAM)
             */
            dbOpen(); // OPEN THE CONNECTION

            DataSet dbDataSet = new DataSet(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(Properties.Resources.query_account, dbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataSet); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED

            // THIS PART IS TO LOOP FOR EACH ITEM IN OUR dbDataSet DataSet
            int row = 0;
            foreach (DataRow rowItem in dbDataSet.Tables[0].Rows)
            {
                // THIS IS COMPARING 2 STRINGS BETWEEN
                // "dbDataSet.Tables[0].Rows[row].ItemArray[1].ToString()" << WHICH IS THE USERNAME ON THE DATASET
                // "username" << WHICH IS THE PASSED STRING IN THIS METHOD
                // THE "String.Compare" RETURNS 0 IF BOTH STRINGS ARE THE SAME, HENCE "== 0"
                // ItemArray[1] IS THE accountUsername FIELD ON THE DATABASE. ItemArray[2] IS THE accountPassword
                if (String.Compare(dbDataSet.Tables[0].Rows[row].ItemArray[1].ToString(), username) == 0)
                {
                    // IF THERE HAPPENS TO HAVE A MATCHING USERNAME ON THE DATASET, THEN IT'S NOW TIME TO COMPARE FOR THE PASSWORD
                    if (String.Compare(dbDataSet.Tables[0].Rows[row].ItemArray[2].ToString(), password) == 0)
                    {
                        // USERNAME AND PASSWORD ARE CORRECT
                        dbClose(); // CLOSE THE CONNECTION
                        return true; // ESCAPE OUT OF THE PROGRAM
                    }
                }
                row++; // INCREMENT EACH ROW TO KEEP FINDING A MATCHING USERNAME
            }
            // IF THERE HAPPENED TO BE NO MATCHING USERNAME AND PASSWORD ABOVE, THEN SHOW THIS
            dbClose(); // CLOSE THE CONNECTION.
            return false; // RETURN FALSE IF PROGRAM DID NOT FIND A MATCHING CREDENTIALS
        }
        /// <summary>
        /// THIS METHOD TAKES A QUERY, LIKE SELECT * FROM tbl_accounts, AND PUTS IT IN A DataGridView OBJECT
        /// </summary>
        /// <param name="query">PASS THE QUERY FROM WHICH FUNCTION IT WAS CALLED</param>
        /// <param name="dgv">THE DataGridView THAT WE CHOOSE TO PUT OUR DATA</param>
        public void dbRead(string query, DataGridView dgv){
            dbOpen(); // OPEN THE CONNECTION

            DataTable dbDataTable= new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, dbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            dgv.DataSource = dbDataTable; // WE WILL CHANGE THE DGV DATA SOURCE WHERE WE CALLED THAT FUNCTION

            dbClose(); // CLOSE THE CONNECTION
        }
        /// <summary>
        /// THIS METHOD OPENS THE DATABASE CONNECTION
        /// </summary>
        private void dbOpen()
        {
            // THIS IF CONDITIONAL MEANS THAT IF THE DATABASE CONNECTION IS CLOSED, THEN OPEN IT USING THE Open(); METHOD
            if (dbCon.State == System.Data.ConnectionState.Closed)
            {
                dbCon.Open();
            }
        }
        /// <summary>
        /// THIS METHOD CLOSES THE DATABASE CONNECTION
        /// </summary>
        private void dbClose()
        {
            // THIS IF CONDITIONAL MEANS THAT IF THE DATABASE CONNECTION IS OPEN, THEN CLOSE IT USING THE Close(); METHOD
            if (dbCon.State == System.Data.ConnectionState.Open)
            {
                dbCon.Close();
            }
        }
        /// <summary>
        /// IS USED FOR FILTERING DATA
        /// </summary>
        /// <param name="pnl">THE CONTAINING PANEL FOR THE RESULT</param>
        /// <param name="query">THE QUERY TO BE EXECUTED</param>
        public void dbSearch(Panel pnl, String query)
        {
            pnl.Controls.Clear(); // CLEARS ALL CHILDREN OF THE PANEL
            ucDataGridView ucDataGridView = new ucDataGridView(); // CREATES A NEW UserControl
            ucDataGridView.Parent = pnl; // SET PARENT OF NEW DASHBOARD
            ucDataGridView.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
            dbRead(query, ucDataGridView.dgvTheDataGridView); // theDataGridView IS A STATIC MEMBER OF THE ucDataGridView CLASS
        }
        /// <summary>
        /// INSERTS EMPLOYEE DATA INTO THE DATABASE
        /// </summary>
        /// <param name="firstName">String</param>
        /// <param name="middleInitial">String</param>
        /// <param name="lastName">String</param>
        /// <param name="sex">String</param>
        /// <param name="contactNumber">int</param>
        /// <param name="emailAddress">String</param>
        /// <param name="homeAddress">String</param>
        /// <param name="birthDate">DateTime</param>
        /// <param name="maritalStatus">String</param>
        /// <param name="nationality">String</param>
        /// <param name="department">String</param>
        /// <param name="position">String</param>
        /// <param name="status">String</param>
        /// <param name="workingHours">int</param>
        /// <param name="hourlyRate">int</param>
        /// <param name="contractDuration">int</param>
        /// <param name="paymentMode">String</param>
        /// <param name="imageLocation">String</param>
        /// <param name="dateEmployed">DateTime</param>
        public void dbInsertEmployee (
            String firstName,
            String middleInitial,
            String lastName,
            String sex,
            Int64 contactNumber,
            String emailAddress,
            String homeAddress,
            DateTime birthDate,
            String maritalStatus,
            String nationality,
            String department,
            String position,
            String status,
            Int64 workingHours,
            Int64 hourlyRate,
            Int64 contractDuration,
            String paymentMode,
            String imageLocation,
            DateTime dateEmployed)
        {
            try
            {
                dbOpen(); // OPEN THE CONNECTION
                // CREATE NEW COMMAND INSTANCE HERE
                MySqlCommand dbCmd = new MySqlCommand(
                @"INSERT INTO tbl_employee(
                employeeFirstName,
                employeeMiddleInitial,
                employeeLastName,
                employeeSex,
                employeeContactNumber,
                employeeEmailAddress,
                employeeHomeAddress,
                employeeBirthDate,
                employeeMaritalStatus,
                employeeNationality,
                employeeDepartment,
                employeePosition,
                employeeStatus,
                employeeWorkingHours,
                employeeHourlyRate,
                employeeContractDuration,
                employeePaymentMode,
                employeeImageLocation,
                employeeDateEmployed) 
                VALUES(
                @employeeFirstName,
                @employeeMiddleInitial,
                @employeeLastName,
                @employeeSex,
                @employeeContactNumber,
                @employeeEmailAddress,
                @employeeHomeAddress,
                @employeeBirthDate,
                @employeeMaritalStatus,
                @employeeNationality,
                @employeeDepartment,
                @employeePosition,
                @employeeStatus,
                @employeeWorkingHours,
                @employeeHourlyRate,
                @employeeContractDuration,
                @employeePaymentMode,
                @employeeImageLocation,
                @employeeDateEmployed)", dbCon); // PASSING QUERY AND CONNECTION HERE
                // THIS IS THE PART WHERE I ADD VALUES BASED ON PASSED VALUES WHEN YOU CALL THIS FUNCTION
                dbCmd.Parameters.AddWithValue("@employeeFirstName", firstName);
                dbCmd.Parameters.AddWithValue("@employeeMiddleInitial", middleInitial);
                dbCmd.Parameters.AddWithValue("@employeeLastName", lastName);
                dbCmd.Parameters.AddWithValue("@employeeSex", sex);
                dbCmd.Parameters.AddWithValue("@employeeContactNumber", contactNumber);
                dbCmd.Parameters.AddWithValue("@employeeEmailAddress", emailAddress);
                dbCmd.Parameters.AddWithValue("@employeeHomeAddress", homeAddress);
                dbCmd.Parameters.AddWithValue("@employeeBirthDate", birthDate);
                dbCmd.Parameters.AddWithValue("@employeeMaritalStatus", maritalStatus);
                dbCmd.Parameters.AddWithValue("@employeeNationality", nationality);
                dbCmd.Parameters.AddWithValue("@employeeDepartment", department);
                dbCmd.Parameters.AddWithValue("@employeePosition", position);
                dbCmd.Parameters.AddWithValue("@employeeStatus", status);
                dbCmd.Parameters.AddWithValue("@employeeWorkingHours", workingHours);
                dbCmd.Parameters.AddWithValue("@employeeHourlyRate", hourlyRate);
                dbCmd.Parameters.AddWithValue("@employeeContractDuration", contractDuration);
                dbCmd.Parameters.AddWithValue("@employeePaymentMode", paymentMode);
                dbCmd.Parameters.AddWithValue("@employeeImageLocation", imageLocation);
                dbCmd.Parameters.AddWithValue("@employeeDateEmployed", dateEmployed);
                dbCmd.ExecuteNonQuery(); // EXECUTE
                dbClose(); // CLOSE THE CONNECTION
                MessageBox.Show(null, Properties.Resources.msg_employee_added, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// GETS THE EMPLOYEE ID OF THE LATEST INSERTED EMPLOYEE
        /// </summary>
        public Tuple <DateTime, String, int> returnLatestEmployeeEntry()
        {
            //GUIDE
            //SELECT employeeID -- fetches employeeID only
            //FROM tbl_employees -- from this table
            //ORDER BY employeeID DESC -- make it descending order
            //LIMIT 1 -- get only the first entry (the highest employeeID value, and probably the latest of them all)
            String query = "SELECT employeeDateEmployed, employeeLastName, employeeID FROM tbl_employee ORDER BY employeeID DESC LIMIT 1";
            int latestEmployeeID = 0;
            DateTime latestEmployeeDateEmployed = DateTime.Today;
            String latestEmployeeLastName = "LASTNAME";

            dbOpen();

            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, dbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED

            dbClose();

            latestEmployeeDateEmployed = dbDataTable.Rows[0].Field<DateTime>(0); // SAME AS WELL ON DATE
            latestEmployeeLastName = dbDataTable.Rows[0].Field<String>(1); // SAME AS WELL ON LAST NAME
            latestEmployeeID = dbDataTable.Rows[0].Field<int>(2); // IN THIS DATA TABLE BY THEORY CONTAINS THE HIGHEST EID WHICH IN THEORY IS LOCATED ONLY AT (0,0) SO WE ARE STORING THEM ON A INT VARIBLE TO BE RETURNED LATER

            return Tuple.Create(latestEmployeeDateEmployed, latestEmployeeLastName, latestEmployeeID);
        }
    }
}
