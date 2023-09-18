using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class PowerOfTowGenerator : MathHelpGenerator
    {
        Random random;

        public PowerOfTowGenerator()
        {
            random = new Random();
        }
        public int calculate(int[] numbers)
        {
            return (int) Math.Pow(2, numbers[0]);
        }

        public string getAnswer(int[] numbers)
        {
            return calculate(numbers).ToString();
        }

        public string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[0] += modifier;
            return getAnswer(numbers);
        }

        public int[] getNumbers()
        {
            int number1 = random.Next(12);
            return new int[] { number1 };
        }

        public string getQuestionText(int[] numbers)
        {
            return "2^" + numbers[0] + " = ?";
        }
    }
}
