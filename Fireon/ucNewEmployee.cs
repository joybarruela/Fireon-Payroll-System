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
        public ucNewEmployee()
        {
            InitializeComponent();
        }
        private void ucNewEmployee_Load(object sender, EventArgs e)
        {
            mcBirthdate.SetDate(DateTime.Today); // SETS THE SELECTED DATE OF THAT CALENDAR TO ALWAYS TODAY WHEN IT GETS LOADED.
        }

        #region UPLOADING AN EMPLOYEE PICTURE
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
            db.copyFile(ofdUploadDP.FileName, ofdUploadDP.FileName, @"C:\Users\Public\Public Desktop\TestFolder");
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
                    txtbxWorkingHours.Text = null; // CLEAN THE FIELD FIRST
                    txtbxWorkingHours.Enabled = true; // ENABLE IT FOR INPUT
                    txtbxContractDuration.Text = null; // CLEAN THE FIELD FIRST
                    txtbxContractDuration.Enabled = true; // AS WELL THE CONTRACT DURATION
                    break;
                case 1:
                    txtbxWorkingHours.Text = Properties.Resources.int_default_working_hours;
                    txtbxWorkingHours.Enabled = false;
                    txtbxContractDuration.Text = null;
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
        #region SIMPLE FILE COPY EXAMPLE
        //public class SimpleFileCopy
        //{
        //    static void Main()
        //    {
        //        string fileName = "test.txt";
        //        string sourcePath = @"C:\Users\Public\TestFolder";
        //        string targetPath = @"C:\Users\Public\TestFolder\SubDir";

        //        // Use Path class to manipulate file and directory paths.
        //        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
        //        string destFile = System.IO.Path.Combine(targetPath, fileName);

        //        // To copy a folder's contents to a new location:
        //        // Create a new target folder.
        //        // If the directory already exists, this method does not create a new directory.
        //        System.IO.Directory.CreateDirectory(targetPath);

        //        // To copy a file to another location and
        //        // overwrite the destination file if it already exists.
        //        System.IO.File.Copy(sourceFile, destFile, true);

        //        // To copy all the files in one directory to another directory.
        //        // Get the files in the source folder. (To recursively iterate through
        //        // all subfolders under the current directory, see
        //        // "How to: Iterate Through a Directory Tree.")
        //        // Note: Check for target path was performed previously
        //        //       in this code example.
        //        if (System.IO.Directory.Exists(sourcePath))
        //        {
        //            string[] files = System.IO.Directory.GetFiles(sourcePath);

        //            // Copy the files and overwrite destination files if they already exist.
        //            foreach (string s in files)
        //            {
        //                // Use static Path methods to extract only the file name from the path.
        //                fileName = System.IO.Path.GetFileName(s);
        //                destFile = System.IO.Path.Combine(targetPath, fileName);
        //                System.IO.File.Copy(s, destFile, true);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Source path does not exist!");
        //        }

        //        // Keep console window open in debug mode.
        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //}
        #endregion
    }
}
