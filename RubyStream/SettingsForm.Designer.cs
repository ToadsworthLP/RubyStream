namespace RubyStream
{
    partial class SettingsForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFont = new System.Windows.Forms.Button();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.RichTextBox();
            this.fntDialog = new System.Windows.Forms.FontDialog();
            this.grpCounter = new System.Windows.Forms.GroupBox();
            this.chkCounter = new System.Windows.Forms.CheckBox();
            this.colDialog = new System.Windows.Forms.ColorDialog();
            this.grpTimer = new System.Windows.Forms.GroupBox();
            this.chkTimerBar = new System.Windows.Forms.CheckBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.chkTimer = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkMaximum = new System.Windows.Forms.CheckBox();
            this.chkCounterBar = new System.Windows.Forms.CheckBox();
            this.numMaximum = new System.Windows.Forms.NumericUpDown();
            this.grpFont.SuspendLayout();
            this.grpCounter.SuspendLayout();
            this.grpTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(10, 33);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(118, 31);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFontSettings_Click);
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.btnColor);
            this.grpFont.Controls.Add(this.txtPreview);
            this.grpFont.Controls.Add(this.btnFont);
            this.grpFont.Location = new System.Drawing.Point(22, 27);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(391, 123);
            this.grpFont.TabIndex = 2;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Schriftart";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(10, 70);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(118, 31);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Farbe";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(134, 33);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(246, 68);
            this.txtPreview.TabIndex = 2;
            this.txtPreview.Text = "Vorschau";
            // 
            // grpCounter
            // 
            this.grpCounter.Controls.Add(this.numMaximum);
            this.grpCounter.Controls.Add(this.chkCounterBar);
            this.grpCounter.Controls.Add(this.chkMaximum);
            this.grpCounter.Controls.Add(this.chkCounter);
            this.grpCounter.Location = new System.Drawing.Point(22, 170);
            this.grpCounter.Name = "grpCounter";
            this.grpCounter.Size = new System.Drawing.Size(391, 96);
            this.grpCounter.TabIndex = 3;
            this.grpCounter.TabStop = false;
            this.grpCounter.Text = "Zähler";
            // 
            // chkCounter
            // 
            this.chkCounter.AutoSize = true;
            this.chkCounter.Checked = true;
            this.chkCounter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCounter.Location = new System.Drawing.Point(8, 0);
            this.chkCounter.Name = "chkCounter";
            this.chkCounter.Size = new System.Drawing.Size(145, 21);
            this.chkCounter.TabIndex = 0;
            this.chkCounter.Text = "Zähler hinzufügen";
            this.chkCounter.UseVisualStyleBackColor = true;
            this.chkCounter.CheckedChanged += new System.EventHandler(this.chkCounter_CheckedChanged);
            // 
            // grpTimer
            // 
            this.grpTimer.Controls.Add(this.chkTimerBar);
            this.grpTimer.Controls.Add(this.lblSeconds);
            this.grpTimer.Controls.Add(this.numSeconds);
            this.grpTimer.Controls.Add(this.lblMinutes);
            this.grpTimer.Controls.Add(this.numMinutes);
            this.grpTimer.Controls.Add(this.lblHours);
            this.grpTimer.Controls.Add(this.numHours);
            this.grpTimer.Controls.Add(this.lblTime);
            this.grpTimer.Controls.Add(this.chkTimer);
            this.grpTimer.Location = new System.Drawing.Point(22, 293);
            this.grpTimer.Name = "grpTimer";
            this.grpTimer.Size = new System.Drawing.Size(391, 96);
            this.grpTimer.TabIndex = 4;
            this.grpTimer.TabStop = false;
            this.grpTimer.Text = "Timer";
            // 
            // chkTimerBar
            // 
            this.chkTimerBar.AutoSize = true;
            this.chkTimerBar.Location = new System.Drawing.Point(50, 59);
            this.chkTimerBar.Name = "chkTimerBar";
            this.chkTimerBar.Size = new System.Drawing.Size(150, 21);
            this.chkTimerBar.TabIndex = 8;
            this.chkTimerBar.Text = "Fortschrittsanzeige";
            this.chkTimerBar.UseVisualStyleBackColor = true;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(326, 30);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(15, 17);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "s";
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(265, 28);
            this.numSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(55, 22);
            this.numSeconds.TabIndex = 6;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(243, 30);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(19, 17);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "m";
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(182, 28);
            this.numMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(55, 22);
            this.numMinutes.TabIndex = 4;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(160, 30);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(16, 17);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "h";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(99, 28);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(55, 22);
            this.numHours.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(47, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Zeit:";
            // 
            // chkTimer
            // 
            this.chkTimer.AutoSize = true;
            this.chkTimer.Checked = true;
            this.chkTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimer.Location = new System.Drawing.Point(8, 0);
            this.chkTimer.Name = "chkTimer";
            this.chkTimer.Size = new System.Drawing.Size(140, 21);
            this.chkTimer.TabIndex = 0;
            this.chkTimer.Text = "Timer hinzufügen";
            this.chkTimer.UseVisualStyleBackColor = true;
            this.chkTimer.CheckedChanged += new System.EventHandler(this.chkTimer_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(176, 31);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Starten";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(237, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 31);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Zurücksetzen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkMaximum
            // 
            this.chkMaximum.AutoSize = true;
            this.chkMaximum.Location = new System.Drawing.Point(50, 27);
            this.chkMaximum.Name = "chkMaximum";
            this.chkMaximum.Size = new System.Drawing.Size(92, 21);
            this.chkMaximum.TabIndex = 1;
            this.chkMaximum.Text = "Maximum:";
            this.chkMaximum.UseVisualStyleBackColor = true;
            this.chkMaximum.CheckedChanged += new System.EventHandler(this.chkMaximum_CheckedChanged);
            // 
            // chkCounterBar
            // 
            this.chkCounterBar.AutoSize = true;
            this.chkCounterBar.Location = new System.Drawing.Point(50, 54);
            this.chkCounterBar.Name = "chkCounterBar";
            this.chkCounterBar.Size = new System.Drawing.Size(150, 21);
            this.chkCounterBar.TabIndex = 2;
            this.chkCounterBar.Text = "Fortschrittsanzeige";
            this.chkCounterBar.UseVisualStyleBackColor = true;
            // 
            // numMaximum
            // 
            this.numMaximum.Enabled = false;
            this.numMaximum.Location = new System.Drawing.Point(148, 26);
            this.numMaximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaximum.Name = "numMaximum";
            this.numMaximum.Size = new System.Drawing.Size(120, 22);
            this.numMaximum.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 474);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpTimer);
            this.Controls.Add(this.grpCounter);
            this.Controls.Add(this.grpFont);
            this.Name = "SettingsForm";
            this.Text = "Einstellungen";
            this.grpFont.ResumeLayout(false);
            this.grpCounter.ResumeLayout(false);
            this.grpCounter.PerformLayout();
            this.grpTimer.ResumeLayout(false);
            this.grpTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.FontDialog fntDialog;
        private System.Windows.Forms.RichTextBox txtPreview;
        private System.Windows.Forms.GroupBox grpCounter;
        private System.Windows.Forms.CheckBox chkCounter;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colDialog;
        private System.Windows.Forms.GroupBox grpTimer;
        private System.Windows.Forms.CheckBox chkTimer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.CheckBox chkTimerBar;
        private System.Windows.Forms.CheckBox chkMaximum;
        private System.Windows.Forms.CheckBox chkCounterBar;
        private System.Windows.Forms.NumericUpDown numMaximum;
    }
}

