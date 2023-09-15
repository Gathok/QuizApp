using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuizApp
{
    public partial class AddQuestionForm : Form
    {
        private readonly String quizType;
        private readonly List<System.Windows.Forms.CheckBox> checkBoxes;

        public AddQuestionForm(String quizType)
        {
            InitializeComponent();
            this.quizType = quizType;
            checkBoxes = new List<System.Windows.Forms.CheckBox>
            {
                cbA1_Add,
                cbA2_Add,
                cbA3_Add,
                cbA4_Add
            };
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddQ_Add_Click(object sender, EventArgs e)
        {
            String[] answers = new String[]
            {
                tbA1_Add.Text,
                tbA2_Add.Text,
                tbA3_Add.Text,
                tbA4_Add.Text
            };
            int currectAnswer = 0;
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    currectAnswer = i + 1;
                    break;
                }
            }
            Question question = new Question(tbQuestion.Text, answers, currectAnswer);

        }
    }
}
