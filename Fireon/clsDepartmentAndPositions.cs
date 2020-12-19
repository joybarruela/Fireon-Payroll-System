using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireon
{
    /// <summary>
    /// THIS CLASS IS FOR THE DEFAULT VALUES OF THE DEPARTMENT AND VALUES
    /// </summary>
    class clsDepartmentAndPositions
    {
        static int inceptionDate = int.Parse(Properties.Resources.int_inception_date);
        // ALL YEARS
        public String[] countYears()
        {
            List<String> yearsList = new List<String>(); // CREATES A LIST SO THAT ITEMS COULD BE ADDED UNLIKE THE ARRAY, BUT WE'LL CONVERT TO THAT LATER.
            for (int i = inceptionDate; i <= DateTime.Today.Year; i++) // LOOP THRU INCEPTION DATE (IN THIS CASE 2020) TO CURRENT YEAR AND ADD EACH ITEM ON THE LIST.
            {
                yearsList.Add(i.ToString());
            }
            String[] yearsArray = yearsList.ToArray(); // CONVERT THE LIST TO ARRAY TO BE USED BY THE YEAR LISTBOX
            return yearsArray;
        }
        // ALL EMPLOYEE STATUS
        public object[] employeeStatus = {
        "Contractual",
        "Regular"
        };
        // ALL DEPARTMENTS
        public object[] departments = {
        "Administrative",
        "Customer Service",
        "Finance",
        "Human Resource",
        "Information Technology",
        "Legal",
        "Marketing",
        "Operation",
        "Production",
        "Purchasing",
        "Research and Development",
        "Sales"
        };
        // ALL MONTHS
        public object[] months = {
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"
        };
        // ALL AVAILABLE POSITIONS
        public object[] posAdministrative = {
        "Administrative Manager",
        "Administrative Assistant Director",
        "Administrative Coordinator",
        "Administrative Director",
        "Administrative Specialist",
        "Administrator",
        "Secretary",
        "Services Manager"
        };
        public object[] posCustomerService = {
        "Call Center Customer Support",
        "Customer Care Operator",
        "Customer Experience Specialist",
        "Customer Interaction Management Specialist",
        "Customer Service Agent",
        "Customer Support Associate",
        "Retail Associate",
        "Telephone Support Specialist"
        };
        public object[] posFinance = {
        "Accountant",
        "Assistant Accountant",
        "Auditor",
        "Finance Clerk",
        "Financial Advisor Assistant",
        "Financial Analyst",
        "Payroll Assistant",
        "Payroll Clerk",
        "Purchasing Clerk"
        };
        public object[] posHumanResource = {
        "Human Resource Administrator",
        "Human Resource Analyst",
        "Human Resource Assistant",
        "Human Resource Associate",
        "Human Resource Director",
        "Human Resource Generalist",
        "Human Resource Manager",
        "Human Resource Representative",
        "Human Resource Specialist",
        "Human Resource Supervisor"
        };
        public object[] posInformationTechnology = {
        "Application Developer",
        "Database Administrator",
        "IT Director",
        "IT Support Specialist",
        "IT Technician",
        "Network Administrator",
        "Security Specialist",
        "System Analyst",
        "Web Developer"
        };
        public object[] posLegal = {
        "Arbitrator",
        "Attorney",
        "Case Manager",
        "Jury Consultant",
        "Law Firm Administrator",
        "Legal Analyst",
        "Legal Services Director"
        };
        public object[] posMarketing = {
        "Communication Manager",
        "Marketing Consultant",
        "Marketing Director",
        "Marketing Manager",
        "Product Manager"
        };
        public object[] posOperation = {
        "Facilities Coordinator",
        "Logistics Manager",
        "Operations Analyst",
        "Operations Assistant",
        "Operations Manager",
        "Operations Supervisor"
        };
        public object[] posProduction = {
        "Assembler",
        "Machinist",
        "Mechatronic Engineer",
        "Product Designer",
        "Production Manager",
        "Quality Control Inspector",
        "Robotics Technician",
        };
        public object[] posPurchasing = {
        "Materials Manager",
        "Production Planner",
        "Purchasing Agent",
        "Purchasing Assistant",
        "Purchasing Clerk",
        "Purchasing Director",
        "Purchasing Manager",
        "Purchasing Supervisor"
        };
        public object[] posResearchAndDevelopment = {
        "R&D Manager",
        "R&D Specialist",
        "R&D Supervisor",
        "Research Assistant"
        };
        public object[] posSales = {
        "Sales Account Executive",
        "Sales Account Manager",
        "Sales Collection Agent",
        "Sales Consultant",
        "Sales Manager",
        "Sales Representative"
        };
    }
}
