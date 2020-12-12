using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // FOR READING DataTable OBJECT.
using System.Windows.Forms; // FOR READING DataGridView OBJECT.
using MySql.Data.MySqlClient; // FOR MySQL CONNECTION. THIS IS A PREREQUISITE.

namespace Fireon
{
    /// <summary>
    /// VIBIESCA
    /// THE MAIN FUNCTION OF THIS CLASS FILE IS TO HANDLE ALL THE DATABASE OPERATIONS.
    /// IN CASE THAT YOU WANT TO COMMUNICATE WITH THE DATABASE, JUST CREATE AN INSTANCE OF THIS CLASS.
    /// </summary>
    class clsDatabaseFunctions
    {
        // THE CONNECTION STRING. REFER TO THE PROPERTIES TO SEE THE CONNECTION STRING. FOR FORMALITY, AS MUCH AS POSSIBLE, WE SHOULD PUT ALL DEFAULT STRINGS ON THE RESOURCES PANEL.
        static string dbConnectionString = Properties.Resources.db_connection_string;
        // dbCon WILL BE YOUR MYSQL CONNECTION INSTANCE. WE WILL PUT NEW MySqlConnection TO OUR dbCon OBJECT.
        static MySqlConnection dbCon= new MySqlConnection(dbConnectionString);


        /// <summary>
        /// VIBIESCA
        /// THIS METHOD VALIDATES THE USERNAME AND PASSWORD ENTERED ON LOGIN. WILL RETURN TRUE IF LOGIN CREDENTIALS MATCH.
        /// </summary>
        /// <param name="username">USUALLY txtbx_username.GetText();</param>
        /// <param name="password">USUALLY txtbx_pw.GetText();</param>
        public bool dbLogin(string username, string password)
        {
            /* ALGORITHM
             * #1 LOOP THRU THE DATABASE TABLE OF ACCOUNTS AND SEE IF THERE IS A MATCHING USERNAME VS. WHAT'S ON THE LOGIN USERNAME TEXTBOX.
             * #2 IF THE LOOP FINDS A MATCHING USERNAME, THEN COMPARE THAT DATABASE ENTRY PASSWORD VS. WHAT'S ON THE LOGIN PASSWORD TEXTBOX.
             * #3 IF NO USERNAME FOUND AT ALL OR PASSWORD MISMATCH THEN PROMPT A MESSAGE AND DECREMENT BY 1 THE TRY COUNTER (WHEN 0, MEANS AUTOMATICALLY CLOSE PROGRAM).
             */
            dbOpen(); // OPEN THE CONNECTION.

            DataSet dbDataSet = new DataSet(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER.
            MySqlCommand dbCmd = new MySqlCommand("SELECT * FROM tbl_account", dbCon); // PASSING QUERY AND CONNECTION HERE.
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataSet); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED.

            // THIS PART IS TO LOOP FOR EACH ITEM IN OUR dbDataSet DataSet.
            int row = 0;
            foreach (DataRow rowItem in dbDataSet.Tables[0].Rows)
            {
                // THIS IS COMPARING 2 STRINGS BETWEEN
                // "dbDataSet.Tables[0].Rows[row].ItemArray[1].ToString()" << WHICH IS THE USERNAME ON THE DATASET
                // "username" << WHICH IS THE PASSED STRING IN THIS METHOD.
                // THE "String.Compare" RETURNS 0 IF BOTH STRINGS ARE THE SAME, HENCE "== 0"
                // ItemArray[1] IS THE accountUsername FIELD ON THE DATABASE. ItemArray[2] IS THE accountPassword.
                if (String.Compare(dbDataSet.Tables[0].Rows[row].ItemArray[1].ToString(), username) == 0)
                {
                    // IF THERE HAPPENS TO HAVE A MATCHING USERNAME ON THE DATASET, THEN IT'S NOW TIME TO COMPARE FOR THE PASSWORD.
                    if (String.Compare(dbDataSet.Tables[0].Rows[row].ItemArray[2].ToString(), password) == 0)
                    {
                        // USERNAME AND PASSWORD ARE CORRECT.
                        dbClose(); // CLOSE THE CONNECTION.
                        return true; // ESCAPE OUT OF THE PROGRAM.
                    }
                }
                row++; // INCREMENT EACH ROW TO KEEP FINDING A MATCHING USERNAME.
            }
            // IF THERE HAPPENED TO BE NO MATCHING USERNAME AND PASSWORD ABOVE, THEN SHOW THIS.
            dbClose(); // CLOSE THE CONNECTION.
            return false; // RETURN FALSE IF PROGRAM DID NOT FIND A MATCHING CREDENTIALS.
        }
        /// <summary>
        /// VIBIESCA
        /// THIS METHOD TAKES A QUERY, LIKE SELECT * FROM tbl_accounts, AND PUTS IT IN A DataGridView OBJECT.
        /// </summary>
        /// <param name="query">PASS THE QUERY FROM WHICH FUNCTION IT WAS CALLED</param>
        /// <param name="dgv">THE DataGridView THAT WE CHOOSE TO PUT OUR DATA.</param>
        public void dbRead(string query, DataGridView dgv){
            dbOpen(); // OPEN THE CONNECTION.

            DataTable dbDataTable= new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER.
            MySqlCommand dbCmd = new MySqlCommand(query, dbCon); // PASSING QUERY AND CONNECTION HERE.
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED.
            dgv.DataSource = dbDataTable; // WE WILL CHANGE THE DGV DATA SOURCE WHERE WE CALLED THAT FUNCTION.

            dbClose(); // CLOSE THE CONNECTION.
        }
        /// <summary>
        /// VIBIESCA
        /// THIS METHOD OPENS THE DATABASE CONNECTION
        /// </summary>
        private void dbOpen()
        {
            // THIS IF CONDITIONAL MEANS THAT IF THE DATABASE CONNECTION IS CLOSED, THEN OPEN IT USING THE Open(); METHOD.
            if (dbCon.State == System.Data.ConnectionState.Closed)
            {
                dbCon.Open();
            }
        }
        /// <summary>
        /// VIBIESCA
        /// THIS METHOD CLOSES THE DATABASE CONNECTION
        /// </summary>
        private void dbClose()
        {
            // THIS IF CONDITIONAL MEANS THAT IF THE DATABASE CONNECTION IS OPEN, THEN CLOSE IT USING THE Close(); METHOD.
            if (dbCon.State == System.Data.ConnectionState.Open)
            {
                dbCon.Close();
            }
        }
        /// <summary>
        /// VIBIESCA
        /// TEMPLATE FUNCTION FOR YOU TO USE. IT COPIPES 1 FILE FROM 1 PLACE TO ANOTHER.
        /// </summary>
        /// <param name="fileName">PASS THE FILENAME HERE</param>
        /// <param name="sourcePath">PASS THE SOURCE LOCATION OF THAT FILE</param>
        /// <param name="targetPath">PASS THIS THE LOCATION WHERE U WANNA PUT IT</param>
        public void copyFile(string fileName, string sourcePath, string targetPath)
        {
            try
            {
                string fileName1 = System.IO.Path.GetFileName(fileName); // GETS THE NAME OF SELECTED FILE
                string sourcePath1 = System.IO.Path.GetDirectoryName(fileName); // GETS THE DIRECTORY OF SELECTED FILE
                //targetPath = @"C:\Users\Public\Public Desktop\TestFolder";

                string sourceFile = System.IO.Path.Combine(sourcePath1, fileName1); // COMBINE
                string destFile = System.IO.Path.Combine(targetPath, fileName1); // COMBINE

                System.IO.Directory.CreateDirectory(targetPath); // CREATES A DIRECTORY ON THE TARGET PATH, IF THERE IS ALREADY THEN ABORT FILE CREATION
                System.IO.File.Copy(sourceFile, destFile, true); // TRIES TO COPY THE FILE
            }
            catch (Exception e)
            {
                MessageBox.Show(Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
