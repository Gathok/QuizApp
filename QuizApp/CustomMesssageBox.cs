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
    public partial class CustomMesssageBox : Form
    {
        private bool customButtons = false;
        private Form parent;

        public CustomMesssageBox(Form parent, string message, string title, string btnLeftText, string btnRightText)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.parent = parent;
            parent.Enabled = false;    // freeze parent
            labelMessage.Text = message;
            this.Text = title;
            btnLeft.Text = btnLeftText;
            btnRight.Text = btnRightText;
            btnLeft.Visible = true;
            customButtons = true;
            FormClosing += new FormClosingEventHandler(CustomMesssageBox_FormClosing); // setze Eventhandler für FormClosing
        }

        public CustomMesssageBox(Form parent, string message, string title)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Enabled = false;    // freeze parent
            labelMessage.Text = message;
            this.Text = title;
            FormClosing += new FormClosingEventHandler(CustomMesssageBox_FormClosing); // setze Eventhandler für FormClosing
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (this.labelMessage.Text == "Wähle eine Option du Doofkopf!") // wenn bei Auforderung "Nö" gewählt wird
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Du hast keine Wahl!", "Doch!"); // zeige neue Meldung nur mit OK Button
                msgBox.ShowDialog();
            }
            else if (!customButtons)    // wenn keine customButtons gesetzt wurden
            {
                this.DialogResult = DialogResult.OK;    // buttonRight = OK
                this.Close();
            }
            else   // wenn customButtons gesetzt wurden
            {
                this.DialogResult = DialogResult.No;   // buttonRight = No
                this.Close();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void CustomMesssageBox_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if (this.DialogResult != DialogResult.No && this.DialogResult != DialogResult.OK
                && this.DialogResult != DialogResult.Yes) // wenn FormClosing nicht durch ButtonClick ausgelöst wurde
            {
                CustomMesssageBox msgBox = new CustomMesssageBox(this, "Wähle eine Option du Doofkopf!", "Fehler", "OK", "Nö"); // zeige Fehlermeldung
                msgBox.ShowDialog();
                e.Cancel = true;    // cancel FormClosing
            }
            else
            {
                parent.Enabled = true;  // unfreeze parent
            }
        }
    }
}
