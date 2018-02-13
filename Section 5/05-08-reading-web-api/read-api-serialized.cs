using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace restApp
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task<List<Movie>> GetMovies(int? id)
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Movie>));

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "ACME Browser");
            var streamTask = client.GetStreamAsync("https://www.jeremymorgan.com:8080/fakeapi/Movies/");
            var Movies = serializer.ReadObject(await streamTask) as List<Movie>;

            return Movies;
        }
        static void Main(string[] args)
        {
           var movies = GetMovies(null).Result;

           foreach (var movie in movies){
                Console.WriteLine(movie.Title + " " + movie.Year);
            }
        }
    }
}
