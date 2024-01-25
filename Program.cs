
using Items;


class Program
{

    public static void Main(string[] args)
    {


        System.Console.Clear();
        System.Console.WriteLine("Welcome to Realm Rhapsody!");
        System.Console.WriteLine("Please enter your character's name:");
        string playerName = Console.ReadLine();

        string background = GenerateBackground();
        Potion startingPotion = GeneratePotionFromBackground(background);
        Weapon weapon = GenerateWeaponFromBackground(background);

        Player player = new Player(playerName, startingPotion, weapon);

        System.Console.WriteLine("Here's your character's background:");
        System.Console.WriteLine(GenerateBackgroundDescription(background));

        System.Console.WriteLine("ENTER ANYTHING TO CONTINUE");


        string userInput = Console.ReadLine();
        string userName = userInput;
        LoadingVisual();
        Console.Clear();

        while (userInput != "quit")
        {

            System.Console.Clear();
            System.Console.WriteLine("INFO, FIGHT, OR QUIT...");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "info")
            {
                while (true)
                {
                    LoadingVisual();
                    System.Console.Clear();

                    System.Console.WriteLine("PLAYER INFORMATION, BOSS INFORMATION, OR BACK...");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "player information")
                    {
                        while (true)
                        {
                            LoadingVisual();
                            System.Console.Clear();

                            System.Console.WriteLine("HEALTH, STRENGTH, OR BACK...");
                            userInput = Console.ReadLine();

                            LoadingVisual();
                            System.Console.Clear();

                            if (userInput.ToLower() == "health")
                            {
                                System.Console.WriteLine("Your current health is:");
                                System.Console.WriteLine("Enter Back to go back");
                                userInput = Console.ReadLine();
                            }

                            else if (userInput.ToLower() == "strength")
                            {
                                System.Console.WriteLine("Your current strength is:");
                                System.Console.WriteLine("Enter Back to go back");
                                userInput = Console.ReadLine();
                            }

                            else if (userInput.ToLower() == "back")
                            {
                                break;
                            }
                        }
                    }

                    if (userInput.ToLower() == "boss information")
                    {
                        while (true)
                        {
                            Thread.Sleep(500);
                            Console.Clear();
                            System.Console.WriteLine("BOSSES FOUND, BOSSES BEATEN, OR BACK");
                            userInput = Console.ReadLine();

                            if (userInput.ToLower() == "")

                                if (userInput.ToLower() == "back")
                                {
                                    break;
                                }
                        }
                    }

                    else if (userInput.ToLower() == "back")
                    {
                        break;
                    }
                }
            }

            else if (userInput.ToLower() == "fight")
            {
                Enemy bossOne = new Enemy("BOSS ONE", 100, 20, 40, true, "Location");
                Enemy bossTwo = new Enemy("BOSS TWO", 100, 20, 40, true, "Location");
                Enemy bossThree = new Enemy("BOSS THREE", 100, 20, 40, true, "Location");

                while (true)
                {
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
                        break;
                    }
                }
            }

            else
            {
                Console.Clear();
                NotValidResponseMessage();
            }

            if (userInput.ToLower() == "quit")
            {
                break;
            }
        }
    }


    public static void LoadingVisual()
    {
        int loadingPauseTime = 300;
        int numberOfDots = 3;

        for (int i = 0; i < numberOfDots; i++)
        {
            System.Console.Write(".");
            Thread.Sleep(loadingPauseTime);
        }

    }

    public static string GenerateBackground()
    {
        Random rnd = new Random();
        int randomBackground = rnd.Next(1, 5);
        string background = "";


        LoadingVisual();
        System.Console.WriteLine("Generating your character background");
        LoadingVisual();


        //COME UP WITH FOUR BACKGROUNDS
        if (randomBackground == 1)
        {
            //BACKGROUND ONE
        }

        else if (randomBackground == 2)
        {
            //BACKGROUND TWO
        }

        else if (randomBackground == 3)
        {
            //BACKGROUND THREE
        }

        else if (randomBackground == 4)
        {
            //BACKGROUND FOUR
        }

        return background;
    }

    public static string GenerateBackgroundDescription(string background)
    {
        string backgroundDescription = "NONE";

        //COME UP WITH DESCRIPTIONS FOR THE FOUR BACKGROUNDS
        if (background == "")
        {
            //BACKGROUND ONE
        }

        else if (background == "")
        {
            //BACKGROUND TWO
        }

        else if (background == "")
        {
            //BACKGROUND THREE
        }

        else if (background == "")
        {
            //BACKGROUND FOUR
        }
        return backgroundDescription;
    }

    public static Potion GeneratePotionFromBackground(string background)
    {
        string potionName = "NONE";
        string potionDescription = "NONE";
        Potion startingPotion = new Potion(potionName, potionDescription);


        //CHANGE POTION NAME AND DESCRIPTION VARIABLES IN EVERY OUTCOME
        if (background == "")
        {
            //BACKGROUND ONE STARTING POTION
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

    public static void NotValidResponseMessage()
    {
        System.Console.WriteLine("NOT A VALID RESPONSE.");
        LoadingVisual();
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

