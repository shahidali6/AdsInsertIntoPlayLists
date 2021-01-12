namespace AdsIntoPlayList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNewListItems = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPlayListsAfterLoad = new System.Windows.Forms.Label();
            this.btnLoadPlayLists = new System.Windows.Forms.Button();
            this.btnAdsintoPlayLists = new System.Windows.Forms.Button();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewListItems
            // 
            this.tbNewListItems.Location = new System.Drawing.Point(6, 42);
            this.tbNewListItems.Multiline = true;
            this.tbNewListItems.Name = "tbNewListItems";
            this.tbNewListItems.Size = new System.Drawing.Size(294, 353);
            this.tbNewListItems.TabIndex = 0;
            this.tbNewListItems.Text = resources.GetString("tbNewListItems.Text");
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(245, 16);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(55, 20);
            this.tbInterval.TabIndex = 2;
            this.tbInterval.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval between Ads Tracks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNewListItems);
            this.groupBox1.Controls.Add(this.tbInterval);
            this.groupBox1.Location = new System.Drawing.Point(482, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 402);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ads into Play Lists";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 425);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(143, 13);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Interval between Ads Tracks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPlayListsAfterLoad);
            this.groupBox2.Location = new System.Drawing.Point(16, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 324);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Playa Lists";
            // 
            // lbPlayListsAfterLoad
            // 
            this.lbPlayListsAfterLoad.AutoSize = true;
            this.lbPlayListsAfterLoad.Location = new System.Drawing.Point(6, 25);
            this.lbPlayListsAfterLoad.Name = "lbPlayListsAfterLoad";
            this.lbPlayListsAfterLoad.Size = new System.Drawing.Size(532, 13);
            this.lbPlayListsAfterLoad.TabIndex = 5;
            this.lbPlayListsAfterLoad.Text = "Intervalasdadsad asd ad ad asd ad asd asd asadasdadas asd asd ad asdas dasdasd as" +
    "d  between Ads Tracks";
            // 
            // btnLoadPlayLists
            // 
            this.btnLoadPlayLists.Location = new System.Drawing.Point(16, 21);
            this.btnLoadPlayLists.Name = "btnLoadPlayLists";
            this.btnLoadPlayLists.Size = new System.Drawing.Size(174, 23);
            this.btnLoadPlayLists.TabIndex = 7;
            this.btnLoadPlayLists.Text = "Load All Play Lists";
            this.btnLoadPlayLists.UseVisualStyleBackColor = true;
            this.btnLoadPlayLists.Click += new System.EventHandler(this.btnLoadPlayLists_Click);
            // 
            // btnAdsintoPlayLists
            // 
            this.btnAdsintoPlayLists.Location = new System.Drawing.Point(246, 21);
            this.btnAdsintoPlayLists.Name = "btnAdsintoPlayLists";
            this.btnAdsintoPlayLists.Size = new System.Drawing.Size(174, 23);
            this.btnAdsintoPlayLists.TabIndex = 8;
            this.btnAdsintoPlayLists.Text = "Add Ads into Play Lists";
            this.btnAdsintoPlayLists.UseVisualStyleBackColor = true;
            this.btnAdsintoPlayLists.Click += new System.EventHandler(this.btnAdsintoPlayLists_Click);
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(96, 54);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(324, 20);
            this.tbFolderPath.TabIndex = 4;
            this.tbFolderPath.Text = "C:\\Users\\Shahid\\Desktop\\temp\\Fiverr\\Final 1-1-2021 playlists\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PlayList Path: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFolderPath);
            this.Controls.Add(this.btnAdsintoPlayLists);
            this.Controls.Add(this.btnLoadPlayLists);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewListItems;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadPlayLists;
        private System.Windows.Forms.Button btnAdsintoPlayLists;
        private System.Windows.Forms.Label lbPlayListsAfterLoad;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Label label1;
    }
}

