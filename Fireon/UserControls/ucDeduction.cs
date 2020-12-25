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
    public partial class ucDeduction : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();

        public ucDeduction()
        {
            InitializeComponent();
            db.dbRead(Properties.Resources.query_string_deduction, dtgvDeduction);
        }
        private void txtbxDeductionAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.thirdRegex(e);
        }
        private void txtbxDeductionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        private void txtbxDeductionName_Leave(object sender, EventArgs e)
        {
            sf.cleanText(this.txtbxDeductionName);
        }

        public bool verifyDeductionIfUnique(String deductionName)
        {
            foreach (DataGridViewRow item in dtgvDeduction.Rows) // LOOPS ON EACH ITEM OF DTGV ACCOUNTS EACH ROW IS VERIFIED
            {
                string testedName = item.Cells[1].Value.ToString();

                if (String.Compare(deductionName, testedName) == 0) // COMPARES WITH THE CURRENT LIST OF EMPLOYEE USERNAME
                {
                    return false; // IF THEY ARE THE SAME THEN EXIT IMMEDIATELY AND SAY FALSE
                }

            }
            return true; // IF NOT BEEN RETURNED, THEN TELL TRUE
        }

        private void btnAddDeduction_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Validate if there is name and if there is amount
             * 2. If yes then add them to the database
             */
            // #1
            if (verifyDeductionIfUnique(txtbxDeductionName.Text) == false)
            {
                MessageBox.Show(null, "Name already exists on the database. Please select another name", Properties.Resources.str_program_title, MessageBoxButtons.OK);
                return;
            }

            if ((String.IsNullOrEmpty(txtbxDeductionName.Text) == false) && (String.IsNullOrEmpty(txtbxDeductionAmount.Text) == false))
            {
                // #2
                db.addDeduction(txtbxDeductionName.Text, txtbxDeductionAmount.Text);
                db.dbRead(Properties.Resources.query_string_deduction, dtgvDeduction);
                MessageBox.Show(null, Properties.Resources.msg_deduction_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                Console.WriteLine("Deduction added");
            }
            else
            {
                MessageBox.Show(null, "Validation incorrect, please fill out the required fields", Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }
        }

        private void btnDeleteDeduction_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Checks if there is a selected row on the datagridview
             * 2. Displays confirmation message if user wants to delete it 
             * 3. If yes then run the database query
             * 4. If no then still the same
             */
            // try catch here if no item is selected on the dtgv
            String deductionName = dtgvDeduction.SelectedRows[0].Cells[1].Value.ToString();
            String deductionID = dtgvDeduction.SelectedRows[0].Cells[0].Value.ToString();

            var result = MessageBox.Show(null, @"Are you sure you want to delete deduction: '" + deductionName + "'?", Properties.Resources.str_program_title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // delete
                db.deleteDeduction(deductionID);
                db.dbRead(Properties.Resources.query_string_deduction, dtgvDeduction);
                MessageBox.Show(null, "Deduction successfully deleted.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // dont
            }
        }




    }
}
