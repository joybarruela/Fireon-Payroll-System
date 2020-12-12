using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    class clsStringFunctions
    {

        /// <summary>
        /// REMOVES DOUBLE SPACES
        /// REMOVE SPACES IN FRONT AND BACK
        /// </summary>
        /// <param name="textBox"></param>
        public void cleanText(TextBox textBox){
            textBox.Text = textBox.Text.Trim(); // REMOVE SPACES IN FRONT AND BACK
            string sentence = textBox.Text;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            textBox.Text = regex.Replace(sentence, " ");
        }
        /// <summary>
        /// NO NUMBER
        /// NO SPECIAL CHARS
        /// ALLOWS SPACE
        /// ALLOWS BACKSPACE
        /// </summary>
        public void firstRegex(KeyPressEventArgs e)
        {
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
        /// NO SPECIAL CHARS
        /// ALLOWS BACKSPACE
        /// </summary>
        public void secondRegex(KeyPressEventArgs e)
        {
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
