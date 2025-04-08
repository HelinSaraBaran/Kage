namespace Kage
{
    internal class Program
    {
        static void Main()
        {
            // vi starter med at oprette en liste med vores ingredienser 
            List<String> ingredients = new List<String>

            // vi tilføjer vores ingredienser til listen
            { "200 g hvedemel (ca. 3.5 dl)",
            "2 teskefulde Bagepulver",
            "1/2 teskefuld fint salt",
            "2 æg",
            "150 g sukker (ca. 1 1/2 dl)",
            "1 teskefuld vaniljesukker",
            "125 g smeltet smør",
            "2 modne bananer",
            "100 g mørk chokolade"
            };

            // vi vil nu gøre brug af en foreach loop 
            foreach (String ingredient in ingredients)
            {
                // vi vil nu udskrive vores ingredienser 
                Console.WriteLine(ingredient);
            }
        }
    }
}
