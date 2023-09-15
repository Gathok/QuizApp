using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.DataTypes;

namespace QuizApp
{
    public partial class StartUpForm : Form
    {
        private Quiz mathQuiz;
        private Quiz flagQuiz;
        private Quiz languageQuiz;
        private QuizForm quizForm;
        private InfoForm infoForm;

        public StartUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mathQuiz = new Quiz("math");        // erstelle Quiz Objekte
            flagQuiz = new Quiz("flag");
            languageQuiz = new Quiz("language");
            FormClosing += new FormClosingEventHandler(StartUpForm_FormClosing); // setze Eventhandler für FormClosing
        }

        // starte QuizForm mit jeweiligem Quiz
        // übergebe StartUpForm um wieder aufzurufen nach beeenden des Quiz
        private void btnMathQuiz_Click(object sender, EventArgs e)
        {
            quizForm = new QuizForm(this, mathQuiz);
            quizForm.Show();
        }

        private void btnLanguageQuiz_Click(object sender, EventArgs e)
        {
            quizForm = new QuizForm(this, languageQuiz);
            quizForm.Show();
        }

        private void btnGeneralQuiz_Click(object sender, EventArgs e)
        {
            quizForm = new QuizForm(this, flagQuiz);
            quizForm.Show();
        }

        // beende Anwendung wenn StartUpForm geschlossen wird
        private void StartUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // öffne InfoForm
        private void btnFutherInfos_Click(object sender, EventArgs e)
        {
            infoForm = new InfoForm(this);
            infoForm.Show();
        }

        public void addQuizQuestion(string quizType, Question question)
        {
            if (quizType == "math")
            {
                mathQuiz.addQuestion(question);
            }
            else if (quizType == "flag")
            {
                flagQuiz.addQuestion(question);
            }
            else if (quizType == "language")
            {
                languageQuiz.addQuestion(question);
            }
        }
    }
}
