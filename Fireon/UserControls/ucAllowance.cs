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
    public partial class ucAllowance : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();

        public ucAllowance()
        {
            InitializeComponent();
            db.dbRead(Properties.Resources.query_string_allowance, dtgvAllowance);
        }
        private void txtbxAllowanceAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
        private void txtbxAllowanceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.firstRegex(e);
        }
        private void txtbxAllowanceName_Leave(object sender, EventArgs e)
        {
            sf.cleanText(this.txtbxAllowanceName);
        }

        public bool verifyAllowanceIfUnique(String allowanceName)
        {
            foreach (DataGridViewRow item in dtgvAllowance.Rows) // LOOPS ON EACH ITEM OF DTGV ACCOUNTS EACH ROW IS VERIFIED
            {
                string testedName = item.Cells[1].Value.ToString();

                if (String.Compare(allowanceName, testedName) == 0) // COMPARES WITH THE CURRENT LIST OF EMPLOYEE USERNAME
                {
                    return false; // IF THEY ARE THE SAME THEN EXIT IMMEDIATELY AND SAY FALSE
                }

            }
            return true; // IF NOT BEEN RETURNED, THEN TELL TRUE
        }






        private void btnAddAllowance_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Validate if there is name and if there is amount
             * 2. If yes then add them to the database
             */
            // #1
            if (verifyAllowanceIfUnique(txtbxAllowanceName.Text) == false)
            {
                MessageBox.Show(null, "Name already exists on the database. Please select another name", Properties.Resources.str_program_title, MessageBoxButtons.OK);
                return;
            }

            if ((String.IsNullOrEmpty(txtbxAllowanceName.Text) == false) && (String.IsNullOrEmpty(txtbxAllowanceAmount.Text) == false)){
                // #2
                db.addAllowance(txtbxAllowanceName.Text, txtbxAllowanceAmount.Text);
                db.dbRead(Properties.Resources.query_string_allowance, dtgvAllowance);
                MessageBox.Show(null, Properties.Resources.msg_allowance_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                Console.WriteLine("Allowance added");
            }
            else
            {
                MessageBox.Show(null, "Validation incorrect, please fill out the required fields", Properties.Resources.str_program_title, MessageBoxButtons.OK);
            }

        }
        private void btnDeleteAllowance_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Checks if there is a selected row on the datagridview
             * 2. Displays confirmation message if user wants to delete it 
             * 3. If yes then run the database query
             * 4. If no then still the same
             */
            // try catch here if no item is selected on the dtgv
            String allowanceName = dtgvAllowance.SelectedRows[0].Cells[1].Value.ToString();
            String allowanceID= dtgvAllowance.SelectedRows[0].Cells[0].Value.ToString();

            var result = MessageBox.Show(null, @"Are you sure you want to delete allowance: '" + allowanceName + "'?", Properties.Resources.str_program_title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // delete
                db.deleteAllowance(allowanceID);
                db.dbRead(Properties.Resources.query_string_allowance, dtgvAllowance);
                MessageBox.Show(null, "Allowance successfully deleted.", Properties.Resources.str_program_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // dont
            }
        }
    }
}
