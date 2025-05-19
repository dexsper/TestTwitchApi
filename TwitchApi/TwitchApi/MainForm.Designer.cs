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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uiChangeNameButton);
            Controls.Add(uiNameTextBox);
            Name = "MainForm";
            Text = "Твич";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uiNameTextBox;
        private Button uiChangeNameButton;
    }
}
