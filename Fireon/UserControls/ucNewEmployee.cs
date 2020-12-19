using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Fireon
{
    public partial class ucNewEmployee : UserControl
    {
        clsStringFunctions sf = new clsStringFunctions();
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();

        #region TRIGGERS AND EVENTS
        /// <summary>
        /// WHEN CALLED
        /// </summary>
        public ucNewEmployee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// WHEN LOADED ON SCREEN?
        /// </summary>
        private void ucNewEmployee_Load(object sender, EventArgs e)
        {
            prepEmployee();
        }
        /// <summary>
        /// LABEL INDICATOR CHANGES WHENEVER THE USER SELECTED A DAY THERE
        /// </summary>
        private void mcBirthdate_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblSelectedBirthdate.Text = mcBirthdate.SelectionStart.ToShortDateString();
        }
        /// <summary>
        /// DELETE THE FILE LOCATION WHEN CLICKED
        /// </summary>
        private void lsbxFileList_Click(object sender, EventArgs e)
        {
            addOrRemoveToFileListBox("remove");
        }
        /// <summary>
        /// HAPPENS WHEN THE USER CLICKS THE "Upload Image" or "Upload Doc" BUTTON IN THE FORM
        /// </summary>
        private void btnUploadDP_Click(object sender, EventArgs e)
        {
            uploadFile(sender);
        }
        #endregion
        #region CUSTOM METHODS
        private void prepEmployee()
        {
            mcBirthdate.SetDate(DateTime.Today); // SETS THE SELECTED DATE OF THAT CALENDAR TO ALWAYS TODAY WHEN IT GETS LOADED.
            mcBirthdate.MaxDate = DateTime.Today;
            lsbxFileList.Items.Clear(); // CLEARS ALL ITEMS ON FILE LIST
        }
        private void cmbxRegular()
        {
            txtbxWorkingHours.Text = Properties.Resources.int_default_working_hours;
            txtbxWorkingHours.Enabled = false;
            txtbxContractDuration.Text = string.Empty;
            txtbxContractDuration.Enabled = false;
        }
        private void cmbxContractual()
        {
            txtbxWorkingHours.Text = string.Empty; // CLEAN THE FIELD FIRST
            txtbxWorkingHours.Enabled = true; // ENABLE IT FOR INPUT
            txtbxContractDuration.Text = string.Empty; // CLEAN THE FIELD FIRST
            txtbxContractDuration.Enabled = true; // AS WELL THE CONTRACT DURATION
        }
        /// <summary>
        /// HANDLES ADDING/REMOVING ITEMS FROM THE FILE LISTBOX
        /// </summary>
        /// <param name="mode">"add" for adding, "remove" for removing algorithm</param>
        private void addOrRemoveToFileListBox(string mode)
        {
            int max = int.Parse(Properties.Resources.int_max_document_count);
            switch (mode)
            {
                case "add":
                    if (lsbxFileList.Items.Count == max)
                    {
                        MessageBox.Show(null, Properties.Resources.msg_max_capacity, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break; // IMMEDIATELY BREAK WHEN lsbx REACHES TO 5 MAX ITEMS
                    }
                    // IF NOT THEN DO THIS
                    string fileName = System.IO.Path.GetFileName(ofdUploadFile.FileName); // GETS THE NAME OF SELECTED FILE
                    string sourcePath = System.IO.Path.GetDirectoryName(ofdUploadFile.FileName); // GETS THE DIRECTORY OF SELECTED FILE
                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName); // COMBINE
                    lsbxFileList.Items.Add(sourceFile.ToString()); // FOR REFERENCE WHEN THE ADD BUTTON IS CLICKED
                    break;
                case "remove":
                    // CHECK FIRST IF SELECTION IS GREATER THAN OR EQUAL TO 0
                    if (lsbxFileList.SelectedIndex >= 0)
                    {
                        var prompt = MessageBox.Show(null, "Confirm remove " + lsbxFileList.SelectedItem.ToString() + " ?", Properties.Resources.str_program_title, MessageBoxButtons.YesNo);
                        if (prompt == DialogResult.Yes)
                        {
                            lsbxFileList.Items.RemoveAt(lsbxFileList.SelectedIndex); // REMOVE THAT ITEM
                        }
                        else if (prompt == DialogResult.No)
                        {
                            // DO NOTHING
                        }
                    }
                    break;
            }
        }
        #endregion
        #region COMBOBOXES LOGIC
        /// <summary>
        /// POSITION LIST BOX ITEMS WILL CHANGE DEPENDING ON THE SELECTED DEPARTMENT
        /// </summary>
        private void cmbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ff.departmentChange(cmbxDepartment, cmbxPosition);
        }
        /// <summary>
        /// SETS LOGIC FOR CONTRACTUAL AND REGULAR EMPLOYEES
        /// </summary>
        private void cmbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0  Contractual
            //1  Regular
            switch (cmbxStatus.SelectedIndex)
            {
                case 0:
                    cmbxContractual();
                    break;
                case 1:
                    cmbxRegular();
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region VALIDATIONS
        private void txtbxFirstName_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        private void txtbxMiddleInitial_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        private void txtbxLastName_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        private void txtbxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
        private void txtbxEmail_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxAddress_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        private void txtbxNationality_Leave(object sender, EventArgs e)
        {
            sf.cleanText((TextBox)sender);
        }
        private void txtbxWorkingHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
        private void txtbxHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
        private void txtbxContractDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
        #endregion
        #region UPLOADING AN EMPLOYEE PICTURE LOGIC
        /// <summary>
        /// FUNCTION THAT EVALUATES BETWEEN "Upload Image" and "Upload Doc"
        /// </summary>
        private void uploadFile(object sender)
        {
            // CHANGE FILTER HERE BASED ON WHICH BUTTON IS CLICKED
            // BETWEEN "btnUploadImage" AND "btnUploadFile"
            Button senderName = (Button)sender; // CAST THE SENDER
            switch (senderName.Name)
            {
                case "btnUploadImage":
                    ofdUploadFile.Filter = "PNG files|*.png|JPEG files|*.jpeg,*.jpg";
                    break;
                case "btnUploadFile":
                    ofdUploadFile.Filter = "PDF files|*.pdf|Text files|*.txt|Word files|*.docx;*.doc;*.rtf";
                    break;
                default:
                    break;
            }
            ofdUploadFile.ShowDialog(); // ofdUploadDP IS A OpenFileDialog INSTANCE I CREATED FOR FILE SEARCHING
        }
        /// <summary>
        /// THIS HAPPENS WHEN THE USER CLICKS ON "OK" ON THE FILE DIALOG.
        /// </summary>
        private void ofdUploadDP_FileOk(object sender, CancelEventArgs e)
        {
            // DECLARE BEHAVIOR DEPENDING ON WHAT TYPE OF FILE IS CHOSEN
            string selectedFileExtension = Path.GetExtension(ofdUploadFile.FileName); // gets extension of chosen file name
            switch (selectedFileExtension)
            {
                case ".png":
                case ".jpeg":
                case ".jpg":
                    // TRY LOADING THE IMAGE DP
                    try
                    {
                        picbDP.Load(ofdUploadFile.FileName); // LOAD THE IMAGE FROM THE LOCATION WHERE THE PICTURE IS SELECTED.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Properties.Resources.msg_exception + ex.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case ".pdf":
                case ".txt":
                case ".docx":
                case ".doc":
                case ".rtf":
                    // ADD THE DOC LOCATION ON THE LISTBOX
                    addOrRemoveToFileListBox("add");
                    break;
                default:
                    break;
            }
            // IMPORTANT TO CLEAR FILENAME ON THE DIALOG
            ofdUploadFile.FileName = String.Empty;
        }
        #endregion
    }
}
