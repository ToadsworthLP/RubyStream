namespace RubyStream
{
    partial class TimerForm
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
            this.barTimer = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barTimer
            // 
            this.barTimer.Location = new System.Drawing.Point(12, 58);
            this.barTimer.Name = "barTimer";
            this.barTimer.Size = new System.Drawing.Size(167, 23);
            this.barTimer.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(9, 11);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(16, 17);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "0";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(189, 87);
            this.Controls.Add(this.barTimer);
            this.Controls.Add(this.lblTimer);
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerMain;
    }
}