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

namespace Fireon.UserControls
{
    public partial class ucHoliday : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();
        public ucHoliday()
        {
            InitializeComponent();
            db.dbRead(Properties.Resources.query_string_employee_details, dtgvHoliday);
        }

        private void btnAddHoliday_Click(object sender, EventArgs e)
        {
            // Formula for special = (employeeHourlyRate * 8) * .30
            // Formula for regular = (employeeHourlyRate * 8) * 1

            /* ALGO
             * 1. Check if this day is a holiday
             * 2. If yes then allow the determine what type of holiday
             * 3. If no then prompt a message "today is not a holiday"
             * 4. Run the database query
             */
            // #1 REGULAR
            if ((checkIfTodayIsHoliday().Item1 == true) && (string.Compare(checkIfTodayIsHoliday().Item2, "regular") == 0) && (dtgvHoliday.SelectedRows.Count != 0))
            {
                // #2
                // do code here
                // #4
                Console.WriteLine("Regular holiday");
                DataGridViewRow selectedRow = dtgvHoliday.SelectedRows[0]; // gets the first selected row
                db.addHoliday(selectedRow.Cells[0].Value.ToString(), 100);
                db.dbRead(Properties.Resources.query_string_employee_details, dtgvHoliday);
                MessageBox.Show(null, "Holiday pay successfully added", Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }
            else if ((checkIfTodayIsHoliday().Item1 == true) && (string.Compare(checkIfTodayIsHoliday().Item2, "special") == 0) && (dtgvHoliday.SelectedRows.Count != 0))
            {
                // #2
                // do code here
                // #4
                Console.WriteLine("Special holiday");
                DataGridViewRow selectedRow = dtgvHoliday.SelectedRows[0]; // gets the first selected row
                db.addHoliday(selectedRow.Cells[0].Value.ToString(), 30);
                db.dbRead(Properties.Resources.query_string_employee_details, dtgvHoliday);
                MessageBox.Show(null, "Holiday pay successfully added", Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }
            else
            {
                // #3
                MessageBox.Show(null, "Today is not a holiday", Properties.Resources.str_program_title, MessageBoxButtons.OK);
                return;
            }
        }




        private Tuple<bool, String> checkIfTodayIsHoliday()
        {

            //PHILIPPINE HOLIDAYS
            //NATIONAL REGULAR HOLIDAYS 
            bool isHoliday = false;
            string regularOrSpecial = "regular";
            
            //1/1
            if ((Properties.Settings.Default.dateToday.Month == 1) && (Properties.Settings.Default.dateToday.Day == 1))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //4/1
            if ((Properties.Settings.Default.dateToday.Month == 4) && (Properties.Settings.Default.dateToday.Day == 1))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //4/2
            if ((Properties.Settings.Default.dateToday.Month == 4) && (Properties.Settings.Default.dateToday.Day == 2))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //4/9
            if ((Properties.Settings.Default.dateToday.Month == 4) && (Properties.Settings.Default.dateToday.Day == 9))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //5/1
            if ((Properties.Settings.Default.dateToday.Month == 5) && (Properties.Settings.Default.dateToday.Day == 1))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //6/12
            if ((Properties.Settings.Default.dateToday.Month == 6) && (Properties.Settings.Default.dateToday.Day == 12))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //8/30
            if ((Properties.Settings.Default.dateToday.Month == 8) && (Properties.Settings.Default.dateToday.Day == 30))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //11/30
            if ((Properties.Settings.Default.dateToday.Month == 11) && (Properties.Settings.Default.dateToday.Day == 30))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //12/25
            if ((Properties.Settings.Default.dateToday.Month == 12) && (Properties.Settings.Default.dateToday.Day == 25))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //12/30
            if ((Properties.Settings.Default.dateToday.Month == 12) && (Properties.Settings.Default.dateToday.Day == 30))
            {
                isHoliday = true;
                regularOrSpecial = "regular";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }

            //SPECIAL (NON-WORKING) HOLIDAYS
            //2/12
            if ((Properties.Settings.Default.dateToday.Month == 2) && (Properties.Settings.Default.dateToday.Day == 12))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //2/25
            if ((Properties.Settings.Default.dateToday.Month == 2) && (Properties.Settings.Default.dateToday.Day == 25))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //4/3
            if ((Properties.Settings.Default.dateToday.Month == 4) && (Properties.Settings.Default.dateToday.Day == 3))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //8/21
            if ((Properties.Settings.Default.dateToday.Month == 8) && (Properties.Settings.Default.dateToday.Day == 21))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //11/1
            if ((Properties.Settings.Default.dateToday.Month == 11) && (Properties.Settings.Default.dateToday.Day == 1))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //12/8
            if ((Properties.Settings.Default.dateToday.Month == 12) && (Properties.Settings.Default.dateToday.Day == 8))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }
            //12/31
            if ((Properties.Settings.Default.dateToday.Month == 12) && (Properties.Settings.Default.dateToday.Day == 31))
            {
                isHoliday = true;
                regularOrSpecial = "special";
                return Tuple.Create(isHoliday, regularOrSpecial);
            }

            return Tuple.Create(isHoliday, regularOrSpecial);
        }
    }
}
