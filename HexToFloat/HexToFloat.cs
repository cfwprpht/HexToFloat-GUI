using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexToFloa
{
    public partial class HexToFloat : Form
    {
        #region var's
        public string[] badHexLetter = 
        { 
            ",", ";", ".", ":", "-", "_", "#", "'", "*", "+", "~", "`", "´", "?", "ß", @"\", "=", "}", ")", "]", "(", "[", "{", "/", "&", "%", "$", "§", "!", "<", ">", "|", "€", "@", "°", "^",
            "Ä", "Ö", "Ü", "ä", "ü", "ö", "²", "³", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "G", "H", "I", "J", "K", "L", "M", "N", 
            "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
        };
        #endregion var's

        // Initialize Components
        public HexToFloat()
        {
            InitializeComponent();
        }

        // On Load of App do...
        private void HexToFloat_Load(object sender, EventArgs e)
        {
            // EventHandler listener
            textSingleHex.TextChanged += new EventHandler(textSingleHex_Changed);
            textDoubleHex.TextChanged += new EventHandler(textDoubleHex_Changed);
            textSingleFloat.TextChanged += new EventHandler(textSingleFloat_Changed);
            textDoubleFloat.TextChanged += new EventHandler(textDoubleFloat_Changed);
        }

        // On Title Click close app
        private void Title_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hex2Float & Float2Hex Tool\nv1.00\nby cfwprophet");
        }

        // Little Endian Swap the input long Hex value and return as such
        private long LittleEndian(long toSwap)
        {
            byte[] reversed = BitConverter.GetBytes(toSwap);
            Array.Reverse(reversed);
            long result = BitConverter.ToInt64(reversed, 0);
            return result;
        }

        // Listen if Single Hex text have changed. If so it will check user input for a valid WORD Hex value
        private void textSingleHex_Changed(object sender, EventArgs e)
        {
            if (!textSingleHex.Text.Contains("0x") && textSingleHex.Text != "")
                textSingleHex.Text = "0x" + textSingleHex.Text;

            string overload = textSingleHex.Text.Replace("0x", "");
            bool adjust = false;

            // Check input value for bad letter's and remove them if found
            for (int i = 0; i < badHexLetter.Length; i++)
            {
                if (overload.Contains(badHexLetter[i]))
                {
                    MessageBox.Show("This is not a valid Hex value!");
                    textSingleHex.Text = "";
                }
            }

            // Check if the input value have the correct length. If not add zero(s) on top for to short and remove values from end if to long.
            if (overload.Length > 8)
            {
                for (int i = overload.Length; i > 8; i--)
                {
                    overload = overload.Remove(overload.Length - 1);
                    adjust = true;
                }
                if (adjust)
                    MessageBox.Show("Your Hex string would be adjusted please double check!");
            }
            else if (overload.Length < 8 && textSingleHex.Text != "")
            {
                for (int i = overload.Length; i < 8; i++)
                {
                    overload = overload.Insert(0, "0");
                    adjust = true;
                }
                if (adjust)
                    MessageBox.Show("Your Hex string would be adjusted please double check!");
            }
            if (adjust)
                textSingleHex.Text = "0x" + overload;
        }

        // Listen if Double Hex text have changed. If so it will check user input for a valid DWORD Hex value
        private void textDoubleHex_Changed(object sender, EventArgs e)
        {
            if (!textDoubleHex.Text.Contains("0x") && textDoubleHex.Text != "")
                textDoubleHex.Text = "0x" + textDoubleHex.Text;

            string overload = textDoubleHex.Text.Replace("0x", "");
            bool adjust = false;

            // Check input value for bad letter's and remove them if found
            for (int i = 0; i < badHexLetter.Length; i++)
            {
                if (overload.Contains(badHexLetter[i]))
                {
                    MessageBox.Show("This is not a valid Hex value!");
                    textDoubleHex.Text = "";
                }
            }

            // Check if the input value have the correct length. If not add zero(s) on top for to short and remove values from end if to long.
            if (overload.Length > 16)
            {
                for (int i = overload.Length; i > 16; i--)
                {
                    overload = overload.Remove(overload.Length - 1);
                    adjust = true;
                }
                if (adjust)
                    MessageBox.Show("Your Hex string would be adjusted please double check!");
            }
            else if (overload.Length < 16 && textDoubleHex.Text != "")
            {
                for (int i = overload.Length; i < 16; i++)
                {
                    overload = overload.Insert(0, "0");
                    adjust = true;
                }
                if (adjust)
                    MessageBox.Show("Your Hex string would be adjusted please double check!");
            }
            if (adjust)
                textDoubleHex.Text = "0x" + overload;
        }

        // Listen to if Single Float text have changed. If so it will check the user input for a valid single Float value
        private void textSingleFloat_Changed(object sender, EventArgs e)
        {
            try { if (textSingleFloat.Text != "") { Single singleFloat = Single.Parse(textSingleFloat.Text, CultureInfo.InvariantCulture); } }
            catch (Exception x)
            {
                textSingleFloat.Text = "";
                MessageBox.Show("This is not a Valid Single Float value!\n" + x.ToString());
            }
        }

        // Listen to if Double Float text have changed. If so it will check the user input for a valid double Float value
        private void textDoubleFloat_Changed(object sender, EventArgs e)
        {
            try { if (textDoubleFloat.Text != "") { double doubleFloat = Double.Parse(textDoubleFloat.Text, CultureInfo.InvariantCulture); } }
            catch (Exception x)
            {
                textDoubleFloat.Text = "";
                MessageBox.Show("This is not a Valid Double Float value!\n" + x.ToString());
            }
        }

        // Convert WORD to Float
        private void ConvertToSingleFloat_Click(object sender, EventArgs e)
        {
            textSingleFloat.Text = "";
            if (textSingleHex.Text != "")
            {
                try
                {
                    byte[] singleHex = BitConverter.GetBytes(uint.Parse(textSingleHex.Text.Replace("0x", ""), NumberStyles.AllowHexSpecifier));   // By putting the input into a uint value and reading that to a byte[] we already have reversed the input Hex byte value...
                    if (checkReverse.Checked) { Array.Reverse(singleHex); }  // ...So we only need to reverse again if we specifically want to use the little endian value to get our float
                    Single singleFloat = BitConverter.ToSingle(singleHex, 0);
                    textSingleFloat.Text = singleFloat.ToString();
                }
                catch (Exception x) { MessageBox.Show(x.ToString()); }
            }
        }

        // Convert Float to WORD
        private void ConvertToSingleHex_Click(object sender, EventArgs e)
        {
            textSingleHex.Text = "";
            if (textSingleFloat.Text != "")
            {
                try
                {
                    byte[] singleHex = BitConverter.GetBytes(Single.Parse(textSingleFloat.Text, CultureInfo.InvariantCulture));
                    if (!checkReverse.Checked) { Array.Reverse(singleHex); }  // Standard : we will reverse the Array cause single float is stored as a little endian value. If Reverse check box is set we will not reverse and use orig hex value.
                    textSingleHex.Text = "0x" + BitConverter.ToString(singleHex).Replace("-", "");
                }
                catch (Exception x) { MessageBox.Show(x.ToString()); }
            }
        }

        // Convert DWORD to Double Float
        private void ConvertToDoubleFloat_Click(object sender, EventArgs e)
        {
            textDoubleFloat.Text = "";
            if (textDoubleHex.Text != "")
            {
                try
                {
                    if (checkReverse.Checked) { textDoubleFloat.Text = BitConverter.Int64BitsToDouble(LittleEndian(long.Parse(textDoubleHex.Text.Replace("0x", ""), NumberStyles.AllowHexSpecifier))).ToString(); }
                    else { textDoubleFloat.Text = BitConverter.Int64BitsToDouble(long.Parse(textDoubleHex.Text.Replace("0x", ""), NumberStyles.AllowHexSpecifier)).ToString(); }
                }
                catch (Exception x) { MessageBox.Show(x.ToString()); }
            }
        }

        // Convert double Float to a DWORD
        private void ConvertToDoubleHex_Click(object sender, EventArgs e)
        {
            textDoubleHex.Text = "";
            if (textDoubleFloat.Text != "")
            {
                try
                {
                    if (checkReverse.Checked) { textDoubleHex.Text = "0x" + LittleEndian(BitConverter.DoubleToInt64Bits(Double.Parse(textDoubleFloat.Text, CultureInfo.InvariantCulture))).ToString("X"); }
                    else { textDoubleHex.Text = "0x" + BitConverter.DoubleToInt64Bits(Double.Parse(textDoubleFloat.Text, CultureInfo.InvariantCulture)).ToString("X"); } // The "X" specification in the ToString() cast will display the Long integer value with there Hex representation
                }
                catch (Exception x) { MessageBox.Show(x.ToString()); }
            }
        }
    }
}
