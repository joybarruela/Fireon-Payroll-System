using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    static class clsProgram
    {
        public static frmLogin programInstance; //  CREATING A STATIC INSTANCE OF THE LOGIN FORM SO THAT I COULD ACCESS THAT IN ANOTHER FORM.
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            programInstance = new frmLogin(); // THE FIRST 2 LINES ARE NECESSARY BEFORE I COULD DECLARE NEW OBJECT.

            // DISPLAY A WELCOMING MESSAGE FIRST TO THE USER.
            MessageBox.Show(Properties.Resources.str_welcome_message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Application.Run(programInstance); // START THE PROGRAM.
        }
    }
}
