using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Quiz
    {
        private readonly string type;
        private readonly string name;
        private List<Question> questions = new List<Question>();
        private Queue<int> questionOrder;
        private int numberOfQuestions = 0;

        public Quiz(string type)
        {
            this.type = type;
            if (this.type == "math")
            {
                name = "Mathe Quiz";
                this.setupMathQuiz();
                // make random order of questions
            }
            else if (this.type == "language")
            {
                name = "Sprachen Quiz";
            }
            else if (this.type == "general")
            {
                name = "Allgemeines Quiz";
            }
            else
            {
                name = "Quiz";
            }
            questionOrder = createQuestionOrder();
        }

        private Queue<int> createQuestionOrder()
        {
            Queue<int> order = new Queue<int>();
            Random random = new Random();
            int randomIndex = random.Next(questions.Count);
            for (int i = 0; i < questions.Count; i++)
            {
                while (order.Contains(randomIndex))
                {
                    randomIndex = random.Next(questions.Count);
                }
                order.Enqueue(randomIndex);
            }
            return order;
        }

        // get next question from list
        public Question getNextQuestion()
        {
            if (questionOrder.Count == 0)
            {
                return null;
            }
            int index = questionOrder.Dequeue();
            Question question = questions[index];
            question.randomizeAnswers();
            return question;
        }

        // method that returns if there are more questions
        public bool hasMoreQuestions()
        {
            return questionOrder.Count > 0;
        }

        // method that returns number of questions
        public int NumberOfQuestions
        {
            get { return numberOfQuestions; }
        }

        // method that returns number of questions left
        public int QuestionsLeft
        {
            get { return questionOrder.Count; }
        }

        public void addQuestion(Question question)
        {
            questions.Add(question);
            numberOfQuestions++;
        }

        public void removeQuestion(Question question)
        {
            questions.Remove(question);
        }

        public void setupMathQuiz()
        {
            this.addQuestion(new Question("Wie lautet die Lösung der Gleichung 2x - 5 = 7?", new string[] { "x = 1", "x = 6", "x = 7", "x = 8" }, 1));

            this.addQuestion(new Question("Welches ist die Ableitung von f(x) = 3x^2 + 2x - 1?", new string[] { "f'(x) = 6x + 2", "f'(x) = 3x^3 + x^2 - x", "f'(x) = 3x^2 + 2", "f'(x) = 6x + 1" }, 0));

            this.addQuestion(new Question("Wie nennt man eine geometrische Figur mit sieben Ecken?", new string[] { "Oktaeder", "Heptagon", "Hexagon", "Pentagon" }, 1));

            this.addQuestion(new Question("Was ist die Summe der Innenwinkel in einem Sechseck?", new string[] { "180 Grad", "360 Grad", "540 Grad", "720 Grad" }, 2));

            this.addQuestion(new Question("Wie lautet der Satz des Pythagoras?", new string[] { "a^2 + b^2 = c^2", "E=mc^2", "sin^2(x) + cos^2(x) = 1", "F=m*a" }, 0));

            this.addQuestion(new Question("Was ist der Logarithmus von 100 zur Basis 10?", new string[] { "1", "2", "10", "100" }, 1));

            this.addQuestion(new Question("Was ist die Wurzel aus 121?", new string[] { "11", "12", "13", "14" }, 0));

            this.addQuestion(new Question("Was ist der Umfang eines Kreises mit Radius 5?", new string[] { "5π", "10π", "15π", "25π" }, 1));

            this.addQuestion(new Question("Wie lautet die Binomialformel?", new string[] { "(a + b)^2 = a^2 + 2ab + b^2", "(a - b)^2 = a^2 - 2ab + b^2", "(a + b)^2 = a^2 + b^2", "(a - b)^2 = a^2 + b^2" }, 0));
        }

        public string Type
        {
            get { return type; }
        }

        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
               return name;
        }
    }
}
