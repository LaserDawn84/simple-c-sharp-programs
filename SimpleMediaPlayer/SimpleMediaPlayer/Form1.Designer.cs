namespace MediaPlayer
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.oFD1 = new System.Windows.Forms.OpenFileDialog();
            this.AddVideoBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PreviousChapterBtn = new System.Windows.Forms.Button();
            this.NextChapterBtn = new System.Windows.Forms.Button();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.RemoveVideoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-3, -4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1022, 553);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.axWindowsMediaPlayer1_EndOfStream);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // oFD1
            // 
            this.oFD1.Filter = "\"MP4|*.mp4|AVI|*.avi|WMV|*.wmv\"";
            // 
            // AddVideoBtn
            // 
            this.AddVideoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVideoBtn.Location = new System.Drawing.Point(1025, 518);
            this.AddVideoBtn.Name = "AddVideoBtn";
            this.AddVideoBtn.Size = new System.Drawing.Size(221, 31);
            this.AddVideoBtn.TabIndex = 2;
            this.AddVideoBtn.Text = "Add Video";
            this.AddVideoBtn.UseVisualStyleBackColor = true;
            this.AddVideoBtn.Click += new System.EventHandler(this.AddVideoBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayBtn.Location = new System.Drawing.Point(12, 555);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PauseBtn.Location = new System.Drawing.Point(93, 555);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 4;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopBtn.Location = new System.Drawing.Point(174, 555);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PreviousChapterBtn
            // 
            this.PreviousChapterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousChapterBtn.Location = new System.Drawing.Point(255, 555);
            this.PreviousChapterBtn.Name = "PreviousChapterBtn";
            this.PreviousChapterBtn.Size = new System.Drawing.Size(75, 23);
            this.PreviousChapterBtn.TabIndex = 6;
            this.PreviousChapterBtn.Text = "<<";
            this.PreviousChapterBtn.UseVisualStyleBackColor = true;
            // 
            // NextChapterBtn
            // 
            this.NextChapterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextChapterBtn.Location = new System.Drawing.Point(336, 555);
            this.NextChapterBtn.Name = "NextChapterBtn";
            this.NextChapterBtn.Size = new System.Drawing.Size(75, 23);
            this.NextChapterBtn.TabIndex = 7;
            this.NextChapterBtn.Text = ">>";
            this.NextChapterBtn.UseVisualStyleBackColor = true;
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VolumeSlider.Location = new System.Drawing.Point(465, 551);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(221, 45);
            this.VolumeSlider.TabIndex = 8;
            this.VolumeSlider.Tag = "Volume";
            this.VolumeSlider.TickFrequency = 10;
            this.VolumeSlider.Value = 50;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            // 
            // RemoveVideoBtn
            // 
            this.RemoveVideoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveVideoBtn.Location = new System.Drawing.Point(1025, 551);
            this.RemoveVideoBtn.Name = "RemoveVideoBtn";
            this.RemoveVideoBtn.Size = new System.Drawing.Size(221, 31);
            this.RemoveVideoBtn.TabIndex = 9;
            this.RemoveVideoBtn.Text = "Remove Video";
            this.RemoveVideoBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(417, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume:";
            // 
            // VideoList
            // 
            this.VideoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoList.BackColor = System.Drawing.SystemColors.ControlText;
            this.VideoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.VideoList.FormattingEnabled = true;
            this.VideoList.ItemHeight = 24;
            this.VideoList.Location = new System.Drawing.Point(1026, 12);
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(220, 504);
            this.VideoList.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1258, 602);
            this.Controls.Add(this.VideoList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveVideoBtn);
            this.Controls.Add(this.VolumeSlider);
            this.Controls.Add(this.NextChapterBtn);
            this.Controls.Add(this.PreviousChapterBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.AddVideoBtn);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleMediaPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog oFD1;
        private System.Windows.Forms.Button AddVideoBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PreviousChapterBtn;
        private System.Windows.Forms.Button NextChapterBtn;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Button RemoveVideoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox VideoList;
    }
}

