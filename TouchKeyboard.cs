using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingManagement
{
    public partial class TouchKeyboard : UserControl
    {
        public event EventHandler KeyClicked;

        public delegate void InputUpdatedEventHandler(string newValue);
        public event InputUpdatedEventHandler InputUpdated;
        private String input;
        public String Input
        {
            get { return input; }
            set
            {
                if (input != value)
                {
                    input = value;
                    OnInputUpdated(input);
                }
            }
        }
        public TouchKeyboard()
        {
            InitializeComponent();
        }

        private void OnKeyClick(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            string key = clickedButton.Name;
            switch (key)
            {
                case "qButton":
                    Input += 'Q';
                    break;
                case "wButton":
                    Input += 'W';
                    break;
                case "eButton":
                    Input += 'E';
                    break;
                case "rButton":
                    Input += 'R';
                    break;
                case "tButton":
                    Input += 'T';
                    break;
                case "yButton":
                    Input += 'Y';
                    break;
                case "uButton":
                    Input += 'U';
                    break;
                case "iButton":
                    Input += 'I';
                    break;
                case "oButton":
                    Input += 'O';
                    break;
                case "pButton":
                    Input += 'P';
                    break;
                case "aButton":
                    Input += 'A';
                    break;
                case "sButton":
                    Input += 'S';
                    break;
                case "dButton":
                    Input += 'D';
                    break;
                case "fButton":
                    Input += 'F';
                    break;
                case "gButton":
                    Input += 'G';
                    break;
                case "hButton":
                    Input += 'H';
                    break;
                case "jButton":
                    Input += 'J';
                    break;
                case "kButton":
                    Input += 'K';
                    break;
                case "lButton":
                    Input += 'L';
                    break;
                case "zButton":
                    Input += 'Z';
                    break;
                case "xButton":
                    Input += 'X';
                    break;
                case "cButton":
                    Input += 'C';
                    break;
                case "vButton":
                    Input += 'V';
                    break;
                case "bButton":
                    Input += 'B';
                    break;
                case "nButton":
                    Input += 'N';
                    break;
                case "mButton":
                    Input += 'M';
                    break;
                case "spaceButton":
                    Input += ' ';
                    break;
                case "commaButton":
                    Input += ',';
                    break;
                case "dotButton":
                    Input += '.';
                    break;
                case "backButton":
                    if(Input.Length > 0)
                    {
                        Input = Input.Substring(0, Input.Length - 1);
                    }
                    break;
                default:
                    // Handle other buttons if needed
                    break;
            }

        }

        protected virtual void OnInputUpdated(string newValue)
        {
            InputUpdated?.Invoke(newValue);
        }
    }
}
