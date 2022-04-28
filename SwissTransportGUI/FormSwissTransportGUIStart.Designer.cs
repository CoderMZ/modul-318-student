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
            this.flpbuttons = new System.Windows.Forms.FlowLayoutPanel();
            this.btntdate = new System.Windows.Forms.Button();
            this.btnmap = new System.Windows.Forms.Button();
            this.btnshare = new System.Windows.Forms.Button();
            this.dgvconnections = new System.Windows.Forms.DataGridView();
            this.cgvdepartpanel = new System.Windows.Forms.DataGridView();
            this.lbldepartpanel = new System.Windows.Forms.Label();
            this.cboarrival = new System.Windows.Forms.ComboBox();
            this.cbodepart = new System.Windows.Forms.ComboBox();
            this.lblarrival = new System.Windows.Forms.Label();
            this.lbldeparture = new System.Windows.Forms.Label();
            this.pnlbanner = new System.Windows.Forms.Panel();
            this.pnltitle = new System.Windows.Forms.Panel();
            this.timerde = new System.Windows.Forms.Timer(this.components);
            this.timerar = new System.Windows.Forms.Timer(this.components);
            this.btnsearch = new System.Windows.Forms.Button();
            this.pnldepartpanel = new System.Windows.Forms.Panel();
            this.chk = new System.Windows.Forms.CheckBox();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldepartdelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldepartline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrivaldelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colarrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgvdepartpanel)).BeginInit();
            this.pnldepartpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpbuttons
            // 
            this.flpbuttons.Controls.Add(this.btntdate);
            this.flpbuttons.Controls.Add(this.btnmap);
            this.flpbuttons.Controls.Add(this.btnshare);
            this.flpbuttons.Location = new System.Drawing.Point(43, 755);
            this.flpbuttons.Name = "flpbuttons";
            this.flpbuttons.Size = new System.Drawing.Size(826, 100);
            this.flpbuttons.TabIndex = 0;
            // 
            // btntdate
            // 
            this.btntdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntdate.Location = new System.Drawing.Point(3, 3);
            this.btntdate.Name = "btntdate";
            this.btntdate.Size = new System.Drawing.Size(317, 97);
            this.btntdate.TabIndex = 0;
            this.btntdate.Text = "Datum/Zeitplaner";
            this.btntdate.UseVisualStyleBackColor = true;
            // 
            // btnmap
            // 
            this.btnmap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmap.Location = new System.Drawing.Point(326, 3);
            this.btnmap.Name = "btnmap";
            this.btnmap.Size = new System.Drawing.Size(317, 97);
            this.btnmap.TabIndex = 1;
            this.btnmap.Text = "Kartendarsteller";
            this.btnmap.UseVisualStyleBackColor = true;
            // 
            // btnshare
            // 
            this.btnshare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnshare.ForeColor = System.Drawing.Color.Black;
            this.btnshare.Location = new System.Drawing.Point(649, 3);
            this.btnshare.Name = "btnshare";
            this.btnshare.Size = new System.Drawing.Size(168, 97);
            this.btnshare.TabIndex = 2;
            this.btnshare.Text = "Teilen";
            this.btnshare.UseVisualStyleBackColor = true;
            // 
            // dgvconnections
            // 
            this.dgvconnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.coldepartdelay,
            this.coldepartline,
            this.colarrivaltime,
            this.colarrivaldelay,
            this.colarrival});
            this.dgvconnections.Location = new System.Drawing.Point(43, 313);
            this.dgvconnections.Name = "dgvconnections";
            this.dgvconnections.RowTemplate.Height = 25;
            this.dgvconnections.Size = new System.Drawing.Size(817, 422);
            this.dgvconnections.TabIndex = 1;
            // 
            // cgvdepartpanel
            // 
            this.cgvdepartpanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cgvdepartpanel.Location = new System.Drawing.Point(0, 0);
            this.cgvdepartpanel.Name = "cgvdepartpanel";
            this.cgvdepartpanel.RowTemplate.Height = 25;
            this.cgvdepartpanel.Size = new System.Drawing.Size(811, 412);
            this.cgvdepartpanel.TabIndex = 2;
            // 
            // lbldepartpanel
            // 
            this.lbldepartpanel.AutoSize = true;
            this.lbldepartpanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldepartpanel.Location = new System.Drawing.Point(570, 239);
            this.lbldepartpanel.Name = "lbldepartpanel";
            this.lbldepartpanel.Size = new System.Drawing.Size(164, 32);
            this.lbldepartpanel.TabIndex = 3;
            this.lbldepartpanel.Text = "Abfahrtstafel";
            this.lbldepartpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // cboarrival
            // 
            this.cboarrival.FormattingEnabled = true;
            this.cboarrival.Location = new System.Drawing.Point(43, 267);
            this.cboarrival.Name = "cboarrival";
            this.cboarrival.Size = new System.Drawing.Size(337, 23);
            this.cboarrival.TabIndex = 4;
            this.cboarrival.SelectedIndexChanged += new System.EventHandler(this.preventdropdown);
            this.cboarrival.TextChanged += new System.EventHandler(this.cbotextchanged);
            // 
            // cbodepart
            // 
            this.cbodepart.FormattingEnabled = true;
            this.cbodepart.Location = new System.Drawing.Point(43, 213);
            this.cbodepart.Name = "cbodepart";
            this.cbodepart.Size = new System.Drawing.Size(337, 23);
            this.cbodepart.TabIndex = 5;
            this.cbodepart.SelectedIndexChanged += new System.EventHandler(this.preventdropdown);
            this.cbodepart.TextChanged += new System.EventHandler(this.cbotextchanged);
            // 
            // lblarrival
            // 
            this.lblarrival.AutoSize = true;
            this.lblarrival.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblarrival.Location = new System.Drawing.Point(43, 239);
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
            this.lbldeparture.Location = new System.Drawing.Point(43, 185);
            this.lbldeparture.Name = "lbldeparture";
            this.lbldeparture.Size = new System.Drawing.Size(107, 25);
            this.lbldeparture.TabIndex = 7;
            this.lbldeparture.Text = "Abfahrtsort";
            this.lbldeparture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // pnlbanner
            // 
            this.pnlbanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlbanner.BackgroundImage")));
            this.pnlbanner.Location = new System.Drawing.Point(0, 0);
            this.pnlbanner.Name = "pnlbanner";
            this.pnlbanner.Size = new System.Drawing.Size(932, 108);
            this.pnlbanner.TabIndex = 8;
            this.pnlbanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.Transparent;
            this.pnltitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnltitle.BackgroundImage")));
            this.pnltitle.Location = new System.Drawing.Point(369, 114);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(193, 64);
            this.pnltitle.TabIndex = 0;
            this.pnltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
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
            this.btnsearch.Location = new System.Drawing.Point(386, 213);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(52, 77);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // pnldepartpanel
            // 
            this.pnldepartpanel.Controls.Add(this.cgvdepartpanel);
            this.pnldepartpanel.Location = new System.Drawing.Point(43, 313);
            this.pnldepartpanel.Name = "pnldepartpanel";
            this.pnldepartpanel.Size = new System.Drawing.Size(817, 422);
            this.pnldepartpanel.TabIndex = 10;
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk.Location = new System.Drawing.Point(730, 250);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(15, 14);
            this.chk.TabIndex = 11;
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrtszeit";
            this.Departure.Name = "Departure";
            this.Departure.Width = 130;
            // 
            // coldepartdelay
            // 
            this.coldepartdelay.HeaderText = "Abfahrtsverspätung";
            this.coldepartdelay.Name = "coldepartdelay";
            this.coldepartdelay.Width = 130;
            // 
            // coldepartline
            // 
            this.coldepartline.HeaderText = "Abfahrtslinie";
            this.coldepartline.Name = "coldepartline";
            this.coldepartline.Width = 130;
            // 
            // colarrivaltime
            // 
            this.colarrivaltime.HeaderText = "Ankunftszeit";
            this.colarrivaltime.Name = "colarrivaltime";
            this.colarrivaltime.Width = 130;
            // 
            // colarrivaldelay
            // 
            this.colarrivaldelay.HeaderText = "Ankunftsverspätung";
            this.colarrivaldelay.Name = "colarrivaldelay";
            this.colarrivaldelay.Width = 130;
            // 
            // colarrival
            // 
            this.colarrival.HeaderText = "Ankunftslinie";
            this.colarrival.Name = "colarrival";
            this.colarrival.Width = 130;
            // 
            // FormSwissTransportGUIStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(931, 889);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.pnldepartpanel);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.pnltitle);
            this.Controls.Add(this.pnlbanner);
            this.Controls.Add(this.lbldeparture);
            this.Controls.Add(this.lblarrival);
            this.Controls.Add(this.cbodepart);
            this.Controls.Add(this.cboarrival);
            this.Controls.Add(this.lbldepartpanel);
            this.Controls.Add(this.dgvconnections);
            this.Controls.Add(this.flpbuttons);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSwissTransportGUIStart";
            this.Text = "ÖV Verbinder - Startseite";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSwissTransportGUI_MouseDown);
            this.flpbuttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgvdepartpanel)).EndInit();
            this.pnldepartpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flpbuttons;
        private Button btntdate;
        private Button btnmap;
        private Button btnshare;
        private DataGridView dgvconnections;
        private DataGridView cgvdepartpanel;
        private Label lbldepartpanel;
        private ComboBox cboarrival;
        private ComboBox cbodepart;
        private Label lblarrival;
        private Label lbldeparture;
        private Panel pnlbanner;
        private Panel pnltitle;
        private System.Windows.Forms.Timer timerde;
        private System.Windows.Forms.Timer timerar;
        private Button btnsearch;
        private Panel pnldepartpanel;
        private CheckBox chk;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn coldepartdelay;
        private DataGridViewTextBoxColumn coldepartline;
        private DataGridViewTextBoxColumn colarrivaltime;
        private DataGridViewTextBoxColumn colarrivaldelay;
        private DataGridViewTextBoxColumn colarrival;
    }
}