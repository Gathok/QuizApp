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
        }

        private void btnMathQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizForm = new QuizForm(mathQuiz);
            quizForm.Show();
        }

        private void btnFlagQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizForm = new QuizForm(flagQuiz);
        }

        private void btnLanguageQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizForm = new QuizForm(languageQuiz);
        }

        private void btnFutherInfos_Click(object sender, EventArgs e)
        {
            infoForm = new InfoForm();
        }
    }
}
