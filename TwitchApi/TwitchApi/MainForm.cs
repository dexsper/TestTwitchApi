using Microsoft.Extensions.DependencyInjection;
using TwitchApi.Twitch;

namespace TwitchApi
{
    public partial class MainForm : Form
    {
        private TwitchApiClient _twitchApiClient;

        public MainForm(TwitchApiClient twitchApiClient)
        {
            _twitchApiClient = twitchApiClient;
            InitializeComponent();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            var tokenIsValid = await _twitchApiClient.IsTokenValid();

            if (tokenIsValid)
            {
                updateButton.Enabled = true;
                return;
            }

            using (var authForm = Program.ServiceProvider.GetRequiredService<AuthForm>())
                authForm.ShowDialog();

            updateButton.Enabled = true;
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            var updateResult = await _twitchApiClient.UpdateBroadcast(uiTitleTextBox.Text, uiCategoryIdTextBox.Text);

            if (!updateResult)
            {
                MessageBox.Show("Не удалось обновить!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Обновлено!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
