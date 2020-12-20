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
        /// <summary>
        /// TEMPLATE FUNCTION FOR YOU TO USE. IT COPIPES 1 FILE FROM 1 PLACE TO ANOTHER
        /// </summary>
        /// <param name="fileName">PASS THE FILENAME HERE</param>
        /// <param name="sourcePath">PASS THE SOURCE LOCATION OF THAT FILE</param>
        /// <param name="targetPath">PASS THIS THE LOCATION WHERE YOU WANT TO PUT IT</param>
        public void dbCopyFile(string fileName, string sourcePath, string targetPath)
        {
            try
            {
                string fileName1 = System.IO.Path.GetFileName(fileName); // GETS THE NAME OF SELECTED FILE
                string sourcePath1 = System.IO.Path.GetDirectoryName(fileName); // GETS THE DIRECTORY OF SELECTED FILE

                string sourceFile = System.IO.Path.Combine(sourcePath1, fileName1); // COMBINE
                string destFile = System.IO.Path.Combine(targetPath, fileName1); // COMBINE

                System.IO.Directory.CreateDirectory(targetPath); // CREATES A DIRECTORY ON THE TARGET PATH, IF THERE IS ALREADY THEN ABORT FILE CREATION
                System.IO.File.Copy(sourceFile, destFile, true); // TRIES TO COPY THE FILE
            }
            catch (Exception e)
            {
                MessageBox.Show(Properties.Resources.msg_exception + e.Message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
