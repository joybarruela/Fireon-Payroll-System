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
        public void computeBasicSalary(int employeeID)
        {

            //* (e) BASIC SALARY         = (c * d)           tbl_employee_details.payrollBasicSalary = (tbl_employee_details.payrollTotalWorkingHours * tbl_employee.employeeHourlyRate)

            string query = @"
            UPDATE fireon.tbl_employee_details 
            SET payrollBasicSalary = (
            (SELECT tbl_employee_details.payrollTotalWorkingHours WHERE idtbl_employee_details = @employeeID)
            * 
            (SELECT fireon.tbl_employee.employeeHourlyRate FROM fireon.tbl_employee WHERE employeeID = @employeeID))
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen(); // OPEN THE CONNECTION
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // INJECTS THE QUERY ON THE COMMAND 
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.ExecuteNonQuery(); // EXECUTE
            db.dbClose(); // CLOSE THE CONNECTION
        }
        public void computeTotalDeduction(int employeeID)
        {
            /* ALGO
             * GET VIOLATION
             * GET DEDUCTION
             * GET CASH ADVANCE
             * INSERT THEM ON THE DATABASE
             */

            int violationAmount = getViolation(employeeID);
            int deductionAmount = getDeduction(employeeID);
            int cashAdvanceAmount = getCashAdvance(employeeID);
            int totalDeductionAmount = (violationAmount + deductionAmount + cashAdvanceAmount);

            string query = @"
            UPDATE fireon.tbl_employee_details 
            SET payrollTotalDeduction = @totalDeductionAmount
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen(); // OPEN THE CONNECTION
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // INJECTS THE QUERY ON THE COMMAND 
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.Parameters.AddWithValue("@totalDeductionAmount", totalDeductionAmount); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.ExecuteNonQuery(); // EXECUTE
            db.dbClose(); // CLOSE THE CONNECTION
        }
        public void computeTotalAddition(int employeeID)
        {
            /* ALGO
             * GET ALLOWANCE
             * GET HOLIDAY
             * INSERT THEM ON THE DATABASE
             */

            int allowanceAmount = getAllowance();
            int holidayAmount = getHoliday(employeeID);
            int totalAdditionAmount = (allowanceAmount + holidayAmount);

            string query = @"
            UPDATE fireon.tbl_employee_details 
            SET payrollTotalAddition= @totalAdditionAmount
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen(); // OPEN THE CONNECTION
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // INJECTS THE QUERY ON THE COMMAND 
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.Parameters.AddWithValue("@totalAdditionAmount", totalAdditionAmount); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.ExecuteNonQuery(); // EXECUTE
            db.dbClose(); // CLOSE THE CONNECTION
        }
        public void computeNetPay(int employeeID)
        {
            string query = @"
            UPDATE fireon.tbl_employee_details 
            SET payrollNetPay = 
            ((SELECT tbl_employee_details.payrollBasicSalary WHERE idtbl_employee_details = @employeeID)
            + 
            (SELECT tbl_employee_details.payrollTotalAddition WHERE idtbl_employee_details = @employeeID))
            -
            (SELECT tbl_employee_details.payrollTotalDeduction WHERE idtbl_employee_details = @employeeID)

            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen(); // OPEN THE CONNECTION
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // INJECTS THE QUERY ON THE COMMAND 
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            dbCmd.ExecuteNonQuery(); // EXECUTE
            db.dbClose(); // CLOSE THE CONNECTION
        }
        #region DEDUCTIONS
        public int getViolation(int employeeID)
        {
            int violationAmount = 0;

            string query = @"
            SELECT violationViolationAmount 
            FROM fireon.tbl_employee_details
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();

            violationAmount = dbDataTable.Rows[0].Field<int>(0); // GETS THAT 1 CELL WHERE THE VIOLATION AMOUNT IS CALLED

            return violationAmount;
        }
        public int getCashAdvance(int employeeID)
        {
            int cashAdvanceAmount = 0;

            string query = @"
            SELECT cashAdvanceAmount 
            FROM fireon.tbl_employee_details
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();

            /* FORMULA
             * int.Parse(Properties.Resources.int_cash_advance) IS THE 5000 DEFAULT CASH ADVANCE VALUE
             * dbDataTable.Rows[0].Field<int>(0) IS THE CURRENT CASH ADVANCE VALUE
             * SUBTRACT DEFAULT VALUE FROM THE CURRENT VALUE OF CASH ADVANCE YOU WILL GET THE CASH ADVANCE DEDUCTION
             */
            cashAdvanceAmount = (int.Parse(Properties.Resources.int_cash_advance) - dbDataTable.Rows[0].Field<int>(0));

            return cashAdvanceAmount;
        }
        public int getBasicSalary(int employeeID)
        {
            int basicSalaryAmount = 0;

            string query = @"
            SELECT payrollBasicSalary 
            FROM fireon.tbl_employee_details
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();

            basicSalaryAmount = dbDataTable.Rows[0].Field<int>(0);

            return basicSalaryAmount;
        }
        public int getDeduction(int employeeID)
        {
            double deductionPercentage = 0.00F;
            int basicSalaryAmount = getBasicSalary(employeeID);
            int deductionAmount = 0; // payrollBasicSalary * deductionPercentage

            string query = @"
            SELECT ROUND(SUM(deductionPercentage), 2)
            FROM fireon.tbl_deduction;
            ";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose(); 

            deductionPercentage = dbDataTable.Rows[0].Field<double>(0); // GETS THAT 1 CELL WHERE THE TOTAL DEDUCTION AMOUNT IS CALLED
            /* FORMULA
             * (deductionPercentage / 100) *  basicSalaryAmount
             */
            try
            {
                deductionAmount = (int)((deductionPercentage / 100) * basicSalaryAmount); // GETS THE DEDUCTED AMOUNT FROM THE BASIC SALARY
            }
            catch (Exception e)
            {
                deductionAmount = 0;
                Console.WriteLine(e.Message.ToString());
            }

            return deductionAmount;
        } 
        #endregion
        #region ADDITIONS
        public int getHoliday(int employeeID)
        {
            int holidayAmount = 0;

            string query = @"
            SELECT holidayHolidayPay 
            FROM fireon.tbl_employee_details
            WHERE idtbl_employee_details = @employeeID;
            ";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            dbCmd.Parameters.AddWithValue("@employeeID", employeeID); // ADDS THE employeeID FROM THE PASSED VALUE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();

            holidayAmount = dbDataTable.Rows[0].Field<int>(0); // GETS THAT 1 CELL WHERE THE VIOLATION AMOUNT IS CALLED

            return holidayAmount;
        }
        public int getAllowance()
        {
            int allowanceAmount = 0;

            string query = @"
            SELECT SUM(allowanceAmount)
            FROM fireon.tbl_allowance;
            ";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();
            try
            {
                allowanceAmount = (int)dbDataTable.Rows[0].Field<decimal>(0); // GETS THAT 1 CELL WHERE THE TOTAL ALLOWANCE AMOUNT IS CALLED
            }
            catch (Exception e)
            {
                allowanceAmount = 0;
                Console.WriteLine(e.Message.ToString());
            }
            return allowanceAmount;
        } 
        #endregion





        public void computePayroll()
        {
            /* ALGORITHM
             * LOOPS THROUGH EACH ENTRY OF THE tbl_employee_details
             * COMPUTES PAYROLL
             */

            string query = @"SELECT idtbl_employee_details FROM fireon.tbl_employee_details";

            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();

            int count = 0;
            foreach (DataRow entry in dbDataTable.Rows)
            {
                Console.WriteLine("Payroll computing for Employee ID: " + dbDataTable.Rows[count].Field<int>(0).ToString());
                computeTotalWorkingHours(dbDataTable.Rows[count].Field<int>(0)); // PASSES EACH idtbl_employee_details FOR computeTotalWorkingHours COMPUTATION
                computeBasicSalary(dbDataTable.Rows[count].Field<int>(0));
                computeTotalDeduction(dbDataTable.Rows[count].Field<int>(0));
                computeTotalAddition(dbDataTable.Rows[count].Field<int>(0));
                computeNetPay(dbDataTable.Rows[count].Field<int>(0));
                // OTHER FUNC HERE
                // OTHER FUNC HERE
                // OTHER FUNC HERE
                count++;
            }
            Console.WriteLine("Payroll Computed");
        }
    }
}
