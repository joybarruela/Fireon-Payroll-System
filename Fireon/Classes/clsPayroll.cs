using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireon.Classes
{
    /// <summary>
    /// COMPUTES THE PAYROLL
    /// </summary>
    class clsPayroll
    {
        /* PAYROLL GETS CALLED WHENEVER
         * Print AREA OF THE SYSTEM SHOWS UP?
         */

        /* FORMULA AND PROCEDURE
         * (a) FIXED WORKING HOURS  =                   tbl_employee.employeeWorkingHours
         * (b) OVERTIME             =                   tbl_employee_details.overtimeAdditionalHours
         * (c) TOTAL WORKING HOURS  = (a + b)           tbl_employee_details.payrollTotalWorkingHours = (tbl_employee.employeeWorkingHours + tbl_employee_details.overtimeAdditionalHours)
         * (d) RATE PER HOUR        =                   tbl_employee.employeeHourlyRate
         * (e) BASIC SALARY         = (c * d)           tbl_employee_details.payrollBasicSalary = (tbl_employee_details.payrollTotalWorkingHours * tbl_employee.employeeHourlyRate)
         * (f) VIOLATION            =                   tbl_employee_details.violationViolationAmount
         * (g) CASH ADVANCE         =                   tbl_employee_details.cashAdvanceAmount = (Properties.Resources.int_cash_advance - tbl_employee_details.cashAdvanceAmount)
         * (h) DEDUCTION            =                   tbl_deduction (ADD ALL DEDUCTION deductionPercentage)
         * (i) HOLIDAY              =                   tbl_employee_details.holidayHolidayPay
         * (j) ALLOWANCE            =                   tbl_allowance (ADD ALL ALLOWANCE allowanceAmount)
         * (k) TOTAL DEDUCTIONS     = (f + g + h)
         * (l) TOTAL ADDITIONS      = (i + j)
         * (m) NET PAY              = ((e - k) + l)
         */

        /* ALGORITHM
         * 1. GET ALL ENTRIES ON tbl_employee_details
         * 2. LOOP ON THEM TO CALCULATE THE PAYROLL DETAILS
         */

        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();

        public void computeTotalWorkingHours(int employeeID)
        {
            // EXAMPLE GOAL

            //UPDATE fireon.tbl_employee_details 
            //SET payrollTotalWorkingHours = (
            //(SELECT fireon.tbl_employee.employeeWorkingHours FROM fireon.tbl_employee WHERE employeeID = 79)
            //+ 
            //(SELECT tbl_employee_details.overtimeAdditionalHours WHERE idtbl_employee_details = 79))
            //WHERE idtbl_employee_details = 79;

            string query = @"
            UPDATE fireon.tbl_employee_details 
            SET payrollTotalWorkingHours = (
            (SELECT fireon.tbl_employee.employeeWorkingHours FROM fireon.tbl_employee WHERE employeeID = @employeeID)
            + 
            (SELECT tbl_employee_details.overtimeAdditionalHours WHERE idtbl_employee_details = @employeeID))
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen(); // OPEN THE CONNECTION
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // INJECTS THE QUERY ON THE COMMAND 
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.ExecuteNonQuery(); // EXECUTE
            db.dbClose(); // CLOSE THE CONNECTION
        }

        
        
        
        

        public void computePayroll()
        {
            /* ALGORITHM
             * LOOPS THROUGH EACH ENTRY OF THE tbl_employee_details
             */

            db.dbOpen();
            string query = @"SELECT idtbl_employee_details FROM fireon.tbl_employee_details";

            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED

            int count = 0;
            foreach (DataRow entry in dbDataTable.Rows)
            {
                computeTotalWorkingHours(dbDataTable.Rows[count].Field<int>(0)); // PASSES EACH idtbl_employee_details FOR computeTotalWorkingHours COMPUTATION
                count++;
            }






            db.dbClose();
        }
    }
}
