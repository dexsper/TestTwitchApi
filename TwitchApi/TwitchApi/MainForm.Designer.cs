namespace TwitchApi
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiNameTextBox = new TextBox();
            uiChangeNameButton = new Button();
            textBox1 = new TextBox();
            uiTarkRadioButton = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // uiNameTextBox
            // 
            uiNameTextBox.Location = new Point(38, 66);
            uiNameTextBox.Name = "uiNameTextBox";
            uiNameTextBox.Size = new Size(240, 23);
            uiNameTextBox.TabIndex = 0;
            // 
            // uiChangeNameButton
            // 
            uiChangeNameButton.Location = new Point(284, 65);
            uiChangeNameButton.Name = "uiChangeNameButton";
            uiChangeNameButton.Size = new Size(75, 23);
            uiChangeNameButton.TabIndex = 1;
            uiChangeNameButton.Text = "button1";
            uiChangeNameButton.UseVisualStyleBackColor = true;
            uiChangeNameButton.Click += uiChangeNameButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 356);
            textBox1.TabIndex = 2;
            // 
            // radioButton1
            // 
            uiTarkRadioButton.AutoSize = true;
            uiTarkRadioButton.Location = new Point(19, 200);
            uiTarkRadioButton.Name = "radioButton1";
            uiTarkRadioButton.Size = new Size(49, 19);
            uiTarkRadioButton.TabIndex = 3;
            uiTarkRadioButton.TabStop = true;
            uiTarkRadioButton.Text = "тарк";
            uiTarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 225);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "разраб";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(uiTarkRadioButton);
            Controls.Add(textBox1);
            Controls.Add(uiChangeNameButton);
            Controls.Add(uiNameTextBox);
            Name = "MainForm";
            Text = "Твич";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uiNameTextBox;
        private Button uiChangeNameButton;
        private TextBox textBox1;
        private RadioButton uiTarkRadioButton;
        private RadioButton radioButton2;
    }
}
