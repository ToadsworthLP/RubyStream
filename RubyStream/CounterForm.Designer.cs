namespace RubyStream
{
    partial class CounterForm
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
            this.barCounter = new System.Windows.Forms.ProgressBar();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barCounter
            // 
            this.barCounter.Location = new System.Drawing.Point(12, 58);
            this.barCounter.Name = "barCounter";
            this.barCounter.Size = new System.Drawing.Size(167, 23);
            this.barCounter.TabIndex = 5;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(9, 11);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(16, 17);
            this.lblCounter.TabIndex = 4;
            this.lblCounter.Text = "0";
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(189, 87);
            this.Controls.Add(this.barCounter);
            this.Controls.Add(this.lblCounter);
            this.Name = "CounterForm";
            this.Text = "CounterForm";
            this.Load += new System.EventHandler(this.CounterForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CounterForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barCounter;
        private System.Windows.Forms.Label lblCounter;
    }
}