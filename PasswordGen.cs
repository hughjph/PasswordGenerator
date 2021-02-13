using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator
{
    public partial class PasswordGen : Form
    {
        int Length = 15;
        string[] password;
        bool Caps = false;
        bool Lower = false;
        bool Numbers = false;
        bool Symbols = false;
        string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
        string LowerCaseLetters = "abcdefghijklmnopqrstuvxyz";
        string NumberChars = "0123456789";
        string SpecialsChars = "£$&()*+[]@#^-_!?";
        Random r = new Random();

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

            if(!Caps && !Lower && !Numbers && !Symbols)
            {
                MessageBox.Show("Please Select at least one type");
            }
            else
            {
                GeneratePassword(Caps, Lower, Numbers, Symbols);
            }

            

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
    }
}
