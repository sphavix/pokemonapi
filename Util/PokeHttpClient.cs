using System.Text.Json;
using pokemonapi.Models;

namespace pokemonapi.Util
{
    public class PokeHttpClient
    {
        public HttpClient Client{ get; set; }

        public PokeHttpClient(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}