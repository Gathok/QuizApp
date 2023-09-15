using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    internal interface MathHelpGenerator
    {
        // Im Konstruktor werden ggf. Operatoren zufällig generiert

        public int[] getNumbers();  // gibt die zufällig erzeugte Zahlen zurück, damit man mit diesen rechnen kann

        public int calculate(int[] numbers);  // berechnet das Ergebnis aus den Zahlen und gibt es als String zurück

        public string getQuestionText(int[] numbers);   // gibt den Text der Frage zurück der bei den gewählten Zahlen rauskommt

        public string getAnswer(int[] numbers);     // gibt die Antwort zurück die bei den gewählten Zahlen rauskommt

        public string getModifiedAnswer(int[] numbers, int modifier);   // gibt eine Anwort zurück bei der das Ergebnis um die mininamle Abweichung
                                                                            // nach oben oder unten (modifier) verändert wurde
    }
}
