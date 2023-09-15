namespace QuizApp
{
    partial class InfoForm
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
            label1 = new Label();
            label2 = new Label();
            btnAddMathQ = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(235, 235, 235);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 0;
            label1.Text = "Mathe Quiz";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(200, 200, 200);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(677, 39);
            label2.TabIndex = 1;
            label2.Text = "Ein Quiz in dem mathematische Aufgaben (z.B. 1 + 1?) gestellt werden.\r\nOder aber auch mathematische Fragen (z.B. Was ist der Satz des Pythagoras?) gestellt werden.";
            // 
            // btnAddMathQ
            // 
            btnAddMathQ.BackColor = Color.FromArgb(136, 136, 136);
            btnAddMathQ.FlatStyle = FlatStyle.Flat;
            btnAddMathQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMathQ.Location = new Point(12, 68);
            btnAddMathQ.Margin = new Padding(3, 2, 3, 2);
            btnAddMathQ.Name = "btnAddMathQ";
            btnAddMathQ.Size = new Size(173, 26);
            btnAddMathQ.TabIndex = 2;
            btnAddMathQ.Text = "Neue Frage hinzufügen";
            btnAddMathQ.UseVisualStyleBackColor = false;
            btnAddMathQ.Click += btnAddMathQ_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(700, 338);
            Controls.Add(btnAddMathQ);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InfoForm";
            Text = "Quiz Infromation und Bearbeitung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAddMathQ;
    }
}