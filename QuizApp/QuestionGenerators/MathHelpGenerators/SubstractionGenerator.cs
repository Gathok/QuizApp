﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.QuestionGenerators.MathHelpGenerators
{
    public class SubstractionGenerator : MathHelpGenerator
    {
        Random random;

        public SubstractionGenerator()
        {
            random = new Random();
        }

        public int calculate(int[] numbers)
        {
            return numbers[0] - numbers[1];
        }

        public string getAnswer(int[] numbers)
        {
            return calculate(numbers).ToString();
        }

        public string getModifiedAnswer(int[] numbers, int modifier)
        {
            numbers[0] += modifier * 10;
            return getAnswer(numbers);
        }

        public int[] getNumbers()
        {
            int number1 = random.Next(1, 1000);
            int number2 = random.Next(1, 1000);
            return new int[] { number1, number2 };
        }

        public string getQuestionText(int[] numbers)
        {
            return numbers[0].ToString() + " - " + numbers[1].ToString() + " = ?";
        }
    }
}
