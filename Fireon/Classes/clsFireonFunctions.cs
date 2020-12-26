using Fireon.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    class clsFireonFunctions
    {
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();
        /// <summary>
        /// RESETS ALL THE COMBOBOXES ON THE EMPLOYEE PART
        /// </summary>
        /// <param name="cmbx">THE COMBOBOX TO BE RESETTED</param>
        public void prepComboBoxesEmployee(params ComboBox[] cmbx)
        {
            // PARAMS ORDER GUIDE
            // cmbx[0] = cmbxRegularContractual
            // cmbx[1] = cmbxDepartment
            // cmbx[2] = cmbxPosition
            // cmbx[3] = cmbxMonth
            // cmbx[4] = cmbxYear

            // PREP cmbxRegularContractual ITEMS
            cmbx[0].Items.Clear();
            cmbx[0].Items.AddRange(dp.employeeStatus);
            cmbx[0].Items.Add("ALL");
            // PREP cmbxDepartment ITEMS
            cmbx[1].Items.Clear();
            cmbx[1].Items.AddRange(dp.departments);
            cmbx[1].Items.Add("ALL");
            // PREP cmbxPosition ITEMS
            cmbx[2].Items.Clear();
            // PREP cmbxMonth ITEMS
            cmbx[3].Items.Clear();
            cmbx[3].Items.AddRange(dp.months);
            cmbx[3].Items.Add("ALL");
            // PREP cmbxYear ITEMS
            cmbx[4].Items.Clear();
            cmbx[4].Items.AddRange(dp.countYears());
            cmbx[4].Items.Add("ALL");
        }
        /// <summary>
        /// RESETS FILTERS FOR COMBOBOXES
        /// </summary>
        public void resetFilterComboBoxes(params ComboBox[] cmbx)
        {
            // RESET STATE OF ALL COMBOBOXES TO "ALL"
            cmbx[0].SelectedIndex = cmbx[0].Items.Count - 1; // THE LAST ITEM ON THE LIST, WHICH IN THIS CASE IS "ALL" -1 BECAUSE INDEX STARTS FROM 0
            cmbx[1].SelectedIndex = cmbx[1].Items.Count - 1; // THE LAST ITEM ON THE LIST, WHICH IN THIS CASE IS "ALL" -1 BECAUSE INDEX STARTS FROM 0
            cmbx[2].SelectedIndex = cmbx[2].Items.Count - 1; // THE LAST ITEM ON THE LIST, WHICH IN THIS CASE IS "ALL" -1 BECAUSE INDEX STARTS FROM 0
            cmbx[3].SelectedIndex = cmbx[3].Items.Count - 1; // THE LAST ITEM ON THE LIST, WHICH IN THIS CASE IS "ALL" -1 BECAUSE INDEX STARTS FROM 0
            cmbx[4].SelectedIndex = cmbx[4].Items.Count - 1; // THE LAST ITEM ON THE LIST, WHICH IN THIS CASE IS "ALL" -1 BECAUSE INDEX STARTS FROM 0
        }
        /// <summary>
        /// GHOST TEXT LOGIC ON TEXTBOX (GRAYTEXT)
        /// </summary>
        /// <param name="txtbx">THE TEXTBOX TO PERFORM THESE OPERATIONS FOR</param>
        /// <param name="ghostText">THE TEXT TO BE DISPLAYED AND EVALUATED</param>
        /// <param name="reset">THE TEXT TO BE DISPLAYED AND EVALUATED</param>
        public void ghostText(String ghostText, TextBox txtbx, bool reset = false)
        {
            if (reset == true)
            {
                txtbx.Text = ghostText;
                txtbx.ForeColor = Color.Gray;
                return;
            }
            if (String.Compare(txtbx.Text, ghostText) == 0) // IF THE TEXT IN TEXTBOX AND GHOSTTEXT IS SAME THEN CLEAR THE TXTBX AND CHANGE TO BLACK FOR TYPING NEW ENTRY
            {
                txtbx.Text = String.Empty;
                txtbx.ForeColor = Color.Black;
                return;
            }
            if (String.IsNullOrWhiteSpace(txtbx.Text) == true) // IF THE TXTBX IS EMPTY THEN SET BACK THE GHOST TEXT AND CHANGE IT BACK TO GRAY
            {
                txtbx.Text = ghostText;
                txtbx.ForeColor = Color.Gray;
                return;
            }
        }
        /// <summary>
        /// CHANGES POSITION OPTIONS BASED ON DEPARTMENT
        /// </summary>
        /// <param name="department">DEPARTMENT COMBOBOX INSTANCE</param>
        /// <param name="position">POSITION COMBOBOX INSTANCE</param>
        /// <param name="mode"></param>
        public void departmentChange(ComboBox department, ComboBox position, string mode = "Default")
        {
            // INDEX LIST ON THIS COMBOBOX GUIDE
            //0  Administrative
            //1  Customer Service
            //2  Finance
            //3  Human Resource
            //4  Information Technology
            //5  Legal
            //6  Marketing
            //7  Operation
            //8  Production
            //9  Purchasing
            //10 Research and Development
            //11 Sales
            position.Items.Clear(); // FIRSTLY REMOVES ALL ITEMS ON THE LIST BEFORE ADDING ENTRIES BASED ON SELECTED INDEX
            switch (department.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 0:
                    position.Items.AddRange(dp.posAdministrative);
                    break;
                case 1:
                    position.Items.AddRange(dp.posCustomerService);
                    break;
                case 2:
                    position.Items.AddRange(dp.posFinance);
                    break;
                case 3:
                    position.Items.AddRange(dp.posHumanResource);
                    break;
                case 4:
                    position.Items.AddRange(dp.posInformationTechnology);
                    break;
                case 5:
                    position.Items.AddRange(dp.posLegal);
                    break;
                case 6:
                    position.Items.AddRange(dp.posMarketing);
                    break;
                case 7:
                    position.Items.AddRange(dp.posOperation);
                    break;
                case 8:
                    position.Items.AddRange(dp.posProduction);
                    break;
                case 9:
                    position.Items.AddRange(dp.posPurchasing);
                    break;
                case 10:
                    position.Items.AddRange(dp.posResearchAndDevelopment);
                    break;
                case 11:
                    position.Items.AddRange(dp.posSales);
                    break;
                default:
                    break;
            }
            // ADD THE "ALL" ON THE END OF CODE DEPENDING WHERE IT IS CALLED (STRING MODE IMPLEMENTATION)
            if (string.Compare(mode, "List Employee Section") == 0)
            {
                position.Items.Add("ALL"); // ADD THE "ALL" IN THE OPTIONS
            }
        }
        /// <summary>
        /// CHECKS ON THE 5 COMBOBOXES AND SEARCH TEXTBOX AND CREATES QUERY FOR THAT
        /// </summary>
        /// <param name="txtbxSearch">THE ONLY TEXTBOX ON THE SEARCHBAR</param>
        /// <param name="cmbx">LIST OF COMBOBOXES TO BE PROCESSED</param>
        /// <returns>RETURNS BASIC SELECT ALL QUERY OF VALIDATION FAILS, RETURNS THE PROCESSED QUERY WHEN ALL VALIDATION PASSES</returns>
        public String employeeSearch(TextBox txtbxSearch, params ComboBox[] cmbx)
        {
            // PARAMS ORDER GUIDE
            // cmbx[0] = cmbxRegularContractual
            // cmbx[1] = cmbxDepartment
            // cmbx[2] = cmbxPosition
            // cmbx[3] = cmbxMonth
            // cmbx[4] = cmbxYear
            string theRawQuery = dq.queryEmployee[0]; // THIS STRING WILL HOLD DATA BASED ON CURRENTLY SELECTED FILTERS
            //IF THERE'S NO SELECTED ITEM ON THE COMBOBOX, AND AN EMPTY SEARCHBOX ADD THE WHERE CLAUSE
            if ((
                ((cmbx[0].SelectedIndex == cmbx[0].Items.Count - 1) || (cmbx[0].SelectedIndex < 0)) &&
                (cmbx[1].SelectedIndex == cmbx[1].Items.Count - 1) || (cmbx[1].SelectedIndex < 0)) &&
                ((cmbx[2].SelectedIndex == cmbx[2].Items.Count - 1) || (cmbx[2].SelectedIndex < 0)) &&
                ((cmbx[3].SelectedIndex == cmbx[3].Items.Count - 1) || (cmbx[3].SelectedIndex < 0)) &&
                ((cmbx[4].SelectedIndex == cmbx[4].Items.Count - 1) || (cmbx[4].SelectedIndex < 0)) &&
                ((txtbxSearch.Text == Properties.Resources.ghost_text_search) || (txtbxSearch.Text == String.Empty))){
                //displayUserControl("List Employee"); // SHOW ALL DATA
                return theRawQuery; // EXIT IMMEDIATELY
            }
            else{
                theRawQuery += " WHERE "; // ADD THE WHERE CLAUSE BECAUSE THE SYSTEM DETECTED AN INPUT FROM 1 OF THE COMBOBOXES OR SEARCHBAR
            }
            // CODE FOR SEARCH BOX TEXT. IF SEARCHBOX IS NOT EMPTY OR NOT EQUAL TO SEARCH THEN DO CODE
            if ((txtbxSearch.Text == String.Empty) || (String.Compare(txtbxSearch.Text, Properties.Resources.ghost_text_search) == 0)){
            }
            else{
                theRawQuery += "employeeFirstName LIKE '" + txtbxSearch.Text + "%' AND ";
            }
            // cmbxFilters[0] = cmbxRegularContractual
            if ((cmbx[0].SelectedIndex != -1) && (String.Compare(cmbx[0].SelectedItem.ToString(), "ALL") != 0)){
                theRawQuery += "employeeStatus = '" + cmbx[0].Text + "' AND ";
            }
            // cmbxFilters[1] = cmbxDepartment
            if ((cmbx[1].SelectedIndex != -1) && (String.Compare(cmbx[1].SelectedItem.ToString(), "ALL") != 0)){
                theRawQuery += "employeeDepartment = '" + cmbx[1].Text + "' AND ";
            }
            // cmbxFilters[2] = cmbxPosition
            if ((cmbx[2].SelectedIndex != -1) && (String.Compare(cmbx[2].SelectedItem.ToString(), "ALL") != 0)){
                theRawQuery += "employeePosition = '" + cmbx[2].Text + "' AND ";
            }
            // cmbxFilters[3] = cmbxMonth
            if ((cmbx[3].SelectedIndex != -1) && (String.Compare(cmbx[3].SelectedItem.ToString(), "ALL") != 0)){
                theRawQuery += "MONTH(employeeDateEmployed) = " + (cmbx[3].SelectedIndex + 1).ToString() + " AND ";
            }
            // cmbxFilters[4] = cmbxYear
            if ((cmbx[4].SelectedIndex != -1) && (String.Compare(cmbx[4].SelectedItem.ToString(), "ALL") != 0)){
                theRawQuery += "YEAR(employeeDateEmployed) = " + cmbx[4].Text + " AND ";
            }

            String theFinalQuery = theRawQuery.Remove(theRawQuery.Length -5, 5); // CODE HERE TO TRIM THE EXCESS " AND " ON THE END OF QUERY STRING AND DECLARE NEW STRING HERE
            theFinalQuery = String.Concat(theFinalQuery, ";"); // APPEND A SEMICOLON
            MessageBox.Show(null, theFinalQuery, Properties.Resources.str_program_title, MessageBoxButtons.OK); // TEST VIEW THE FINAL QUERY
            try // TRY TO RUN THE READ
            {
                return theFinalQuery; // SUCCESS
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message.ToString(), null, MessageBoxButtons.OK); // TEST HERE
            }
            return theRawQuery;
        }
        /// <summary>
        /// TAKES A PANEL AND A USERCONTROL OBJECT AND PLACES THAT UC ON THE PANEL
        /// </summary>
        /// <param name="pnl">THE CONTAINER PANEL</param>
        /// <param name="uc">THE INSTANCE OF UC TO PUT ON THAT PANEL</param>
        public void displayUserControl(Panel pnl, UserControl uc)
        {
            pnl.Controls.Clear(); // CLEARS ALL CHILDREN OF THE PANEL
            uc.Parent = pnl; // SET PARENT OF NEW DASHBOARD
            uc.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
        }
    }
}
