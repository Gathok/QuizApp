namespace QuizApp
{
    partial class StartUpForm
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
            btnMathQuiz = new Button();
            label1 = new Label();
            btnGeneralQuiz = new Button();
            btnLanguageQuiz = new Button();
            btnFutherInfos = new Button();
            SuspendLayout();
            // 
            // btnMathQuiz
            // 
            btnMathQuiz.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMathQuiz.Location = new Point(12, 37);
            btnMathQuiz.Name = "btnMathQuiz";
            btnMathQuiz.Size = new Size(149, 29);
            btnMathQuiz.TabIndex = 0;
            btnMathQuiz.Text = "Mathe Quiz";
            btnMathQuiz.UseVisualStyleBackColor = true;
            btnMathQuiz.Click += btnMathQuiz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "Wähle dein Quiz";
            // 
            // btnGeneralQuiz
            // 
            btnGeneralQuiz.Enabled = false;
            btnGeneralQuiz.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeneralQuiz.Location = new Point(15, 107);
            btnGeneralQuiz.Name = "btnGeneralQuiz";
            btnGeneralQuiz.Size = new Size(149, 29);
            btnGeneralQuiz.TabIndex = 2;
            btnGeneralQuiz.Text = "Allgemeines Quiz";
            btnGeneralQuiz.UseVisualStyleBackColor = true;
            btnGeneralQuiz.Click += btnGeneralQuiz_Click;
            // 
            // btnLanguageQuiz
            // 
            btnLanguageQuiz.Enabled = false;
            btnLanguageQuiz.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLanguageQuiz.Location = new Point(15, 72);
            btnLanguageQuiz.Name = "btnLanguageQuiz";
            btnLanguageQuiz.Size = new Size(149, 29);
            btnLanguageQuiz.TabIndex = 3;
            btnLanguageQuiz.Text = "Sprachen Quiz";
            btnLanguageQuiz.UseVisualStyleBackColor = true;
            // 
            // btnFutherInfos
            // 
            btnFutherInfos.Enabled = false;
            btnFutherInfos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFutherInfos.Location = new Point(15, 169);
            btnFutherInfos.Name = "btnFutherInfos";
            btnFutherInfos.Size = new Size(149, 29);
            btnFutherInfos.TabIndex = 4;
            btnFutherInfos.Text = "Mehr Infos";
            btnFutherInfos.UseVisualStyleBackColor = true;
            // 
            // StartUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 208);
            Controls.Add(btnFutherInfos);
            Controls.Add(btnLanguageQuiz);
            Controls.Add(btnGeneralQuiz);
            Controls.Add(label1);
            Controls.Add(btnMathQuiz);
            Name = "StartUpForm";
            Text = "Quiz Wahl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMathQuiz;
        private Label label1;
        private Button btnGeneralQuiz;
        private Button btnLanguageQuiz;
        private Button btnFutherInfos;
    }
}