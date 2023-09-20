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
            // btnAddLangQ
            // 
            btnAddLangQ.BackColor = Color.FromArgb(136, 136, 136);
            btnAddLangQ.FlatStyle = FlatStyle.Flat;
            btnAddLangQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLangQ.Location = new Point(13, 183);
            btnAddLangQ.Margin = new Padding(3, 2, 3, 2);
            btnAddLangQ.Name = "btnAddLangQ";
            btnAddLangQ.Size = new Size(173, 26);
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
            label3.Location = new Point(13, 142);
            label3.Name = "label3";
            label3.Size = new Size(677, 39);
            label3.TabIndex = 4;
            label3.Text = "Ein Quiz in ein Wort gegeben wird und man dieses einer Sprache zuordnen muss.\r\nOder aber auch man die Übersetztung eines Wortes erraten/wissen muss.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(235, 235, 235);
            label4.Location = new Point(11, 122);
            label4.Name = "label4";
            label4.Size = new Size(144, 22);
            label4.TabIndex = 3;
            label4.Text = "Sprachen Quiz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(235, 235, 235);
            label5.Location = new Point(11, 236);
            label5.Name = "label5";
            label5.Size = new Size(168, 22);
            label5.TabIndex = 3;
            label5.Text = "Allgemeines Quiz";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(200, 200, 200);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 256);
            label6.Name = "label6";
            label6.Size = new Size(677, 39);
            label6.TabIndex = 4;
            label6.Text = "Ein Quiz in dem Fragen verschiedester Art gestellt werden die das Allgemeinwissen o.ä betreffen.\r\n";
            // 
            // btnAddGeneralQ
            // 
            btnAddGeneralQ.BackColor = Color.FromArgb(136, 136, 136);
            btnAddGeneralQ.FlatStyle = FlatStyle.Flat;
            btnAddGeneralQ.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGeneralQ.Location = new Point(13, 297);
            btnAddGeneralQ.Margin = new Padding(3, 2, 3, 2);
            btnAddGeneralQ.Name = "btnAddGeneralQ";
            btnAddGeneralQ.Size = new Size(173, 26);
            btnAddGeneralQ.TabIndex = 5;
            btnAddGeneralQ.Text = "Neue Frage hinzufügen";
            btnAddGeneralQ.UseVisualStyleBackColor = false;
            btnAddGeneralQ.Click += btnAddGeneralQ_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(700, 338);
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
        private Button btnAddLangQ;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAddGeneralQ;
    }
}