using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon.Classes
{
    /// <summary>
    /// FILE OPS BABY
    /// </summary>
    class clsFileOperations
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        /// <summary>
        /// TEMPLATE FUNCTION FOR YOU TO USE. IT COPIPES 1 FILE FROM 1 PLACE TO ANOTHER
        /// </summary>
        /// <param name="fileName">PASS THE FILENAME HERE</param>
        /// <param name="sourcePath">PASS THE SOURCE LOCATION OF THAT FILE</param>
        /// <param name="targetPath">PASS THIS THE LOCATION WHERE YOU WANT TO PUT IT</param>
        public void copyFile(string fileName, string sourcePath, string targetPath)
        {
            try
            {
                string fileName1 = System.IO.Path.GetFileName(fileName); // GETS THE NAME OF SELECTED FILE
                string sourcePath1 = System.IO.Path.GetDirectoryName(fileName); // GETS THE DIRECTORY OF SELECTED FILE

                string sourceFile = System.IO.Path.Combine(sourcePath1, fileName1); // COMBINE
                string destFile = System.IO.Path.Combine(targetPath, fileName1); // COMBINE

                System.IO.Directory.CreateDirectory(targetPath); // CREATES A DIRECTORY ON THE TARGET PATH, IF THERE IS ALREADY THEN IT ABORTS FILE CREATION
                System.IO.File.Copy(sourceFile, destFile, true); // TRIES TO COPY THE FILE
            }
            catch (Exception e)
            {
                MessageBox.Show(Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void createEmployeeDirectory(ListBox.ObjectCollection fileListLocations)
        {
            try
            {
                // #1 #2
                string defaultFileDirectory = Properties.Settings.Default.defaultFileLocation; // EVERY TIME THIS FUNCTION IS CALLED, THE defaultFileDirectory REFRESHES ACCORDING TO THE CURRENT SAVED LOCATION
                System.IO.Directory.CreateDirectory(defaultFileDirectory); // TRIES TO CREATE THE DEFAULT FILE DIRECTORY IN CASE IT HAS NOT BEEN THERE

                // #3
                DateTime latestEmployeeDateEmployed = db.returnLatestEmployeeEntry().Item1; // EVERY TIME THIS FUNCTION IS CALLED, GETS THE employeeDateEmployed OF THE LATEST ADDED EMPLOYEE
                String latestEmployeeLastName = db.returnLatestEmployeeEntry().Item2; // EVERY TIME THIS FUNCTION IS CALLED, GETS THE employeeLastName OF THE LATEST ADDED EMPLOYEE
                int latestEmployeeID = db.returnLatestEmployeeEntry().Item3; // EVERY TIME THIS FUNCTION IS CALLED, GETS THE employeeID OF THE LATEST ADDED EMPLOYEE

                string employeeFolderName = String.Concat(latestEmployeeDateEmployed.Month.ToString(),"-",
                                                          latestEmployeeDateEmployed.Day.ToString(),"-",
                                                          latestEmployeeDateEmployed.Year.ToString(),"_",
                                                          latestEmployeeLastName.ToString(),"_",
                                                          latestEmployeeID.ToString()); // "12-25-2020_VIBIESCA_3" I USED DASHES BECAUSE OF THE FILE CONFLICT WHEN COMBINING
                string employeeFolder = System.IO.Path.Combine(defaultFileDirectory, employeeFolderName); // COMBINE
                System.IO.Directory.CreateDirectory(employeeFolder); // CREATE THE EMPLOYEE FOLDER CODE HERE
            
                // #4 #5
                foreach (var item in fileListLocations)
                {
                    // #6
                    copyFile(item.ToString(), item.ToString(), employeeFolder);
                    // #7
                    // INSERT TO DATABASE CODE HERE
                    // #8
                    Console.WriteLine(item);
                }

                /* ALGO
                 * 1. CREATE DIRECTORY FOR STORAGE OF FOLDERS, REFER FROM THE RESOURCES
                 * 2. GET THE DEFAULT DIRECTORY FOR STORING EMPLOYEE DOCUMENTS
                 * 3. CREATE A FOLDER INSIDE IT AND NAME IT WITH THE FOLLOWING FORMAT: employeeDateEmployed+"_"+employeeLastName+"_"+employeeID EG. "12-25-2020_VIBIESCA_3"
                 * 4. TAKES A List<> OBJECT THAT CONTAINS THE FILE LIST LOCATIONS
                 * 5. LOOPS THRU EACH ITEM ON THE LIST
                 * 6. FOR EACH ITEM PERFORM A TRY COPY FROM THAT LOCATION TO THE DESTINATION DIRECTORY
                 * 7. STORE THEM LOCATIONS ON THE DATABASE
                 * 8. MESSAGE CONFIRMATION
                 */

                // #8
                Console.WriteLine(employeeFolderName);
            }
            catch (Exception e)
            {
                MessageBox.Show(Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// GETS THE FOLDER DIRECTORY LOCATION AND SAVES IT IN THE Settings.settings FOR PERSISTENCE 
        /// </summary>
        /// <param name="location">THE LOCATION OF THE SELECTED FOLDER DIRECTORY</param>
        /// <param name="display">THE LABEL TO REFLECT THE LOCATION WITH</param>
        public void saveDefaultFileLocation(String location, Label display)
        {
            Properties.Settings.Default.defaultFileLocation = location; // CHANGE THE LOCATION PROPERTY
            Properties.Settings.Default.Save(); // SAVE IT
            MessageBox.Show(null, Properties.Resources.msg_default_file_location, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information); // MESSAGE
            display.Text = Properties.Settings.Default.defaultFileLocation.ToString(); // RETURN THE STRING SO THAT IT WOULD REFLECT TO USER
        }
    }
}
