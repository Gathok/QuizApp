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
            btnAddLangQ = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAddGeneralQ = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(235, 235, 235);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 27);
            label1.TabIndex = 0;
            label1.Text = "Mathe Quiz";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(200, 200, 200);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 36);
            label2.Name = "label2";
            label2.Size = new Size(774, 52);
            label2.TabIndex = 1;
            label2.Text = "Ein Quiz in dem mathematische Aufgaben (z.B. 1 + 1?) gestellt werden.\r\nOder aber auch mathematische Fragen (z.B. Was ist der Satz des Pythagoras?) gestellt werden.";
            // 
            // btnAddMathQ
            // 
            btnAddMathQ.BackColor = Color.FromArgb(136, 136, 136);
            btnAddMathQ.FlatStyle = FlatStyle.Flat;
            btnAddMathQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMathQ.Location = new Point(14, 91);
            btnAddMathQ.Name = "btnAddMathQ";
            btnAddMathQ.Size = new Size(198, 35);
            btnAddMathQ.TabIndex = 2;
            btnAddMathQ.Text = "Neue Frage hinzufügen";
            btnAddMathQ.UseVisualStyleBackColor = false;
            btnAddMathQ.Click += btnAddMathQ_Click;
            // 
            // btnAddLangQ
            // 
            btnAddLangQ.BackColor = Color.FromArgb(136, 136, 136);
            btnAddLangQ.FlatStyle = FlatStyle.Flat;
            btnAddLangQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLangQ.Location = new Point(15, 244);
            btnAddLangQ.Name = "btnAddLangQ";
            btnAddLangQ.Size = new Size(198, 35);
            btnAddLangQ.TabIndex = 5;
            btnAddLangQ.Text = "Neue Frage hinzufügen";
            btnAddLangQ.UseVisualStyleBackColor = false;
            btnAddLangQ.Click += btnAddLangQ_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(200, 200, 200);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 189);
            label3.Name = "label3";
            label3.Size = new Size(774, 52);
            label3.TabIndex = 4;
            label3.Text = "Ein Quiz in dem ein Wort gegeben wird und man dieses einer Sprache zuordnen muss.\r\nOder aber auch man die Übersetztung eines Wortes erraten/wissen muss.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(235, 235, 235);
            label4.Location = new Point(13, 163);
            label4.Name = "label4";
            label4.Size = new Size(177, 27);
            label4.TabIndex = 3;
            label4.Text = "Sprachen Quiz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(235, 235, 235);
            label5.Location = new Point(13, 315);
            label5.Name = "label5";
            label5.Size = new Size(205, 27);
            label5.TabIndex = 3;
            label5.Text = "Allgemeines Quiz";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(200, 200, 200);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 341);
            label6.Name = "label6";
            label6.Size = new Size(774, 52);
            label6.TabIndex = 4;
            label6.Text = "Ein Quiz in dem Fragen verschiedester Art gestellt werden, die das Allgemeinwissen o. Ä. betreffen.\r\n";
            // 
            // btnAddGeneralQ
            // 
            btnAddGeneralQ.BackColor = Color.FromArgb(136, 136, 136);
            btnAddGeneralQ.FlatStyle = FlatStyle.Flat;
            btnAddGeneralQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGeneralQ.Location = new Point(15, 396);
            btnAddGeneralQ.Name = "btnAddGeneralQ";
            btnAddGeneralQ.Size = new Size(198, 35);
            btnAddGeneralQ.TabIndex = 5;
            btnAddGeneralQ.Text = "Neue Frage hinzufügen";
            btnAddGeneralQ.UseVisualStyleBackColor = false;
            btnAddGeneralQ.Click += btnAddGeneralQ_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(800, 451);
            Controls.Add(btnAddGeneralQ);
            Controls.Add(btnAddLangQ);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnAddMathQ);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InfoForm";
            Text = "Quiz Infromation und Bearbeitung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAddMathQ;
        private Button btnAddLangQ;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAddGeneralQ;
    }
}