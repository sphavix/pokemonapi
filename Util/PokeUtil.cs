namespace pokemonapi.Util
{
    public static class PokeUtil
    {
        public const string Pokeball = "icons8-insignia-3-stars-96.png";
        public const string Greatball = "icons8-pokemon-ball-96.png";
        public const string Ultraball = "icons8-ultra-ball-96.png";
        public const string Masterball = "icons8-insignia-2-stars-96.png";

        public static string GetRandomBall()
        {
            var pokeballArray = new string[] {Pokeball, Greatball, Ultraball, Masterball};

            var random = new Random();
            string randomBall = pokeballArray[random.Next(pokeballArray.Length)];

            return randomBall;
        }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}