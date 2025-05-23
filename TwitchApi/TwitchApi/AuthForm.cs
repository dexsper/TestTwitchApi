using System.Diagnostics;
using System.Net;
using System.Text;
using TwitchAPi.Client;

namespace TwitchApi
{
    public partial class AuthForm : Form
    {
        private const int ListenPort = 21799;
        private string RedirectUrl => $"http://localhost:{ListenPort}";

        private TwitchApiClient _twitchApiClient;

        public AuthForm(TwitchApiClient twitchApiClient)
        {
            _twitchApiClient = twitchApiClient;
            InitializeComponent();
        }

        private async void authButton_Click(object sender, EventArgs e)
        {
            var code = await GetAuthCode();
            await _twitchApiClient.RefreshTokenByCode(code, RedirectUrl);

            Close();
        }

        private async Task<string> GetAuthCode()
        {
            var authorizeUrl = _twitchApiClient.GetCodeAuthLink(
                RedirectUrl,
                TwitchScope.UserReadBroadcast | TwitchScope.ChannelManageBroadcast
            );

            Process.Start(new ProcessStartInfo(authorizeUrl) { UseShellExecute = true });
            return await ListenCode();
        }

        private async Task<string> ListenCode()
        {
            var listener = new HttpListener();
            listener.Prefixes.Add($"http://localhost:{ListenPort}/");
            listener.Start();

            while (true)
            {
                var context = await listener.GetContextAsync();
                var request = context.Request;
                var code = request.QueryString["code"];

                if (string.IsNullOrEmpty(code))
                    continue;

                string responseString = @"
                <html>
                  <head>
                    <meta charset=""utf-8"" />
                    <script>
                      window.close();
                    </script>
                  </head>
                  <body>
                    <p>Вы можете закрыть это окно</p>
                  </body>
                </html>";

                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                context.Response.ContentLength64 = buffer.Length;
                context.Response.ContentType = "text/html";
                await context.Response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                context.Response.OutputStream.Close();


                return code;
            }
        }
    }
}
