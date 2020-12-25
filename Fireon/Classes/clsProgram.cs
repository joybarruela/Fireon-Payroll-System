using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    static class clsProgram
    {
        public static frmLogin programInstance; //  CREATING A STATIC INSTANCE OF THE LOGIN FORM SO THAT I COULD ACCESS THAT IN ANOTHER FORM
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // SET THE CURRENT DATE HERE FOR THE HOLIDAY CHECKING
            Properties.Settings.Default.dateToday = DateTime.Today;
            // ENABLE CODE TO MANUAL SET DATE
            //Properties.Settings.Default.dateToday = new DateTime(2020, 12, 24);
            // WRITE TODAY DA
            Console.WriteLine("Today is " + Properties.Settings.Default.dateToday.ToShortDateString().ToString());
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // DISPLAY A WELCOMING MESSAGE FIRST TO THE USER
            MessageBox.Show(Properties.Resources.msg_welcome_message, Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            programInstance = new frmLogin(); // THE FIRST 2 LINES ARE NECESSARY BEFORE I COULD DECLARE NEW OBJECT
            Application.Run(programInstance); // START THE PROGRAM
        }
    }
}
