using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using QuizApp.DataTypes;
using QuizApp.QuestionGenerators.MathHelpGenerators;

namespace QuizApp.QuestionGenerators
{
    public class MathQuestionGenerator : QuestionGenerator
    {
        private Random random;
        private MathHelpGenerator[] mathHelpGenerators;

        public MathQuestionGenerator()
        {
            random = new Random();
            mathHelpGenerators = new MathHelpGenerator[4];               // für jeden FragenTyp einen Generator erstellen
            mathHelpGenerators[0] = new PowerOfTowGenerator();           // und diesen in ein Array speichern
            mathHelpGenerators[1] = new RootGenerator();
            mathHelpGenerators[2] = new LogarithmusGenerator();
            mathHelpGenerators[3] = new SimpleCalculationGenerator();
        }

        public Question generateRandomQuestion()
        {
            return this.generateRandomQuestionv1();
        }

        public Question generateRandomQuestionv1()
        {
            mathHelpGenerators[3] = new SimpleCalculationGenerator();                   // Neuen Opterator für SimpleCalculationGenerator generieren

            int questionType = random.Next(8);                                          // zufälligen Fragetyp generieren:
            if (questionType > 3)                                                       // PowerOfTowGenerator: 0, RootGenerator: 1, LogarithmusGenerator: 2,
            {                                                                           // SimpleCalculationGenerator: 3-7 (weil 4 verschiedene Rechenarten kombiniert)
                questionType = 3;
            }                                                                           
            MathHelpGenerator mathHelpGenerator = mathHelpGenerators[questionType];
            int[] numbers = mathHelpGenerator.getNumbers();                             // zufällige Zahlen für die korrekte Antwort generieren
            string questionText = mathHelpGenerator.getQuestionText(numbers);           // Frage mit Zahlen generieren

            string[] answers = new string[4];                                           // Arrray für die Antworten erstellen
            string correctAnswer = mathHelpGenerator.getAnswer(numbers);                // richtige Antwort generieren
            answers[0] = correctAnswer;                                                 // Richtige Antwort als erstes Element
            int modifier = getModifier();                                               // zufälligen Modifier generieren,
                                                                                        // dieser bestimmt ob die 2. Antwort über oder unter der richtigen Antwort liegt
            answers[1] = mathHelpGenerator.getModifiedAnswer(numbers, modifier);        // Antwort knapp neben der richtigen Antwort

            int[] numbers2 = mathHelpGenerator.getNumbers();                            // zufällige Zahlen für die 2 weiteren falschen Antworten generieren
            string answer3 = mathHelpGenerator.getAnswer(numbers2);                     // 3. Antwort generieren
            while (answers.Contains(answer3))                                           // Verhinderung von doppelten Antworten
            {
                numbers2 = mathHelpGenerator.getNumbers();
                answer3 = mathHelpGenerator.getAnswer(numbers2);
            }
            answers[2] = answer3;                                                       // Antwort 3 zu Array hinzufügen

            int modifier2 = getModifier();                                              // zufälligen Modifier generieren,
                                                                                        // dieser bestimmt ob die 4.Antwort über oder unter der 3. Antwort liegt
            string answer4 = mathHelpGenerator.getModifiedAnswer(numbers2, modifier2);  // 4. Antwort generieren
            if (answers.Contains(answer4))                                              // Verhinderung von doppelten Antworten
            {
                answer4 = mathHelpGenerator.getModifiedAnswer(numbers2, -modifier2);    // modifier invertieren
            }
            answers[3] = answer4;                                                       // Antwort 4 zu Array hinzufügen

            return new Question(questionText, answers, 0);                              // Frage mit Antworten erstellen und zurückgeben
        }

        private int getModifier()
        {
            int randInt = random.Next(2);
            if (randInt == 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
