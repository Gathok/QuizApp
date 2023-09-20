using QuizApp.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.QuestionGenerators
{
    public partial class QuestionAmountForm : Form
    {
        private Quiz quiz;

        public QuestionAmountForm(Quiz quiz)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.quiz = quiz;
        }

        private void selectAmount_ValueChanged(object sender, EventArgs e)
        {
            labelMessage.Text = "Möchtest du ein neues Quiz mit " + selectAmount.Value + " Fragen generieren?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        public int getQuestionAmount()
        {
            return (int)selectAmount.Value;
        }
    }
}