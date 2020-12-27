using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fireon.Classes; // FOR MySQL CONNECTION. THIS IS A PREREQUISITE

namespace Fireon
{
    /// <summary>
    /// THE CLASS TO HANDLE ALL DATABASE CONNECTIONS
    /// IN CASE THAT YOU WANT TO COMMUNICATE WITH THE DATABASE, JUST CREATE AN INSTANCE OF THIS CLASS SOMEWHERE IN YOUR STUFF.
    /// </summary>
    class clsDatabaseFunctions
    {
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsDatabaseQueries dq = new clsDatabaseQueries();
        clsPayroll pr = new clsPayroll();

        static string dbConnectionString = Properties.Resources.db_connection_string; // THE CONNECTION STRING. REFER TO THE PROPERTIES TO SEE THE CONNECTION STRING. FOR FORMALITY, AS MUCH AS POSSIBLE, WE SHOULD PUT ALL DEFAULT STRINGS ON THE RESOURCES PANEL
        static MySqlConnection dbCon = new MySqlConnection(dbConnectionString); // dbCon WILL BE YOUR MYSQL CONNECTION INSTANCE. WE WILL PUT NEW MySqlConnection TO OUR dbCon OBJECT. STATIC BECAUSE THIS IS THE ONLY INSTANCE
        public string getDbConnectionString // GETTER OVER HERE, FOR THE clsPayroll THAT'S THE ONLY INSTANCE OF SEPARATE DATABAS USAGE
        {
            get { return dbConnectionString; }
        }
        public MySqlConnection getDbCon // GETTER OVER HERE, FOR THE clsPayroll THAT'S THE ONLY INSTANCE OF SEPARATE DATABAS USAGE
        {
            get { return dbCon; }
        }

        
        #region LOGIN
        /// <summary>
        /// VALIDATES THE USERNAME AND PASSWORD ENTERED ON LOGIN. WILL RETURN TRUE IF LOGIN CREDENTIALS MATCH
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
            MySqlCommand dbCmd = new MySqlCommand(dq.queryAccount[0], dbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataSet); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED

            // THIS PART IS TO LOOP FOR EACH ITEM IN OUR dbDataSet DataSet
            int row = 0;
            foreach (DataRow rowItem in dbDataSet.Tables[0].Rows)
            {
                // THIS IS COMPARING 2 STRINGS BETWEEN
                // "dbDataSet.Tables[0].Rows[row].ItemArray[1].ToString()" << WHICH IS THE USERNAME ON THE DATASET
                // "allowanceName" << WHICH IS THE PASSED STRING IN THIS METHOD
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
        #endregion
        #region DATABASE
        /// <summary>
        /// THIS METHOD TAKES A QUERY, LIKE SELECT * FROM tbl_accounts, AND PUTS IT IN A DataGridView OBJECT
        /// </summary>
        /// <param name="query">PASS THE QUERY FROM WHICH FUNCTION IT WAS CALLED</param>
        /// <param name="dgv">THE DataGridView THAT WE CHOOSE TO PUT OUR DATA</param>
        public void dbRead(string query, DataGridView dgv)
        {
            dbOpen(); // OPEN THE CONNECTION

            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, dbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            dgv.DataSource = dbDataTable; // WE WILL CHANGE THE DGV DATA SOURCE WHERE WE CALLED THAT FUNCTION

            dbClose(); // CLOSE THE CONNECTION
            Console.WriteLine("Query: " + query);
        }
        /// <summary>
        /// THIS METHOD OPENS THE DATABASE CONNECTION
        /// </summary>
        public void dbOpen()
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
        public void dbClose()
        {
            // THIS IF CONDITIONAL MEANS THAT IF THE DATABASE CONNECTION IS OPEN, THEN CLOSE IT USING THE Close(); METHOD
            if (dbCon.State == System.Data.ConnectionState.Open)
            {
                dbCon.Close();
            }
        } 
        #endregion
        #region EMPLOYEE
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
            pr.computePayroll(); // COMPUTES THE PAYROLL HERE
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
        public void dbInsertEmployee(String firstName, String middleInitial, String lastName, String sex, Int64 contactNumber, String emailAddress, String homeAddress, DateTime birthDate, String maritalStatus, String nationality, String department, String position, String status, Int64 workingHours, Int64 hourlyRate, Int64 contractDuration, String paymentMode, String imageLocation, DateTime dateEmployed)
        {
            try
            {
                dbOpen(); // OPEN THE CONNECTION
                MySqlCommand dbCmd = new MySqlCommand(dq.queryEmployee[1], dbCon); // CREATE NEW COMMAND INSTANCE HERE AND PASSING QUERY AND CONNECTION HERE
                // ADD VALUES BASED ON PASSED VALUES WHEN YOU CALL THIS FUNCTION
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
                MessageBox.Show(null, Properties.Resources.msg_new_employee_added, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void dbInsertEmployeeDetails()
        {
            try
            {
                dbOpen(); // OPEN THE CONNECTION
                MySqlCommand dbCmd = new MySqlCommand(dq.queryEmployeeDetails[1], dbCon); // CREATE NEW COMMAND INSTANCE HERE AND PASSING QUERY AND CONNECTION HERE
                // THIS IS THE PART WHERE I ADD VALUES BASED ON PASSED VALUES WHEN YOU CALL THIS FUNCTION
                dbCmd.Parameters.AddWithValue("@SickLeave", int.Parse(Properties.Resources.int_sick_leave));
                dbCmd.Parameters.AddWithValue("@VacationLeave", int.Parse(Properties.Resources.int_vacation_leave));
                dbCmd.Parameters.AddWithValue("@MaternityLeave", int.Parse(Properties.Resources.int_maternity_leave));
                dbCmd.Parameters.AddWithValue("@AdvanceAmount", int.Parse(Properties.Resources.int_cash_advance));
                dbCmd.ExecuteNonQuery(); // EXECUTE
                dbClose(); // CLOSE THE CONNECTION
                Console.WriteLine("Employee details added successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(null, Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// GETS THE EMPLOYEE ID OF THE LATEST INSERTED EMPLOYEE
        /// </summary>
        public Tuple<DateTime, String, int> returnLatestEmployeeEntry()
        {
            /* GUIDE
             * SELECT employeeID -- fetches employeeID only
             * FROM tbl_employees -- from this table
             * ORDER BY employeeID DESC -- make it descending order
             * LIMIT 1 -- get only the first entry (the highest employeeID value, and probably the latest of them all)
             */
            String query = dq.query[0];
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
        #endregion
        #region ACCOUNT SETTINGS
        public void addAccountInfo(string username, string password)
        {
            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(dq.querySettings[0], dbCon);
            dbCmd.Parameters.AddWithValue("@allowanceName", username);
            dbCmd.Parameters.AddWithValue("@password", password);
            dbCmd.Parameters.AddWithValue("@type", dp.accountTypes[0].ToString());
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
        }
        public void getAccountCredentials(String username, String password, DataGridView dtgvAccounts, bool checkedKeepMeLoggedIn)
        {
            // SETS THE keepLoggedIn, lastLoggedInUsername, lastLoggedInPassword, isSuperUser ON THE Setting.settings VALUES.
            /* ALGO
             * #1 Check if the passed allowanceName is a "Super User". If yes then set the correct value for the isSuperUser.
             * #2 Add the lastLoggedInUsername, add the lastLoggedInPassword
             * #3 Check the keepMeLoggedIn value 
             */
            dbOpen();

            // #2
            Properties.Settings.Default.isSuperUser = false;
            Properties.Settings.Default.lastLoggedInUsername = username;
            Properties.Settings.Default.lastLoggedInPassword = password;

            // #1
            foreach (DataGridViewRow rowItem in dtgvAccounts.Rows) // LOOPS IN THE DTGV ACCOUNT DTGV
            {
                string accountUsernameValue = rowItem.Cells[1].Value.ToString(); // USERNAME IN THE DATAGRIDVIEW
                string accountTypeValue = rowItem.Cells[3].Value.ToString(); // ACCOUNT TYPE IN THE DATAGRIDVIEW

                string superUser = dp.accountTypes[1].ToString();

                if ((String.Compare(accountUsernameValue, username) == 0) && (String.Compare(superUser, accountTypeValue) == 0)) // IF SAME USERNAME WHO LOGGED ON AND SAME "Super User" VALUE ON THE DATAGRIDVIEW
                {
                    // #2 CHANGE PROPER SETTINGS HERE
                    Properties.Settings.Default.isSuperUser = true; // CHECK THE SUPERUSER
                    Console.WriteLine("The logged person was an admin.");
                    break; // IF THEY ARE THE SAME THEN EXIT IMMEDIATELY
                }
                else
                {
                }
            }
            // #3
            if (checkedKeepMeLoggedIn == true)
            {
                Properties.Settings.Default.keepLoggedIn = true;
            }
            else
            {
                Properties.Settings.Default.keepLoggedIn = false;
            }
            dbClose();
        }
        public void deleteAccountInfo(int accountID)
        {
            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(dq.querySettings[1], dbCon);
            dbCmd.Parameters.AddWithValue("@ID", accountID);
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
        } 
        #endregion
        #region LEAVE
        public void addLeave(string employeeID, int deductionValue, string mode)
        {
            // UPDATE fireon.tbl_employee_details SET leaveSickLeave = leaveSickLeave - 10 WHERE idtbl_employee_details = 70;
            string leaveTypeQuery = dq.queryLeave[0];

            switch (mode)
            {
                case "sick":
                    leaveTypeQuery = dq.queryLeave[0];
                    break;
                case "vacation":
                    leaveTypeQuery = dq.queryLeave[1];
                    break;
                case "maternity":
                    leaveTypeQuery = dq.queryLeave[2];
                    break;
                default:
                    break;
            }

            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(leaveTypeQuery, dbCon);
            dbCmd.Parameters.AddWithValue("@employeeID", int.Parse(employeeID));
            dbCmd.Parameters.AddWithValue("@deductionValue", deductionValue);
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
            Console.WriteLine(employeeID + " " + deductionValue.ToString() + " " + mode);
        } 
        #endregion
        #region OVERTIME
        public void addOvertime(string employeeID, int overtimeValue)
        {
            // UPDATE fireon.tbl_employee_details SET overtimeAdditionalHours = overtimeAdditionalHours - 10 WHERE idtbl_employee_details = 70;
            string overtimeQuery = dq.queryOvertime[0];

            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(overtimeQuery, dbCon);
            dbCmd.Parameters.AddWithValue("@employeeID", int.Parse(employeeID));
            dbCmd.Parameters.AddWithValue("@overtimeValue", overtimeValue);
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
            Console.WriteLine(employeeID + " " + overtimeValue.ToString());

        } 
        #endregion
        #region HOLIDAY
        public void addHoliday(string employeeID, int percentage)
        {
            string holidayQuery = dq.queryHoliday[0];

            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(holidayQuery, dbCon);
            dbCmd.Parameters.AddWithValue("@employeeID", int.Parse(employeeID));
            dbCmd.Parameters.AddWithValue("@percentage", percentage * .01);
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
            Console.WriteLine(employeeID + " " + percentage.ToString());
        }
        #endregion
        #region VIOLATION
        public void addViolation(string employeeID, int violationValue)
        {
            string violationQuery = dq.queryViolation[0];

            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(violationQuery, dbCon);
            dbCmd.Parameters.AddWithValue("@employeeID", int.Parse(employeeID));
            dbCmd.Parameters.AddWithValue("@violationValue", violationValue);
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
            Console.WriteLine(employeeID + " " + violationValue.ToString());
        } 
        #endregion
        #region CASH ADVANCE
        public void addCashAdvance(string employeeID, int cashAdvanceValue)
        {
            // UPDATE fireon.tbl_employee_details SET leaveSickLeave = leaveSickLeave - 10 WHERE idtbl_employee_details = 70;
            string cashAdvanceQuery = dq.queryCashAdvance[0];

            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(cashAdvanceQuery, dbCon);
            dbCmd.Parameters.AddWithValue("@employeeID", int.Parse(employeeID));
            dbCmd.Parameters.AddWithValue("@cashAdvanceValue", cashAdvanceValue);
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
            Console.WriteLine(employeeID + " " + cashAdvanceValue.ToString());
        } 
        #endregion
        #region DEDUCTION
        public void addDeduction(string deductionName, string deductionPercentage)
        {
            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(dq.queryDeduction[1], dbCon);
            dbCmd.Parameters.AddWithValue("@deductionName", deductionName);
            dbCmd.Parameters.AddWithValue("@deductionPercentage", double.Parse(deductionPercentage));
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
        }
        public void deleteDeduction(string deductionID)
        {
            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(dq.queryDeduction[2], dbCon);
            dbCmd.Parameters.AddWithValue("@ID", int.Parse(deductionID));
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
        } 
        #endregion
        #region ALLOWANCE
        public void addAllowance(string allowanceName, string allowanceAmount)
        {
            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(dq.queryAllowance[1], dbCon);
            dbCmd.Parameters.AddWithValue("@allowanceName", allowanceName);
            dbCmd.Parameters.AddWithValue("@allowanceAmount", int.Parse(allowanceAmount));
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
        }
        public void deleteAllowance(string allowanceID)
        {
            dbOpen();
            MySqlCommand dbCmd = new MySqlCommand(dq.queryAllowance[2], dbCon);
            dbCmd.Parameters.AddWithValue("@ID", int.Parse(allowanceID));
            dbCmd.ExecuteNonQuery(); // EXECUTE
            dbClose();
        } 
        #endregion
        #region PRINT
        public String getEmployeeDetailsBasedOnCurrentFilters(String theFinalQuery)
        {
            /* ALGO
             * 1. PUT THE theFinalQuery IN A DataTable BUT MODIFY THE QUERY SO THAT ONLY THE employeeID WOULD BE STORED
             * 2. CREATE A NEW QUERY THAT WILL SELECT FROM THE tbl_employee_details BASED ON THAT DataTable CONTENTS REGARDING employeeID
             * 3. BY THAT WAY, THE PROGRAM WILL SHOW THE tbl_employee_details RECORDS BASED ON EMPLOYEE FILTERS (employeeStatus, employeeDepartment, employeePosition, month, and year)
             * TARGET OUTPUT SAMPLE: SELECT * FROM tbl_employee_details WHERE idtbl_employee_details IN(77,78,79,80);
             */
            String employeeDetailsBasedOnFiltersQuery = dq.queryEmployeeDetails[2];

            // #1

            dbOpen();

            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(theFinalQuery, dbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED

            dbClose();

            // EVALUATE HERE IF dbDataTable HAS ENTRIES, IF YES THEN PROCEED ELSE RETURN THE RAW STIRNG;
            if (dbDataTable.Rows.Count == 0)
            {
                return employeeDetailsBasedOnFiltersQuery; // IMMEDIATELY EXIT THIS FUNCTION AND RETURN RAW QUERY
            }
            else
            {
                Console.WriteLine("dbDataTableRow count is {0}", dbDataTable.Rows.Count.ToString());
                employeeDetailsBasedOnFiltersQuery = String.Concat(employeeDetailsBasedOnFiltersQuery, " WHERE idtbl_employee_details IN(");

                // #2 LOOP THRU EACH employeeID ENTRY AND INSERT THEM ON THE QUERY.

                int count = 0;
                foreach (DataRow x in dbDataTable.Rows)
                {
                    // APPENDS employeeID ON THIS QUERY
                    string employeeID = String.Concat(dbDataTable.Rows[count].Field<int>(0).ToString(), ", ");
                    Console.WriteLine(employeeID);
                    employeeDetailsBasedOnFiltersQuery = string.Concat(employeeDetailsBasedOnFiltersQuery, employeeID);
                    count++;
                }
                // TRIM THE EXCESS ", "
                employeeDetailsBasedOnFiltersQuery = employeeDetailsBasedOnFiltersQuery.Remove(employeeDetailsBasedOnFiltersQuery.Length - 2, 2);
                // APPEND THE ");"
                employeeDetailsBasedOnFiltersQuery = String.Concat(employeeDetailsBasedOnFiltersQuery, ");");
                Console.WriteLine(employeeDetailsBasedOnFiltersQuery);
                return employeeDetailsBasedOnFiltersQuery;
            }
        } 
        #endregion
    }
}
