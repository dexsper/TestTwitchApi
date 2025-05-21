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
            uiTitleTextBox = new TextBox();
            updateButton = new Button();
            uiCategoryIdTextBox = new TextBox();
            uiTypeTarkovRadioButton = new RadioButton();
            uiTypeDevelopRadioButton = new RadioButton();
            uiTypeCustomRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // uiTitleTextBox
            // 
            uiTitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiTitleTextBox.Location = new Point(172, 11);
            uiTitleTextBox.Name = "uiTitleTextBox";
            uiTitleTextBox.PlaceholderText = "Название стрима";
            uiTitleTextBox.Size = new Size(200, 23);
            uiTitleTextBox.TabIndex = 0;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(93, 237);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(200, 50);
            updateButton.TabIndex = 1;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // uiCategoryIdTextBox
            // 
            uiCategoryIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiCategoryIdTextBox.Location = new Point(172, 40);
            uiCategoryIdTextBox.Name = "uiCategoryIdTextBox";
            uiCategoryIdTextBox.PlaceholderText = "ID игры";
            uiCategoryIdTextBox.Size = new Size(200, 23);
            uiCategoryIdTextBox.TabIndex = 2;
            // 
            // uiTypeTarkovRadioButton
            // 
            uiTypeTarkovRadioButton.AutoSize = true;
            uiTypeTarkovRadioButton.Location = new Point(12, 37);
            uiTypeTarkovRadioButton.Name = "uiTypeTarkovRadioButton";
            uiTypeTarkovRadioButton.Size = new Size(63, 19);
            uiTypeTarkovRadioButton.TabIndex = 3;
            uiTypeTarkovRadioButton.Text = "Тарков";
            uiTypeTarkovRadioButton.UseVisualStyleBackColor = true;
            uiTypeTarkovRadioButton.CheckedChanged += uiTypeRadioButtons_CheckedChanged;
            // 
            // uiTypeDevelopRadioButton
            // 
            uiTypeDevelopRadioButton.AutoSize = true;
            uiTypeDevelopRadioButton.Location = new Point(12, 62);
            uiTypeDevelopRadioButton.Name = "uiTypeDevelopRadioButton";
            uiTypeDevelopRadioButton.Size = new Size(99, 19);
            uiTypeDevelopRadioButton.TabIndex = 4;
            uiTypeDevelopRadioButton.Text = ".Net помойка";
            uiTypeDevelopRadioButton.UseVisualStyleBackColor = true;
            uiTypeDevelopRadioButton.CheckedChanged += uiTypeRadioButtons_CheckedChanged;
            // 
            // uiTypeCustomRadioButton
            // 
            uiTypeCustomRadioButton.AutoSize = true;
            uiTypeCustomRadioButton.Checked = true;
            uiTypeCustomRadioButton.Location = new Point(12, 12);
            uiTypeCustomRadioButton.Name = "uiTypeCustomRadioButton";
            uiTypeCustomRadioButton.Size = new Size(100, 19);
            uiTypeCustomRadioButton.TabIndex = 5;
            uiTypeCustomRadioButton.TabStop = true;
            uiTypeCustomRadioButton.Text = "Произвольно";
            uiTypeCustomRadioButton.UseVisualStyleBackColor = true;
            uiTypeCustomRadioButton.CheckedChanged += uiTypeRadioButtons_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(uiTypeCustomRadioButton);
            Controls.Add(uiTypeDevelopRadioButton);
            Controls.Add(uiTypeTarkovRadioButton);
            Controls.Add(uiCategoryIdTextBox);
            Controls.Add(updateButton);
            Controls.Add(uiTitleTextBox);
            Name = "MainForm";
            Text = "Твич";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uiTitleTextBox;
        private Button updateButton;
        private TextBox uiCategoryIdTextBox;
        private RadioButton uiTypeTarkovRadioButton;
        private RadioButton uiTypeDevelopRadioButton;
        private RadioButton uiTypeCustomRadioButton;
    }
}
