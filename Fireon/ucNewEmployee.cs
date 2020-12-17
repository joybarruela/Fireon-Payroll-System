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

namespace Fireon
{
    public partial class ucNewEmployee : UserControl
    {
        clsStringFunctions sf = new clsStringFunctions(); // CREATE AN INSTANCE OF clsStringFunctions.
        clsDatabaseFunctions db = new clsDatabaseFunctions(); // CREATE AN INSTANCE OF clsDatabaseFunctions.
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions(); // CREATE AN INSTANCE OF clsDepartmentAndPositions.
        public ucNewEmployee()
        {
            InitializeComponent();
        }
        private void ucNewEmployee_Load(object sender, EventArgs e)
        {
            mcBirthdate.SetDate(DateTime.Today); // SETS THE SELECTED DATE OF THAT CALENDAR TO ALWAYS TODAY WHEN IT GETS LOADED.
        }

        #region UPLOADING AN EMPLOYEE PICTURE LOGIC
        /// <summary>
        /// HAPPENS WHEN THE USER CLICKS THE "Upload Image" BUTTON IN THE FORM
        /// </summary>
        private void btnUploadDP_Click(object sender, EventArgs e)
        {
            ofdUploadDP.ShowDialog(); // ofdUploadDP IS A OpenFileDialog INSTANCE I CREATED FOR FILE SEARCHING
        }
        /// <summary>
        /// THIS HAPPENS WHEN THE USER CLICKS ON "OK" ON THE FILE DIALOG.
        /// </summary>
        private void ofdUploadDP_FileOk(object sender, CancelEventArgs e)
        {
            // I HAVE MADE A TEMPLATE FUNCTION THAT COPIES ONE FILE TO ANOTHER IN clsDatabaseFunctions
            db.dbCopyFile(ofdUploadDP.FileName, ofdUploadDP.FileName, @"C:\Users\Public\Public Desktop\TestFolder");
            try
            {
                picbDP.Load(ofdUploadDP.FileName); // LOAD THE IMAGE FROM THE LOCATION WHERE THE PICTURE IS SELECTED.
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.msg_exception + ex.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region COMBOBOXES LOGIC
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
            // COMBOBOX INDEX GUIDE
            //0  Contractual
            //1  Regular
            switch (cmbxStatus.SelectedIndex)
            {
                case 0:
                    txtbxWorkingHours.Text = string.Empty; // CLEAN THE FIELD FIRST
                    txtbxWorkingHours.Enabled = true; // ENABLE IT FOR INPUT
                    txtbxContractDuration.Text = string.Empty; // CLEAN THE FIELD FIRST
                    txtbxContractDuration.Enabled = true; // AS WELL THE CONTRACT DURATION
                    break;
                case 1:
                    txtbxWorkingHours.Text = Properties.Resources.int_default_working_hours;
                    txtbxWorkingHours.Enabled = false;
                    txtbxContractDuration.Text = string.Empty;
                    txtbxContractDuration.Enabled = false;
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
    }
}
