using System.Text.Json;

namespace TwitchApi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            var updateResult = await Program.Client.UpdateBroadcast(uiTitleTextBox.Text, uiCategoryIdTextBox.Text);

            if (updateResult)
            {
                MessageBox.Show("Обновлено!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не удалось обновить!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiTypeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            uiTitleTextBox.Enabled = uiTypeCustomRadioButton.Checked;
            uiCategoryIdTextBox.Enabled = uiTypeCustomRadioButton.Checked;

            if (uiTypeTarkovRadioButton.Checked)
            {
                uiTitleTextBox.Text = "Escape From Tarkov / Страдания новичка";
                uiCategoryIdTextBox.Text = "491931";
            }
            else if (uiTypeDevelopRadioButton.Checked)
            {
                uiTitleTextBox.Text = ".net помойка / делаем бота для твича #2";
                uiCategoryIdTextBox.Text = "1469308723";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
