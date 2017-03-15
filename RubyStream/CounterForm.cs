using System;
using System.Windows.Forms;

namespace RubyStream
{
    public partial class CounterForm : Form
    {

        int counter = 0;

        InfoPackage info;

        public CounterForm()
        {
            InitializeComponent();
        }

        private void CounterForm_Load(object sender, EventArgs e)
        {
            if(info.counterMaximum == 0)
            {
                info.counterMaximum = int.MaxValue;
            }

            barCounter.Maximum = info.counterMaximum;
            barCounter.Enabled = info.barEnabled;
            barCounter.Visible = info.barEnabled;

            lblCounter.Font = info.font;
            lblCounter.ForeColor = info.color;
        }

        public void setInfoPackage(InfoPackage infoPackage)
        {
            info = infoPackage;
        }

        private void CounterForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                if(counter < info.counterMaximum)
                {
                    counter += 1;
                    UpdateWindow();
                }
            }
            else
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if(counter > 0)
                {
                    counter -= 1;
                    UpdateWindow();
                }
            }
        }

        void UpdateWindow()
        {
            lblCounter.Text = Convert.ToString(counter);
            barCounter.Value = counter;
        }
    }
}
