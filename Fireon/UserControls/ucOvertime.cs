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
    public partial class ucOvertime : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();

        public ucOvertime()
        {
            InitializeComponent();
            db.dbRead(Properties.Resources.query_string_employee_details, dtgvOvertime);
        }

        /// <summary>
        /// VALIDATIONS
        /// </summary>
        private void txtbxAddWorkingHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }

        /// <summary>
        /// WHEN THE USER CLICKS ADD ON THE OVERTIME
        /// </summary>
        private void btnAddOvertime_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Check if there is typed value on the textbox
             * 2. Get the data on the selected row
             * 3. Run the database query
             */

            if (String.IsNullOrEmpty(txtbxAddWorkingHours.Text) == false)
            {

                //// #5
                //// THINGS TO PASS HERE
                //// 1. EID
                //// 2. THE DEDUCTORY VALUE
                //db.addLeave(selectedRow.Cells[0].Value.ToString(), deductionValue, "sick");
                //db.dbRead(Properties.Resources.query_string_employee_details, dtgvLeave);
                //MessageBox.Show(null, Properties.Resources.msg_leave_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                //Console.WriteLine("Sick leave done");
                DataGridViewRow selectedRow = dtgvOvertime.SelectedRows[0]; // gets the first selected row

                int overtimeValue = int.Parse(txtbxAddWorkingHours.Text);

                db.addOvertime(selectedRow.Cells[0].Value.ToString(), overtimeValue);
                db.dbRead(Properties.Resources.query_string_employee_details, dtgvOvertime);
                MessageBox.Show(null, Properties.Resources.msg_overtime_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }
        }
    }
}
