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
    public partial class QuizForm : Form
    {
        private Quiz quiz;
        private int correctAnswer = 0;
        private int score = 0;
        private ScoreTimer scoreTimer;
        private Form parent;

        public QuizForm(Form parent, Quiz quiz)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parent = parent;       // setze parent Form um wieder aufzurufen nach beeenden des Quiz und um es zu verstecken
            this.quiz = quiz;
            this.Text = quiz.Name;      // ändere Titel vom Form
            progressBar.Maximum = quiz.NumberOfQuestions;   // setze maximale Value für ProgressBar auf Anzahl der Fragen
            scoreTimer = new ScoreTimer();
            FormClosing += new FormClosingEventHandler(QuizForm_FormClosing); // setze Eventhandler für FormClosing
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            quiz.restart();     // erzeuge eine neue zufällige Reihenfolge der Fragen + update falls neue Fragen hinzugefügt worden sind
            if (!quiz.hasMoreQuestions())   // überprüfe ob Fragen vorhanden
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Es sind keine Fragen für dieses Quiz vorhanden!", "Keine Fragen");  // wenn nicht, zeige Fehlermeldung
                msgBox.ShowDialog();
                this.Close();   // schließe/öffne gar nicht erst Form
            }
            else if (quiz.NumberOfQuestions <= 5)   // wenn 5 oder weniger Fragen, frage ob starten
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Es sind nur " + quiz.NumberOfQuestions + " Fragen vorhanden!\n\n" +
                                       "Möchtest du trotzdem starten?", "Wenige Fragen", "Ja", "Nein");
                msgBox.ShowDialog();
                if (msgBox.DialogResult == DialogResult.Yes)  // wenn ja, starte Quiz/erste Frage
                {
                    parent.Hide();  // verstecke parent Form
                    this.nextQuestion();
                }
                else if (msgBox.DialogResult == DialogResult.No)  // wenn nein, schließe QuizForm
                {
                    this.Close();
                }
            }
            else
            {
                parent.Hide();  // verstecke parent Form
                this.nextQuestion();    // starte Quiz/erste Frage
            }
        }

        private void nextQuestion()
        {
            if (!quiz.hasMoreQuestions())   // überprüfe ob Quizz beendet 
            {
                timer.Stop();               // stoppe Timer
                string timeNeeded = scoreTimer.ToString();    // speichere Zeit
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Du hast " + score + " von " + quiz.NumberOfQuestions + " Fragen richtig beantwortet!" +
                    "\n\nDeine Zeit: " + timeNeeded, "Ergebnis", "Wiederholung", "Hauptmenü"); // Zeige Ergebnis
                msgBox.ShowDialog();
                reset();
                if (msgBox.DialogResult == DialogResult.Yes)  // wenn Wiederholung gewählt, starte Quiz neu
                {
                    timer.Start();
                    this.nextQuestion();
                }
                else if (msgBox.DialogResult == DialogResult.No)  // wenn Hauptmenü gewählt, schließe QuizForm und zeige StartUpForm
                {
                    this.Close();
                    parent.Show();
                }
            }
            else
            {
                Question question = quiz.getNextQuestion(); // hole nächste Frage
                labelQuestion.Text = question.Frage;        // setze Frage und Antworten auf Label und Buttons
                btnAnswer1.Text = question.Answers[0];
                btnAnswer2.Text = question.Answers[1];
                btnAnswer3.Text = question.Answers[2];
                btnAnswer4.Text = question.Answers[3];
                correctAnswer = question.CorrectAnswer;     // speichere richtige Antwort
                progressBar.Value = quiz.NumberOfQuestions - quiz.QuestionsLeft;    // update ProgressBar
            }
        }

        // Quiz zurücksetzen
        private void reset()
        {
            quiz.restart();
            score = 0;
            labelScore.Text = "Score: " + score;
            progressBar.Value = 0;
            scoreTimer.reset();
        }

        private void questionAnswer(Button answerButton, int answer)
        {
            Button rightButton = answerButton;  // Annahme: richtige Antwort

            if (answer == correctAnswer)        // Überprüfe Antwort
            {
                answerButton.BackColor = Color.FromArgb(46, 204, 64);   // wenn richtig, färbe Button grün
                score++;                                                // erhöhe Score
                labelScore.Text = "Score: " + score;                    // update Score Label
            }
            else
            {
                answerButton.BackColor = Color.FromArgb(255, 65, 54);   // wenn falsch, färbe Button rot
                switch (correctAnswer)
                {
                    case 0:                                                 // färbe richtigen Button grün
                        btnAnswer1.BackColor = Color.FromArgb(46, 204, 64);
                        rightButton = btnAnswer1;
                        break;
                    case 1:
                        btnAnswer2.BackColor = Color.FromArgb(46, 204, 64);
                        rightButton = btnAnswer2;
                        break;
                    case 2:
                        btnAnswer3.BackColor = Color.FromArgb(46, 204, 64);
                        rightButton = btnAnswer3;
                        break;
                    case 3:
                        btnAnswer4.BackColor = Color.FromArgb(46, 204, 64);
                        rightButton = btnAnswer4;
                        break;
                }
            }
            setAllButtons(false);                   // deaktiviere alle Buttons
            System.Threading.Thread.Sleep(2000);    // warte 2 Sekunden
            answerButton.BackColor = Color.FromArgb(136, 136, 136);   // farbe wieder zurücksetzen
            rightButton.BackColor = Color.FromArgb(136, 136, 136);
            setAllButtons(true);                    // buttons wieder aktivieren
            this.nextQuestion();                    // nächste Frage
        }

        // de-/aktiviere alle Buttons
        private void setAllButtons(bool enabled)
        {
            btnAnswer1.Enabled = enabled;
            btnAnswer2.Enabled = enabled;
            btnAnswer3.Enabled = enabled;
            btnAnswer4.Enabled = enabled;
        }

        // wenn Antwort-Button geklickt, rufe questionAnswer() mit entsprechendem Button und Antwort auf
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

        // wenn geschlossen, zeige wieder StartUpForm
        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // wenn QuizForm ohne beenden des Quiz geschlossen wird, fragen ob wirklich beenden
            if (quiz.QuestionsLeft != quiz.NumberOfQuestions)
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Möchtest du das Quiz wirklich beenden?", "Quiz beenden", "Ja", "Nein");
                msgBox.ShowDialog();
                if (msgBox.DialogResult == DialogResult.Yes)  // wenn ja, schließe QuizForm und zeige StartUpForm
                {
                    parent.Show();
                }
                else if (msgBox.DialogResult == DialogResult.No)  // wenn nein, schließe CustomMessageBox
                {
                    e.Cancel = true;
                }
            }
            else
            {
                parent.Show();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            scoreTimer.addTime(100);                    // füge 100ms zur Zeit hinzu
            labelTimer.Text = scoreTimer.ToString();    // update Timer Label
        }
    }
}
