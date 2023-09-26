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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuizApp
{
    public partial class AddQuestionForm : Form
    {
        private readonly string quizType;
        private readonly List<System.Windows.Forms.CheckBox> checkBoxes;
        private readonly StartUpForm startUpForm;
        private readonly Form parent;

        public AddQuestionForm(Form parent, StartUpForm startUpForm, string quizType)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parent = parent;
            this.parent.Enabled = false;    // freeze parent
            this.startUpForm = startUpForm;
            this.quizType = quizType;
            checkBoxes = new List<System.Windows.Forms.CheckBox>    // füge alle CheckBoxes in eine Liste
            {
                cbA1_Add,
                cbA2_Add,
                cbA3_Add,
                cbA4_Add
            };
            FormClosing += new FormClosingEventHandler(AddQuestionForm_FormClosing); // setze Eventhandler für FormClosing
        }

        private void btnAddQ_Add_Click(object sender, EventArgs e)
        {
            if (tbQuestion.Text == "" || tbA1_Add.Text == "" || tbA2_Add.Text == "" || tbA3_Add.Text == "" || tbA4_Add.Text == "")  // wenn ein Textfeld leer ist
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Bitte fülle alle Felder aus!", "Fehler");                   // zeige Fehlermeldung
                msgBox.ShowDialog();
                return;
            }
            int currectAnswer = -1;                      // setze currectAnswer auf -1 um zu überprüfen zu können ob genau eine Antwort ausgewählt wurde
            for (int i = 0; i < checkBoxes.Count; i++)  // iteriere über alle CheckBoxes
            {
                if (checkBoxes[i].Checked)              // wenn CheckBox gecheckt ist
                {
                    if (currectAnswer != -1)              // wenn ereits eine Antwort ausgewählt wurde, setze excatlyOneChecked auf false und break
                    {
                        currectAnswer = -1;             // setze currectAnswer auf -1 um zu signalisieren, dass mehr als eine Antwort ausgewählt wurde
                        break;                          // beeende Schleife, da Fehlerzustand erreicht wurde
                    }
                    currectAnswer = i;                  // setze currectAnswer auf Index)
                }
            }
            if (currectAnswer != -1) // wenn nicht genau eine Antwort ausgewählt wurde, zeige Fehlermeldung
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Bitte wähle genau eine richtige Antwort aus!", "Fehler");
                msgBox.ShowDialog();
                return;
            }
            string[] answers = new string[] // erstelle Array mit allen Antwortmöglichkeiten
            {
                tbA1_Add.Text,
                tbA2_Add.Text,
                tbA3_Add.Text,
                tbA4_Add.Text
            };

            Question question = new Question(tbQuestion.Text, answers, currectAnswer);  // erstelle Frage mit Daten
            startUpForm.addQuizQuestion(quizType, question);                            // füge Frage zum Quiz hinzu
            this.DialogResult = DialogResult.Continue;                                  // setze DialogResult auf Continue, damit kommuniziert wird, dass Frage hinzugefügt wurde
            this.Close();
        }

        // überprüfe ob bereits eingaben geätigt wurden
        private bool startedTyping()
        {
            if (tbQuestion.Text != "" || tbA1_Add.Text != "" || tbA2_Add.Text != "" || tbA3_Add.Text != "" || tbA4_Add.Text != "")   // Textfeld ist nicht leer
            {
                return true;
            }
            for (int i = 0; i < checkBoxes.Count; i++)  // iteriere über alle CheckBoxes
            {
                if (checkBoxes[i].Checked) // wenn CheckBox gecheckt ist
                {
                    return true;
                }
            }
            return false;
        }

        private void AddQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // wenn FormClosing nicht durch ButtonClick ausgelöst wurde und bereits eingaben getätigt worden, überprüfe ob wirklich geschlossen werden soll
            if (this.DialogResult != DialogResult.Continue && startedTyping())
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Willst du wirklich abbrechen?", "Abbrechen", "Ja", "Nein");
                msgBox.ShowDialog();
                if (msgBox.DialogResult == DialogResult.No)  // wenn nein, cancel schließen
                {
                    e.Cancel = true;
                }   // wenn ja, lasse formClosing zu
            }
            if (e.Cancel == false)
            {
                parent.Enabled = true; // unfreeze parent
            }
        }
    }
}
