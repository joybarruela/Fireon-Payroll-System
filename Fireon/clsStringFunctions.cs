using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    /// <summary>
    /// THIS CLASS IS FOR ALL THE STRING OPERATIONS THAT YOU WANT TO PERFORM ON THE PROGRAM
    /// CALL IT WHEREVER, THANK YOU.
    /// </summary>
    class clsStringFunctions
    {

        /// <summary>
        /// REMOVES DOUBLE SPACES
        /// REMOVE SPACES IN FRONT AND BACK
        /// </summary>
        public void cleanText(TextBox textBox){
            textBox.Text = textBox.Text.Trim(); // REMOVE SPACES IN FRONT AND BACK
            string sentence = textBox.Text; // VARIABLE INITIALIZE CONTAINING RAW STRING
            RegexOptions options = RegexOptions.None; // SETTING OPTIONS HERE
            Regex regex = new Regex("[ ]{2,}", options); // CREATING THE REGEX RULE
            textBox.Text = regex.Replace(sentence, " "); // APPLYING IT ON THE VARIABLE
        }
        /// <summary>
        /// ALLOWS SPACE
        /// ALLOWS BACKSPACE
        /// ALLOWS LETTERS
        /// </summary>
        public void firstRegex(KeyPressEventArgs e)
        {
            // IF INPUT IS A SPACE OR A LETTER OR A BACKSPACE THEN ALLOW, ELSE DON'T.
            if ((char.IsWhiteSpace(e.KeyChar)) || (char.IsLetter(e.KeyChar)) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// ALLOWS NUMBER
        /// ALLOWS BACKSPACE
        /// </summary>
        public void secondRegex(KeyPressEventArgs e)
        {
            // IF INPUT IS A NUMBER OR A BACKSPACE THEN ALLOW, ELSE DON'T.
            if ((char.IsNumber(e.KeyChar)) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
