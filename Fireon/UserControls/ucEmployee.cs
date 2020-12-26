using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fireon.Classes;

namespace Fireon
{
    public partial class ucEmployee : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        public ucEmployee()
        {
            InitializeComponent();
        }
        #region TRIGGERS AND EVENTS
        private void ucEmployee_Load(object sender, EventArgs e)
        {
            displayUserControl("List Employee");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            db.dbSearch(pnlEmployee, ff.employeeSearch(txtbxSearch, this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear));
        }
        private void txtbxSearch_Enter(object sender, EventArgs e)
        {
            ff.ghostText("Search", this.txtbxSearch);
        }
        private void txtbxSearch_Leave(object sender, EventArgs e)
        {
            ff.ghostText("Search", this.txtbxSearch);
        }
        private void cmbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ff.departmentChange(cmbxDepartment, cmbxPosition, "List Employee Part");
        }
        #endregion
        #region CUSTOM FUNCTIONS
        /// <summary>
        /// DISPLAYS USER CONTROL
        /// </summary>
        /// <param name="mode"></param>
        public void displayUserControl(string mode)
        {
            switch (mode)
            {
                case "New Employee":
                    ff.displayUserControl(pnlEmployee, new ucNewEmployee());
                    pnlFilters.Hide();
                    btnSearch.Hide();
                    btnCancel.Show();
                    break;
                case "List Employee":
                    ff.displayUserControl(pnlEmployee, new ucDataGridView());
                    pnlFilters.Show();
                    btnSearch.Show();
                    pnlSeparator2.Hide();
                    btnCancel.Hide();
                    // cmbx[0] = cmbxemployeestatus
                    // cmbx[1] = cmbxdepartment
                    // cmbx[2] = cmbxposition
                    // cmbx[3] = cmbxmonth
                    // cmbx[4] = cmbxyear
                    ff.prepComboBoxesEmployee(this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear);
                    ff.resetFilterComboBoxes(this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear);
                    ff.ghostText("Search", this.txtbxSearch, true);
                    db.dbSearch(pnlEmployee, ff.employeeSearch(txtbxSearch, this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear));
                    break;
                default:
                    pnlFilters.Show();
                    btnSearch.Show();
                    pnlSeparator1.Show();
                    btnCancel.Hide();
                    break;
            }
        }
        /// <summary>
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

                // LOOP TO FILL IN LISTBOX ITEMS ON THERE
                ListBox.ObjectCollection fileListLocations = ucNewEmployee.lsbxFileList.Items; // INITS THE LOCATION LIST
                // ADD THE IMAGE LOCATION ON THE LISTBOX
                if (String.IsNullOrEmpty(ucNewEmployee.picbDP.ImageLocation) == false)
                {
                    fileListLocations.Add(ucNewEmployee.picbDP.ImageLocation);
                }

                // SURELY NO ON IS BORN ON THE SAME THEY THEY'LL APPLY RIGHT?
                if (ucNewEmployee.mcBirthdate.SelectionStart == DateTime.Today)
                {
                    MessageBox.Show(null, Properties.Resources.msg_employee_validation_birthdate, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // IF NO SEX IS SELECTED
                if ((ucNewEmployee.rdbtnMale.Checked == false) && (ucNewEmployee.rdbtnFemale.Checked == false))
                {
                    MessageBox.Show(null, Properties.Resources.msg_employee_validation_sex, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // IF USER SELECTS REGULAR, IT'S OKAY IF THE CONTRACT DURATION IS BLANK, IF USER IS CONTRACTUAL, CONTRACT DURATION SHOULD HAVE INPUT, THIS CHECKS IF THE CONTRACTUAL (INDEX OF 0) IS SELECTED BUT NO CONTRACT DURATION IS PRESENT
                if ((ucNewEmployee.cmbxStatus.SelectedIndex == 0) && (ucNewEmployee.txtbxContractDuration.Text == String.Empty))
                {
                    MessageBox.Show(null, Properties.Resources.msg_employee_validation_contract_duration, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // I USED TRYPARSE AND AND INT64 WHICH IS BY THE WAY ANOTHER NAME OF LONG DATA TYPE, IS BECAUSE THOSE 4 VARIABLES ARE PRONE TO HAVE A 0 OR NULL INPUT
                Int64 theFuckingContractDurationValue;
                Int64 theFuckingWorkingHoursValue;
                Int64 theFuckingHourlyRateValue;
                Int64 theFuckingContactValue;

                bool tryParseTheFuckingContractDurationResult = Int64.TryParse(ucNewEmployee.txtbxContractDuration.Text.ToString(), out theFuckingContractDurationValue);
                bool tryParseTheFuckingWorkingHoursResult = Int64.TryParse(ucNewEmployee.txtbxWorkingHours.Text.ToString(), out theFuckingWorkingHoursValue);
                bool tryParseTheFuckingHourlyRateResult = Int64.TryParse(ucNewEmployee.txtbxHourlyRate.Text.ToString(), out theFuckingHourlyRateValue);
                bool tryParseTheFuckingContactResult = Int64.TryParse(ucNewEmployee.txtbxContact.Text.ToString(), out theFuckingContactValue);

                if (tryParseTheFuckingContractDurationResult)
                { /*parse just got real*/}
                else
                { theFuckingContractDurationValue = 0; /*if there is no value*/}
                if (tryParseTheFuckingWorkingHoursResult)
                { /*parse just got real*/}
                else
                { theFuckingWorkingHoursValue = 0; /*if there is no value*/}
                if (tryParseTheFuckingHourlyRateResult)
                { /*parse just got real*/}
                else
                { theFuckingHourlyRateValue = 0; /*if there is no value*/}
                if (tryParseTheFuckingContactResult)
                { /*parse just got real*/}
                else
                { theFuckingContactValue = 0; /*if there is no value*/}

                // OTHER VALIDATIONS PART
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
                    MessageBox.Show(null, Properties.Resources.msg_validation_success, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    db.dbInsertEmployeeDetails();
                    fo.createEmployeeDirectory(fileListLocations); // CREATE THE EMPLOYEE DIRECTORY FOR THAT
                    displayUserControl("New Employee"); // BACK TO NEW EMPLOYEE
                }
                else
                {
                    MessageBox.Show(null, Properties.Resources.msg_validation_fail, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        #endregion
    }
}
