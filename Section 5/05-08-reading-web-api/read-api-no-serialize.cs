using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace restApp
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task GetMovies(int? id)
        {
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Add("User-Agent", "ACME Browser");
        var getMoviesTask= client.GetStringAsync("https://www.jeremymorgan.com:8080/fakeapi/Movies/" + id);
        var output = await getMoviesTask;
        Console.Write(output);
        }

        static void Main(string[] args)
        {
            GetMovies(null).Wait();
            Console.WriteLine("----------------------------------");
            GetMovies(1).Wait();
            Console.WriteLine("----------------------------------");
            GetMovies(4).Wait();
            Console.WriteLine("----------------------------------");
            GetMovies(3).Wait();
        }
    }
}
