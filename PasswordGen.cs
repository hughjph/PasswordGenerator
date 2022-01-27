using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;


namespace PasswordGenerator
{
    public partial class PasswordGen : Form
    {
        int Length = 15;
        bool Caps = false;
        bool Lower = false;
        bool Numbers = false;
        bool Symbols = false;
        bool Readable = false;
        string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
        string LowerCaseLetters = "abcdefghijklmnopqrstuvxyz";
        string NumberChars = "0123456789";
        string SpecialsChars = "£$&()*+[]@#^-_!?";
        Random r = new Random();
        string WordApiLink = "https://random-word-api.herokuapp.com/word?number=";



        public PasswordGen()
        {
            InitializeComponent();
        }

        private void lengthSelector_Scroll(object sender, EventArgs e)
        {
            Length = lengthSelector.Value;
            LengthText.Text = lengthSelector.Value.ToString();
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            Caps = capsCheck.Checked;
            Lower = lowerCheck.Checked;
            Numbers = numbersCheck.Checked;
            Symbols = symbolsCheck.Checked;
            Readable = readableCheck.Checked;

            if(!Caps && !Lower && !Numbers && !Symbols)
            {
                MessageBox.Show("Please Select at least one character type");
            }
            else if((Numbers || Symbols) && Readable && !Lower && !Caps)
            {
                MessageBox.Show("You need to select a letter type for it to be readable!");
            }
            else if(Readable && (Lower || Caps))
            {
                MessageBox.Show("Readable passwords do not include numbers or symbols");
                GenerateReadablePassword(Caps, Lower);
            }
            else
            {
                GeneratePassword(Caps, Lower, Numbers, Symbols);
            }
        }

        void GenerateReadablePassword(bool Caps, bool Lower)
        {
            string json = new WebClient().DownloadString(WordApiLink + Length.ToString());
            List<string> words = JsonConvert.DeserializeObject<List<string>>(json);
            string password = "";
            if (Caps && Lower)
            {
                foreach (string word in words)
                {
                    password += UppercaseFirst(word);
                }
            }else if (Caps && !Lower)
            {
                foreach (string word in words)
                {
                    password += word.ToUpper();
                }
            }else if (!Caps && Lower)
            {
                foreach (string word in words)
                {
                    password += word;
                }
            }

            output.Text = password;
        }

        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        void GeneratePassword(bool Caps, bool Lower, bool Numbers, bool Symbols)
        {
            int typeLength = 0;
            int CapsID = 0;
            int LowerID = 0;
            int NumberID = 0;
            int SymbolsID = 0;
            if (Caps)
            {
                typeLength += 1;
                CapsID = typeLength;
            }
            if (Lower)
            {
                typeLength += 1;
                LowerID = typeLength;
            }
            if (Numbers)
            {
                typeLength += 1;
                NumberID = typeLength;
            }
            if (Symbols)
            {
                typeLength += 1;
                SymbolsID = typeLength;
            }

            int CharType;
            string[] Password = new string[Length];

            for(int i = 0; i < Length; i++)
            {
                CharType = r.Next(1, typeLength+1);

                if(CharType == CapsID)
                {
                    Password[i] = UpperCaseLetters[r.Next(UpperCaseLetters.Length)].ToString();
                    Console.WriteLine("Caps");
                } else if(CharType == LowerID)
                {
                    Password[i] = LowerCaseLetters[r.Next(LowerCaseLetters.Length)].ToString();
                    Console.WriteLine("Lower");
                } else if(CharType == SymbolsID)
                {
                    Password[i] = SpecialsChars[r.Next(SpecialsChars.Length)].ToString();
                    Console.WriteLine("Symbol");
                } else if(CharType == NumberID)
                {
                    Password[i] = NumberChars[r.Next(NumberChars.Length)].ToString();
                    Console.WriteLine("Number");
                }
            }

            string OutputPassword = "";

            for(int i = 0; i < Password.Length; i++)
            {
                OutputPassword += Password[i];
            }

            output.Text = OutputPassword;
            
        }

        private void PasswordGen_Load(object sender, EventArgs e)
        {

        }

        private void readableCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (readableCheck.Checked)
            {
                lengthSelector.Maximum = 5;
                lengthSelector.Minimum = 1;
                LengthText.Text = lengthSelector.Value.ToString();
                SelectorTitle.Text = "Word Number";
            }
            else
            {
                lengthSelector.Maximum = 30;
                lengthSelector.Minimum = 8;
                LengthText.Text = lengthSelector.Value.ToString();
                SelectorTitle.Text = "Character Number";
            }
        }
    }
}
