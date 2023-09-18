using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class LogarithmusGenerator : MathHelpGenerator
    {
        Random Random;

        public LogarithmusGenerator()
        {
            Random = new Random();
        }

        public int calculate(int[] numbers)
        {
            return (int) Math.Pow(numbers[0], numbers[1]);
        }

        public string getAnswer(int[] numbers)
        {
            return numbers[1].ToString();
        }

        public string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[1] += modifier;
            return getAnswer(numbers);
        }

        public int[] getNumbers()
        {
            int number1 = Random.Next(2, 10);      // Basis: zwischen 2 und 10 weil 0 und 1 ergibt kein sinn und ab 10 wird es zu schwer
            int number2 = Random.Next(1, 5);       // Logarithmus: zwischen 1 und 5 weil bei 0 der Logarithmus nicht definiert ist und ab 5 wird es zu schwer
            return new int[] { number1, number2 };
        }

        public string getQuestionText(int[] numbers)
        {
            return "log" + numbers[0] + "(" + calculate(numbers) + ") = ?";
        }
    }
}
