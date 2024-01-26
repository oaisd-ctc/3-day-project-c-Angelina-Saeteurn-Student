
using Enemies;
using Items;


class Program
{
    public static string userInput;

    public static void Main(string[] args)
    {
        string background = GenerateBackground();

        System.Console.Clear();
        System.Console.WriteLine("Welcome to Realm Rhapsody!");
        System.Console.WriteLine("Please enter your character's name:");

        string playerName = Console.ReadLine();
        Player player = CreatePlayer(background, playerName);
        // Thread.Sleep(300);
        System.Console.WriteLine("Here's your character's background:");
        GenerateBackground();
        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
        Console.ReadKey();
        System.Console.WriteLine("");
        // LoadingVisual();
        Console.Clear();

        while (userInput != "quit")
        {

            System.Console.WriteLine("Enter: Info, Fight, or Quit");
            userInput = Console.ReadLine();
            // LoadingVisual();
            System.Console.Clear();

            if (userInput.ToLower() == "info")
            {

                while (true)
                {
                    System.Console.WriteLine("Enter: Player info, Boss info, or Back.");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "player info" || userInput.ToLower() == "player" || userInput.ToLower() == "player ")
                    {
                        while (true)
                        {
                            // LoadingVisual();
                            System.Console.Clear();

                            System.Console.WriteLine("Enter: Health, Strength, or Back");
                            userInput = Console.ReadLine();

                            // LoadingVisual();
                            System.Console.Clear();

                            if (userInput.ToLower() == "health")
                            {
                                System.Console.WriteLine("Your current health is: ");
                                System.Console.WriteLine("Press any button to go back.");
                                Console.ReadKey();
                                userInput = "player info";
                                continue;

                            }

                            else if (userInput.ToLower() == "strength")
                            {
                                System.Console.WriteLine("Your current strength is: ");
                                System.Console.WriteLine("Press any button to go back.");
                                Console.ReadKey();
                                userInput = "player info";
                                continue;
                            }

                            else if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
                            {
                                userInput = "info";
                                break;
                            }

                            else if (userInput.ToLower() == "back")
                            {
                                // LoadingVisual();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("NOT A VALID INPUT.");
                                System.Console.WriteLine("Enter: Health, Strength, or Back");
                                userInput = Console.ReadLine();
                            }



                            if (userInput.ToLower() == "back")
                            {
                                break;
                            }

                            else
                            {
                                Console.Clear();
                                NotValidResponseMessage();
                                LoadingVisual();
                                continue;
                            }
                        }


                        if (userInput.ToLower() == "boss info" || userInput.ToLower() == "boss" || userInput.ToLower() == "boss ")
                        {
                            while (true)
                            {
                                // Thread.Sleep(500);
                                Console.Clear();
                                System.Console.WriteLine("Enter: Bosses Found, Bosses Beaten, back, or Quit.");
                                userInput = Console.ReadLine();

                                if (userInput.ToLower() == "bosses found" || userInput.ToLower() == "found")
                                {
                                    System.Console.WriteLine("You have found __ bosses. \n Boss: \n Boss: \n");
                                    System.Console.WriteLine("Enter Back to go back");
                                    userInput = Console.ReadLine();

                                }
                                else if (userInput.ToLower() == "bosses beaten" || userInput.ToLower() == "beaten")
                                {
                                    System.Console.WriteLine("You have beaten __ bosses. \n Boss: \n Boss: \n");
                                    System.Console.WriteLine("Enter Back to go back");
                                    userInput = Console.ReadLine();
                                }
                                else if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
                                {
                                    break;
                                    Console.Clear();
                                }
                                else if (userInput.ToLower() == "quit")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    System.Console.WriteLine("Not a valid response\n");
                                    LoadingVisual();

                                }

                            }

                            if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
                            {
                                continue;
                            }

                        }

                    }
                    if (userInput.ToLower() == "boss")
                    {

                    }
                    if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
                    {
                        // LoadingVisual();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        NotValidResponseMessage();
                        LoadingVisual();
                        continue;
                    }
                }

            }

            if (userInput.ToLower() == "fight")
            {
                Boss1 bossOne = new Boss1("The Frugal Financier, Aedan the Penny-Pinching Tycoon", 100, 1, 21, true, "The Limosa Umbra Sanctum, in the Marshland");
                Boss2 bossTwo = new Boss2("The Enigmatic Soverign, Mister Luyk the Arcane Luminary", 100, 5, 31, true, "Frostweave Spire, in the Arctic Freeze");
                Boss3 bossThree = new Boss3("The Infernal Warlord, Emannuel The Scorched Conquerer", 100, 10, 41, true, "The Eternal Caldera, in the Vocanic Lands");


                Console.Clear();
                Console.WriteLine("BOSS 1, 2, 3 OR BACK");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "1")
                {
                    FightLoop(player, bossOne, bossOne.GetName(), player.GetName());
                }

                else if (userInput.ToLower() == "2")
                {
                    FightLoop(player, bossTwo, bossTwo.GetName(), player.GetName());
                }

                else if (userInput.ToLower() == "3")
                {
                    FightLoop(player, bossThree, bossThree.GetName(), player.GetName());
                }

                else if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
                {
                    continue;
                }

            }
            else if (userInput.ToLower() == "quit")
            {
                break;
            }
            else if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
            {
                continue;
            }
            else
            {
                Console.Clear();
                NotValidResponseMessage();
                LoadingVisual();
                continue;
            }

            break;
        }
    }

    public static Player CreatePlayer(string background, string playerName)
    {

        Potion startingPotion = GeneratePotionFromBackground(background);
        Weapon weapon = GenerateWeaponFromBackground(background);
        Player player = new Player(playerName, startingPotion, weapon);

        return player;
    }

    public static string GenerateBackground()
    {
        Random rnd = new Random();
        int randomBackground = rnd.Next(1, 5);
        string background = " ";

        Console.Clear();
        System.Console.WriteLine("\nGenerating your character background");
        LoadingVisual();

        if (randomBackground == 1)
        {

            background = "Marsh";
            Console.WriteLine("Background: \n Within the Marshland, life thrives amidst the ethereal mist and labyrinthine waterways. The air is thick with the heady scent of decay and the symphony of unseen creatures. Wisps of fog weave through twisted mangroves, and the inhabitants, attuned to the swamp's rhythm, move with a quiet grace through the murky depths. The shadowy spires of ancient cypress trees stand sentinel, where secrets are whispered through rustling leaves and the swamp's heart beats with an enigmatic pulse.");

        }

        else if (randomBackground == 2)
        {
            background = "Lava";
            Console.WriteLine("Background: \nAmidst the Volcanic land of Alchemy, existence is a dance within the radiant warmth and ancient mystique. Luminescent energies pulsate through the air, casting a perpetual glow upon the inhabitants who navigate the incandescent pathways of this scorching realm. The towering pyro-spires stand as testament to the mastery of elemental forces, where each heartbeat resonates with the untamed vitality of the living flames.");

        }

        else if (randomBackground == 3)
        {
            background = "Snow";
            Console.WriteLine("Background: \nIn the frozen solitude of the Glacial Citadel, life unfolds amidst shimmering ice and ancient enchantments. Wisps of frost weave through the air as the inhabitants, attuned to the icy symphony, navigate crystalline corridors. The wizard's tower, a spire of enchanted ice, stands sentinel against the relentless chill, where every breath feels like a whispered incantation. \n ");

        }

        else if (randomBackground == 4)
        {
            background = "Plains";
            Console.WriteLine("In the vast expanse of the Dreamweaver Plains, where golden sunlight bathes the rolling hills, a hidden Apothecary Dell is a sanctuary for healers and seekers alike. Amidst the sea of swaying grasses and vibrant wildflowers, a mystical Well of Vitality emerges. Legends speak of the wellspring's magical waters, enriched by the purity of the meadow's essence.");
        }

        return background;
    }

    public static Potion GeneratePotionFromBackground(string background)
    {
        string potionName = "NONE";
        string potionDescription = "NONE";
        Potion startingPotion = new Potion(potionName, potionDescription);


        //CHANGE POTION NAME AND DESCRIPTION VARIABLES IN EVERY OUTCOME
        if (background == "Lava")
        {
            
        }

        else if (background == "Marsh")
        {
            //BACKGROUND TWO STARTING POTION
        }

        else if (background == "Snow")
        {
            //BACKGROUND THREE STARTING POTION
        }

        else if (background == "Plains")
        {
            //BACKGROUND FOUR STARTING POTION
        }


        return startingPotion;
    }

    public static Weapon GenerateWeaponFromBackground(string background)
    {
        string weaponName = "NONE";
        string weaponDescription = "NONE";
        Weapon weapon = new Weapon(weaponName, weaponDescription, 10, 20);


        //CHANGE WEAPON NAME AND DESCRIPTION VARIABLES IN EVERY OUTCOME
        if (background == "Lava")
        {
            Weapon magmaSearBlade = new Weapon("Magma Sear Blade", "");
            weapon = magmaSearBlade;
        }

        else if (background == "Marsh")
        {
            Weapon bogreaperScythe = new Weapon("Bogreaper Scythe", "");
            weapon = bogreaperScythe;
        }

        else if (background == "Snow")
        {
            Weapon glacialEmbraceBlade = new Weapon("Glacial Embrace Blade", "");
            weapon = glacialEmbraceBlade;
        }

        else if (background == "Plains")
        {
            Weapon windshardLongbow = new Weapon("Windshard Longbow", "");
            weapon = windshardLongbow;
        }

        return weapon;
    }

    static void NotValidResponseMessage()
    {
        System.Console.WriteLine("NOT A VALID RESPONSE.");
        // LoadingVisual();
    }

    public static void LoadingVisual()
    {
        int loadingPauseTime = 400;
        int numberOfDots = 3;


        for (int i = 0; i < numberOfDots; i++)
        {
            System.Console.Write(".");
            Thread.Sleep(loadingPauseTime);
        }
        Console.Clear();

    }

    public static void FightLoop(Player player, Enemy chosenBoss, string bossName, string playerName)
    {
        bool isPlayersTurn = true;

        while (true)
        {
            if (chosenBoss.GetHealth() > 0)
            {
                while (isPlayersTurn)
                {
                    Console.Clear();
                    Console.WriteLine($"{playerName} VS {bossName}");
                    Console.WriteLine();
                    Console.WriteLine($"HEALTH : {player.GetHealth()}");
                    Console.WriteLine($"BOSS : {bossName}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\n>>ATTACK \n>>POTIONS \n>>RUN AWAY");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "attack")
                    {
                        Console.Clear();
                        LoadingVisual();
                        if (player.GetWeapon() == "Magma Sear Blade") {
                            Console.WriteLine($"You sear slashed {bossName}!");
                            Thread.Sleep(500);
                            isPlayersTurn=false;
                            break;
                        }
                        else if (player.GetWeapon() == "Bogreaper Scythe") {
                            Console.WriteLine($"You Bog Sliced {bossName}");
                            Thread.Sleep(500);
                            isPlayersTurn=false;
                            break;
                        }
                        else if (player.GetWeapon() == "Glacial Embrace Blade") {
                            Console.WriteLine($"You Glacial Sliced {bossName}");
                            Thread.Sleep(500);
                            isPlayersTurn=false;
                            break;
                        }
                        else if (player.GetWeapon() == "Windshard Longbow") {
                            Console.WriteLine($"You Windshard bowed {bossName}!");
                            Thread.Sleep(5000);
                            isPlayersTurn=false;
                            break;
                        }
                    }
                    else if (userInput.ToLower() == "potions")
                    {
                        Potion[] inventory = player.GetInventory();

                        Console.WriteLine();
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"{i + 1} - {inventory[i].GetItemName()}");
                        }

                        Console.WriteLine();
                        Console.WriteLine("CHOOSE NUMBER OR BACK");
                        userInput = Console.ReadLine();


                        if (userInput.ToLower() == "1")
                        {
                            Potion one = inventory[0];
                            //add function to use
                        }
                        if (userInput.ToLower() == "2")
                        {
                            Potion two = inventory[1];
                            //add function to use
                        }
                        if (userInput.ToLower() == "3")
                        {
                            Potion three = inventory[2];
                            //add function to use
                        }
                        if (userInput.ToLower() == "4")
                        {
                            Potion four = inventory[3];
                            //add function to use
                        }
                        if (userInput.ToLower() == "5")
                        {
                            Potion five = inventory[4];
                            //add function to use
                        }

                    }

                    else if (userInput.ToLower() == "run away")
                    {

                        Console.Clear();
                        Console.WriteLine("Are you sure?");
                        userInput = Console.ReadLine();

                        if (userInput.ToLower() == "yes")
                        {
                            Console.WriteLine();
                            break;
                        }
                        else { }
                    }
                }
                while (isPlayersTurn == false) {
                    Console.Clear();
                    LoadingVisual();
                    chosenBoss.Attack();
                    Thread.Sleep(6000);
                    isPlayersTurn=true;
                    
                }
            }
        }
    }

}


