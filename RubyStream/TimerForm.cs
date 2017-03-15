using System;
using System.Windows.Forms;

namespace RubyStream
{
    public partial class TimerForm : Form
    {
        InfoPackage info;

        long time = 0;

        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            time = info.timerMaximum;

            barTimer.Maximum = (int)time;
            barTimer.Value = (int)time;
            barTimer.Enabled = info.barEnabled;
            barTimer.Visible = info.barEnabled;

            lblTimer.Font = info.font;
            lblTimer.ForeColor = info.color;

            UpdateWindow();
        }

        public void setInfoPackage(InfoPackage infoPackage)
        {
            info = infoPackage;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time -= 1;
                UpdateWindow();
            }
        }

        private void TimerForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                if (!timerMain.Enabled)
                {
                    timerMain.Enabled = true;
                }
            }
        }

        String formatTime(long seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);

            string str = time.ToString(@"hh\:mm\:ss");
            return str;
        }

        void UpdateWindow()
        {
            lblTimer.Text = formatTime(time);
            barTimer.Value = (int)time;
        }
    }
}
