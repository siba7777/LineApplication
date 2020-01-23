using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PushMessageSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SendPushMessage().GetAwaiter().GetResult();
        }

        private static async Task SendPushMessage()
        {
            var message = new PushMessage();
            message.To = "BOTユーザのユーザID";
            message.message.Add(new Message("text", "Hello World1"));
            message.message.Add(new Message("text", "Hello World2"));

            var json = JsonConvert.SerializeObject(message);

            var accessToken = "アクセストークン";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://api.line.me/v2/bot/message/push", content);
        }
    }
}
