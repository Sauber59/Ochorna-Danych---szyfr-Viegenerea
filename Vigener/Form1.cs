using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        private void encrypt_BTN_Click(object sender, EventArgs e)
        {
            output_TB.Clear();

            char[] key = keyTB.Text.ToCharArray();
            char[] charsToEncode = input_TB.Text.ToArray();
            string encodeText = "";

            for (int i = 0; i < charsToEncode.Length; i++)
            {
                {
                    int numberKey = i % key.Length;
                    encodeText += alphabet[(getNumberOfLetter(charsToEncode[i]) + getNumberOfLetter(key[numberKey])) % alphabet.Length];
                }
            }

            output_TB.Paste(encodeText);
        }

        private void decrypt_BTN_Click(object sender, EventArgs e)
        {
            output_TB.Clear();

            char[] key = keyTB.Text.ToCharArray();
            char[] charsToDecode = input_TB.Text.ToArray();
            string decodeText = "";

            for (int i = 0; i < charsToDecode.Length; i++)
            {
                {
                    int numberKey = i % key.Length;
                    decodeText += alphabet[(getNumberOfLetter(charsToDecode[i]) - getNumberOfLetter(key[numberKey])) % alphabet.Length];
                }
            }

            output_TB.Paste(decodeText);
        }

        private int getNumberOfLetter(char letter)
        {
            int x = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (char.Equals(char.ToUpper(letter), alphabet[i]))
                {
                    x = i;
                }
            }
            return x;
        }

        private void input_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkEnterChar(e);
        }
        private void keyTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkEnterChar(e);
        }

        private static void checkEnterChar(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == 'ą' || e.KeyChar == 'ę' || e.KeyChar == 'ź' || e.KeyChar == 'ć' || e.KeyChar == 'ń' || e.KeyChar == 'ó' || e.KeyChar == 'ł')
            {
                MessageBox.Show("Tylko litery, bez polskich znakow");
                e.Handled = true;
            }
        }
    }
}
