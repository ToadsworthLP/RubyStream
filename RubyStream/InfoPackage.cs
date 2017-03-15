using System.Drawing;

namespace RubyStream
{
    public class InfoPackage
    {
        public Font font;
        public Color color;

        public bool counterEnabled;
        public bool timerEnabled;

        public bool barEnabled;

        public long timerMaximum;
        public int counterMaximum;

        public void setFont(Font f)
        {
            this.font = f;
        }

        public void setColor(Color c)
        {
            this.color = c;
        }

        public void setCounter(bool enabled, int max, bool progressBar)
        {
            this.counterEnabled = enabled;
            this.counterMaximum = max;
            this.barEnabled = progressBar;
        }

        public void setTimer(bool enabled, long secs, bool progressBar)
        {
            this.timerEnabled = enabled;
            this.timerMaximum = secs;
            this.barEnabled = progressBar;
        }
    }
}
