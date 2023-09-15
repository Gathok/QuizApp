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
            components = new System.ComponentModel.Container();
            labelQuestion = new Label();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            progressBar = new ProgressBar();
            labelScore = new Label();
            labelTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestion.ForeColor = Color.FromArgb(235, 235, 235);
            labelQuestion.Location = new Point(12, 25);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(488, 154);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "Frage";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            btnAnswer1.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer1.FlatStyle = FlatStyle.Flat;
            btnAnswer1.Location = new Point(12, 213);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(241, 71);
            btnAnswer1.TabIndex = 1;
            btnAnswer1.Text = "Antwort 1";
            btnAnswer1.UseVisualStyleBackColor = false;
            btnAnswer1.Click += btnAnswer1_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer2.FlatStyle = FlatStyle.Flat;
            btnAnswer2.Location = new Point(261, 213);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(241, 71);
            btnAnswer2.TabIndex = 2;
            btnAnswer2.Text = "Antwort 2";
            btnAnswer2.UseVisualStyleBackColor = false;
            btnAnswer2.Click += btnAnswer2_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer3.FlatStyle = FlatStyle.Flat;
            btnAnswer3.Location = new Point(12, 290);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(241, 71);
            btnAnswer3.TabIndex = 3;
            btnAnswer3.Text = "Antwort 3";
            btnAnswer3.UseVisualStyleBackColor = false;
            btnAnswer3.Click += btnAnswer3_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer4.FlatStyle = FlatStyle.Flat;
            btnAnswer4.Location = new Point(261, 290);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(241, 71);
            btnAnswer4.TabIndex = 4;
            btnAnswer4.Text = "Antwort 4";
            btnAnswer4.UseVisualStyleBackColor = false;
            btnAnswer4.Click += btnAnswer4_Click;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.Fuchsia;
            progressBar.Location = new Point(12, 186);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(487, 22);
            progressBar.Step = 50;
            progressBar.TabIndex = 5;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.ForeColor = Color.FromArgb(235, 235, 235);
            labelScore.Location = new Point(12, 7);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(60, 16);
            labelScore.TabIndex = 6;
            labelScore.Text = "Score: 0";
            // 
            // labelTimer
            // 
            labelTimer.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.ForeColor = Color.FromArgb(235, 235, 235);
            labelTimer.Location = new Point(407, 7);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(83, 19);
            labelTimer.TabIndex = 7;
            labelTimer.Text = "00:00,00";
            labelTimer.TextAlign = ContentAlignment.TopRight;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(512, 371);
            Controls.Add(labelTimer);
            Controls.Add(labelScore);
            Controls.Add(progressBar);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(labelQuestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QuizForm";
            Text = "QuizForm";
            Load += QuizForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuestion;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private ProgressBar progressBar;
        private Label labelScore;
        private Label labelTimer;
        private System.Windows.Forms.Timer timer;
    }
}