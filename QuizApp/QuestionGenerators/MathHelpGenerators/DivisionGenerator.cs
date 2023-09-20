using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class DivisionGenerator : MathHelpGenerator
    {
        Random random;

        public DivisionGenerator()
        {
            random = new Random();
        }

        public int calculate(int[] numbers)
        {
            return numbers[0] / numbers[1];
        }

        public string getAnswer(int[] numbers)
        {
            return calculate(numbers).ToString();
        }

        public string getModifiedAnswer(int[] numbers, int modifier)
        {
            return (calculate(numbers) + modifier).ToString();
        }

        public int[] getNumbers()
        {
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);
            while (number1 % number2 != 0)
            {
                number1 = random.Next(1, 100);
                number2 = random.Next(1, 100);
            }
            return new int[] { number1, number2 };
        }

        public string getQuestionText(int[] numbers)
        {
            return numbers[0] + " / " + numbers[1] + " = ?";
        }
    }
}
