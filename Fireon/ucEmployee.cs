using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    public partial class ucEmployee : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions(); // CREATE AN INSTANCE OF clsDatabaseFunctions.
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions(); // CREATE AN INSTANCE OF clsDepartmentAndPositions.
        #region TRIGGERS AND EVENTS
        /// <summary>
        /// VIBIESCA
        /// Default stuff
        /// </summary>
        public ucEmployee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// VIBIESCA
        /// EVERY TIME ucEmployee LOADS ONTO THE MEMORY, CALL DISPLAY USER CONTROL TO DISPLAY THE EMPLOYEE LIST
        /// </summary>
        private void ucEmployee_Load(object sender, EventArgs e)
        {
            displayUserControl("List Employee");
        }
        #endregion
        #region CUSTOM FUNCTIONS
        /// <summary>
        /// VIBIESCA
        /// TRIES TO ADD DATA FROM ucNewEmployee TO THE DATABASE
        /// </summary>
        private void addNewEmployee(UserControl reference)
        {
            /* ALGO
             * ACCESS THE ucNewEmployee FIRST
             * VALIDATE THE INPUT
             * INSERT THEM TO DATABASE
             */
            try
            {
                var ucNewEmployee = (ucNewEmployee)reference; // CAST THE PARAMETER TO A ucNewEmployee SO THAT THE SYSTEM COULD READ IT'S CONTENTS
                // VALIDATE THE INPUT
                // midddle initial is optional
                // (ucNewEmployee.picbDP.ImageLocation != null)
                // should not check for picture because user may leave it blank
                // birthdate no validation; it just depends on the user's stupidity

                if (ucNewEmployee.mcBirthdate.SelectionStart == DateTime.Today){
                    MessageBox.Show(null, "Validation fail.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((ucNewEmployee.rdbtnMale.Checked == false) && (ucNewEmployee.rdbtnFemale.Checked == false)){
                    MessageBox.Show(null, "Validation fail.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // if user selects regular, it's okay if the contract duration is blank
                // if user is contractual, contract duration should have input
                // this checks if the contractual (index of 0) is selected but no contract duration is present
                if ((ucNewEmployee.cmbxStatus.SelectedIndex == 0) && (ucNewEmployee.txtbxContractDuration.Text == String.Empty)){
                    MessageBox.Show(null, "Validation fail.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //ucNewEmployee.txtbxWorkingHours.Text.ToString()
                // handle the tryparse on these motherfucking stuff because contract duration is prone to being null or empty
                Int64 theFuckingContractDurationValue;
                Int64 theFuckingWorkingHoursValue;
                Int64 theFuckingHourlyRateValue;
                Int64 theFuckingContactValue;

                bool tryParseTheFuckingContractDurationResult = Int64.TryParse(ucNewEmployee.txtbxContractDuration.Text.ToString(), out theFuckingContractDurationValue);
                bool tryParseTheFuckingWorkingHoursResult = Int64.TryParse(ucNewEmployee.txtbxWorkingHours.Text.ToString(), out theFuckingWorkingHoursValue);
                bool tryParseTheFuckingHourlyRateResult = Int64.TryParse(ucNewEmployee.txtbxHourlyRate.Text.ToString(), out theFuckingHourlyRateValue);
                bool tryParseTheFuckingContactResult = Int64.TryParse(ucNewEmployee.txtbxContact.Text.ToString(), out theFuckingContactValue);

                if (tryParseTheFuckingContractDurationResult)
                {/*parse just got real*/}
                else
                { theFuckingContractDurationValue = 0; /*if there is no value*/}
                if (tryParseTheFuckingWorkingHoursResult)
                {/*parse just got real*/}
                else
                { theFuckingWorkingHoursValue = 0; /*if there is no value*/}
                if (tryParseTheFuckingHourlyRateResult)
                {/*parse just got real*/}
                else
                { theFuckingHourlyRateValue = 0; /*if there is no value*/}
                if (tryParseTheFuckingContactResult)
                {/*parse just got real*/}
                else
                { theFuckingContactValue = 0; /*if there is no value*/}

                if ((ucNewEmployee.txtbxFirstName.Text != String.Empty) &&
                    (ucNewEmployee.txtbxLastName.Text != String.Empty) &&
                    (ucNewEmployee.txtbxContact.Text.Length == 11) &&
                    (ucNewEmployee.txtbxEmail.Text != String.Empty) &&
                    (ucNewEmployee.txtbxAddress.Text != String.Empty) &&
                    (ucNewEmployee.cmbxMaritalStatus.SelectedIndex > -1) &&
                    (ucNewEmployee.txtbxNationality.Text != String.Empty) &&
                    (ucNewEmployee.cmbxDepartment.SelectedIndex > -1) &&
                    (ucNewEmployee.cmbxPosition.SelectedIndex > -1) &&
                    (ucNewEmployee.cmbxStatus.SelectedIndex > -1) &&
                    (ucNewEmployee.txtbxWorkingHours.Text != String.Empty) &&
                    (ucNewEmployee.txtbxHourlyRate.Text != String.Empty) &&
                    (ucNewEmployee.cmbxPaymentMode.SelectedIndex > -1))
                {
                    // TELL THEM THAT THE VALIDATION HAS SUCCEEDED
                    MessageBox.Show(null, "Validation succeded.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // INSERT THEM TO DATABASE
                    db.dbInsertEmployee(
                        ucNewEmployee.txtbxFirstName.Text,
                        ucNewEmployee.txtbxMiddleInitial.Text,
                        ucNewEmployee.txtbxLastName.Text,
                        ucNewEmployee.rdbtnMale.Checked == true ? "Male" : "Female",
                        theFuckingContactValue,
                        ucNewEmployee.txtbxEmail.Text,
                        ucNewEmployee.txtbxAddress.Text,
                        ucNewEmployee.mcBirthdate.SelectionStart,
                        ucNewEmployee.cmbxMaritalStatus.GetItemText(ucNewEmployee.cmbxMaritalStatus.SelectedItem),
                        ucNewEmployee.txtbxNationality.Text,
                        ucNewEmployee.cmbxDepartment.GetItemText(ucNewEmployee.cmbxDepartment.SelectedItem),
                        ucNewEmployee.cmbxPosition.GetItemText(ucNewEmployee.cmbxPosition.SelectedItem),
                        ucNewEmployee.cmbxStatus.GetItemText(ucNewEmployee.cmbxStatus.SelectedItem),
                        theFuckingWorkingHoursValue,
                        theFuckingHourlyRateValue,
                        theFuckingContractDurationValue,
                        ucNewEmployee.cmbxPaymentMode.GetItemText(ucNewEmployee.cmbxPaymentMode.SelectedItem),
                        ucNewEmployee.picbDP.ImageLocation,
                        DateTime.Today
                        );
                    displayUserControl("New Employee");
                }
                else
                {
                    MessageBox.Show(null, "Validation fail.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// VIBIESCA
        /// DISPLAY USER CONTROL
        /// </summary>
        public void displayUserControl(string name, string query = "SELECT * FROM tbl_employee", bool clearFilter = true)
        {
            switch (name)
            {
                case "New Employee":
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucNewEmployee ucNewEmployee = new ucNewEmployee(); // CREATES A NEW UserControl
                    ucNewEmployee.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucNewEmployee.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    pnlFilters.Hide();
                    btnSearch.Hide();
                    btnCancel.Show();
                    break;
                case "List Employee":
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucDataGridView ucDataGridView = new ucDataGridView(); // CREATES A NEW UserControl
                    ucDataGridView.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucDataGridView.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    // CHECK HERE FIRST IF QUERY IS EMPTY OR NOT
                    if (string.Compare(query,"SELECT * FROM tbl_employee") == 0)
                    {
                        // JUST DISPLAY ALL EMPLOYEE
                        db.dbRead("SELECT * FROM tbl_employee", ucDataGridView.theDataGridView); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                    }
                    else
                    {
                        // ACQUIRE THE CUSTOM QUERY
                        db.dbRead(query, ucDataGridView.theDataGridView);
                    }
                    pnlFilters.Show();
                    btnSearch.Show();
                    pnlSeparator2.Hide();
                    btnCancel.Hide();
                    displayAllAvailableYears();
                    if (clearFilter == false)
                    {

                    }
                    else
                    {
                        resetFilterComboBoxes();
                    }
                    break;
                default:
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucDataGridView ucDataGridViewDefault = new ucDataGridView(); // CREATES A NEW UserControl
                    ucDataGridViewDefault.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucDataGridViewDefault.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    db.dbRead("SELECT * FROM tbl_employee", ucDataGridViewDefault.theDataGridView); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                    pnlFilters.Show();
                    btnSearch.Show();
                    pnlSeparator1.Show();
                    btnCancel.Hide();
                    break;
            }
        }
        private void resetFilterComboBoxes()
        {
            // RESET STATE OF ALL CMBXes TO ALL
            cmbxRegularContractual.SelectedIndex = 0;
            cmbxDepartment.SelectedIndex = 0;
            cmbxPosition.SelectedIndex = 0;
            cmbxMonth.SelectedIndex = 0;
            cmbxYear.SelectedIndex = 0;
            txtbxSearch.Text = "Search";
            txtbxSearch.ForeColor = Color.Gray;
        }
        public void displayAllAvailableYears()
        {
            // MAKE A CODE TO DISPLAY ALL YEARS
            this.cmbxYear.Items.Clear(); // CLEAR ALL ITEMS FIRST
            // ADD THE "ALL" OPTION HERE
            cmbxYear.Items.Add((Object)"ALL");
            // LOOP THRU 2020 (INCEPTION DATE) TO CURRENT YEAR AND ADD EACH ITEM ON THE LIST
            for (int i = 2020; i <= DateTime.Today.Year; i++)
            {
                cmbxYear.Items.Add((Object)i.ToString());
            }
        }
        #endregion
        #region ADD, CANCEL, and SEARCH LOGIC
        /// <summary>
        /// VIBIESCA
        /// EVERY TIME THAT THE NEW BUTTON IS CLICKED
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* ALGO
             * TWO THINGS CAN HAPPEN WHEN ADD BUTTON IS CLICKED
             * IF ucNewEmployee IS VISIBLE, TRY TO ADD THEM TO DATABASE
             * IF ucEmployee IS VISIBLE, TRY TO SHOW ucNewEmployee
             */
            UserControl reference = null;
            bool ucNewEmployeeFound = false; // RESULT BASED ON THE LOOP BELOW
            foreach (Object obj in pnlEmployee.Controls) // START LOOPING TO ALL CHILD OF pnlEmployee
            {
                UserControl item = (UserControl)obj; // CAST THEM
                if (item.Name == "ucNewEmployee")
                {
                    ucNewEmployeeFound = true; // SET TO TRUE IF THERE IS 1
                    reference = item; // PASSES THE REFERENCE
                    break; // BREAK OUT OF THE LOOP
                }
            }
            if (ucNewEmployeeFound == true) // EVALUATE RESULT
            {
                addNewEmployee(reference); // THERE IS ALREADY A NEW EMPLOYEE FORM THEN CALL THIS FUNCTION TO TRY TO ADD THE DATA INTO THE DATABASE.
            }
            else
            {
                displayUserControl("New Employee"); // SHOW A NEW FORM
            }
        }
        /// <summary>
        /// WHEN THE USER CLICKS CANCEL ON THE NEW EMPLOYEE FORM
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            /*
             * ALGO
             * EITHER PROMPT THE USER TO CLEAR AND RESET TEXT FIELDS 
             * OR displayUserControl("List Employee");
             */
            var prompt = MessageBox.Show(null, Properties.Resources.msg_new_employee_prompt, Properties.Resources.str_program_title, MessageBoxButtons.AbortRetryIgnore);
            if (prompt == DialogResult.Abort)
            {
                displayUserControl("List Employee");
            }
            else if (prompt == DialogResult.Retry)
            {
                displayUserControl("New Employee");
                MessageBox.Show(null, Properties.Resources.msg_new_employee_retry, Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }
            else if (prompt == DialogResult.Ignore)
            {
            }
        }
        /// <summary>
        /// WHEN THE USER CLICKS SEARCH
        /// Change selected item will trigger this
        /// 1. Declare a query string that changes dynamically according to the filter setting
        /// 2. Run a database read basing on that string.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // THIS STRING WILL HOLD DATA BASED ON CURRENTLY SELECTED FILTERS
            string theRawQuery = "SELECT * FROM tbl_employee";
            /* CONDITIONALS
             * WHERE THE SEARCHBOX IS EMPTY, AS WELL AS ALL COMBOBOXES
             * 
             */

            //IF THERE'S NO SELECTED ITEM ON THE COMBOBOX, AND AN EMPTY SEARCHBOX ADD THE WHERE CLAUSE
            if (
                ((cmbxRegularContractual.SelectedIndex <= 0) &&
                (cmbxDepartment.SelectedIndex <= 0) &&
                (cmbxPosition.SelectedIndex <= 0) &&
                (cmbxMonth.SelectedIndex <= 0) &&
                (cmbxYear.SelectedIndex <= 0)) &&

                ((txtbxSearch.Text == "Search") ||
                (txtbxSearch.Text == String.Empty))
                )
            {
                    displayUserControl("List Employee"); // SHOW ALL DATA
                    return; // EXIT IMMEDIATELY
            }
            else
            {
                // ADD THE WHERE CLAUSE BECAUSE THE SYSTEM DETECTED AN INPUT FROM 1 OF THE CMBXes /SEARCHBAR
                theRawQuery += " WHERE ";
            }

            // CODE FOR SEARCH BOX TEXT
            // IF SEARCHBOX IS NOT EMPTY OR NOT EQUAL TO SEARCH THEN DO CODE
            if ((txtbxSearch.Text == String.Empty) || (String.Compare(txtbxSearch.Text, "Search") == 0))
            {
            }
            else
            {
                theRawQuery += "employeeFirstName LIKE '" + txtbxSearch.Text.ToString() + "%' AND ";
            }
            
            //0 ALL
            //1 Contractual
            //2 Regular
            switch (cmbxRegularContractual.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 0:
                    // do nothing
                    break;
                case 1:
                    theRawQuery += "employeeStatus = 'Contractual' AND ";
                    break;
                case 2:
                    theRawQuery += "employeeStatus = 'Regular' AND ";
                    break;
                default:
                    break;
            }

            //0 All
            //1 Jan
            //2 Feb
            //3 Mar
            //4 Apr
            //5 May
            //6 Jun
            //7 Jul
            //8 Aug
            //9 Sep
            //10 Oct
            //11 Nov
            //12 Dec

            switch(cmbxMonth.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    theRawQuery += "MONTH(employeeDateEmployed) = 1 AND ";
                    break;
                case 2:
                    theRawQuery += "MONTH(employeeDateEmployed) = 2 AND ";
                    break;
                case 3:
                    theRawQuery += "MONTH(employeeDateEmployed) = 3 AND ";
                    break;
                case 4:
                    theRawQuery += "MONTH(employeeDateEmployed) = 4 AND ";
                    break;
                case 5:
                    theRawQuery += "MONTH(employeeDateEmployed) = 5 AND ";
                    break;
                case 6:
                    theRawQuery += "MONTH(employeeDateEmployed) = 6 AND ";
                    break;
                case 7:
                    theRawQuery += "MONTH(employeeDateEmployed) = 7 AND ";
                    break;
                case 8:
                    theRawQuery += "MONTH(employeeDateEmployed) = 8 AND ";
                    break;
                case 9:
                    theRawQuery += "MONTH(employeeDateEmployed) = 9 AND ";
                    break;
                case 10:
                    theRawQuery += "MONTH(employeeDateEmployed) = 10 AND ";
                    break;
                case 11:
                    theRawQuery += "MONTH(employeeDateEmployed) = 11 AND ";
                    break;
                case 12:
                    theRawQuery += "MONTH(employeeDateEmployed) = 12 AND ";
                    break;
            }

            if (cmbxYear.SelectedIndex >= 1)
            {
                theRawQuery += "YEAR(employeeDateEmployed) = " + cmbxYear.Text + " AND ";
            }

            //0  ALL
            //1  Administrative
            //2  Customer Service
            //3  Finance
            //4  Human Resource
            //5  Information Technology
            //6  Legal
            //7  Marketing
            //8  Operation
            //9  Production
            //10 Purchasing
            //11 Research and Development
            //12 Sales

            switch (cmbxDepartment.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    theRawQuery += "employeeDepartment = 'Administrative' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Administrative Manager' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Administrative Assistant Director' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Administrative Coordinator' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Administrative Director' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Administrative Specialist' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Administrator' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Secretary' AND ";
                            break;
                        case 8:
                            theRawQuery += "employeePosition = 'Services Manager' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    theRawQuery += "employeeDepartment = 'Customer Service' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Call Center Customer Support' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Customer Care Operator' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Customer Experience Specialist' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Customer Interaction Management Specialist' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Customer Service Agent' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Customer Support Associate' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Retail Associate' AND ";
                            break;
                        case 8:
                            theRawQuery += "employeePosition = 'Telephone Support Specialist' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    theRawQuery += "employeeDepartment = 'Finance' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Accountant' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Assistant Accountant' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Auditor' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Finance Clerk' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Financial Advisor Assistant' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Financial Analyst' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Payroll Assistant' AND ";
                            break;
                        case 8:
                            theRawQuery += "employeePosition = 'Payroll Clerk' AND ";
                            break;
                        case 9:
                            theRawQuery += "employeePosition = 'Purchasing Clerk' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    theRawQuery += "employeeDepartment = 'Human Resource' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Human Resource Administrator' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Human Resource Analyst' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Human Resource Assistant' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Human Resource Associate' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Human Resource Director' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Human Resource Generalist' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Human Resource Manager' AND ";
                            break;
                        case 8:
                            theRawQuery += "employeePosition = 'Human Resource Representative' AND ";
                            break;
                        case 9:
                            theRawQuery += "employeePosition = 'Human Resource Specialist' AND ";
                            break;
                        case 10:
                            theRawQuery += "employeePosition = 'Human Resource Supervisor' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    theRawQuery += "employeeDepartment = 'Information Technology' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Application Developer' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Database Administrator' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'IT Director' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'IT Support Specialist' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'IT Technician' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Network Administrator' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Security Specialist' AND ";
                            break;
                        case 8:
                            theRawQuery += "employeePosition = 'System Analyst' AND ";
                            break;
                        case 9:
                            theRawQuery += "employeePosition = 'Web Developer' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    theRawQuery += "employeeDepartment = 'Legal' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Arbitrator' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Attorney' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Case Manager' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Jury Consultant' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Law Firm Administrator' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Legal Analyst' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Legal Services Director' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    theRawQuery += "employeeDepartment = 'Marketing' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Communication Manager' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Marketing Consultant' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Marketing Director' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Marketing Manager' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Product Manager' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 8:
                    theRawQuery += "employeeDepartment = 'Operation' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Facilities Coordinator' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Logistics Manager' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Operations Analyst' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Operations Assistant' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Operations Manager' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Operations Supervisor' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 9:
                    theRawQuery += "employeeDepartment = 'Production' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Assembler' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Machinist' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Mechatronic Engineer' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Product Designer' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Production Manager' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Quality Control Inspector' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Robotics Technician' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 10:
                    theRawQuery += "employeeDepartment = 'Purchasing' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Materials Manager' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Production Planner' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Purchasing Agent' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Purchasing Assistant' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Purchasing Clerk' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Purchasing Director' AND ";
                            break;
                        case 7:
                            theRawQuery += "employeePosition = 'Purchasing Manager' AND ";
                            break;
                        case 8:
                            theRawQuery += "employeePosition = 'Purchasing Supervisor' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 11:
                    theRawQuery += "employeeDepartment = 'Research and Development' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'R&D Manager' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'R&D Specialist' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'R&D Supervisor' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Research Assistant' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
                case 12:
                    theRawQuery += "employeeDepartment = 'Sales' AND ";
                    switch (cmbxPosition.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            theRawQuery += "employeePosition = 'Sales Account Executive' AND ";
                            break;
                        case 2:
                            theRawQuery += "employeePosition = 'Sales Account Manager' AND ";
                            break;
                        case 3:
                            theRawQuery += "employeePosition = 'Sales Collection Agent' AND ";
                            break;
                        case 4:
                            theRawQuery += "employeePosition = 'Sales Consultant' AND ";
                            break;
                        case 5:
                            theRawQuery += "employeePosition = 'Sales Manager' AND ";
                            break;
                        case 6:
                            theRawQuery += "employeePosition = 'Sales Representative' AND ";
                            break;
                        default:
                            break;
                    }
                    break;
            }


            // CODE HERE TO TRIM THE EXCESS " AND " ON THE END OF QUERY STRING
            // DECLARE NEW STRING HERE
            String theFinalQuery = theRawQuery.Remove(theRawQuery.Length -5, 5);
            theFinalQuery = String.Concat(theFinalQuery, ";");
            MessageBox.Show(null, theFinalQuery, null, MessageBoxButtons.OK); // TEST HERE
            // TRY TO RUN THE READ
            try
            {
                displayUserControl("List Employee", theFinalQuery, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message.ToString(), null, MessageBoxButtons.OK); // TEST HERE
                displayUserControl("List Employee");
            }
        }
        #endregion
        #region SEARCH BOX LOGIC
        private void txtbxSearch_Enter(object sender, EventArgs e)
        {
            if (String.Compare(txtbxSearch.Text, "Search") == 0)
            {
                txtbxSearch.Text = "";
                txtbxSearch.ForeColor = Color.Black;
            }
        }
        private void txtbxSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbxSearch.Text) == true)
            {
                txtbxSearch.Text = "Search";
                txtbxSearch.ForeColor = Color.Gray;
            }
        }
        #endregion
        #region COMBOBOXES LOGIC
        /// <summary>
        /// POSITION LIST BOX ITEMS WILL CHANGE DEPENDING ON THE SELECTED DEPARTMENT
        /// </summary>
        private void cmbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // INDEX LIST ON THIS COMBOBOX GUIDE
            //0  ALL
            //1  Administrative
            //2  Customer Service
            //3  Finance
            //4  Human Resource
            //5  Information Technology
            //6  Legal
            //7  Marketing
            //8  Operation
            //9  Production
            //10 Purchasing
            //11 Research and Development
            //12 Sales

            cmbxPosition.Items.Clear(); // FIRSTLY REMOVES ALL ITEMS ON THE LIST BEFORE ADDING 1 BASED ON SELECTED
            this.cmbxPosition.Items.Add("ALL"); // ADD THE "ALL" CODE
            switch (cmbxDepartment.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 1:
                    this.cmbxPosition.Items.AddRange(dp.posAdministrative);
                    break;
                case 2:
                    this.cmbxPosition.Items.AddRange(dp.posCustomerService);
                    break;
                case 3:
                    this.cmbxPosition.Items.AddRange(dp.posFinance);
                    break;
                case 4:
                    this.cmbxPosition.Items.AddRange(dp.posHumanResource);
                    break;
                case 5:
                    this.cmbxPosition.Items.AddRange(dp.posInformationTechnology);
                    break;
                case 6:
                    this.cmbxPosition.Items.AddRange(dp.posLegal);
                    break;
                case 7:
                    this.cmbxPosition.Items.AddRange(dp.posMarketing);
                    break;
                case 8:
                    this.cmbxPosition.Items.AddRange(dp.posOperation);
                    break;
                case 9:
                    this.cmbxPosition.Items.AddRange(dp.posProduction);
                    break;
                case 10:
                    this.cmbxPosition.Items.AddRange(dp.posPurchasing);
                    break;
                case 11:
                    this.cmbxPosition.Items.AddRange(dp.posResearchAndDevelopment);
                    break;
                case 12:
                    this.cmbxPosition.Items.AddRange(dp.posSales);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
