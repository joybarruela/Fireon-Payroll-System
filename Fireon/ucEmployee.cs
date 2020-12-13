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
                addNewEmployee(reference); // IS THERE IS ALREADY A NEW EMPLOYEE FORM THEN CALL THIS FUNCTION TO TRY TO ADD THE DATA INTO THE DATABASE.
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
                string sex; // holds what the user has selected

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
                if ((ucNewEmployee.cmbxStatus.SelectedIndex == 0) && (ucNewEmployee.txtbxContractDuration.Text == String.Empty))
                {
                    MessageBox.Show(null, "Validation fail.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
                if((ucNewEmployee.txtbxFirstName.Text != "") &&
                    (ucNewEmployee.txtbxLastName.Text != "") &&
                    (ucNewEmployee.txtbxContact.Text.Length == 11) &&
                    (ucNewEmployee.txtbxEmail.Text != "") &&
                    (ucNewEmployee.txtbxAddress.Text != "") &&
                    (ucNewEmployee.cmbxMaritalStatus.SelectedIndex > -1) &&
                    (ucNewEmployee.txtbxNationality.Text != "") &&
                    (ucNewEmployee.cmbxDepartment.SelectedIndex > -1) &&
                    (ucNewEmployee.cmbxPosition.SelectedIndex > -1) &&
                    (ucNewEmployee.cmbxStatus.SelectedIndex > -1) &&
                    (ucNewEmployee.txtbxWorkingHours.Text != "") &&
                    (ucNewEmployee.txtbxHourlyRate.Text != "") &&
                    (ucNewEmployee.cmbxPaymentMode.SelectedIndex > -1))
                {
                    MessageBox.Show(null, "Validation succeded.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // INSERT THEM TO DATABASE
                    db.insertEmployee(
                        ucNewEmployee.txtbxFirstName.Text,
                        ucNewEmployee.txtbxMiddleInitial.Text,
                        ucNewEmployee.txtbxLastName.Text,
                        )
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
        public void displayUserControl(string name)
        {
            switch (name)
            {
                case "New Employee":
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucNewEmployee ucNewEmployee = new ucNewEmployee(); // CREATES A NEW UserControl
                    ucNewEmployee.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucNewEmployee.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    pnlFilters.Hide();
                    btnCancel.Show();
                    break;
                case "List Employee":
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucDataGridView ucDataGridView = new ucDataGridView(); // CREATES A NEW UserControl
                    ucDataGridView.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucDataGridView.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    db.dbRead("SELECT * FROM tbl_employee", ucDataGridView.theDataGridView); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                    pnlFilters.Show();
                    btnCancel.Hide();
                    break;
                default:
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucDataGridView ucDataGridViewDefault = new ucDataGridView(); // CREATES A NEW UserControl
                    ucDataGridViewDefault.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucDataGridViewDefault.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    db.dbRead("SELECT * FROM tbl_employee", ucDataGridViewDefault.theDataGridView); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                    pnlFilters.Show();
                    btnCancel.Hide();
                    break;
            }
        }

        #region COOL SEARCH BOX LOOGIC
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
        #region COMBOBOX LOGIC
        /// <summary>
        /// VIBIESCA
        /// POSITION LIST BOX ITEMS WILL CHANGE DEPENDING ON THE SELECTED DEPARTMENT
        /// </summary>
        private void cmbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // INDEX LIST ON THIS COMBOBOX GUIDE
            //0  Administrative
            //1  Customer Service
            //2  Finance
            //3  Human Resource
            //4  Information Technology
            //5  Legal
            //6  Marketing
            //7  Operations
            //8  Production
            //9  Purchasing
            //10 Research and Development
            //11 Sales

            cmbxPosition.Items.Clear(); // FIRSTLY REMOVES ALL ITEMS ON THE LIST BEFORE ADDING 1 BASED ON SELECTED
            switch (cmbxDepartment.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 0:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
                case 1:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
                case 2:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
                case 3:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
                case 4:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
                case 5:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Arbitrator",
                    "Attorney",
                    "Case Manager",
                    "Jury Consultant",
                    "Law ﬁrm Administrator",
                    "Legal Analyst",
                    "Legal Services Director",
                    });
                    break;
                case 6:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Marketing Director",
                    "Marketing Manager",
                    "Communication Manager",
                    "Product Manager",
                    "Marketing Consultant",
                    });
                    break;
                case 7:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Operations Manager",
                    "Operations Supervisor",
                    "Operations Assistant",
                    "Operations Analyst",
                    "Facilities Coordinator",
                    "Logistics Manager",
                    });
                    break;
                case 8:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Robotics Technician",
                    "Mechatronic Engineer",
                    "Assembler",
                    "Machinist",
                    "Production Manager",
                    "Quality Control Inspector",
                    "Product Designer",
                    });
                    break;
                case 9:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
                case 10:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Research Assistant ",
                    "R&D Manager",
                    "R&D Supervisor",
                    "R&D Specialist",
                    });
                    break;
                case 11:
                    this.cmbxPosition.Items.AddRange(new object[] {
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
