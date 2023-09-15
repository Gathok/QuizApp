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
    public partial class QuizForm : Form
    {
        private Quiz quiz;
        private int correctAnswer = 0;
        private int score = 0;

        public QuizForm(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
            // change titel of form to quiz Name
            this.Text = quiz.Name;
            // set progressbar max value
            progressBar.Maximum = quiz.NumberOfQuestions;
            FormClosing += new FormClosingEventHandler(QuizForm_FormClosing); // setze Eventhandler für FormClosing
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            this.nextQuestion();
        }

        private void nextQuestion()
        {
            if (!quiz.hasMoreQuestions())
            {
                // show score
                MessageBox.Show("Du hast " + score + " von " + quiz.NumberOfQuestions + " Fragen richtig beantwortet!");
            }
            else
            {
                Question question = quiz.getNextQuestion();
                labelQuestion.Text = question.Text;
                btnAnswer1.Text = question.Answers[0];
                btnAnswer2.Text = question.Answers[1];
                btnAnswer3.Text = question.Answers[2];
                btnAnswer4.Text = question.Answers[3];
                correctAnswer = question.CorrectAnswer;
                progressBar.Value = quiz.NumberOfQuestions - quiz.QuestionsLeft;
            }
        }

        // btn color green when true, red when false and make right answer green, next question after 2 sec
        private void questionAnswer(Button answerButton, int answer)
        {
            Button rightButton = answerButton;

            if (answer == correctAnswer)
            {
                answerButton.BackColor = Color.Green;
                score++;
            }
            else
            {
                answerButton.BackColor = Color.Red;
                switch (correctAnswer)
                {
                    case 0:
                        btnAnswer1.BackColor = Color.Green;
                        rightButton = btnAnswer1;
                        break;
                    case 1:
                        btnAnswer2.BackColor = Color.Green;
                        rightButton = btnAnswer2;
                        break;
                    case 2:
                        btnAnswer3.BackColor = Color.Green;
                        rightButton = btnAnswer3;
                        break;
                    case 3:
                        btnAnswer4.BackColor = Color.Green;
                        rightButton = btnAnswer4;
                        break;
                }
            }
            // disable all buttons
            setAllButtons(false);
            // wait 2 sec
            System.Threading.Thread.Sleep(2000);
            // reset button color
            answerButton.BackColor = Color.White;
            rightButton.BackColor = Color.White;
            // enable all buttons
            setAllButtons(true);
            // next question
            this.nextQuestion();
        }

        // enable or disable all buttons
        private void setAllButtons(bool enabled)
        {
            btnAnswer1.Enabled = enabled;
            btnAnswer2.Enabled = enabled;
            btnAnswer3.Enabled = enabled;
            btnAnswer4.Enabled = enabled;
        }

        // when button pressed, check if right: call fuc questionAnswer
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            this.questionAnswer(btnAnswer1, 0);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            this.questionAnswer(btnAnswer2, 1);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            this.questionAnswer(btnAnswer3, 2);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            this.questionAnswer(btnAnswer4, 3);
        }

        // wenn geschlossen, zeige StartUpForm
        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpForm startUpForm = new StartUpForm();
            startUpForm.Show();
        }
    }
}
