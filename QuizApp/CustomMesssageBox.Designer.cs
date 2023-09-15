namespace QuizApp
{
    partial class CustomMesssageBox
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
            labelMessage = new Label();
            btnRight = new Button();
            btnLeft = new Button();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.FromArgb(235, 235, 235);
            labelMessage.Location = new Point(12, 9);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(196, 88);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "Message";
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.FromArgb(136, 136, 136);
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRight.Location = new Point(118, 100);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(95, 30);
            btnRight.TabIndex = 1;
            btnRight.Text = "OK";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.FromArgb(136, 136, 136);
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeft.Location = new Point(12, 100);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(95, 30);
            btnLeft.TabIndex = 2;
            btnLeft.Text = "Wiederholung";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Visible = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // CustomMesssageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(220, 142);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(labelMessage);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "CustomMesssageBox";
            Text = "CustomMesssageBox";
            ResumeLayout(false);
        }

        #endregion

        private Label labelMessage;
        private Button btnRight;
        private Button btnLeft;
    }
}