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
        clsStringFunctions sf = new clsStringFunctions(); // CREATE AN INSTANCE OF clsStringFunctions.
        clsDatabaseFunctions db = new clsDatabaseFunctions(); // CREATE AN INSTANCE OF clsDatabaseFunctions.
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions(); // CREATE AN INSTANCE OF clsDepartmentAndPositions.
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
            switch (mode)
            {
                case "add":
                    if (lsbxFileList.Items.Count == 5)
                    {
                        MessageBox.Show(null, "Exceeding file count capacity.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break; // IMMEDIATELY BREAK WHEN lsbx REACHES TO 5 MAX ITEMS
                    }
                    // IF NOT THEN DO THIS
                    string fileName = System.IO.Path.GetFileName(ofdUploadFile.FileName); // GETS THE NAME OF SELECTED FILE
                    string sourcePath = System.IO.Path.GetDirectoryName(ofdUploadFile.FileName); // GETS THE DIRECTORY OF SELECTED FILE

                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName); // COMBINE

                    lsbxFileList.Items.Add(sourceFile.ToString()); // FOR REFERENCE WHEN THE ADD BUTTON IS CLICKED
                    break;
                case "remove":
                    // check first if selection is greater than or equal to 0
                    if (lsbxFileList.SelectedIndex >= 0)
                    {
                        var prompt = MessageBox.Show(null, "Confirm remove " + lsbxFileList.SelectedItem.ToString() + " ?", Properties.Resources.str_program_title, MessageBoxButtons.YesNo);
                        if (prompt == DialogResult.Yes)
                        {
                            // remove that item
                            lsbxFileList.Items.RemoveAt(lsbxFileList.SelectedIndex);
                        }
                        else if (prompt == DialogResult.No)
                        {
                            // do nothing
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
            //0  Administrative
            //1  Customer Service
            //2  Finance
            //3  Human Resource
            //4  Information Technology
            //5  Legal
            //6  Marketing
            //7  Operation
            //8  Production
            //9  Purchasing
            //10 Research and Development
            //11 Sales
            cmbxPosition.Items.Clear(); // FIRSTLY REMOVES ALL ITEMS ON THE LIST BEFORE ADDING 1 BASED ON SELECTED
            switch (cmbxDepartment.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 0:
                    this.cmbxPosition.Items.AddRange(dp.posAdministrative);
                    break;
                case 1:
                    this.cmbxPosition.Items.AddRange(dp.posCustomerService);
                    break;
                case 2:
                    this.cmbxPosition.Items.AddRange(dp.posFinance);
                    break;
                case 3:
                    this.cmbxPosition.Items.AddRange(dp.posHumanResource);
                    break;
                case 4:
                    this.cmbxPosition.Items.AddRange(dp.posInformationTechnology);
                    break;
                case 5:
                    this.cmbxPosition.Items.AddRange(dp.posLegal);
                    break;
                case 6:
                    this.cmbxPosition.Items.AddRange(dp.posMarketing);
                    break;
                case 7:
                    this.cmbxPosition.Items.AddRange(dp.posOperation);
                    break;
                case 8:
                    this.cmbxPosition.Items.AddRange(dp.posProduction);
                    break;
                case 9:
                    this.cmbxPosition.Items.AddRange(dp.posPurchasing);
                    break;
                case 10:
                    this.cmbxPosition.Items.AddRange(dp.posResearchAndDevelopment);
                    break;
                case 11:
                    this.cmbxPosition.Items.AddRange(dp.posSales);
                    break;
                default:
                    break;
            }
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
        /// FUNCTION THAT EVALUATES between "Upload Image" and "Upload Doc"
        /// </summary>
        private void uploadFile(object sender)
        {
            // CHANGE FILTER HERE BASED ON WHICH BUTTON IS CLICKED
            // BETWEEN "btnUploadImage" and "btnUploadFile"
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
            // I HAVE MADE A TEMPLATE FUNCTION THAT COPIES ONE FILE TO ANOTHER IN clsDatabaseFunctions
            //db.dbCopyFile(ofdUploadFile.FileName, ofdUploadFile.FileName, @"C:\Users\Public\Public Desktop\TestFolder");
            
            // IMPORTANT TO CLEAR FILENAME ON THE DIALOG
            ofdUploadFile.FileName = String.Empty;
        }
        #endregion
    }
}
