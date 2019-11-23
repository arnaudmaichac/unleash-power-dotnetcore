using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace Superheroes.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Superheroes.Protos.Superheroes.SuperheroesClient(channel);
            var response = await client.GetByIdAsync(new Protos.GetByIdRequest
            {
                Id = 1
            });

            Console.WriteLine(response.Superhero.Id);
            Console.Read();
        }
    }
}
