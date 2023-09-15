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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 27);
            label1.TabIndex = 0;
            label1.Text = "Mathe Quiz";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(776, 47);
            label2.TabIndex = 1;
            label2.Text = "Ein Quiz in dem mathematische Aufgaben (z.B. 1 + 1?) gestellt werden.\r\nOder aber auch mathematische Fragen (z.B. Was ist der Satz des Pythagoras?) gestellt werden.";
            // 
            // btnAddMathQ
            // 
            btnAddMathQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMathQ.Location = new Point(12, 86);
            btnAddMathQ.Name = "btnAddMathQ";
            btnAddMathQ.Size = new Size(145, 29);
            btnAddMathQ.TabIndex = 2;
            btnAddMathQ.Text = "Frage hinzufügen";
            btnAddMathQ.UseVisualStyleBackColor = true;
            btnAddMathQ.Click += btnAddMathQ_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddMathQ);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InfoForm";
            Text = "InfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAddMathQ;
    }
}