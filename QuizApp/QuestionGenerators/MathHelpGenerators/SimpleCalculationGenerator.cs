using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    // MathHelpGenerator implementieren
    public abstract class SimpleCalculationGenerator : MathHelpGenerator
    {
        protected Random random;

        public SimpleCalculationGenerator()
        {
            random = new Random();
        }

        public abstract int calculate(int[] numbers);

        public string getAnswer(int[] numbers)
        {
            return calculate(numbers).ToString();
        }

        public abstract string getModifiedAnswer(int[] numbers, int modifier);

        public abstract int[] getNumbers();

        public abstract string getQuestionText(int[] numbers);
    }
}
