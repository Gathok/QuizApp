using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class RootGenerator : MathHelpGenerator
    {
        Random Random;

        public RootGenerator()
        {
            Random = new Random();
        }

        public int calculate(int[] numbers)
        {
            return numbers[0] * numbers[0];
        }

        public string getAnswer(int[] numbers)
        {
            return numbers[0].ToString();
        }

        public string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[0] += modifier;
            return getAnswer(numbers);
        }

        public int[] getNumbers()
        {
            int number1 = Random.Next(10);
            return new int[] { number1 };
        }

        public string getQuestionText(int[] numbers)
        {
            return "√" + calculate(numbers) + " = ?";
        }
    }
}
