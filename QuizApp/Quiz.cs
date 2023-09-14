using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Quiz
    {
        private readonly string type;
        private readonly string name;

        public Quiz(string type)
        {
            this.type = type;
            if (this.type == "math")
            {
                name = "Mathe Quiz";
            }
            else if (this.type == "flag")
            {
                name = "Flaggen Quiz";
            }
            else if (this.type == "language")
            {
                name = "Sprachen Quiz";
            }
        }

        public string Type
        {
            get { return type; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
