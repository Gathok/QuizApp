using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class MultiplicationGenerator : SimpleCalculationGenerator
    {
        public override int calculate(int[] numbers)
        {
            return numbers[0] * numbers[1];
        }

        public override string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[0] += modifier;
            return getAnswer(numbers);
        }

        public override int[] getNumbers()
        {
            int number1 = random.Next(1, 20);
            int number2 = random.Next(1, 20);
            return new int[] { number1, number2 };
        }

        public override string getQuestionText(int[] numbers)
        {
            return numbers[0].ToString() + " * " + numbers[1].ToString() + " = ?";
        }
    }
}
