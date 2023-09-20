namespace QuizApp
{
    partial class FlagQuizForm
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
            labelTimer = new Label();
            labelScore = new Label();
            progressBar = new ProgressBar();
            btnAnswer4 = new Button();
            btnAnswer3 = new Button();
            btnAnswer2 = new Button();
            btnAnswer1 = new Button();
            timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.ForeColor = Color.FromArgb(235, 235, 235);
            labelTimer.Location = new Point(417, 4);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(83, 19);
            labelTimer.TabIndex = 15;
            labelTimer.Text = "00:00,00";
            labelTimer.TextAlign = ContentAlignment.TopRight;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.ForeColor = Color.FromArgb(235, 235, 235);
            labelScore.Location = new Point(12, 4);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(60, 16);
            labelScore.TabIndex = 14;
            labelScore.Text = "Score: 0";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.Fuchsia;
            progressBar.Location = new Point(12, 183);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(490, 22);
            progressBar.Step = 50;
            progressBar.TabIndex = 13;
            // 
            // btnAnswer4
            // 
            btnAnswer4.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer4.FlatStyle = FlatStyle.Flat;
            btnAnswer4.Location = new Point(261, 287);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(241, 71);
            btnAnswer4.TabIndex = 12;
            btnAnswer4.Text = "Antwort 4";
            btnAnswer4.UseVisualStyleBackColor = false;
            // 
            // btnAnswer3
            // 
            btnAnswer3.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer3.FlatStyle = FlatStyle.Flat;
            btnAnswer3.Location = new Point(12, 287);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(241, 71);
            btnAnswer3.TabIndex = 11;
            btnAnswer3.Text = "Antwort 3";
            btnAnswer3.UseVisualStyleBackColor = false;
            // 
            // btnAnswer2
            // 
            btnAnswer2.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer2.FlatStyle = FlatStyle.Flat;
            btnAnswer2.Location = new Point(261, 210);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(241, 71);
            btnAnswer2.TabIndex = 10;
            btnAnswer2.Text = "Antwort 2";
            btnAnswer2.UseVisualStyleBackColor = false;
            // 
            // btnAnswer1
            // 
            btnAnswer1.BackColor = Color.FromArgb(136, 136, 136);
            btnAnswer1.FlatStyle = FlatStyle.Flat;
            btnAnswer1.Location = new Point(12, 210);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(241, 71);
            btnAnswer1.TabIndex = 9;
            btnAnswer1.Text = "Antwort 1";
            btnAnswer1.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 155);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FlagQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(512, 371);
            Controls.Add(pictureBox1);
            Controls.Add(labelTimer);
            Controls.Add(labelScore);
            Controls.Add(progressBar);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Name = "FlagQuizForm";
            Text = "FlagQuizForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTimer;
        private Label labelScore;
        private ProgressBar progressBar;
        private Button btnAnswer4;
        private Button btnAnswer3;
        private Button btnAnswer2;
        private Button btnAnswer1;
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBox1;
    }
}