﻿using System;
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
    public partial class ucViolation : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();

        public ucViolation()
        {
            InitializeComponent();
            db.dbRead(dq.queryEmployeeDetails[0], dtgvViolation);
        }

        private void txtbxAddViolationCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }

        private void btnAddViolation_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Check if there is typed value on the textbox
             * 2. Get the data on the selected row
             * 3. Run the database query
             */

            if (String.IsNullOrEmpty(txtbxAddViolationCost.Text) == false)
            {

                //// #5
                //// THINGS TO PASS HERE
                //// 1. EID
                //// 2. THE DEDUCTORY VALUE
                //db.addLeave(selectedRow.Cells[0].Value.ToString(), deductionValue, "sick");
                //db.dbRead(Properties.Resources.query_string_employee_details, dtgvLeave);
                //MessageBox.Show(null, Properties.Resources.msg_leave_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                //Console.WriteLine("Sick leave done");
                DataGridViewRow selectedRow = dtgvViolation.SelectedRows[0]; // gets the first selected row

                int violationValue = int.Parse(txtbxAddViolationCost.Text);

                db.addViolation(selectedRow.Cells[0].Value.ToString(), violationValue);
                db.dbRead(dq.queryEmployeeDetails[0], dtgvViolation);
                MessageBox.Show(null, Properties.Resources.msg_violation_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }
        }

    }
}
