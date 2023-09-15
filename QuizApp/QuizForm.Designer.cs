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
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestion.Location = new Point(14, 9);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(558, 230);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "labelQuestion";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            btnAnswer1.Location = new Point(14, 251);
            btnAnswer1.Margin = new Padding(3, 4, 3, 4);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(275, 95);
            btnAnswer1.TabIndex = 1;
            btnAnswer1.Text = "Antwort 1";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Click += btnAnswer1_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Location = new Point(296, 251);
            btnAnswer2.Margin = new Padding(3, 4, 3, 4);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(275, 95);
            btnAnswer2.TabIndex = 2;
            btnAnswer2.Text = "Antwort 2";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Click += btnAnswer2_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.Location = new Point(14, 353);
            btnAnswer3.Margin = new Padding(3, 4, 3, 4);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(275, 95);
            btnAnswer3.TabIndex = 3;
            btnAnswer3.Text = "Antwort 2";
            btnAnswer3.UseVisualStyleBackColor = true;
            btnAnswer3.Click += btnAnswer3_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.BackColor = Color.White;
            btnAnswer4.Location = new Point(296, 353);
            btnAnswer4.Margin = new Padding(3, 4, 3, 4);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(275, 95);
            btnAnswer4.TabIndex = 4;
            btnAnswer4.Text = "Antwort 4";
            btnAnswer4.UseVisualStyleBackColor = false;
            btnAnswer4.Click += btnAnswer4_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 455);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(557, 29);
            progressBar.Step = 50;
            progressBar.TabIndex = 5;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 495);
            Controls.Add(progressBar);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(labelQuestion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuizForm";
            Text = "QuizForm";
            Load += QuizForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelQuestion;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private ProgressBar progressBar;
    }
}