using System.Text.Json;
using System.Text;

namespace TwitchApi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            uiNameTextBox.Text = ".net помойка / делаем бота для твича / upd1";
        }

        private async void uiChangeNameButton_Click(object sender, EventArgs e)
        {
            var newName = uiNameTextBox.Text;

            var accessFile = "E:\\bobgroup\\projects\\TwitchPomogator\\key.txt";
            var lines = System.IO.File.ReadAllLines(accessFile);

            string clientId = "gvo8mc3xtlkg79k8gdsj1gt8ylb2ht";
            string oauthToken = "huy";
            string broadcasterId = "177128531";
            await UpdateTwitchStreamTitle(clientId, oauthToken, broadcasterId, newName);
        }

        async Task UpdateTwitchStreamTitle(string clientId, string oauthToken, string broadcasterId, string newTitle)
        {
            using (HttpClient client = new HttpClient())
            {
                // Устанавливаем заголовки
                client.DefaultRequestHeaders.Add("Client-ID", clientId);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {oauthToken.Replace("oauth:", "")}");

                // Тело запроса (меняем только title)
                var requestBody = new
                {
                    title = newTitle
                };

                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // URL API для обновления информации о трансляции
                string url = $"https://api.twitch.tv/helix/channels?broadcaster_id={broadcasterId}";

                // Отправляем PATCH-запрос
                HttpResponseMessage response = await client.PatchAsync(url, content);

                // Проверяем ответ
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Название трансляции успешно изменено!", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseContent, $"Ошибка: {response.StatusCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
