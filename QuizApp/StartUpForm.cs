using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mathQuiz = new Quiz("math");
            flagQuiz = new Quiz("flag");
            languageQuiz = new Quiz("language");
            FormClosing += new FormClosingEventHandler(StartUpForm_FormClosing); // setze Eventhandler für FormClosing
        }

        private void btnMathQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizForm = new QuizForm(mathQuiz);
            quizForm.Show();
        }

        private void btnLanguageQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizForm = new QuizForm(languageQuiz);
            quizForm.Show();
        }

        private void btnGeneralQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizForm = new QuizForm(flagQuiz);
            quizForm.Show();
        }

        // close all forms when StartUpForm is closed
        private void StartUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFutherInfos_Click(object sender, EventArgs e)
        {
            this.Hide();
            infoForm = new InfoForm();
            infoForm.Show();
        }
    }
}
