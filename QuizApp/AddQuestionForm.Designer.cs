namespace QuizApp
{
    partial class AddQuestionForm
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
            tbQuestion = new TextBox();
            tagQuestion_Add = new Label();
            labelA1_Add = new Label();
            tbA1_Add = new TextBox();
            tbA2_Add = new TextBox();
            labelA2_Add = new Label();
            labelA4_Add = new Label();
            tbA4_Add = new TextBox();
            tbA3_Add = new TextBox();
            labelA3_Add = new Label();
            btnAddQ_Add = new Button();
            cbA3_Add = new CheckBox();
            cbA1_Add = new CheckBox();
            cbA2_Add = new CheckBox();
            cbA4_Add = new CheckBox();
            SuspendLayout();
            // 
            // tbQuestion
            // 
            tbQuestion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuestion.Location = new Point(12, 31);
            tbQuestion.Name = "tbQuestion";
            tbQuestion.Size = new Size(776, 30);
            tbQuestion.TabIndex = 0;
            // 
            // tagQuestion_Add
            // 
            tagQuestion_Add.AutoSize = true;
            tagQuestion_Add.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tagQuestion_Add.Location = new Point(12, 9);
            tagQuestion_Add.Name = "tagQuestion_Add";
            tagQuestion_Add.Size = new Size(57, 19);
            tagQuestion_Add.TabIndex = 1;
            tagQuestion_Add.Text = "Frage:";
            // 
            // labelA1_Add
            // 
            labelA1_Add.AutoSize = true;
            labelA1_Add.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelA1_Add.Location = new Point(12, 76);
            labelA1_Add.Name = "labelA1_Add";
            labelA1_Add.Size = new Size(77, 19);
            labelA1_Add.TabIndex = 2;
            labelA1_Add.Text = "Antwort 1";
            // 
            // tbA1_Add
            // 
            tbA1_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbA1_Add.Location = new Point(12, 99);
            tbA1_Add.Name = "tbA1_Add";
            tbA1_Add.Size = new Size(378, 30);
            tbA1_Add.TabIndex = 6;
            // 
            // tbA2_Add
            // 
            tbA2_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbA2_Add.Location = new Point(410, 99);
            tbA2_Add.Name = "tbA2_Add";
            tbA2_Add.Size = new Size(378, 30);
            tbA2_Add.TabIndex = 7;
            // 
            // labelA2_Add
            // 
            labelA2_Add.AutoSize = true;
            labelA2_Add.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelA2_Add.Location = new Point(410, 76);
            labelA2_Add.Name = "labelA2_Add";
            labelA2_Add.Size = new Size(77, 19);
            labelA2_Add.TabIndex = 8;
            labelA2_Add.Text = "Antwort 2";
            // 
            // labelA4_Add
            // 
            labelA4_Add.AutoSize = true;
            labelA4_Add.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelA4_Add.Location = new Point(410, 140);
            labelA4_Add.Name = "labelA4_Add";
            labelA4_Add.Size = new Size(77, 19);
            labelA4_Add.TabIndex = 12;
            labelA4_Add.Text = "Antwort 4";
            // 
            // tbA4_Add
            // 
            tbA4_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbA4_Add.Location = new Point(410, 163);
            tbA4_Add.Name = "tbA4_Add";
            tbA4_Add.Size = new Size(378, 30);
            tbA4_Add.TabIndex = 11;
            // 
            // tbA3_Add
            // 
            tbA3_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbA3_Add.Location = new Point(12, 163);
            tbA3_Add.Name = "tbA3_Add";
            tbA3_Add.Size = new Size(378, 30);
            tbA3_Add.TabIndex = 10;
            // 
            // labelA3_Add
            // 
            labelA3_Add.AutoSize = true;
            labelA3_Add.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelA3_Add.Location = new Point(12, 140);
            labelA3_Add.Name = "labelA3_Add";
            labelA3_Add.Size = new Size(77, 19);
            labelA3_Add.TabIndex = 9;
            labelA3_Add.Text = "Antwort 3";
            // 
            // btnAddQ_Add
            // 
            btnAddQ_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQ_Add.Location = new Point(12, 211);
            btnAddQ_Add.Name = "btnAddQ_Add";
            btnAddQ_Add.Size = new Size(776, 42);
            btnAddQ_Add.TabIndex = 13;
            btnAddQ_Add.Text = "Frage hinzufügen";
            btnAddQ_Add.UseVisualStyleBackColor = true;
            btnAddQ_Add.Click += btnAddQ_Add_Click;
            // 
            // cbA3_Add
            // 
            cbA3_Add.AutoSize = true;
            cbA3_Add.Location = new Point(95, 140);
            cbA3_Add.Name = "cbA3_Add";
            cbA3_Add.Size = new Size(18, 17);
            cbA3_Add.TabIndex = 14;
            cbA3_Add.UseVisualStyleBackColor = true;
            // 
            // cbA1_Add
            // 
            cbA1_Add.AutoSize = true;
            cbA1_Add.Location = new Point(95, 78);
            cbA1_Add.Name = "cbA1_Add";
            cbA1_Add.Size = new Size(18, 17);
            cbA1_Add.TabIndex = 15;
            cbA1_Add.UseVisualStyleBackColor = true;
            // 
            // cbA2_Add
            // 
            cbA2_Add.AutoSize = true;
            cbA2_Add.Location = new Point(493, 76);
            cbA2_Add.Name = "cbA2_Add";
            cbA2_Add.Size = new Size(18, 17);
            cbA2_Add.TabIndex = 16;
            cbA2_Add.UseVisualStyleBackColor = true;
            // 
            // cbA4_Add
            // 
            cbA4_Add.AutoSize = true;
            cbA4_Add.Location = new Point(493, 142);
            cbA4_Add.Name = "cbA4_Add";
            cbA4_Add.Size = new Size(18, 17);
            cbA4_Add.TabIndex = 17;
            cbA4_Add.UseVisualStyleBackColor = true;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbA4_Add);
            Controls.Add(cbA2_Add);
            Controls.Add(cbA1_Add);
            Controls.Add(cbA3_Add);
            Controls.Add(btnAddQ_Add);
            Controls.Add(labelA4_Add);
            Controls.Add(tbA4_Add);
            Controls.Add(tbA3_Add);
            Controls.Add(labelA3_Add);
            Controls.Add(labelA2_Add);
            Controls.Add(tbA2_Add);
            Controls.Add(tbA1_Add);
            Controls.Add(labelA1_Add);
            Controls.Add(tagQuestion_Add);
            Controls.Add(tbQuestion);
            Name = "AddQuestionForm";
            Text = "Frage hinzufügen";
            Load += AddQuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbQuestion;
        private Label tagQuestion_Add;
        private Label labelA1_Add;
        private TextBox tbA1_Add;
        private TextBox tbA2_Add;
        private Label labelA2_Add;
        private Label labelA4_Add;
        private TextBox tbA4_Add;
        private TextBox tbA3_Add;
        private Label labelA3_Add;
        private Button btnAddQ_Add;
        private CheckBox cbA3_Add;
        private CheckBox cbA1_Add;
        private CheckBox cbA2_Add;
        private CheckBox cbA4_Add;
    }
}