using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRClientConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chatHub")
                .Build();

            connection.StartAsync().Wait();
            connection.InvokeCoreAsync("sendMessage", args: new[] { "Scribo", "Hello" });
            connection.On("ReceiveMessage", (string userName, string message) =>
            { 
                Console.WriteLine(userName + ":" + message);
            });

            Console.ReadKey();
        }
    }
}