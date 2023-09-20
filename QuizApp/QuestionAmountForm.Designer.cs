namespace QuizApp.QuestionGenerators
{
    partial class QuestionAmountForm
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
            btnYes = new Button();
            btnNo = new Button();
            labelMessage = new Label();
            selectAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)selectAmount).BeginInit();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(136, 136, 136);
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnYes.Location = new Point(12, 100);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(95, 30);
            btnYes.TabIndex = 5;
            btnYes.Text = "Ja";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(136, 136, 136);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.Location = new Point(118, 100);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(95, 30);
            btnNo.TabIndex = 4;
            btnNo.Text = "Nein";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // labelMessage
            // 
            labelMessage.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.FromArgb(235, 235, 235);
            labelMessage.Location = new Point(12, 9);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(202, 40);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "Möchtest du ein neues Quiz mit 10 Fragen generieren?";
            // 
            // selectAmount
            // 
            selectAmount.BackColor = Color.FromArgb(136, 136, 136);
            selectAmount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectAmount.Location = new Point(12, 62);
            selectAmount.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            selectAmount.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            selectAmount.Name = "selectAmount";
            selectAmount.Size = new Size(201, 21);
            selectAmount.TabIndex = 6;
            selectAmount.TextAlign = HorizontalAlignment.Center;
            selectAmount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            selectAmount.ValueChanged += selectAmount_ValueChanged;
            // 
            // QuestionAmountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(226, 142);
            Controls.Add(selectAmount);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(labelMessage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "QuestionAmountForm";
            Text = "QuestionAmountForm";
            ((System.ComponentModel.ISupportInitialize)selectAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Label labelMessage;
        private NumericUpDown selectAmount;
    }
}