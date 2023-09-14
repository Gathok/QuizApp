namespace QuizApp
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelQuestion = new Label();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestion.Location = new Point(12, 88);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(776, 75);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "labelQuestion";
            labelQuestion.TextAlign = ContentAlignment.TopCenter;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelQuestion);
            Name = "QuizForm";
            Text = "QuizForm";
            Load += QuizForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelQuestion;
    }
}