using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DataTypes
{
    // Klasse für Zeitmessung und Formatierung
    public class ScoreTimer
    {
        private int minutes;
        private int seconds;
        private int millisecs;

        // Standardkonstruktor
        public ScoreTimer()
        {
            minutes = 0;
            seconds = 0;
            millisecs = 0;
        }

        // Konstruktor mit Startzeit
        public ScoreTimer(int minutes, int seconds, int millisecs)
        {
            this.minutes = minutes;
            this.seconds = seconds;
            this.millisecs = millisecs;
        }

        public void addTime(int millisecs)
        {
            this.millisecs += millisecs;    // addiere Zeit zu Millisekunden
            if (this.millisecs >= 1000)     // Wenn Millisekunden mehr als eine Sekunde sind, addiere Sekunde/n
            {
                int toMuch = this.millisecs / 1000;
                seconds += toMuch;
                this.millisecs -= toMuch * 1000;    // ziehe überzählige Sekunden von Millisekunden ab
            }
            if (seconds >= 60)         // Wenn Sekunden mehr als eine Minute sind, addiere Minute/n
            {
                int toMuch = seconds / 60;
                minutes += toMuch;
                seconds -= toMuch * 60;    // ziehe überzählige Minuten von Sekunden ab
            }
        }

        // konvertiere int zu String mit zwei Stellen
        private string convertToTwoDigit(int i)
        {
            if (i < 10) // wenn int einstellig, füge 0 vorne an
            {
                return "0" + i;
            }
            else if (i >= 100)  // wenn int mehr als 2 Stellen, kürze auf 2 Stellen
            {
                string s = Convert.ToString(i);
                return s.Substring(0, 2);
            }
            else // wenn int zweistellig, gib als String zurück
            {
                return i.ToString();
            }
        }

        // gib Zeit als formatierten String (z.B. "01:23,40") zurück
        public override string ToString()
        {
            return convertToTwoDigit(minutes) + ":" + convertToTwoDigit(seconds) + ","
                + convertToTwoDigit(millisecs);
        }

        // setze Zeit zurück
        public void reset()
        {
            minutes = 0;
            seconds = 0;
            millisecs = 0;
        }
    }
}
