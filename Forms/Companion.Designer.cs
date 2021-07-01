namespace Hood.Core
{
    partial class Companion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label _helpLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companion));
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._timerText = new System.Windows.Forms.Label();
            this._farmNameInput = new System.Windows.Forms.TextBox();
            this._dropsLabel = new System.Windows.Forms.Label();
            this._farmLabel = new System.Windows.Forms.Label();
            this._keptLabel = new System.Windows.Forms.Label();
            this._startTimer = new System.Windows.Forms.Button();
            this._percentLabel = new System.Windows.Forms.Label();
            this._runsLabel = new System.Windows.Forms.Label();
            this._dropTableLink = new System.Windows.Forms.LinkLabel();
            this._runInput = new System.Windows.Forms.TextBox();
            this._dropInput = new System.Windows.Forms.TextBox();
            this._keptInput = new System.Windows.Forms.TextBox();
            this._percentInput = new System.Windows.Forms.TextBox();
            this._resetRun = new System.Windows.Forms.Button();
            this._openLog = new System.Windows.Forms.LinkLabel();
            this._saveButton = new System.Windows.Forms.Button();
            this._streamerMode = new System.Windows.Forms.CheckBox();
            this._setCPU = new System.Windows.Forms.CheckBox();
            this._mayhemSelect = new System.Windows.Forms.ComboBox();
            this._versionNumber = new System.Windows.Forms.LinkLabel();
            _helpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _helpLabel
            // 
            _helpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            _helpLabel.AutoSize = true;
            _helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _helpLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            _helpLabel.Location = new System.Drawing.Point(268, 141);
            _helpLabel.Name = "_helpLabel";
            _helpLabel.Size = new System.Drawing.Size(70, 13);
            _helpLabel.TabIndex = 16;
            _helpLabel.Text = "Click for Help";
            _helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _helpLabel.Click += new System.EventHandler(this._helpLabel_Click);
            // 
            // _timerText
            // 
            this._timerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._timerText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._timerText.ForeColor = System.Drawing.SystemColors.ControlText;
            this._timerText.Location = new System.Drawing.Point(12, 9);
            this._timerText.Name = "_timerText";
            this._timerText.Size = new System.Drawing.Size(214, 51);
            this._timerText.TabIndex = 1;
            this._timerText.Text = "00:00:00";
            this._timerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _farmNameInput
            // 
            this._farmNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._farmNameInput.Location = new System.Drawing.Point(12, 77);
            this._farmNameInput.Name = "_farmNameInput";
            this._farmNameInput.Size = new System.Drawing.Size(269, 26);
            this._farmNameInput.TabIndex = 2;
            this._farmNameInput.Text = "Enter Farm Name";
            // 
            // _dropsLabel
            // 
            this._dropsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dropsLabel.AutoSize = true;
            this._dropsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._dropsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dropsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._dropsLabel.Location = new System.Drawing.Point(346, 77);
            this._dropsLabel.Name = "_dropsLabel";
            this._dropsLabel.Size = new System.Drawing.Size(54, 22);
            this._dropsLabel.TabIndex = 3;
            this._dropsLabel.Text = "Drops";
            this._dropsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _farmLabel
            // 
            this._farmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._farmLabel.AutoSize = true;
            this._farmLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._farmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._farmLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._farmLabel.Location = new System.Drawing.Point(187, 106);
            this._farmLabel.Name = "_farmLabel";
            this._farmLabel.Size = new System.Drawing.Size(94, 22);
            this._farmLabel.TabIndex = 4;
            this._farmLabel.Text = "Farm Name";
            this._farmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._farmLabel.Click += new System.EventHandler(this._farmName_Click);
            // 
            // _keptLabel
            // 
            this._keptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._keptLabel.AutoSize = true;
            this._keptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._keptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._keptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._keptLabel.Location = new System.Drawing.Point(413, 77);
            this._keptLabel.Name = "_keptLabel";
            this._keptLabel.Size = new System.Drawing.Size(44, 22);
            this._keptLabel.TabIndex = 5;
            this._keptLabel.Text = "Kept";
            this._keptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _startTimer
            // 
            this._startTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._startTimer.AutoSize = true;
            this._startTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._startTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this._startTimer.Location = new System.Drawing.Point(232, 9);
            this._startTimer.Name = "_startTimer";
            this._startTimer.Size = new System.Drawing.Size(136, 55);
            this._startTimer.TabIndex = 0;
            this._startTimer.Text = "Start Timer";
            this._startTimer.UseVisualStyleBackColor = false;
            this._startTimer.Click += new System.EventHandler(this._startTimer_Click);
            // 
            // _percentLabel
            // 
            this._percentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._percentLabel.AutoSize = true;
            this._percentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._percentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._percentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._percentLabel.Location = new System.Drawing.Point(470, 77);
            this._percentLabel.Name = "_percentLabel";
            this._percentLabel.Size = new System.Drawing.Size(66, 22);
            this._percentLabel.TabIndex = 7;
            this._percentLabel.Text = "Percent";
            this._percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _runsLabel
            // 
            this._runsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._runsLabel.AutoSize = true;
            this._runsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._runsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._runsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._runsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._runsLabel.Location = new System.Drawing.Point(289, 77);
            this._runsLabel.Name = "_runsLabel";
            this._runsLabel.Size = new System.Drawing.Size(49, 22);
            this._runsLabel.TabIndex = 8;
            this._runsLabel.Text = "Runs";
            this._runsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dropTableLink
            // 
            this._dropTableLink.AutoSize = true;
            this._dropTableLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dropTableLink.Location = new System.Drawing.Point(524, 9);
            this._dropTableLink.Name = "_dropTableLink";
            this._dropTableLink.Size = new System.Drawing.Size(87, 20);
            this._dropTableLink.TabIndex = 9;
            this._dropTableLink.TabStop = true;
            this._dropTableLink.Text = "Drop Table";
            this._dropTableLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._dropTableLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._dropTableLink_LinkClicked);
            // 
            // _runInput
            // 
            this._runInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._runInput.Location = new System.Drawing.Point(289, 102);
            this._runInput.Name = "_runInput";
            this._runInput.Size = new System.Drawing.Size(49, 26);
            this._runInput.TabIndex = 10;
            this._runInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _dropInput
            // 
            this._dropInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dropInput.Location = new System.Drawing.Point(346, 102);
            this._dropInput.Name = "_dropInput";
            this._dropInput.Size = new System.Drawing.Size(54, 26);
            this._dropInput.TabIndex = 11;
            this._dropInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _keptInput
            // 
            this._keptInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._keptInput.Location = new System.Drawing.Point(413, 102);
            this._keptInput.Name = "_keptInput";
            this._keptInput.Size = new System.Drawing.Size(44, 26);
            this._keptInput.TabIndex = 12;
            this._keptInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _percentInput
            // 
            this._percentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._percentInput.Location = new System.Drawing.Point(470, 102);
            this._percentInput.Name = "_percentInput";
            this._percentInput.Size = new System.Drawing.Size(66, 26);
            this._percentInput.TabIndex = 13;
            this._percentInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _resetRun
            // 
            this._resetRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._resetRun.AutoSize = true;
            this._resetRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._resetRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this._resetRun.Location = new System.Drawing.Point(370, 9);
            this._resetRun.Name = "_resetRun";
            this._resetRun.Size = new System.Drawing.Size(136, 55);
            this._resetRun.TabIndex = 14;
            this._resetRun.Text = "Reset Run";
            this._resetRun.UseVisualStyleBackColor = false;
            this._resetRun.Click += new System.EventHandler(this.ResetRun);
            // 
            // _openLog
            // 
            this._openLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._openLog.AutoSize = true;
            this._openLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._openLog.Location = new System.Drawing.Point(527, 40);
            this._openLog.Name = "_openLog";
            this._openLog.Size = new System.Drawing.Size(79, 20);
            this._openLog.TabIndex = 17;
            this._openLog.TabStop = true;
            this._openLog.Text = "Open Log";
            this._openLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._openLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._openLog_LinkClicked);
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.AutoSize = true;
            this._saveButton.BackColor = System.Drawing.Color.Transparent;
            this._saveButton.BackgroundImage = global::Hood.Core.Properties.Resources.FloppySave;
            this._saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._saveButton.FlatAppearance.BorderSize = 0;
            this._saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._saveButton.Location = new System.Drawing.Point(559, 78);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(57, 49);
            this._saveButton.TabIndex = 6;
            this._saveButton.UseVisualStyleBackColor = false;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _streamerMode
            // 
            this._streamerMode.AutoSize = true;
            this._streamerMode.Location = new System.Drawing.Point(12, 136);
            this._streamerMode.Name = "_streamerMode";
            this._streamerMode.Size = new System.Drawing.Size(98, 17);
            this._streamerMode.TabIndex = 18;
            this._streamerMode.Text = "Streamer Mode";
            this._streamerMode.UseVisualStyleBackColor = true;
            // 
            // _setCPU
            // 
            this._setCPU.AutoSize = true;
            this._setCPU.Location = new System.Drawing.Point(116, 136);
            this._setCPU.Name = "_setCPU";
            this._setCPU.Size = new System.Drawing.Size(82, 17);
            this._setCPU.TabIndex = 19;
            this._setCPU.Text = "CPU Priority";
            this._setCPU.UseVisualStyleBackColor = true;
            // 
            // _mayhemSelect
            // 
            this._mayhemSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this._mayhemSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mayhemSelect.FormattingEnabled = true;
            this._mayhemSelect.ItemHeight = 20;
            this._mayhemSelect.Location = new System.Drawing.Point(12, 102);
            this._mayhemSelect.Name = "_mayhemSelect";
            this._mayhemSelect.Size = new System.Drawing.Size(169, 28);
            this._mayhemSelect.TabIndex = 20;
            this._mayhemSelect.Text = "Mayhem Level: 0";
            // 
            // _versionNumber
            // 
            this._versionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._versionNumber.AutoSize = true;
            this._versionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._versionNumber.Location = new System.Drawing.Point(585, 140);
            this._versionNumber.Name = "_versionNumber";
            this._versionNumber.Size = new System.Drawing.Size(31, 13);
            this._versionNumber.TabIndex = 21;
            this._versionNumber.TabStop = true;
            this._versionNumber.Text = "0.2.0";
            this._versionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._versionNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._versionNumber_LinkClicked);
            // 
            // Companion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(619, 156);
            this.Controls.Add(this._versionNumber);
            this.Controls.Add(this._mayhemSelect);
            this.Controls.Add(this._setCPU);
            this.Controls.Add(this._streamerMode);
            this.Controls.Add(this._openLog);
            this.Controls.Add(_helpLabel);
            this.Controls.Add(this._resetRun);
            this.Controls.Add(this._percentInput);
            this.Controls.Add(this._keptInput);
            this.Controls.Add(this._dropInput);
            this.Controls.Add(this._runInput);
            this.Controls.Add(this._dropTableLink);
            this.Controls.Add(this._runsLabel);
            this.Controls.Add(this._percentLabel);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._keptLabel);
            this.Controls.Add(this._farmLabel);
            this.Controls.Add(this._dropsLabel);
            this.Controls.Add(this._farmNameInput);
            this.Controls.Add(this._timerText);
            this.Controls.Add(this._startTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Companion";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "L.A.D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _startTimer;
        public System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.TextBox _farmNameInput;
        public System.Windows.Forms.Label _dropsLabel;
        private System.Windows.Forms.Label _farmLabel;
        private System.Windows.Forms.Label _keptLabel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label _percentLabel;
        private System.Windows.Forms.Label _runsLabel;
        private System.Windows.Forms.LinkLabel _dropTableLink;
        private System.Windows.Forms.TextBox _runInput;
        private System.Windows.Forms.TextBox _dropInput;
        private System.Windows.Forms.TextBox _keptInput;
        private System.Windows.Forms.TextBox _percentInput;
        private System.Windows.Forms.Label _timerText;
        private System.Windows.Forms.Button _resetRun;
        private System.Windows.Forms.LinkLabel _openLog;
        private System.Windows.Forms.CheckBox _streamerMode;
        private System.Windows.Forms.CheckBox _setCPU;
        private System.Windows.Forms.ComboBox _mayhemSelect;
        private System.Windows.Forms.LinkLabel _versionNumber;
    }
}

