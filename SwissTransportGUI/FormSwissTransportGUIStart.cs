using System;
using System.Threading;
using SwissTransport.Core;
using SwissTransport.Models;
using Microsoft.Web.WebView2.Core;

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
            this.Size = new Size(934, 837);
            MessageBox.Show("Bitte schalten sie das Internet an für die Nutzung dieser Applikation ansonsten kann es sein dass dieses Programm crasht.");
            
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
            else if (sendername == "cboarrival")
            {
                timerar.Enabled = false;
                timerar.Enabled = true;
            }
        }

        private void autofillcbo(object sender, EventArgs e)
        {
            ComboBox senderbox = null;
            if (((System.Windows.Forms.Timer)sender).Tag == "arrival")
                senderbox = cboarrival;
            else if (((System.Windows.Forms.Timer)sender).Tag == "depart")
                senderbox = cbodepart;
            else
                return;
            if (senderbox.Text == null)
            {
                MessageBox.Show("Bitte einen Eintrag anklicken.");
            }
            else
            {
                ((ComboBox)senderbox).Items.Clear();
                ((System.Windows.Forms.Timer)sender).Enabled = false;
                foreach (Station station in SwissTransp.GetStations(((ComboBox)senderbox).Text).StationList)
                {
                    ((ComboBox)senderbox).Items.Add(station.Name);
                }
                if (prevention == false)
                    ((ComboBox)senderbox).DroppedDown = true;
                prevention = false;
                senderbox.SelectionStart = senderbox.Text.Length;
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbodepart.Text != null && cbodepart.Text != "")
            {
                if (this.Size.Width == 1820)
                    maprefresh();
                dgvdepartpanel.Rows.Clear();
                var list = SwissTransp.GetStationBoard(cbodepart.Text, " ");
                foreach (var station in list.Entries)
                {
                    dgvdepartpanel.Rows.Add(station.To, station.Number, string.Format("{0:HH:mm}", station.Stop.Departure));
                }

                DateTime date = datetimepickerdate.Value;
                TimeSpan time = datetimepickertime.Value - DateTime.Now.Date;
                dgvconnections.Rows.Clear();
                if (cboarrival.Text == null || cboarrival.Text == "")
                { }
                else
                {
                    Connections list2 = SwissTransp.GetConnections(cbodepart.Text, cboarrival.Text, date, time);
                    foreach (Connection connection in list2.ConnectionList)
                    {
                        dgvconnections.Rows.Add(connection.From.Departure, connection.From.Delay == 0 || connection.From.Delay == null ? "N/A" : connection.From.Delay, connection.From.Platform == null ? "N/A" : connection.From.Platform, connection.To.Arrival, connection.To.Delay == 0 || connection.To.Delay == null ? "N/A" : connection.To.Delay, connection.To.Platform == null ? "N/A" : connection.To.Platform);
                    }
                }
            }
            else { }
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

        private void btnshare_Click(object sender, EventArgs e)
        {
            string urlstring = "mailto:yourcoworker@workplace.com?subject=Meine%20Verbindung%20nach%20" + cboarrival.Text + "&body=";
            var list = dgvconnections.SelectedCells;
            int defcounter = 0;
            foreach (DataGridViewCell cell in list)
            {
                string tempstring = "";
                if (Convert.ToString(cell.Value) == "N/A")
                { }
                else
                {
                    switch (defcounter)
                    {
                        case 0:
                            tempstring = "Abfahrtszeitpunkt:";
                            urlstring += tempstring;
                            tempstring = "%20";
                            urlstring += tempstring;
                            break;
                        case 1:
                            tempstring = "Abfahrtsverspätung:";
                            urlstring += tempstring;
                            tempstring = "%20";
                            urlstring += tempstring;
                            break;
                        case 2:
                            tempstring = "Abfahrtslinie:";
                            tempstring += urlstring;
                            tempstring = "%20";
                            tempstring += urlstring;
                            break;
                        case 3:
                            tempstring = "Ankunftszeitpunkt:";
                            urlstring += tempstring;
                            tempstring = "%20";
                            urlstring += tempstring;
                            break;
                        case 4:
                            tempstring = "Ankunftsverspätung:";
                            urlstring += tempstring;
                            tempstring = "%20";
                            urlstring += tempstring;
                            break;
                        case 5:
                            tempstring = "Ankunftslinie:";
                            urlstring += tempstring;
                            tempstring = "%20";
                            urlstring += tempstring;
                            break;
                    }
                    tempstring = "%20";
                    urlstring += tempstring;
                    urlstring += cell.Value;
                    tempstring = "%20";
                    urlstring += tempstring;
                }
                defcounter++;
            }
            Uri url = new Uri(urlstring);
            webview.Source = url;
        }

        private void btnmap_Click(object sender, EventArgs e)
        {
            if (Size.Width == 1820)
                this.Size = new Size(934, 837);
            else
                this.Size = new Size(1820, 837);
        }
        private void maprefresh()
        {
            string arrival = "/" + cboarrival.Text;
            string depart = "/" + cbodepart.Text;
            string finalstring = "https://www.google.ch/maps/dir";
            finalstring += depart;
            finalstring += arrival;
            Uri url = new Uri(finalstring);
            webview.Source = url;
        }
    }
}