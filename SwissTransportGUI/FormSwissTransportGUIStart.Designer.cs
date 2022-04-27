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
            this.flpbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgvdepartpanel)).BeginInit();
            this.SuspendLayout();
            // 
            // flpbuttons
            // 
            this.flpbuttons.Controls.Add(this.btntdate);
            this.flpbuttons.Controls.Add(this.btnmap);
            this.flpbuttons.Controls.Add(this.btnshare);
            this.flpbuttons.Location = new System.Drawing.Point(41, 604);
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
            this.dgvconnections.Location = new System.Drawing.Point(41, 162);
            this.dgvconnections.Name = "dgvconnections";
            this.dgvconnections.RowTemplate.Height = 25;
            this.dgvconnections.Size = new System.Drawing.Size(394, 422);
            this.dgvconnections.TabIndex = 1;
            // 
            // cgvdepartpanel
            // 
            this.cgvdepartpanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cgvdepartpanel.Location = new System.Drawing.Point(464, 162);
            this.cgvdepartpanel.Name = "cgvdepartpanel";
            this.cgvdepartpanel.RowTemplate.Height = 25;
            this.cgvdepartpanel.Size = new System.Drawing.Size(403, 422);
            this.cgvdepartpanel.TabIndex = 2;
            // 
            // lbldepartpanel
            // 
            this.lbldepartpanel.AutoSize = true;
            this.lbldepartpanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldepartpanel.Location = new System.Drawing.Point(591, 81);
            this.lbldepartpanel.Name = "lbldepartpanel";
            this.lbldepartpanel.Size = new System.Drawing.Size(164, 32);
            this.lbldepartpanel.TabIndex = 3;
            this.lbldepartpanel.Text = "Abfahrtstafel";
            // 
            // cboarrival
            // 
            this.cboarrival.FormattingEnabled = true;
            this.cboarrival.Location = new System.Drawing.Point(41, 116);
            this.cboarrival.Name = "cboarrival";
            this.cboarrival.Size = new System.Drawing.Size(394, 23);
            this.cboarrival.TabIndex = 4;
            // 
            // cbodepart
            // 
            this.cbodepart.FormattingEnabled = true;
            this.cbodepart.Location = new System.Drawing.Point(41, 62);
            this.cbodepart.Name = "cbodepart";
            this.cbodepart.Size = new System.Drawing.Size(394, 23);
            this.cbodepart.TabIndex = 5;
            this.cbodepart.TextChanged += new System.EventHandler(this.cbodepart_TextChanged);
            // 
            // lblarrival
            // 
            this.lblarrival.AutoSize = true;
            this.lblarrival.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblarrival.Location = new System.Drawing.Point(41, 88);
            this.lblarrival.Name = "lblarrival";
            this.lblarrival.Size = new System.Drawing.Size(110, 25);
            this.lblarrival.TabIndex = 6;
            this.lblarrival.Text = "Ankunftsort";
            // 
            // lbldeparture
            // 
            this.lbldeparture.AutoSize = true;
            this.lbldeparture.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldeparture.Location = new System.Drawing.Point(41, 34);
            this.lbldeparture.Name = "lbldeparture";
            this.lbldeparture.Size = new System.Drawing.Size(107, 25);
            this.lbldeparture.TabIndex = 7;
            this.lbldeparture.Text = "Abfahrtsort";
            // 
            // FormSwissTransportGUIStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(931, 760);
            this.Controls.Add(this.lbldeparture);
            this.Controls.Add(this.lblarrival);
            this.Controls.Add(this.cbodepart);
            this.Controls.Add(this.cboarrival);
            this.Controls.Add(this.lbldepartpanel);
            this.Controls.Add(this.cgvdepartpanel);
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
    }
}