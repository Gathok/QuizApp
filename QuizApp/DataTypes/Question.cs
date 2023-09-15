using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DataTypes
{
    public class Question
    {
        private readonly string question;
        private string[] answers;
        private int correctAnswer;

        public Question(string question, string[] answers, int correctAnswer)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
        }

        // durchwürfeln der Antworten
        public void randomizeAnswers()
        {
            Random random = new Random();
            int randomIndex = random.Next(answers.Length);  // setzte randomIndex auf eine zufällige Zahl zwischen 0 und answers.Length
            for (int i = 0; i < answers.Length; i++)        // geht alle Antworten durch
            {
                string temp = answers[i];                   // speichere Antwort an Stelle i in temp
                answers[i] = answers[randomIndex];          // überschreibe Antwort an Stelle i mit Antwort an Stelle randomIndex
                answers[randomIndex] = temp;                // überschreibe Antwort an Stelle randomIndex mit temp
                if (i == correctAnswer)                     // wenn i die richtige Antwort ist
                {
                    correctAnswer = randomIndex;            // setzte correctAnswer auf randomIndex
                }
                else if (randomIndex == correctAnswer)      // wenn randomIndex die richtige Antwort ist
                {
                    correctAnswer = i;                      // setzte correctAnswer auf i
                }
                randomIndex = random.Next(answers.Length);  // generiere neue zufällige Zahl für randomIndex
            }

        }

        public string Frage
        {
            get { return question; }
        }

        public string[] Answers
        {
            get { return answers; }
        }

        public int CorrectAnswer
        {
            get { return correctAnswer; }
        }

        public override string ToString()
        {
            return question;
        }
    }
}
