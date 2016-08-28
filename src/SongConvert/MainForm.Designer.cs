namespace SongConvert
{
    partial class MainForm
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
            this.easyWorshipSongPath = new System.Windows.Forms.TextBox();
            this.easyWorshipBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationBrowseButton = new System.Windows.Forms.Button();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.convertButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.removeHeadersCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // easyWorshipSongPath
            // 
            this.easyWorshipSongPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyWorshipSongPath.Location = new System.Drawing.Point(11, 28);
            this.easyWorshipSongPath.Multiline = true;
            this.easyWorshipSongPath.Name = "easyWorshipSongPath";
            this.easyWorshipSongPath.Size = new System.Drawing.Size(540, 20);
            this.easyWorshipSongPath.TabIndex = 0;
            // 
            // easyWorshipBrowseButton
            // 
            this.easyWorshipBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.easyWorshipBrowseButton.Location = new System.Drawing.Point(557, 27);
            this.easyWorshipBrowseButton.Name = "easyWorshipBrowseButton";
            this.easyWorshipBrowseButton.Size = new System.Drawing.Size(28, 20);
            this.easyWorshipBrowseButton.TabIndex = 1;
            this.easyWorshipBrowseButton.Text = "...";
            this.easyWorshipBrowseButton.UseVisualStyleBackColor = true;
            this.easyWorshipBrowseButton.Click += new System.EventHandler(this.easyWorshipBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Where are the EasyWorship songs located?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Where should the text files be stored?";
            // 
            // destinationBrowseButton
            // 
            this.destinationBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationBrowseButton.Location = new System.Drawing.Point(557, 80);
            this.destinationBrowseButton.Name = "destinationBrowseButton";
            this.destinationBrowseButton.Size = new System.Drawing.Size(28, 20);
            this.destinationBrowseButton.TabIndex = 4;
            this.destinationBrowseButton.Text = "...";
            this.destinationBrowseButton.UseVisualStyleBackColor = true;
            this.destinationBrowseButton.Click += new System.EventHandler(this.destinationBrowseButton_Click);
            // 
            // destinationPath
            // 
            this.destinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationPath.Location = new System.Drawing.Point(11, 80);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(540, 20);
            this.destinationPath.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(91, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(494, 23);
            this.progressBar.TabIndex = 6;
            this.progressBar.UseWaitCursor = true;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(11, 143);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // removeHeadersCheckBox
            // 
            this.removeHeadersCheckBox.AutoSize = true;
            this.removeHeadersCheckBox.Location = new System.Drawing.Point(11, 120);
            this.removeHeadersCheckBox.Name = "removeHeadersCheckBox";
            this.removeHeadersCheckBox.Size = new System.Drawing.Size(207, 17);
            this.removeHeadersCheckBox.TabIndex = 8;
            this.removeHeadersCheckBox.Text = "Remove verse/chorus/bridge headers";
            this.removeHeadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 178);
            this.Controls.Add(this.removeHeadersCheckBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destinationBrowseButton);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.easyWorshipBrowseButton);
            this.Controls.Add(this.easyWorshipSongPath);
            this.Name = "MainForm";
            this.Text = "Convert EasyWorship songs to text files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox easyWorshipSongPath;
        private System.Windows.Forms.Button easyWorshipBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button destinationBrowseButton;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.CheckBox removeHeadersCheckBox;
    }
}

