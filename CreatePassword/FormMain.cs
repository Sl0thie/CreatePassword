using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatePassword
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PasswordLength.Value = Properties.Settings.Default.Length;
            UseNumbers.Checked = Properties.Settings.Default.UseNumbers;
            UseSymbols.Checked = Properties.Settings.Default.UseSymbols;
            UseLowercase.Checked = Properties.Settings.Default.UseLowercase;
            UseUppercase.Checked = Properties.Settings.Default.UseUppercase;
            CopyToClipboard.Checked = Properties.Settings.Default.CopyToClipboard;
            AutoClose.Checked = Properties.Settings.Default.AutoClose;
            Top = Properties.Settings.Default.Top;
            Left = Properties.Settings.Default.Left;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            CreateNewPassword();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Length = (int)PasswordLength.Value;
            Properties.Settings.Default.UseNumbers = UseNumbers.Checked;
            Properties.Settings.Default.UseSymbols = UseSymbols.Checked;
            Properties.Settings.Default.UseLowercase = UseLowercase.Checked;
            UseUppercase.Checked = Properties.Settings.Default.UseUppercase = UseUppercase.Checked;
            Properties.Settings.Default.CopyToClipboard = CopyToClipboard.Checked;
            Properties.Settings.Default.AutoClose = AutoClose.Checked;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Save();
        }

        private void CreatePassword_Click(object sender, EventArgs e)
        {
            CreateNewPassword();
            ResetTimer(null,null);
        }

        private void CreateNewPassword()
        {
            Password.Text = "";
            var rand = new Random();

            while (Password.TextLength < PasswordLength.Value)
            {
                switch (rand.Next(94))
                {
                    case 0:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "0"; }
                        break;
                    case 1:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "1"; }
                        break;
                    case 2:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "2"; }
                        break;
                    case 3:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "3"; }
                        break;
                    case 4:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "4"; }
                        break;
                    case 5:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "5"; }
                        break;
                    case 6:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "6"; }
                        break;
                    case 7:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "7"; }
                        break;
                    case 8:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "8"; }
                        break;
                    case 9:
                        if (UseNumbers.Checked) { Password.Text = Password.Text + "9"; }
                        break;
                    case 10:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "~"; }
                        break;
                    case 11:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "!"; }
                        break;
                    case 12:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "@"; }
                        break;
                    case 13:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "#"; }
                        break;
                    case 14:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "$"; }
                        break;
                    case 15:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "%"; }
                        break;
                    case 16:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "^"; }
                        break;
                    case 17:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "&"; }
                        break;
                    case 18:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "*"; }
                        break;
                    case 19:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "("; }
                        break;
                    case 20:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + ")"; }
                        break;
                    case 21:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "_"; }
                        break;
                    case 22:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "-"; }
                        break;
                    case 23:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "+"; }
                        break;
                    case 24:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "="; }
                        break;
                    case 25:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "{"; }
                        break;
                    case 26:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "}"; }
                        break;
                    case 27:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "["; }
                        break;
                    case 28:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "]"; }
                        break;
                    case 29:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "|"; }
                        break;
                    case 30:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "\\"; }
                        break;
                    case 31:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + ":"; }
                        break;
                    case 32:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + ";"; }
                        break;
                    case 33:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "\""; }
                        break;
                    case 34:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "'"; }
                        break;
                    case 35:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "<"; }
                        break;
                    case 36:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + ">"; }
                        break;
                    case 37:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + ","; }
                        break;
                    case 38:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "."; }
                        break;
                    case 39:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "?"; }
                        break;
                    case 40:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "/"; }
                        break;
                    case 41:
                        if (UseSymbols.Checked) { Password.Text = Password.Text + "`"; }
                        break;
                    case 42:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "A"; }
                        break;
                    case 43:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "B"; }
                        break;
                    case 44:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "C"; }
                        break;
                    case 45:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "D"; }
                        break;
                    case 46:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "E"; }
                        break;
                    case 47:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "F"; }
                        break;
                    case 48:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "G"; }
                        break;
                    case 49:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "H"; }
                        break;
                    case 50:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "I"; }
                        break;
                    case 51:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "J"; }
                        break;
                    case 52:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "K"; }
                        break;
                    case 53:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "L"; }
                        break;
                    case 54:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "M"; }
                        break;
                    case 55:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "N"; }
                        break;
                    case 56:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "O"; }
                        break;
                    case 57:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "P"; }
                        break;
                    case 58:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "Q"; }
                        break;
                    case 59:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "R"; }
                        break;
                    case 60:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "S"; }
                        break;
                    case 61:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "T"; }
                        break;
                    case 62:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "U"; }
                        break;
                    case 63:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "V"; }
                        break;
                    case 64:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "W"; }
                        break;
                    case 65:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "X"; }
                        break;
                    case 66:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "Y"; }
                        break;
                    case 67:
                        if (UseUppercase.Checked) { Password.Text = Password.Text + "Z"; }
                        break;
                    case 68:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "a"; }
                        break;
                    case 69:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "b"; }
                        break;
                    case 70:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "c"; }
                        break;
                    case 71:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "d"; }
                        break;
                    case 72:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "e"; }
                        break;
                    case 73:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "f"; }
                        break;
                    case 74:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "g"; }
                        break;
                    case 75:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "h"; }
                        break;
                    case 76:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "i"; }
                        break;
                    case 77:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "j"; }
                        break;
                    case 78:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "k"; }
                        break;
                    case 79:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "l"; }
                        break;
                    case 80:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "m"; }
                        break;
                    case 81:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "n"; }
                        break;
                    case 82:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "o"; }
                        break;
                    case 83:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "p"; }
                        break;
                    case 84:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "q"; }
                        break;
                    case 85:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "r"; }
                        break;
                    case 86:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "s"; }
                        break;
                    case 87:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "t"; }
                        break;
                    case 88:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "u"; }
                        break;
                    case 89:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "v"; }
                        break;
                    case 90:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "w"; }
                        break;
                    case 91:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "x"; }
                        break;
                    case 92:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "y"; }
                        break;
                    case 93:
                        if (UseLowercase.Checked) { Password.Text = Password.Text + "z"; }
                        break;
                }
            }

            if (CopyToClipboard.Checked)
            {
                Clipboard.SetText(Password.Text);
            }
        }

        private void ResetTimer(object sender, EventArgs e)
        {
            CloseTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if(AutoClose.Checked) { this.Close(); }
        }
    }
}
