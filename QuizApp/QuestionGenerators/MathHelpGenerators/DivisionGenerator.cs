using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class DivisionGenerator : SimpleCalculationGenerator
    {
        public override int calculate(int[] numbers)
        {
            return numbers[0] / numbers[1];
        }

        public override string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[0] += modifier;
            return getAnswer(numbers);
        }

        public override int[] getNumbers()
        {
            double number1 = random.Next(1, 400)/4;     // soll das Ergebnis sein, durch vier, damit es nicht nur Natürliche Zahlen sondern auch viertel gibt
            int number2 = random.Next(1, 20);           // soll der Divisor sein
            int number3 = number1 * number2;            // soll der Dividend sein
        }

        public override string getQuestionText(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
