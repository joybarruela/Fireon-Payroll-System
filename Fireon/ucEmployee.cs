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
        public void displayUserControl(string name, string query = "SELECT * FROM tbl_employee")
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
                    return; // EXIT IMMEDIATELY
            }
            else
            {
                // ADD THE WHERE CLAUSE BECAUSE THE SYSTEM DETECTED AN INPUT FROM 1 OF THE CMBXes /SEARCHBAR
                theRawQuery += " WHERE ";
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
                    theRawQuery += "employeeStatus = 'Contractual', ";
                    break;
                case 2:
                    theRawQuery += "employeeStatus = 'Regular', ";
                    break;
                default:
                    break;
            }


            // CODE HERE TO TRIM THE EXCESS ", " ON THE END OF QUERY STRING
            // DECLARE NEW STRING HERE
            String theFinalQuery = theRawQuery.Remove(theRawQuery.Length - 2, 2);
            MessageBox.Show(null, theFinalQuery, null, MessageBoxButtons.OK); // TEST HERE
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
            //8  Operations
            //9  Production
            //10 Purchasing
            //11 Research and Development
            //12 Sales


            cmbxPosition.Items.Clear(); // FIRSTLY REMOVES ALL ITEMS ON THE LIST BEFORE ADDING 1 BASED ON SELECTED
            switch (cmbxDepartment.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 1:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Administrator",
                    "Administrative Coordinator",
                    "Administrative Director",
                    "Administrative Manager",
                    "Administrative Specialist",
                    "Services Manager",
                    "Secretary",
                    "Administrative Assistant Director",
                    });
                    break;
                case 2:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Customer Experience Specialist",
                    "Customer Support Associate",
                    "Customer Service Agent",
                    "Retail Associate",
                    "Telephone Support Specialist",
                    "Customer Interaction Management Specialist",
                    "Call Center Customer Support",
                    "Customer Care Operator",
                    });
                    break;
                case 3:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Payroll Clerk",
                    "Financial Analyst",
                    "Payroll Assistant",
                    "Finance Clerk",
                    "Financial Advisor Assistant",
                    "Purchasing Clerk",
                    "Accountant",
                    "Assistant Accountant",
                    "Auditor",
                    });
                    break;
                case 4:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Human Resource Generalist",
                    "Human Resource Assistant",
                    "Human Resource Associate",
                    "Human Resource Representative",
                    "Human Resource Administrator",
                    "Human Resource Analyst",
                    "Human Resource Specialist",
                    "Human Resource Supervisor",
                    "Human Resource Manager",
                    "Human Resource Director",
                    });
                    break;
                case 5:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "IT Technician",
                    "Network Administrator",
                    "System Analyst",
                    "IT Director",
                    "IT Support Specialist",
                    "Database Administrator",
                    "Security Specialist",
                    "Application Developer",
                    "Web Developer"
                    });
                    break;
                case 6:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Arbitrator",
                    "Attorney",
                    "Case Manager",
                    "Jury Consultant",
                    "Law ﬁrm Administrator",
                    "Legal Analyst",
                    "Legal Services Director",
                    });
                    break;
                case 7:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Marketing Director",
                    "Marketing Manager",
                    "Communication Manager",
                    "Product Manager",
                    "Marketing Consultant",
                    });
                    break;
                case 8:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Operations Manager",
                    "Operations Supervisor",
                    "Operations Assistant",
                    "Operations Analyst",
                    "Facilities Coordinator",
                    "Logistics Manager",
                    });
                    break;
                case 9:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Robotics Technician",
                    "Mechatronic Engineer",
                    "Assembler",
                    "Machinist",
                    "Production Manager",
                    "Quality Control Inspector",
                    "Product Designer",
                    });
                    break;
                case 10:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Purchasing Manager ",
                    "Materials Manager",
                    "Purchasing Director",
                    "Purchasing Supervisor",
                    "Purchasing Agent",
                    "Purchasing Assistant",
                    "Purchasing Clerk",
                    "Production Planner",
                    });
                    break;
                case 11:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Research Assistant ",
                    "R&D Manager",
                    "R&D Supervisor",
                    "R&D Specialist",
                    });
                    break;
                case 12:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "ALL",
                    "Sales Collection Agent",
                    "Sales Account Manager",
                    "Sales Account Executive",
                    "Sales Manager",
                    "Sales Representative",
                    "Sales Consultant",
                    });
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
