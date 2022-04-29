namespace SwissTransportGUI
{
    partial class FormSwissTransportGUIStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwissTransportGUIStart));
            this.btnshare = new System.Windows.Forms.Button();
            this.dgvconnections = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldepartdelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldepartline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrivaldelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdepartpanel = new System.Windows.Forms.DataGridView();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldepartpanel = new System.Windows.Forms.Label();
            this.cboarrival = new System.Windows.Forms.ComboBox();
            this.cbodepart = new System.Windows.Forms.ComboBox();
            this.lblarrival = new System.Windows.Forms.Label();
            this.lbldeparture = new System.Windows.Forms.Label();
            this.panelbanner = new System.Windows.Forms.Panel();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.timerde = new System.Windows.Forms.Timer(this.components);
            this.timerar = new System.Windows.Forms.Timer(this.components);
            this.btnsearch = new System.Windows.Forms.Button();
            this.datetimepickerdate = new System.Windows.Forms.DateTimePicker();
            this.datetimepickertime = new System.Windows.Forms.DateTimePicker();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblconnections = new System.Windows.Forms.Label();
            this.btnmap = new System.Windows.Forms.Button();
            this.lbldepartdescription = new System.Windows.Forms.Label();
            this.webview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblinfotext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartpanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshare
            // 
            this.btnshare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshare.BackgroundImage")));
            this.btnshare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnshare.ForeColor = System.Drawing.Color.Black;
            this.btnshare.Location = new System.Drawing.Point(686, 203);
            this.btnshare.Name = "btnshare";
            this.btnshare.Size = new System.Drawing.Size(84, 77);
            this.btnshare.TabIndex = 6;
            this.btnshare.UseVisualStyleBackColor = true;
            this.btnshare.Click += new System.EventHandler(this.btnshare_Click);
            // 
            // dgvconnections
            // 
            this.dgvconnections.AllowUserToAddRows = false;
            this.dgvconnections.AllowUserToDeleteRows = false;
            this.dgvconnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.coldepartdelay,
            this.coldepartline,
            this.colarrivaltime,
            this.colarrivaldelay,
            this.colarrival});
            this.dgvconnections.Location = new System.Drawing.Point(43, 325);
            this.dgvconnections.Name = "dgvconnections";
            this.dgvconnections.RowHeadersVisible = false;
            this.dgvconnections.RowTemplate.Height = 25;
            this.dgvconnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvconnections.Size = new System.Drawing.Size(811, 211);
            this.dgvconnections.TabIndex = 1;
            // 
            // Departure
            // 
            this.Departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departure.HeaderText = "Abfahrtszeitpunkt";
            this.Departure.Name = "Departure";
            // 
            // coldepartdelay
            // 
            this.coldepartdelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldepartdelay.HeaderText = "Abfahrtsverspätung";
            this.coldepartdelay.Name = "coldepartdelay";
            // 
            // coldepartline
            // 
            this.coldepartline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldepartline.HeaderText = "Abfahrtslinie";
            this.coldepartline.Name = "coldepartline";
            // 
            // colarrivaltime
            // 
            this.colarrivaltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colarrivaltime.HeaderText = "Ankunftszeit";
            this.colarrivaltime.Name = "colarrivaltime";
            // 
            // colarrivaldelay
            // 
            this.colarrivaldelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colarrivaldelay.HeaderText = "Ankunftsverspätung";
            this.colarrivaldelay.Name = "colarrivaldelay";
            // 
            // colarrival
            // 
            this.colarrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colarrival.HeaderText = "Ankunftsliniepunkt";
            this.colarrival.Name = "colarrival";
            // 
            // dgvdepartpanel
            // 
            this.dgvdepartpanel.AllowUserToAddRows = false;
            this.dgvdepartpanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepartpanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colname,
            this.colnumber,
            this.colto});
            this.dgvdepartpanel.Location = new System.Drawing.Point(43, 583);
            this.dgvdepartpanel.Name = "dgvdepartpanel";
            this.dgvdepartpanel.RowHeadersVisible = false;
            this.dgvdepartpanel.RowTemplate.Height = 25;
            this.dgvdepartpanel.Size = new System.Drawing.Size(811, 242);
            this.dgvdepartpanel.TabIndex = 2;
            // 
            // colname
            // 
            this.colname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colname.HeaderText = "Name";
            this.colname.Name = "colname";
            // 
            // colnumber
            // 
            this.colnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnumber.HeaderText = "Linie";
            this.colnumber.Name = "colnumber";
            // 
            // colto
            // 
            this.colto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colto.HeaderText = "Abfahrt";
            this.colto.Name = "colto";
            // 
            // lbldepartpanel
            // 
            this.lbldepartpanel.AutoSize = true;
            this.lbldepartpanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldepartpanel.Location = new System.Drawing.Point(43, 539);
            this.lbldepartpanel.Name = "lbldepartpanel";
            this.lbldepartpanel.Size = new System.Drawing.Size(164, 32);
            this.lbldepartpanel.TabIndex = 3;
            this.lbldepartpanel.Text = "Abfahrtstafel";
            this.lbldepartpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // cboarrival
            // 
            this.cboarrival.FormattingEnabled = true;
            this.cboarrival.Location = new System.Drawing.Point(43, 257);
            this.cboarrival.Name = "cboarrival";
            this.cboarrival.Size = new System.Drawing.Size(337, 23);
            this.cboarrival.TabIndex = 1;
            this.cboarrival.SelectedIndexChanged += new System.EventHandler(this.preventdropdown);
            this.cboarrival.TextChanged += new System.EventHandler(this.cbotextchanged);
            // 
            // cbodepart
            // 
            this.cbodepart.FormattingEnabled = true;
            this.cbodepart.Location = new System.Drawing.Point(43, 203);
            this.cbodepart.Name = "cbodepart";
            this.cbodepart.Size = new System.Drawing.Size(337, 23);
            this.cbodepart.TabIndex = 0;
            this.cbodepart.SelectedIndexChanged += new System.EventHandler(this.preventdropdown);
            this.cbodepart.TextChanged += new System.EventHandler(this.cbotextchanged);
            // 
            // lblarrival
            // 
            this.lblarrival.AutoSize = true;
            this.lblarrival.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblarrival.Location = new System.Drawing.Point(43, 229);
            this.lblarrival.Name = "lblarrival";
            this.lblarrival.Size = new System.Drawing.Size(110, 25);
            this.lblarrival.TabIndex = 6;
            this.lblarrival.Text = "Ankunftsort";
            this.lblarrival.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // lbldeparture
            // 
            this.lbldeparture.AutoSize = true;
            this.lbldeparture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldeparture.Location = new System.Drawing.Point(43, 175);
            this.lbldeparture.Name = "lbldeparture";
            this.lbldeparture.Size = new System.Drawing.Size(107, 25);
            this.lbldeparture.TabIndex = 7;
            this.lbldeparture.Text = "Abfahrtsort";
            this.lbldeparture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // panelbanner
            // 
            this.panelbanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelbanner.BackgroundImage")));
            this.panelbanner.Location = new System.Drawing.Point(1, 0);
            this.panelbanner.Name = "panelbanner";
            this.panelbanner.Size = new System.Drawing.Size(931, 108);
            this.panelbanner.TabIndex = 8;
            this.panelbanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.Transparent;
            this.paneltitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneltitle.BackgroundImage")));
            this.paneltitle.Location = new System.Drawing.Point(369, 114);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(193, 64);
            this.paneltitle.TabIndex = 0;
            this.paneltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // timerde
            // 
            this.timerde.Interval = 700;
            this.timerde.Tag = "depart";
            this.timerde.Tick += new System.EventHandler(this.autofillcbo);
            // 
            // timerar
            // 
            this.timerar.Interval = 700;
            this.timerar.Tag = "arrival";
            this.timerar.Tick += new System.EventHandler(this.autofillcbo);
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearch.Location = new System.Drawing.Point(524, 203);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(156, 77);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // datetimepickerdate
            // 
            this.datetimepickerdate.CustomFormat = "   dd.MM.yyyy";
            this.datetimepickerdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerdate.Location = new System.Drawing.Point(403, 257);
            this.datetimepickerdate.Name = "datetimepickerdate";
            this.datetimepickerdate.Size = new System.Drawing.Size(104, 23);
            this.datetimepickerdate.TabIndex = 1;
            // 
            // datetimepickertime
            // 
            this.datetimepickertime.CustomFormat = "   HH:mm";
            this.datetimepickertime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickertime.Location = new System.Drawing.Point(403, 203);
            this.datetimepickertime.Name = "datetimepickertime";
            this.datetimepickertime.ShowUpDown = true;
            this.datetimepickertime.Size = new System.Drawing.Size(104, 23);
            this.datetimepickertime.TabIndex = 0;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(403, 183);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(27, 15);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "Zeit";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(403, 236);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 15);
            this.lbldate.TabIndex = 12;
            this.lbldate.Text = "Datum";
            // 
            // lblconnections
            // 
            this.lblconnections.AutoSize = true;
            this.lblconnections.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblconnections.Location = new System.Drawing.Point(43, 283);
            this.lblconnections.Name = "lblconnections";
            this.lblconnections.Size = new System.Drawing.Size(176, 32);
            this.lblconnections.TabIndex = 13;
            this.lblconnections.Text = "Verbindungen";
            // 
            // btnmap
            // 
            this.btnmap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmap.BackgroundImage")));
            this.btnmap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmap.ForeColor = System.Drawing.Color.Black;
            this.btnmap.Location = new System.Drawing.Point(776, 203);
            this.btnmap.Name = "btnmap";
            this.btnmap.Size = new System.Drawing.Size(84, 77);
            this.btnmap.TabIndex = 14;
            this.btnmap.UseVisualStyleBackColor = true;
            this.btnmap.Click += new System.EventHandler(this.btnmap_Click);
            // 
            // lbldepartdescription
            // 
            this.lbldepartdescription.AutoSize = true;
            this.lbldepartdescription.Location = new System.Drawing.Point(202, 553);
            this.lbldepartdescription.Name = "lbldepartdescription";
            this.lbldepartdescription.Size = new System.Drawing.Size(195, 15);
            this.lbldepartdescription.TabIndex = 15;
            this.lbldepartdescription.Text = "Nur vom eingegebenen Abfahrtsort";
            // 
            // webview
            // 
            this.webview.AllowExternalDrop = true;
            this.webview.CreationProperties = null;
            this.webview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webview.Location = new System.Drawing.Point(930, -1);
            this.webview.Name = "webview";
            this.webview.Size = new System.Drawing.Size(884, 837);
            this.webview.TabIndex = 0;
            this.webview.ZoomFactor = 1D;
            // 
            // lblinfotext
            // 
            this.lblinfotext.AutoSize = true;
            this.lblinfotext.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblinfotext.Location = new System.Drawing.Point(1007, 396);
            this.lblinfotext.Name = "lblinfotext";
            this.lblinfotext.Size = new System.Drawing.Size(726, 40);
            this.lblinfotext.TabIndex = 16;
            this.lblinfotext.Text = "Drücken sie den Suchknopf um die Karte zu initalisieren.";
            // 
            // FormSwissTransportGUIStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1820, 837);
            this.Controls.Add(this.webview);
            this.Controls.Add(this.lbldepartdescription);
            this.Controls.Add(this.btnmap);
            this.Controls.Add(this.lblconnections);
            this.Controls.Add(this.dgvdepartpanel);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnshare);
            this.Controls.Add(this.datetimepickerdate);
            this.Controls.Add(this.datetimepickertime);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelbanner);
            this.Controls.Add(this.lbldeparture);
            this.Controls.Add(this.lblarrival);
            this.Controls.Add(this.cbodepart);
            this.Controls.Add(this.cboarrival);
            this.Controls.Add(this.lbldepartpanel);
            this.Controls.Add(this.dgvconnections);
            this.Controls.Add(this.lblinfotext);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSwissTransportGUIStart";
            this.Text = "ÖV Verbinder - Startseite";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartpanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnshare;
        private DataGridView dgvconnections;
        private DataGridView dgvdepartpanel;
        private Label lbldepartpanel;
        private ComboBox cboarrival;
        private ComboBox cbodepart;
        private Label lblarrival;
        private Label lbldeparture;
        private Panel panelbanner;
        private Panel paneltitle;
        private System.Windows.Forms.Timer timerde;
        private System.Windows.Forms.Timer timerar;
        private Button btnsearch;
        private DateTimePicker datetimepickerdate;
        private DateTimePicker datetimepickertime;
        private Label lbltime;
        private Label lbldate;
        private Label lblconnections;
        private Button btnmap;
        private Label lbldepartdescription;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn coldepartdelay;
        private DataGridViewTextBoxColumn coldepartline;
        private DataGridViewTextBoxColumn colarrivaltime;
        private DataGridViewTextBoxColumn colarrivaldelay;
        private DataGridViewTextBoxColumn colarrival;
        private DataGridViewTextBoxColumn colname;
        private DataGridViewTextBoxColumn colnumber;
        private DataGridViewTextBoxColumn colto;
        private Microsoft.Web.WebView2.WinForms.WebView2 webview;
        private Label lblinfotext;
    }
}