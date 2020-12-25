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

namespace Fireon
{
    public partial class ucLeave : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();

        public ucLeave()
        {
            InitializeComponent();
            db.dbRead(Properties.Resources.query_string_employee_details, dtgvLeave);
        }


        /// <summary>
        /// WHEN THE USER CLICKS ADD ON THE LEAVE
        /// </summary>
        private void btnAddLeave_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Check if there is selected on the radiobuttons
             * 2. Check if there is a typed value on the textbox
             * 3. Get the data on the selected row.
             * 4. Compare the details if the input is compatible with what's selected on the datagridview
             * 5. If yes then run the database query
             */

            int deductionValue = 0; // DEPENDS ON WHAT IS TYPED ON THE TEXTBOX
            // #1
            if ((rdbtnSick.Checked == true) || (rdbtnVacation.Checked == true) || (rdbtnMaternity.Checked == true)){
                // #2
                if (String.IsNullOrEmpty(txtbxNumberOfDays.Text) == false)
                {
                    DataGridViewRow selectedRow = dtgvLeave.SelectedRows[0]; // gets the first selected row

                    // 2, 3, 4 is sick, vacation, and maternity leave on dtgv consecutively
                    int sickLeaveDefault = int.Parse(selectedRow.Cells[2].Value.ToString());
                    int vacationLeaveDefault = int.Parse(selectedRow.Cells[3].Value.ToString());
                    int maternityLeaveDefault = int.Parse(selectedRow.Cells[4].Value.ToString());

                    deductionValue = int.Parse(txtbxNumberOfDays.Text);
                    // #4
                    if ((rdbtnSick.Checked == true) && (sickLeaveDefault - int.Parse(txtbxNumberOfDays.Text) >= 0))
                    {
                        // #5
                        // THINGS TO PASS HERE
                        // 1. EID
                        // 2. THE DEDUCTORY VALUE
                        db.addLeave(selectedRow.Cells[0].Value.ToString(), deductionValue, "sick");
                        db.dbRead(Properties.Resources.query_string_employee_details, dtgvLeave);
                        MessageBox.Show(null, Properties.Resources.msg_leave_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                        Console.WriteLine("Sick leave done");
                        return;
                    }

                    // #4
                    if ((rdbtnVacation.Checked == true) && (vacationLeaveDefault - int.Parse(txtbxNumberOfDays.Text) >= 0))
                    {
                        // #5
                        // THINGS TO PASS HERE
                        // 1. EID
                        // 2. THE DEDUCTORY VALUE
                        db.addLeave(selectedRow.Cells[0].Value.ToString(), deductionValue, "vacation");
                        db.dbRead(Properties.Resources.query_string_employee_details, dtgvLeave);
                        MessageBox.Show(null, Properties.Resources.msg_leave_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                        Console.WriteLine("Vacation leave done");
                        return;
                    }

                    // #4
                    if ((rdbtnMaternity.Checked == true) && (maternityLeaveDefault - int.Parse(txtbxNumberOfDays.Text) >= 0))
                    {
                        // #5
                        // THINGS TO PASS HERE
                        // 1. EID
                        // 2. THE DEDUCTORY VALUE
                        db.addLeave(selectedRow.Cells[0].Value.ToString(), deductionValue, "maternity");
                        db.dbRead(Properties.Resources.query_string_employee_details, dtgvLeave);
                        MessageBox.Show(null, Properties.Resources.msg_leave_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                        Console.WriteLine("Maternity leave done");
                        return;
                    }
                }
            }
        }
        
        //VALIDATIONS
        private void txtbxNumberOfDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
    }
}
