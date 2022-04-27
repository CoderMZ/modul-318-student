using System;
using System.Threading;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class FormSwissTransportGUIStart : Form
    {
        Transport SwissTransp = new Transport();
        public FormSwissTransportGUIStart()
        {
            InitializeComponent();
        }

        private void cbodepart_TextChanged(object sender, EventArgs e)
        {
            //add a timer which resets upon calling this class,
            //if this timer expires the set time run the autocompletion
            //also make sure that when a item is selected the clearing of items
            //ignores the currently selected station.
            try
            {
                
                cbodepart.Items.Clear();
                foreach (Station station in SwissTransp.GetStations(cbodepart.Text).StationList)
                {
                    cbodepart.Items.Add(station.Name);
                }
            }
            catch (Exception ex)
            { } 
            
        }
        //taken from "https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable"
        //to make the design prettier and because it's too hard
        //for me to code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormSwissTransportGUI_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}