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
    class clsDashboard
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();

        public void retrieveDashboardStatistics(
            Label lblTotalEmployeesCount,
            Label lblTotalMaleCount,
            Label lblTotalFemaleCount,
            Label lblTotalContractualCount,
            Label lblTotalRegularCount,
            Label lblAdministrativeCount,
            Label lblCustomerServiceCount,
            Label lblFinanceCount,
            Label lblHumanResourceCount,
            Label lblInformationTechnologyCount,
            Label lblLegalCount,
            Label lblMarketingCount,
            Label lblOperationCount,
            Label lblProductionCount,
            Label lblPurchasingCount,
            Label lblResearchAndDevelopmentCount,
            Label lblSalesCount)
        {
            /* ALGORITHM
             * THIS FUNCTION GETS THE NECESSARY DATA AND SENDS IT BACK TO THE LABELS
             * THINGS TO ACQUIRE FROM THE DATABASE ARE:
             * a. total number of employees
             * b. male and female count
             * c. employee statuses
             * d. department categories and count
             */

            // TOTAL # OF EMPLOYEES
            DataTable dtTotalEmployeesCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee;");
            lblTotalEmployeesCount.Text = dtTotalEmployeesCount.Rows[0].Field<object>(0).ToString();

            // SEX: MALE
            DataTable dtTotalMaleCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeSex = 'Male'");
            lblTotalMaleCount.Text = dtTotalMaleCount.Rows[0].Field<object>(0).ToString();

            // SEX: FEMALE
            DataTable dtTotalFemaleCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeSex = 'Female'");
            lblTotalFemaleCount.Text = dtTotalFemaleCount.Rows[0].Field<object>(0).ToString();

            // EMPLOYEE STATUS: CONTRACTUAL
            DataTable dtTotalContractualCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeStatus = 'Contractual'");
            lblTotalContractualCount.Text = dtTotalContractualCount.Rows[0].Field<object>(0).ToString();

            // EMPLOYEE STATUS: REGULAR
            DataTable dtTotalRegularCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeStatus = 'Regular'");
            lblTotalRegularCount.Text = dtTotalRegularCount.Rows[0].Field<object>(0).ToString();
            
            // DEPARTENT: Administrative
            DataTable dtAdministrativeCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Administrative'");
            lblAdministrativeCount.Text = dtAdministrativeCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Customer Service
            DataTable dtCustomerServiceCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Customer Service'");
            lblCustomerServiceCount.Text = dtCustomerServiceCount.Rows[0].Field<object>(0).ToString();
            // DEPARTENT: Finance
            DataTable dtFinanceCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Finance'");
            lblFinanceCount.Text = dtFinanceCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Human Resource
            DataTable dtHumanResourceCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Human Resource'");
            lblHumanResourceCount.Text = dtHumanResourceCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Information Technology
            DataTable dtInformationTechnologyCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Information Technology'");
            lblInformationTechnologyCount.Text = dtInformationTechnologyCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Legal
            DataTable dtLegalCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Legal'");
            lblLegalCount.Text = dtLegalCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Marketing
            DataTable dtMarketingCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Marketing'");
            lblMarketingCount.Text = dtMarketingCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Operation
            DataTable dtOperationCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Operation'");
            lblOperationCount.Text = dtOperationCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Production
            DataTable dtProductionCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Production'");
            lblProductionCount.Text = dtProductionCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Purchasing
            DataTable dtPurchasingCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Purchasing'");
            lblPurchasingCount.Text = dtPurchasingCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Research and Development
            DataTable dtResearchAndDevelopmentCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Research and Development'");
            lblResearchAndDevelopmentCount.Text = dtResearchAndDevelopmentCount.Rows[0].Field<object>(0).ToString();

            // DEPARTENT: Sales
            DataTable dtSalesCount = getParticularData("SELECT COUNT(employeeID) FROM fireon.tbl_employee WHERE employeeDepartment = 'Sales'");
            lblSalesCount.Text = dtSalesCount.Rows[0].Field<object>(0).ToString();
        }

        private DataTable getParticularData(String query)
        {
            db.dbOpen();
            DataTable dbDataTable = new DataTable(); // DataTable IS LIKE A LOGICAL TABLE CONTAINER OF DATA THAT WILL FILL IN LATER
            MySqlCommand dbCmd = new MySqlCommand(query, db.getDbCon); // PASSING QUERY AND CONNECTION HERE
            MySqlDataAdapter dbDataAdapter = new MySqlDataAdapter(dbCmd);
            dbDataAdapter.Fill(dbDataTable); // LET'S FILL OUR DataTable INSTANCE WITH THE QUERY WE REQUESTED
            db.dbClose();
            return dbDataTable;
        }
    }
}
