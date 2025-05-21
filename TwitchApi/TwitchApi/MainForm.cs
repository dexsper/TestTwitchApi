using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using TwitchApi.Profile;
using TwitchApi.Twitch;

namespace TwitchApi
{
    public partial class MainForm : Form
    {
        private readonly TwitchApiClient _twitchApiClient;
        private readonly TwitchProfileStorage _profileStorage;

        private BindingList<TwitchProfile> _profiles;

        public MainForm(TwitchApiClient twitchApiClient, TwitchProfileStorage profileStorage)
        {
            InitializeComponent();

            _twitchApiClient = twitchApiClient;
            _profileStorage = profileStorage;

            _profiles = new BindingList<TwitchProfile>(profileStorage.LoadProfiles());
            uiProfileComboBox.DataSource = _profiles;
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _profileStorage.SaveProfiles(_profiles.ToList());
        }

        private void uiProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiProfileComboBox.SelectedItem is TwitchProfile selectedProfile)
            {
                uiTitleTextBox.Text = selectedProfile.Title;
                uiCategoryIdTextBox.Text = selectedProfile.CategoryId;
            }
        }

        private void uiCreateProfileButton_Click(object sender, EventArgs e)
        {
            var profileName = ShowInputDialog("Введите название профиля:");
            if (profileName == null)
            {
                return;
            }

            var profile = new TwitchProfile(profileName, uiTitleTextBox.Text, uiCategoryIdTextBox.Text);

            _profiles.Add(profile);
            uiProfileComboBox.SelectedIndex = _profiles.Count - 1;
        }

        private void uiDeleteProfileButton_Click(object sender, EventArgs e)
        {
            _profiles.RemoveAt(uiProfileComboBox.SelectedIndex);
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

        private static string? ShowInputDialog(string text)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Ввод",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 10, Top = 40, Width = 260 };

            Button confirmation = new Button() { Text = "OK", Left = 110, Width = 80, Top = 70, DialogResult = DialogResult.OK };
            prompt.AcceptButton = confirmation;

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : null;
        }
    }
}
