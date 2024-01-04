using System;
using static System.Formats.Asn1.AsnWriter;

namespace GA_LinearSearch
{
    internal class Program
    {

        // Declare the global arrays
        static string[] storeDirectory;
        static string[] storeCategories;
        static Store[] stores;

        static string[] consoles;
        static string[] games;
        static GameConsole[] gameConsoles;
        static string[] company;

        static void Main(string[] args)
        {
            Preload();

            Console.WriteLine("Contains");
            Console.WriteLine(ContainsCompany(consoles, "Sony").ToString()); // True
            Console.WriteLine(ContainsCompany(consoles, "Sega").ToString()); // False

            Console.WriteLine("Store By Index");
            Console.WriteLine(GameByConsole(games, "Nintendo 3DS").ToString()); // 6
            Console.WriteLine(GameByConsole(games, "Sega").ToString()); // -1

            Console.WriteLine("All games of a console");
            Console.WriteLine(AllGamesbyConsole(consoles, "Xbox One").Count); // 2
            Console.WriteLine(AllGamesbyConsole(consoles, "Xbox Series s").Count); // 0

            Console.WriteLine("All consoles In a company (Just use the first Letter)");
            List<GameConsole> companyResults = AllConsolesInCompany(gameConsoles, "N");
            Console.WriteLine(companyResults.Count); // 4
            foreach (GameConsole console in companyResults) { Console.WriteLine($"{console.ConsoleName} - {console.Company}"); }
            Console.WriteLine(AllConsolesInCompany(gameConsoles, "N").Count); // 0

        }

        public static bool ContainsCompany(string[] companyList, string searchKey)
        {
            foreach (string company in companyList)
            {
                if (company == searchKey)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GameByConsole(string[] games, string searchKey)
        {
            for (int i = 0; i < consoles.Length; i++)
            {
                if (consoles[i] == searchKey)
                {
                    return i;
                }
            }
            return -1; // Return -1 if not found
        }

        public static List<int> AllGamesbyConsole(string[] games, string searchKey)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i] == searchKey)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public static List<GameConsole> AllConsolesInCompany(GameConsole[] consolelist, string searchKey)
        {
            List<GameConsole> consolesInCompany = new List<GameConsole>();
            foreach (GameConsole console in consolelist)
            {
                if (console.Company[0].ToString() == searchKey)
                {
                    consolesInCompany.Add(console);
                }
            }
            return consolesInCompany;
        }



        static void Preload()
        {
            storeDirectory = new string[]
            {
            "Aqua Adventures",
            "Pixel Playhouse",
            "Brew & Bean",
            "Vintage Visions",
            "Garden Gateway",
            "Melody Makers",
            "Spice Spectrum",
            "Tech Trends",
            "Cozy Corner",
            "Frosty Delights"
            };

            storeCategories = new string[]
            {
            "Sports & Recreation",      // Aqua Adventures
            "Entertainment",            // Pixel Playhouse
            "Café & Bakery",            // Brew & Bean
            "Clothing & Accessories",   // Vintage Visions
            "Home & Garden",            // Garden Gateway
            "Entertainment",            // Melody Makers
            "Food & Groceries",         // Spice Spectrum
            "Electronics",              // Tech Trends
            "Home & Garden",            // Cozy Corner
            "Café & Bakery"             // Frosty Delights
            };

            stores = new Store[]
            {
            new Store("Aqua Adventures", "Sports & Recreation", "A21"),
            new Store("Pixel Playhouse", "Entertainment", "B7"),
            new Store("Brew & Bean", "Café & Bakery", "C36"),
            new Store("Vintage Visions", "Clothing & Accessories", "A9"),
            new Store("Garden Gateway", "Home & Garden", "B42"),
            new Store("Melody Makers", "Entertainment", "C15"),
            new Store("Spice Spectrum", "Food & Groceries", "A3"),
            new Store("Tech Trends", "Electronics", "B28"),
            new Store("Cozy Corner", "Home & Garden", "C12"),
            new Store("Frosty Delights", "Café & Bakery", "A31")
            };

            games = new string[]
            {
             "The Legend of Zelda: Breath of the Wild",
            "Super Mario Odyssey",
            "Red Dead Redemption 2",
            "Fortnite",
            "Minecraft",
            "Overwatch",
            "Cyberpunk 2077",
            "Assassin's Creed Valhalla",
            "Call of Duty: Warzone",
            "FIFA 21",
            "FIFA 17",
            "FIFA 15",
            "MarioKart DS",
            "MarioKart7"
            };

            consoles = new string[]
            {
            "PlayStation 5",
            "Xbox Series X",
            "Nintendo Switch",
            "PlayStation 4",
            "Xbox One",
            "Nintendo Wii U",
            "Nintendo 3DS",
            "PC",
            "Nintendo DS",
            "PlayStation 3"

            };

            company = new string[]
            {
                "Sony",
                "Microsoft",
                "Nintendo",
                "Epic Games",
                "Mojang",
                "Blizzard"
            };

            gameConsoles = new GameConsole[]
            {
                new GameConsole("Nintendo Wii U","The Legend of Zelda: Breath of the Wild", "Nintendo"),
                new GameConsole("Nintendo Switch", "Super Mario Odyssey", "Nintendo"),
                new GameConsole("Xbox Series X", "Red Dead Redemption 2", "Microsoft"),
                new GameConsole("Xbox One","Fortnite", "Microsoft"),
                new GameConsole("PC", "Minecraft", "Mojang"),
                new GameConsole("PC", "Overwatch", "Blizzard"),
                new GameConsole("PC", "Cyberpunk 2077", "Epic Games"),
                new GameConsole("PlayStation 5", "Assassin's Creed Valhalla","Sony"),
                new GameConsole("PlayStation 5", "Call of Duty: Warzone", "Sony"),
                new GameConsole("PlayStation 3", "FIFA 15", "Sony"),
                new GameConsole("PlayStation 4", "FIFA 17", "Sony"),
                new GameConsole("Nintendo DS", "MarioKart DS", "Nintendo"),
                new GameConsole("Nintendo 3DS","MarioKart7", "Nintendo")

            };


        } // End Preload

       


    }
}
