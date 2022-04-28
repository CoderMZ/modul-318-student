using System;
using System.Threading;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class FormSwissTransportGUIStart : Form
    {
        bool prevention = false;
        string tempstringsave = string.Empty;
        Transport SwissTransp = new Transport();

        public FormSwissTransportGUIStart()
        {
            InitializeComponent();
            pnldepartpanel.Visible = false;
        }
        private void preventdropdown(object sender, EventArgs e)
        {
            prevention = true;
        }
        //hier dasselbe wie unten
        private void cbotextchanged(object sender, EventArgs e)
        {
            string sendername = ((ComboBox)sender).Name;
            if (sendername == "cbodepart")
            {
                timerde.Enabled = false;
                timerde.Enabled = true;
            }
            else if(sendername == "cboarrival")
            {
                timerar.Enabled = false;
                timerar.Enabled = true;
            }
        }

        //am ende zu einer Methode fügen und variable erstellen damit kein duplicate code vorhanden ist.
        private void autofillcbo(object sender, EventArgs e)
        {
            ComboBox senderbox = null;
            if (((System.Windows.Forms.Timer)sender).Tag == "arrival")
                senderbox = cboarrival;
            else if (((System.Windows.Forms.Timer)sender).Tag == "depart")
                senderbox = cbodepart;
            else
                return;
                ((ComboBox)senderbox).Items.Clear();
            ((System.Windows.Forms.Timer)sender).Enabled = false;
            try
            {
                foreach (Station station in SwissTransp.GetStations(((ComboBox)senderbox).Text).StationList)
                {
                    ((ComboBox)senderbox).Items.Add(station.Name);
                }
            }
            catch (Exception ex)
            { }
            if(prevention == false)
                ((ComboBox)senderbox).DroppedDown = true;
            prevention = false;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            object list = SwissTransp.GetConnections(cbodepart.Text, cboarrival.Text);
            foreach(Connection connection in ((Connections)list).ConnectionList)
            {
                dgvconnections.Rows.Add(connection.From.Departure, connection.From.Delay, connection.To.Platform, connection.To.Arrival, connection.To.Delay, connection.To.Platform);
            }
        }

        //source: "https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable"
        //this code enables the dragging of the form without a border.
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

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if(chk.Checked == true)
            {
                pnldepartpanel.Visible = true;
            }
            else
            {
                pnldepartpanel.Visible = false;
            }
        }
    }
}