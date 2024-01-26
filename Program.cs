
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
                            System.Console.WriteLine("Your current strength is:");
                            System.Console.WriteLine("Enter Back to go back");
                            userInput = Console.ReadLine();
                            continue;
                        }

                        else if (userInput.ToLower() == "back")
                        {
                            userInput = "info";
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("NOT A VALID INPUT.");
                            System.Console.WriteLine("Enter: Health, Strength, or Back");
                            userInput = Console.ReadLine();
                        }

                    }
                    else if (userInput.ToLower() == "back")
                    {
                        break;
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
                            else if (userInput.ToLower() == "back")
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

                        if (userInput.ToLower() == "back")
                        {
                            continue;
                        }

                    }
                    else if (userInput.ToLower() == "back")
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
                if (userInput.ToLower() == "back")
                {
                    // LoadingVisual();
                    Console.Clear();
                    continue;
                }
            }

            if (userInput.ToLower() == "fight")
            {
                Enemy bossOne = new Enemy("BOSS ONE", 100, 20, 40, true, "Location");
                Enemy bossTwo = new Enemy("BOSS TWO", 100, 20, 40, true, "Location");
                Enemy bossThree = new Enemy("BOSS THREE", 100, 20, 40, true, "Location");


                Console.Clear();
                Console.WriteLine("BOSS 1, 2, 3 OR BACK");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "1")
                {
                    FightLoop(player, bossOne);
                }

                else if (userInput.ToLower() == "1")
                {
                    FightLoop(player, bossTwo);
                }

                else if (userInput.ToLower() == "1")
                {
                    FightLoop(player, bossThree);
                }

                else if (userInput.ToLower() == "back")
                {
                    continue;
                }

            }
            else if (userInput.ToLower() == "quit")
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
        for (int i = 0; i < 6; i++)
        {
            System.Console.Write(".");
            // Thread.Sleep(500);
        }
        Console.Clear();



        //COME UP WITH FOUR BACKGROUNDS
        if (randomBackground == 1)
        {

            background = "Lava";
            Console.WriteLine("Volcanic land of Alchemy\n");
            //description

        }

        else if (randomBackground == 2)
        {

            Console.WriteLine("Marshland\n");

        }

        else if (randomBackground == 3)
        {

            Console.WriteLine("Arctic Freeze");

        }

        else if (randomBackground == 4)
        {

            Console.WriteLine("Something");


        }

        return background;
    }

    public static Potion GeneratePotionFromBackground(string background)
    {
        string potionName = "NONE";
        string potionDescription = "NONE";
        Potion startingPotion = new Potion(potionName, potionDescription);


        //CHANGE POTION NAME AND DESCRIPTION VARIABLES IN EVERY OUTCOME
        if (background == "snow")
        {
            //BACKGROUND ONE STARTING POTION - Snow potion for snow background
        }

        else if (background == "")
        {
            //BACKGROUND TWO STARTING POTION
        }

        else if (background == "")
        {
            //BACKGROUND THREE STARTING POTION
        }

        else if (background == "")
        {
            //BACKGROUND FOUR STARTING POTION
        }


        return startingPotion;
    }

    public static Weapon GenerateWeaponFromBackground(string background)
    {
        string weaponName = "NONE";
        string weaponDescription = "NONE";
        Weapon weapon = new Weapon(weaponName, weaponDescription);


        //CHANGE WEAPON NAME AND DESCRIPTION VARIABLES IN EVERY OUTCOME
        if (background == "")
        {
            //BACKGROUND ONE WEAPON
        }

        else if (background == "")
        {
            //BACKGROUND TWO WEAPON
        }

        else if (background == "")
        {
            //BACKGROUND THREE WEAPON
        }

        else if (background == "")
        {
            //BACKGROUND FOUR WEAPON
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

    public static void FightLoop(Player player, Enemy chosenBoss)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"HEALTH : {player.GetHealth()}");
            Console.WriteLine($"BOSS : {chosenBoss}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n>>ATTACK \n>>INVENTORY \n>>RUN AWAY");
        }
    }

}


