using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class ScoreTimer
    {
        private int minutes;
        private int seconds;
        private int millisecs;

        public ScoreTimer()
        {
            this.minutes = 0;
            this.seconds = 0;
            this.millisecs = 0;
        }

        public ScoreTimer(int minutes, int seconds, int millisecs)
        {
            this.minutes = minutes;
            this.seconds = seconds;
            this.millisecs = millisecs;
        }

        public void addTime(int millisecs)
        {
            this.millisecs += millisecs;
            if (this.millisecs >= 1000)
            {
                int toMuch = (int) (this.millisecs / 1000);
                this.seconds += toMuch;
                this.millisecs -= toMuch * 1000;
            }
            if (this.seconds >= 60)
            {
                int toMuch = (int) (this.seconds / 60);
                this.minutes += toMuch;
                this.seconds -= toMuch * 60;
            }
        }

        private string convertToTwoDigit(int i)
        {
            if (i < 10)
            {
                return "0" + i;
            }
            else if (i >= 100)
            {
                string s = Convert.ToString(i);
                return s.Substring(0, 2);
            }
            else
            {
                return i.ToString();
            }
        }

        public override string ToString()
        {
            return convertToTwoDigit(minutes) + ":" + convertToTwoDigit(seconds) + ","
                + convertToTwoDigit(millisecs);
        }
    }
}
