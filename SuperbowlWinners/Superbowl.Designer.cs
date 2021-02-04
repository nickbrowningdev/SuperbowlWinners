namespace SuperbowlWinners
{
    partial class Superbowl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Superbowl));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.groupTeams = new System.Windows.Forms.GroupBox();
            this.groupResults = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.groupTeams.SuspendLayout();
            this.groupResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(42, 30);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(217, 17);
            this.lblIntroduction.TabIndex = 2;
            this.lblIntroduction.Text = "The list of teams from 1966-2019";
            this.lblIntroduction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(22, 62);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(261, 228);
            this.teamsListBox.TabIndex = 3;
            // 
            // groupTeams
            // 
            this.groupTeams.Controls.Add(this.label2);
            this.groupTeams.Controls.Add(this.label1);
            this.groupTeams.Controls.Add(this.lblNote);
            this.groupTeams.Controls.Add(this.lblIntroduction);
            this.groupTeams.Controls.Add(this.teamsListBox);
            this.groupTeams.Location = new System.Drawing.Point(12, 12);
            this.groupTeams.Name = "groupTeams";
            this.groupTeams.Size = new System.Drawing.Size(308, 483);
            this.groupTeams.TabIndex = 4;
            this.groupTeams.TabStop = false;
            this.groupTeams.Text = "Team List";
            // 
            // groupResults
            // 
            this.groupResults.Controls.Add(this.txtCount);
            this.groupResults.Controls.Add(this.txtSearch);
            this.groupResults.Controls.Add(this.label3);
            this.groupResults.Controls.Add(this.lblExplain);
            this.groupResults.Controls.Add(this.btnExit);
            this.groupResults.Controls.Add(this.btnSearch);
            this.groupResults.Location = new System.Drawing.Point(336, 12);
            this.groupResults.Name = "groupResults";
            this.groupResults.Size = new System.Drawing.Size(303, 174);
            this.groupResults.TabIndex = 5;
            this.groupResults.TabStop = false;
            this.groupResults.Tag = "Superbowl Results";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(27, 300);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(242, 34);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Note: Some teams were relocated or \r\nhave changed team names. ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "These teams include: Arizona Cardinals, \r\nLos Angeles Rams, Los Angeles Chargers\r" +
    "\nTennessee Titans, Oakland Raiders*, \r\nIndianapolis Colts, and New England Patri" +
    "ots.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "(*) As of 10/04/2019, \r\nOakland Raiders have not relocated to \r\nLas Vegas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(20, 86);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(119, 17);
            this.lblExplain.TabIndex = 2;
            this.lblExplain.Text = "How Many Times:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search the amount of \r\ntimes a team has won:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(174, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(174, 83);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 22);
            this.txtCount.TabIndex = 11;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(336, 193);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(303, 302);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 6;
            this.picboxLogo.TabStop = false;
            // 
            // Superbowl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 507);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.groupResults);
            this.Controls.Add(this.groupTeams);
            this.Name = "Superbowl";
            this.Text = "How many times has a NFL Team won?";
            this.Load += new System.EventHandler(this.Superbowl_Load);
            this.groupTeams.ResumeLayout(false);
            this.groupTeams.PerformLayout();
            this.groupResults.ResumeLayout(false);
            this.groupResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.GroupBox groupTeams;
        private System.Windows.Forms.GroupBox groupResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picboxLogo;
    }
}

