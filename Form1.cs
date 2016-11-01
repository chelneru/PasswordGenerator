///TODO :
///-Make the GeneratingPassword method multi-threaded;
///-Fix Controls behavior when the Window is resized;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace PassWordGenerator
{
    public partial class Form1 : Form
    {
        private bool advancedOptionsActivated;
        static private bool lettersChecked, digitsChecked, symbolsChecked;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            advancedOptionsActivated = false;
        }


        private bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }
        public string generateCharacter(bool includeLetters, bool includeDigits, bool includeSymbols)
        {

            List<string> symbols = new List<string>() { "~", "@", "#", "$", "%", "^", "&", "*", "(", ")", "[", "]", "!", "?", "+", "_", "=", "-", "/", "\\" };
            List<string> digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<string> letters = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Random rand = new Random();
            List<int> typesLists = new List<int>();
            if (includeLetters) typesLists.Add(1);
            if (includeDigits) typesLists.Add(2);
            if (includeSymbols) typesLists.Add(3);
            int listsIndex = rand.Next(0, typesLists.Count());
            string character;
            if (typesLists.ElementAt(listsIndex) == 1)
            {
                character = letters[rand.Next(0, letters.Count())];
                int up = rand.Next(1, 3);
                if (up == 2) character = character.ToUpper();
                return character;
            }
            else if (typesLists.ElementAt(listsIndex) == 2)
            {
                character = digits[rand.Next(0, digits.Count())];
                return character;
            }
            else if (typesLists.ElementAt(listsIndex) == 3)
            {
                character = symbols[rand.Next(0, symbols.Count())];
                return character;
            }

            else return "0"; //this should never happen

        }

        private int passwordValidity()
        {
            string inputPasswordLength = this.inputLengthValue.Text.ToString().Trim();

            if (!IsNumeric(inputPasswordLength)) { lengthError.Visible = true; return 0; }
            else if (Convert.ToInt32(inputPasswordLength) <= 0 || Convert.ToInt32(inputPasswordLength) > GeneratedPassword.MaxLength)
            {
                lengthError.Visible = true;
                charTypeError.Visible = false;
                return 0;
            }
            else
            {
                if (checkedListBox1.GetItemChecked(0) == true) lettersChecked = true;
                else lettersChecked = false;
                if (checkedListBox1.GetItemChecked(1) == true) digitsChecked = true;
                else digitsChecked = false;
                if (checkedListBox1.GetItemChecked(2) == true) symbolsChecked = true;
                else symbolsChecked = false;
                int ValidPasswordLength = Convert.ToInt32(inputPasswordLength);
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    lengthError.Visible = false;
                    charTypeError.Visible = true;
                    return 0;
                }
                else return ValidPasswordLength;
            }
        }
        private async void Generate_Click(object sender, EventArgs e)
        {   
            if (this.advancedOptionsActivated == false)
            {
                this.checkedListBox1.SetItemChecked(0, true);
                this.checkedListBox1.SetItemChecked(1, true);
                this.checkedListBox1.SetItemChecked(2, false);
                this.inputLengthValue.Text = "10";
            }
            int passLength = this.passwordValidity();
            if (passLength > 0)
            {

                this.GeneratedPassword.Text = "";
                this.charTypeError.Visible = false;
                this.lengthError.Visible = false;
                checkedListBox1.Enabled = false;
                Generate.Enabled = false;
                Task<string> task = GeneratingPassword(passLength);

                this.GeneratedPassword.Text = await task;
                if (task.IsCompleted) { checkedListBox1.Enabled = true; Generate.Enabled = true; }

            }
        }

        private Task<string> GeneratingPassword(int passLength)
        {
            return Task.Run(() =>
        {
            string result = "";
            for (int charIndex = 1; charIndex <= passLength; charIndex++)
            {
                string currentChar = generateCharacter(lettersChecked, digitsChecked, symbolsChecked);
                while (result.EndsWith(currentChar))
                {
                    currentChar = generateCharacter(lettersChecked, digitsChecked, symbolsChecked);
                }
                result = result + currentChar;
                //Multi=threaded call on the update for progressbar
                if (progressBar1.InvokeRequired)
                {
                    progressBar1.Invoke(
                       new ThreadStart(delegate
                     {
                         progressBar1.Value = charIndex * 100 / passLength;
                     }));
                }
                else
                { progressBar1.Value = charIndex * 100 / passLength; }

            }


            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(
                   new ThreadStart(delegate
                   {
                       progressBar1.Value = 0;
                   }));
            }
            else
                progressBar1.Value = 0;

            return result;
        });

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (advancedOptionsActivated == false)
            {
                advancedOptionsActivated = true;
                this.lengthLabel.Visible = true;
                this.inputLengthValue.Text = "";
                this.inputLengthValue.Visible = true;

                this.checkedListBox1.SetItemChecked(0, false);
                this.checkedListBox1.SetItemChecked(1, false);
                this.checkedListBox1.Visible = true;

                this.progressBar1.Visible = true;
                this.button1.Text = "Hide Advanced Options";
            }
            else
            {
                advancedOptionsActivated = false;
                checkedListBox1.Visible = false;
                lengthLabel.Visible = false;
                inputLengthValue.Visible = false;
                progressBar1.Visible = false;
                this.lengthError.Visible = false;
                this.charTypeError.Visible = false;

                this.button1.Text = "Show Advanced Options";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GeneratedPassword.Text.Length > 0)
                Clipboard.SetText(GeneratedPassword.Text);
        }
    }
}
