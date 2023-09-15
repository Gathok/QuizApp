using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    // MathHelpGenerator implementieren
    public class SimpleCalculationGenerator : MathHelpGenerator
    {
        private Random random;
        private int operatorIndex;

        public SimpleCalculationGenerator()
        {
            random = new Random();
            operatorIndex = random.Next(3);     // TODO: Division einbauen
        }                                       // momentan nur Addition, Subtraktion und Multiplikation, weil für Division Komma-Zahlen eingeführt werden müssten

        public int calculate(int[] numbers)
        {
            switch (operatorIndex)
            {
                case 0:
                    return numbers[0] + numbers[1];
                case 1:
                    return numbers[0] - numbers[1];
                case 2:
                    return numbers[0] * numbers[1];
                case 3:
                    return numbers[0] / numbers[1];
                default:
                    throw new Exception(operatorIndex.ToString() + " is not a valid operatorIndex");
            }
        }

        public string getAnswer(int[] numbers)
        {
            return calculate(numbers).ToString();
        }

        public string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[0] += modifier;
            return calculate(numbers).ToString();
        }

        public int[] getNumbers()
        {
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            while (number2 == 0 && operatorIndex == 3)
            {
                number2 = random.Next(100);
            }
            return new int[] { number1, number2 };
        }

        public string getQuestionText(int[] numbers)
        {
            return numbers[0] + " " + getOperator(operatorIndex) + " " + numbers[1] + " = ?";
        }

        private string getOperator(int operatorIndex)
        {
            switch (operatorIndex)
            {
                case 0:
                    return "+";
                case 1:
                    return "-";
                case 2:
                    return "*";
                case 3:
                    return "/";
                default:
                    throw new Exception(operatorIndex.ToString() + " is not a valid operatorIndex");
            }
        }
    }
}
