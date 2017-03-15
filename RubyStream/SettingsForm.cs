using System;
using System.Drawing;
using System.Windows.Forms;

namespace RubyStream
{
    public partial class SettingsForm : Form
    {

        public Font mainFont;
        public Color mainColor;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnFontSettings_Click(object sender, EventArgs e)
        {
            // Show the dialog.
            DialogResult result = fntDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fntDialog.Font;
                // Set TextBox properties.
                txtPreview.Font = font;

                mainFont = font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Show the dialog.
            DialogResult result = colDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Color.
                Color color = colDialog.Color;
                // Set TextBox properties.
                txtPreview.ForeColor = color;

                mainColor = color;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void chkCounter_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpCounter.Controls)
            {
                if (ctrl.Name != chkCounter.Name)
                {
                    ctrl.Enabled = chkCounter.Checked;
                }
            }
        }

        private void chkTimer_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpTimer.Controls)
            {
                if (ctrl.Name != chkTimer.Name)
                {
                    ctrl.Enabled = chkTimer.Checked;
                }
            }
        }

        private void chkMaximum_CheckedChanged(object sender, EventArgs e)
        {
            numMaximum.Enabled = chkMaximum.Checked;
            numMaximum.Value = numMaximum.Minimum;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(mainFont == null)
            {
                mainFont = txtPreview.Font;
            }

            if(mainColor == null)
            {
                mainColor = txtPreview.ForeColor;
            }

            InfoPackage info = new InfoPackage();

            info.setFont(mainFont);
            info.setColor(mainColor);

            if (chkCounter.Checked)
            {
                CounterForm counter = new CounterForm();
                info.setCounter(chkCounter.Checked, (int)numMaximum.Value, chkCounterBar.Checked);
                counter.setInfoPackage(info);
                counter.Show();
            }

            if (chkTimer.Checked)
            {
                TimerForm timer = new TimerForm();
                info.setTimer(chkTimer.Checked, (long)(numSeconds.Value + numMinutes.Value * 60 + numHours.Value * 3600), chkTimerBar.Checked);
                timer.setInfoPackage(info);
                timer.Show();
            }
        }
    }
}
