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
            uiProfileComboBox = new ComboBox();
            uiCreateProfileButton = new Button();
            uiDeleteProfileButton = new Button();
            SuspendLayout();
            // 
            // uiTitleTextBox
            // 
            uiTitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiTitleTextBox.Location = new Point(12, 12);
            uiTitleTextBox.Name = "uiTitleTextBox";
            uiTitleTextBox.PlaceholderText = "Название стрима";
            uiTitleTextBox.Size = new Size(200, 23);
            uiTitleTextBox.TabIndex = 0;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateButton.Location = new Point(12, 183);
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
            uiCategoryIdTextBox.Location = new Point(12, 41);
            uiCategoryIdTextBox.Name = "uiCategoryIdTextBox";
            uiCategoryIdTextBox.PlaceholderText = "ID игры";
            uiCategoryIdTextBox.Size = new Size(200, 23);
            uiCategoryIdTextBox.TabIndex = 2;
            // 
            // uiProfileComboBox
            // 
            uiProfileComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiProfileComboBox.DropDownHeight = 120;
            uiProfileComboBox.DropDownWidth = 200;
            uiProfileComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            uiProfileComboBox.FormattingEnabled = true;
            uiProfileComboBox.IntegralHeight = false;
            uiProfileComboBox.Location = new Point(12, 70);
            uiProfileComboBox.Name = "uiProfileComboBox";
            uiProfileComboBox.Size = new Size(200, 23);
            uiProfileComboBox.TabIndex = 3;
            uiProfileComboBox.SelectedIndexChanged += uiProfileComboBox_SelectedIndexChanged;
            // 
            // uiCreateProfileButton
            // 
            uiCreateProfileButton.Location = new Point(12, 109);
            uiCreateProfileButton.Name = "uiCreateProfileButton";
            uiCreateProfileButton.Size = new Size(200, 23);
            uiCreateProfileButton.TabIndex = 4;
            uiCreateProfileButton.Text = "Создать профиль";
            uiCreateProfileButton.UseVisualStyleBackColor = true;
            uiCreateProfileButton.Click += uiCreateProfileButton_Click;
            // 
            // uiDeleteProfileButton
            // 
            uiDeleteProfileButton.Location = new Point(12, 138);
            uiDeleteProfileButton.Name = "uiDeleteProfileButton";
            uiDeleteProfileButton.Size = new Size(200, 23);
            uiDeleteProfileButton.TabIndex = 5;
            uiDeleteProfileButton.Text = "Удалить профиль";
            uiDeleteProfileButton.UseVisualStyleBackColor = true;
            uiDeleteProfileButton.Click += uiDeleteProfileButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 245);
            Controls.Add(uiDeleteProfileButton);
            Controls.Add(uiCreateProfileButton);
            Controls.Add(uiProfileComboBox);
            Controls.Add(uiCategoryIdTextBox);
            Controls.Add(updateButton);
            Controls.Add(uiTitleTextBox);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Твич";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uiTitleTextBox;
        private Button updateButton;
        private TextBox uiCategoryIdTextBox;
        private ComboBox uiProfileComboBox;
        private Button uiCreateProfileButton;
        private Button uiDeleteProfileButton;
    }
}
