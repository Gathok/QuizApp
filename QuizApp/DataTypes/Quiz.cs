using QuizApp.QuestionGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.DataTypes
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

        public void setupMathQuiz(int questionAmount)
        {
            MathQuestionGenerator mathQuestionGenerator = new MathQuestionGenerator();
            for (int i = 0; i < questionAmount; i++)
            {
                addQuestion(mathQuestionGenerator.generateRandomQuestion());
            }
        }

        public void restart()
        {
            questionOrder = createQuestionOrder();
        }

        private Queue<int> createQuestionOrder()
        {
            Queue<int> order = new Queue<int>();                    // erstelle Queue für zufällige Reihenfolge der Fragen
            Random random = new Random();
            int randomIndex = random.Next(questions.Count);         // erstelle zufällige Zahl zwischen 0 und Anzahl der Fragen
            for (int i = 0; i < questions.Count; i++)               // iteriere über alle Fragen
            {
                while (order.Contains(randomIndex))                 // solange die zufällige Zahl schon in der Queue ist, erstelle neue zufällige Zahl
                {
                    randomIndex = random.Next(questions.Count);
                }
                order.Enqueue(randomIndex);                         // wenn nicht, füge zufällige Zahl zur Queue hinzu
            }
            return order;
        }

        // gebe nächste Frage zurück, oder mit leeren Antworten wenn keine Fragen mehr vorhanden sind
        public Question? getNextQuestion()
        {
            if (questionOrder.Count == 0)
            {
                return new Question("Keine Fragen mehr", new string[] { "", "", "", "" }, 1);
            }
            int index = questionOrder.Dequeue();
            Question question = questions[index];
            question.randomizeAnswers();
            return question;
        }

        // methode um zu überprüfen ob noch neue Fragen vorhanden sind
        public bool hasMoreQuestions()
        {
            return questionOrder.Count > 0;
        }

        public int NumberOfQuestions
        {
            get { return numberOfQuestions; }
        }

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
            numberOfQuestions--;
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
