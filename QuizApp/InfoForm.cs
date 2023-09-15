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
    public partial class InfoForm : Form
    {
        StartUpForm startUpForm;

        public InfoForm(StartUpForm startUpForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.startUpForm = startUpForm;
            this.startUpForm.Enabled = false;   // freeze startUpForm
            FormClosing += new FormClosingEventHandler(InfoForm_FormClosing); // setze Eventhandler für FormClosing
        }

        // öffne AddQuestionForm mit jeweiligem Quiz
        private void btnAddMathQ_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm(this, startUpForm, "math");
            addQuestionForm.ShowDialog();
        }

        // starte bei Schließen des InfoForm wieder StartUpForm
        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            startUpForm.Enabled = true;     // unfreeze startUpForm
        }
    }
}
