using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireon.Classes
{
    /// <summary>
    /// CONTAINS ALL THE POSSIBLE DATABASE QUERIES INSIDE THE PROGRAM
    /// </summary>
    class clsDatabaseQueries
    {
        // EMPLOYEE
        public string[] queryEmployee = { 
        @"SELECT * FROM tbl_employee",
        @"INSERT INTO tbl_employee(employeeFirstName, employeeMiddleInitial, employeeLastName, employeeSex, employeeContactNumber, employeeEmailAddress, employeeHomeAddress, employeeBirthDate, employeeMaritalStatus, employeeNationality, employeeDepartment, employeePosition, employeeStatus, employeeWorkingHours, employeeHourlyRate, employeeContractDuration, employeePaymentMode, employeeImageLocation, employeeDateEmployed) VALUES(@employeeFirstName, @employeeMiddleInitial, @employeeLastName, @employeeSex, @employeeContactNumber, @employeeEmailAddress, @employeeHomeAddress, @employeeBirthDate, @employeeMaritalStatus, @employeeNationality, @employeeDepartment, @employeePosition, @employeeStatus, @employeeWorkingHours, @employeeHourlyRate, @employeeContractDuration, @employeePaymentMode, @employeeImageLocation, @employeeDateEmployed)",
        @"SELECT employeeID FROM tbl_employee",
        @"",
        };
        // LEAVE
        public string[] queryLeave = {
        @"UPDATE fireon.tbl_employee_details SET leaveSickLeave = leaveSickLeave - @deductionValue WHERE idtbl_employee_details = @employeeID",
        @"UPDATE fireon.tbl_employee_details SET leaveVacationLeave = leaveVacationLeave - @deductionValue WHERE idtbl_employee_details = @employeeID",
        @"UPDATE fireon.tbl_employee_details SET leaveMaternityLeave = leaveMaternityLeave - @deductionValue WHERE idtbl_employee_details = @employeeID",
        @"",
        };
        // OVERTIME
        public string[] queryOvertime = {
        @"UPDATE fireon.tbl_employee_details SET overtimeAdditionalHours = overtimeAdditionalHours + @overtimeValue WHERE idtbl_employee_details = @employeeID",
        @"",
        @"",
        @"",
        @"",
        };
        // HOLIDAY
        public string[] queryHoliday = {
        @" UPDATE fireon.tbl_employee_details 
           SET holidayHolidayPay = holidayHolidayPay + ((SELECT employeeHourlyRate FROM tbl_employee ORDER BY employeeID DESC LIMIT 1) * @percentage) 
           WHERE idtbl_employee_details = @employeeID;",
        @"",
        @"",
        @"",
        };
        // VIOLATION
        public string[] queryViolation = {
        @"UPDATE fireon.tbl_employee_details SET violationViolationAmount = violationViolationAmount + @violationValue WHERE idtbl_employee_details = @employeeID",
        @"",
        @"",
        @"",
        };
        // CASH ADVANCE
        public string[] queryCashAdvance = {
        @"UPDATE fireon.tbl_employee_details SET cashAdvanceAmount = cashAdvanceAmount - @cashAdvanceValue WHERE idtbl_employee_details = @employeeID",
        @"",
        @"",
        };
        // DEDUCTION
        public string[] queryDeduction = { 
        @"SELECT * FROM tbl_deduction",
        @"INSERT INTO tbl_deduction(deductionName, deductionPercentage) VALUES(@deductionName, @deductionPercentage)",
        @"DELETE FROM tbl_deduction WHERE deductionID = @ID",
        @"",
        };
        // ALLOWANCE
        public string[] queryAllowance = { 
        @"SELECT * FROM tbl_allowance",
        @"INSERT INTO tbl_allowance(allowanceName, allowanceAmount) VALUES(@allowanceName, @allowanceAmount)",
        @"DELETE FROM tbl_allowance WHERE allowanceID = @ID",
        @"",
        };
        // EMPLOYEE DETAILS
        public string[] queryEmployeeDetails = { 
        @"SELECT * FROM tbl_employee_details",
        @"INSERT INTO tbl_employee_details(leaveSickLeave, leaveVacationLeave, leaveMaternityLeave, cashAdvanceAmount, idtbl_employee_details) VALUES(@SickLeave, @VacationLeave, @MaternityLeave, @AdvanceAmount, (SELECT employeeID FROM fireon.tbl_employee WHERE employeeID = (SELECT employeeID FROM tbl_employee ORDER BY employeeID DESC LIMIT 1)));",
        @"SELECT * FROM tbl_employee_details",
        @"",
        @"",
        };
        // SETTINGS
        public string[] querySettings = { 
        @"INSERT INTO tbl_account(accountUsername, accountPassword, accountType) VALUES(@allowanceName, @password, @type)",
        @"DELETE FROM tbl_account WHERE accountID = @ID",
        @"",
        };
        // ACCOUNT
        public string[] queryAccount = { 
        @"SELECT * FROM tbl_account",
        @"SELECT accountID, accountUsername, accountType FROM tbl_account",
        @"",
        @"",
        };
        public string[] query = { 
        "SELECT employeeDateEmployed, employeeLastName, employeeID FROM tbl_employee ORDER BY employeeID DESC LIMIT 1",
        "",
        "",
        "",
        };
    }
}
