
using Enemies;
using Items;

class Program
{
    public static int boss1Health = 80;
    public static int boss2Health = 100;
    public static int boss3Health = 125;
    public static int playerHealth = 100;
    public static int healAmount = 20;
    public static string userInput;
    public static int loop = 0;
    public static string playerStrength = "Weak";

    public static void Main(string[] args)
    {

        System.Console.Clear();
        System.Console.WriteLine("Welcome to Realm Rhapsody!\n");
        System.Console.Write("Please enter your character's name: ");
        string playerName = Console.ReadLine();

        LoadingVisual();


        string background = GenerateBackground();
        // Thread.Sleep(3000);
        Player player = CreatePlayer(background, playerName);


        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
        Console.ReadKey();

        System.Console.WriteLine("");
        LoadingVisual();

        while (userInput != "quit")
        {

            System.Console.WriteLine("Your current choices are: Check game Info, Fight a boss, or Quit");
            userInput = Console.ReadLine();
            Thread.Sleep(200);
            System.Console.Clear();

            if (userInput.ToLower() == "info" || userInput.ToLower() == "check info" || userInput.ToLower() == "check" || userInput.ToLower() == "check "|| userInput.ToLower() == "check " || userInput.ToLower() == "check ")
            {
                System.Console.WriteLine("");
                Console.Clear();
                System.Console.WriteLine("Enter: Player info, Boss info, or Back.");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "player info" || userInput.ToLower() == "player" || userInput.ToLower() == "player ")
                {

                    System.Console.Clear();
                    System.Console.WriteLine("Your current health is: " + playerHealth);
                    System.Console.WriteLine("Your current Heal amount is: " + healAmount);
                    Console.WriteLine("Your current strength is: " + playerStrength);
                    System.Console.WriteLine("\nPRESS ANY KEY TO GO BACK");
                    Console.ReadKey();
                    LoadingVisual();
                    continue;

                }

                if (userInput.ToLower() == "boss info" || userInput.ToLower() == "boss" || userInput.ToLower() == "boss ")
                {
                    while (true)
                    {

                        // Thread.Sleep(500);
                        Console.Clear();

                        if (userInput.ToLower() == "boss info" || userInput.ToLower() == "boss" || userInput.ToLower() == "boss ")
                        {
                            if (boss1Health > 0)
                            {
                                System.Console.WriteLine("Boss 1 currently has " + boss1Health + " health");
                            }
                            else if (boss1Health <= 0)
                            {
                                System.Console.WriteLine("Aedan the Penny-Pinching Tycoon is Dead. R.I.P");
                            }
                            if (boss2Health > 0)
                            {
                                System.Console.WriteLine("Boss 2 currently has " + boss2Health + " health");
                            }
                            else if (boss2Health <= 0)
                            {
                                System.Console.WriteLine("Mister Luyk the Arcane Luminary is Dead. R.I.P");
                            }
                            if (boss3Health > 0)
                            {
                                System.Console.WriteLine("Boss 3 currently has " + boss3Health + " health");
                            }
                            else if (boss3Health <= 0)
                            {
                                System.Console.WriteLine("Emannuel The Scorched Conquerer is Dead. R.I.P");
                            }
                            System.Console.WriteLine("\nPRESS ANY KEY TO GO BACK");
                            Console.ReadKey();
                            LoadingVisual();
                            Console.Clear();
                            break;
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
                }
                if (userInput.ToLower() == "back")
                {
                    Console.Clear();
                    continue;
                }

            }

            if (userInput.ToLower() == "fight")
            {
                Boss1 bossOne = new Boss1("Aedan the Penny-Pinching Tycoon", 80, 1, 21, true, "The Limosa Umbra Sanctum, in the Marshland");
                Boss2 bossTwo = new Boss2("Mister Luyk the Arcane Luminary", 100, 5, 31, true, "Frostweave Spire, in the Arctic Freeze");
                Boss3 bossThree = new Boss3("Emannuel The Scorched Conquerer", 125, 10, 41, true, "The Eternal Caldera, in the Vocanic Lands");


                Console.Clear();
                Console.WriteLine("Which level boss do you want to fight?\n1. Easy\n2. Medium\n3. Hard\n\nOr Back");
                userInput = Console.ReadLine();
                Console.Clear();

                if (userInput.ToLower() == "1" || userInput.ToLower() == "easy")
                {
                    FightLoop1(player, bossOne, bossOne.GetName(), player.GetName());
                }

                else if (userInput.ToLower() == "2" || userInput.ToLower() == "medium")
                {
                    FightLoop2(player, bossTwo, bossTwo.GetName(), player.GetName());
                }

                else if (userInput.ToLower() == "3" || userInput.ToLower() == "hard")
                {
                    FightLoop3(player, bossThree, bossThree.GetName(), player.GetName());
                }

                else if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
                {
                    Console.Clear();
                    continue;
                }

            }
            else if (userInput.ToLower() == "quit")
            {
                Console.Clear();
                break;
            }
            else if (userInput.ToLower() == "back" || userInput.ToLower() == "back ")
            {
                Console.Clear();
                continue;
            }
            else if (userInput.ToLower() == "boss info" || userInput.ToLower() == "boss" || userInput.ToLower() == "boss ")
            {
                continue;
            }
            else
            {
                Console.Clear();
                NotValidResponseMessage();
                LoadingVisual();
                Console.Clear();
                continue;
            }
            Console.Clear();
            continue;
        }
    }

    public static int getMinDamage(int minimumDamage)
    {

        return minimumDamage;
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
        // int randomBackground = rnd.Next(1, 5);
        int randomBackground = 2;
        string background = " ";

        Console.Clear();
        System.Console.WriteLine("\nGenerating your character background");
        LoadingVisual();

        if (randomBackground == 1)
        {

            background = "Marsh";
            Console.WriteLine("Background:\n\nWithin the Marshland, life thrives amidst the ethereal mist and labyrinthine waterways. The air is thick with the heady scent of decay and the symphony of unseen creatures.\nWisps of fog weave through twisted mangroves, and the inhabitants, attuned to the swamp's rhythm, move with a quiet grace through the murky depths.\nThe shadowy spires of ancient cypress trees stand sentinel, where secrets are whispered through rustling leaves and the swamp's heart beats with an enigmatic pulse.");

        }

        else if (randomBackground == 2)
        {
            background = "Lava";
            Console.WriteLine("Background:\n\nAmidst the volcanic land of Alchemy, existence is a dance within the radiant warmth and ancient mystique.\nLuminescent energies pulsate through the air, casting a perpetual glow upon the inhabitants who navigate the incandescent pathways of this scorching realm.\nThe towering pyro-spires stand as testament to the mastery of elemental forces, where each heartbeat resonates with the untamed vitality of the living flames.");

        }

        else if (randomBackground == 3)
        {
            background = "Snow";
            Console.WriteLine("Background:\n\nIn the frozen solitude of the Glacial Citadel, life unfolds amidst shimmering ice and ancient enchantments.\nWisps of frost weave through the air as the inhabitants, attuned to the icy symphony, navigate crystalline corridors.\nThe wizard's tower, a spire of enchanted ice, stands sentinel against the relentless chill, where every breath feels like a whispered incantation.");

        }

        else if (randomBackground == 4)
        {
            background = "Plains";
            Console.WriteLine("Background:\n\nIn the vast expanse of the Dreamweaver Plains, where golden sunlight bathes the rolling hills, a hidden Apothecary Dell is a sanctuary for healers and seekers alike.\nAmidst the sea of swaying grasses and vibrant wildflowers, a mystical Well of Vitality emerges.\nLegends speak of the wellspring's magical waters, enriched by the purity of the meadow's essence.");
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

    public static void FightLoop1(Player player, Enemy chosenBoss, string bossName, string playerName)
    {
        bool isPlayersTurn = true;

        while (true)
        {
            if (boss1Health > 0)
            {
                if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                {
                    LoadingVisual();
                    break;
                }
                while (isPlayersTurn)
                {
                    Console.Clear();
                    Console.WriteLine($"{playerName} VS {bossName}");
                    Console.WriteLine();
                    Console.WriteLine($"BOSS : {bossName}");
                    Console.WriteLine($"BOSS HEALTH : " + boss1Health);
                    Console.WriteLine($"YOUR HEALTH : " + playerHealth);
                    Console.WriteLine("\n\n\n1. >>ATTACK \n2. >>HEAL " + healAmount + "\n3. >>RUN AWAY");
                    userInput = Console.ReadLine();
                    LoadingVisual();

                    if (userInput != "1" && userInput != "2" && userInput != "3")
                    {
                        Console.WriteLine("That is not an option\n\n1. >>ATTACK \n2. >>HEAL " + healAmount + "\n3. >>RUN AWAY");
                        userInput = Console.ReadLine();
                        LoadingVisual();
                    }
                    if (userInput == "3")
                    {

                        Console.Clear();
                        Console.WriteLine("Are you sure?\nYes/No");
                        userInput = Console.ReadLine();

                        if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                        {
                            Console.Clear();
                            break;

                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }

                    }

                    else if (userInput == "2")
                    {
                        Console.WriteLine("You heal " + healAmount + " health.");

                        if (playerHealth + healAmount > 100)
                        {
                            playerHealth = 100;
                        }
                        else
                        {
                            playerHealth += healAmount;
                        }

                        System.Console.WriteLine("Your health is now: " + playerHealth);
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        isPlayersTurn = false;

                    }
                    else if (userInput == "1")
                    {
                        if (player.GetWeapon() == "Magma Sear Blade")
                        {
                            Random randomNum = new Random();
                            int randomAttack = randomNum.Next(1, 5);
                            switch (randomAttack)
                            {
                                case 1:
                                    Console.WriteLine("You throw a searing strike!\n This does 15 damage!");
                                    boss1Health = boss1Health - 25;
                                    break;

                                case 2:
                                    Console.WriteLine("You do an Inferno Slash!\n This does 20 damage!");
                                    boss1Health = boss1Health - 20;
                                    break;

                                case 3:
                                    Console.WriteLine("You unleash Volcanic Fury!\n This does 25 damage");
                                    boss1Health = boss1Health - 25;
                                    break;
                                case 4:
                                    Console.WriteLine($"You sear slashed {bossName}!\n This does 30 damage!");
                                    boss1Health = boss1Health - 30;
                                    break;
                                default:
                                    Console.WriteLine("You missed");
                                    break;
                            }
                            System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                            Console.ReadKey();
                            LoadingVisual();

                            isPlayersTurn = false;

                            if (isPlayersTurn = false && boss1Health <= 0)
                            {
                                LoadingVisual();
                                System.Console.WriteLine("You Killed " + bossName + "!!!");
                                System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Medium!\nYour Heal amount is now 30!");
                                healAmount = 30;
                                playerStrength = "Medium";
                                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                LoadingVisual();
                                break;
                            }
                            if (playerHealth <= 0)
                            {
                                LoadingVisual();
                                System.Console.WriteLine("YOU DIED\n\nGAME OVER");
                                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }

                    }

                    if (player.GetWeapon() == "Bogreaper Scythe")
                    {
                        Console.WriteLine($"You Bog Sliced {bossName}");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();


                        isPlayersTurn = false;
                        break;
                    }
                    else if (player.GetWeapon() == "Glacial Embrace Blade")
                    {
                        Console.WriteLine($"You Glacial Sliced {bossName}");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();


                        isPlayersTurn = false;
                        break;
                    }
                    else if (player.GetWeapon() == "Windshard Longbow")
                    {
                        Console.WriteLine($"You Windshard bowed {bossName}!");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();

                        isPlayersTurn = false;
                        break;
                    }
                }

                if (isPlayersTurn == false)
                {
                    System.Console.WriteLine("Now " + bossName + "'s turn to Attack!");
                    System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    if (boss1Health <= 0)
                    {

                        LoadingVisual();
                        System.Console.WriteLine("You Killed " + bossName + "!!!");
                        System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Medium!\nYour Heal amount is now 30!");
                        healAmount = 30;
                        playerStrength = "Medium";
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        LoadingVisual();
                        break;
                    }
                    if (playerHealth <= 0)
                    {
                        LoadingVisual();
                        System.Console.WriteLine("YOU DIED\n\nGAME OVER");
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    LoadingVisual();
                    playerHealth = playerHealth - chosenBoss.Attack();
                    System.Console.WriteLine("\nPRESS ANY KEY TO GO CONTINUE");
                    Console.ReadKey();
                    LoadingVisual();
                    isPlayersTurn = true;
                    continue;
                }
            }
            else
            {
                LoadingVisual();
                System.Console.WriteLine(bossName + " is Dead. You Destroyed Him!\nYour strength is now Medium!\nYour Heal amount is now 30!");
                System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
                break;
            }
        }
    }
    public static void FightLoop2(Player player, Enemy chosenBoss, string bossName, string playerName)
    {
        bool isPlayersTurn = true;

        while (true)
        {
            if (boss2Health > 0)
            {
                if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                {
                    LoadingVisual();
                    break;
                }
                while (isPlayersTurn)
                {
                    Console.Clear();
                    Console.WriteLine($"{playerName} VS {bossName}");
                    Console.WriteLine();
                    Console.WriteLine($"BOSS : {bossName}");
                    Console.WriteLine($"BOSS HEALTH : " + boss2Health);
                    Console.WriteLine($"YOUR HEALTH : " + playerHealth);
                    Console.WriteLine("\n\n\n1. >>ATTACK \n2. >>HEAL " + healAmount + "\n3. >>RUN AWAY");
                    userInput = Console.ReadLine();
                    LoadingVisual();

                    if (userInput != "1" && userInput != "2" && userInput != "3")
                    {
                        Console.WriteLine("That is not an option\n\n1. >>ATTACK \n2. >>HEAL " + healAmount + "\n3. >>RUN AWAY");
                        userInput = Console.ReadLine();
                        LoadingVisual();
                    }
                    if (userInput == "3")
                    {

                        Console.Clear();
                        Console.WriteLine("Are you sure?\nYes/No");
                        userInput = Console.ReadLine();

                        if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }

                    else if (userInput == "2")
                    {
                        Console.WriteLine("You heal " + healAmount + " health.");

                        if (playerHealth + healAmount > 100)
                        {
                            playerHealth = 100;
                        }
                        else
                        {
                            playerHealth += healAmount;
                        }
                        System.Console.WriteLine("Your health is now: " + playerHealth);
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        isPlayersTurn = false;
                    }
                    else if (userInput == "1")
                    {
                        if (player.GetWeapon() == "Magma Sear Blade")
                        {
                            Random randomNum = new Random();
                            int randomAttack = randomNum.Next(1, 5);
                            switch (randomAttack)
                            {
                                case 1:
                                    Console.WriteLine("You throw a searing strike!\n This does 25 damage!");
                                    boss2Health = boss2Health - 25;
                                    break;

                                case 2:
                                    Console.WriteLine("You do an Inferno Slash!\n This does 30 damage!");
                                    boss2Health = boss2Health - 30;
                                    break;

                                case 3:
                                    Console.WriteLine("You unleash Volcanic Fury!\n This does 35 damage");
                                    boss2Health = boss2Health - 35;
                                    break;
                                case 4:
                                    Console.WriteLine($"You sear slashed {bossName}!\n This does 40 damage!");
                                    boss2Health = boss2Health - 40;
                                    break;
                                default:
                                    Console.WriteLine("You missed");
                                    break;
                            }
                            System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                            Console.ReadKey();
                            LoadingVisual();

                            isPlayersTurn = false;

                            if (isPlayersTurn = false && boss2Health <= 0)
                            {
                                LoadingVisual();
                                System.Console.WriteLine("You Killed " + bossName + "!!!");
                                System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Huge!\nYour Heal amount is now 40!");
                                healAmount = 40;
                                playerStrength = "Huge";
                                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                LoadingVisual();
                                break;
                            }
                            if (playerHealth <= 0)
                            {
                                LoadingVisual();
                                System.Console.WriteLine("YOU DIED\n\nGAME OVER");
                                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }

                    }

                    if (player.GetWeapon() == "Bogreaper Scythe")
                    {
                        Console.WriteLine($"You Bog Sliced {bossName}");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();


                        isPlayersTurn = false;
                        break;
                    }
                    else if (player.GetWeapon() == "Glacial Embrace Blade")
                    {
                        Console.WriteLine($"You Glacial Sliced {bossName}");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();


                        isPlayersTurn = false;
                        break;
                    }
                    else if (player.GetWeapon() == "Windshard Longbow")
                    {
                        Console.WriteLine($"You Windshard bowed {bossName}!");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();

                        isPlayersTurn = false;
                        break;
                    }
                }

                if (isPlayersTurn == false)
                {
                    System.Console.WriteLine("Now " + bossName + "'s turn to Attack!");
                    System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    if (boss2Health <= 0)
                    {
                        LoadingVisual();
                        System.Console.WriteLine("You Killed " + bossName + "!!!");
                        System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Huge!\nYour Heal amount is now 40!");
                        healAmount = 40;
                        playerStrength = "Huge";
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        LoadingVisual();
                        break;
                    }
                    if (playerHealth <= 0)
                    {
                        LoadingVisual();
                        System.Console.WriteLine("YOU DIED\n\nGAME OVER");
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    LoadingVisual();
                    playerHealth = playerHealth - chosenBoss.Attack();
                    System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    LoadingVisual();
                    isPlayersTurn = true;
                    continue;
                }
            }
            else
            {
                LoadingVisual();
                System.Console.WriteLine(bossName + " is Dead. You Destroyed Him!\nYour strength is now Huge!\nYour Heal amount is now 40!");
                healAmount = 40;
                playerStrength = "Huge";
                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                Console.ReadKey();
                break;
            }
        }
    }
    public static void FightLoop3(Player player, Enemy chosenBoss, string bossName, string playerName)
    {
        bool isPlayersTurn = true;

        while (true)
        {
            if (boss3Health > 0)
            {
                if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                {
                    LoadingVisual();
                    break;
                }
                while (isPlayersTurn)
                {
                    Console.Clear();
                    Console.WriteLine($"{playerName} VS {bossName}");
                    Console.WriteLine();
                    Console.WriteLine($"BOSS : {bossName}");
                    Console.WriteLine($"BOSS HEALTH : " + boss3Health);
                    Console.WriteLine($"YOUR HEALTH : " + playerHealth);
                    Console.WriteLine("\n\n\n1. >>ATTACK \n2. >>HEAL " + healAmount + "\n3. >>RUN AWAY");
                    userInput = Console.ReadLine();
                    LoadingVisual();

                    if (userInput != "1" && userInput != "2" && userInput != "3")
                    {
                        Console.WriteLine("That is not an option\n\n1. >>ATTACK \n2. >>HEAL " + healAmount + "\n3. >>RUN AWAY");
                        userInput = Console.ReadLine();
                        LoadingVisual();
                    }
                    if (userInput == "3")
                    {

                        Console.Clear();
                        Console.WriteLine("Are you sure?\nYes/No");
                        userInput = Console.ReadLine();

                        if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                        {
                            Console.Clear();
                            break;

                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }

                    }

                    else if (userInput == "2" || userInput.ToLower() == "h" || userInput.ToLower() == "heal")
                    {
                        Console.WriteLine("You heal " + healAmount + " health.");

                        if (playerHealth + healAmount > 100)
                        {
                            playerHealth = 100;
                        }
                        else
                        {
                            playerHealth += healAmount;
                        }

                        System.Console.WriteLine("Your health is now: " + playerHealth);
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        isPlayersTurn = false;

                    }
                    if (playerHealth <= 0)
                    {
                        LoadingVisual();
                        System.Console.WriteLine("YOU DIED\n\nGAME OVER");
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    if (boss3Health <= 0)
                            {
                                LoadingVisual();
                                System.Console.WriteLine("You Killed " + bossName + "!!!");
                                System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Godly!\nYour Heal amount is now 1,000,000!");
                                healAmount = 1000000;
                                playerStrength = "Godly";
                                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                LoadingVisual();
                                break;
                            }
                    else if (userInput == "1" || userInput.ToLower() == "a" || userInput.ToLower() == "attack")
                    {
                        if (player.GetWeapon() == "Magma Sear Blade")
                        {
                            Random randomNum = new Random();
                            int randomAttack = randomNum.Next(1, 5);
                            switch (randomAttack)
                            {
                                case 1:
                                    Console.WriteLine("You throw a searing strike!\n This does 30 damage!");
                                    boss3Health = boss3Health - 30;
                                    break;

                                case 2:
                                    Console.WriteLine("You do an Inferno Slash!\n This does 35 damage!");
                                    boss3Health = boss3Health - 35;
                                    break;

                                case 3:
                                    Console.WriteLine("You unleash Volcanic Fury!\n This does 40 damage");
                                    boss3Health = boss3Health - 40;
                                    break;
                                case 4:
                                    Console.WriteLine($"You sear slashed {bossName}!\n This does 45 damage!");
                                    boss3Health = boss3Health - 45;
                                    break;
                                default:
                                    Console.WriteLine("You missed");
                                    break;
                            }
                            System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                            Console.ReadKey();
                            LoadingVisual();


                            isPlayersTurn = false;

                            if (isPlayersTurn = false && boss3Health <= 0)
                            {
                                LoadingVisual();
                                System.Console.WriteLine("You Killed " + bossName + "!!!");
                                System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Godly!\nYour Heal amount is now 1,000,000!");
                                healAmount = 1000000;
                                playerStrength = "Godly";
                                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                LoadingVisual();
                                break;
                            }


                        }

                    }

                    if (player.GetWeapon() == "Bogreaper Scythe")
                    {
                        Console.WriteLine($"You Bog Sliced {bossName}");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();


                        isPlayersTurn = false;
                        break;
                    }
                    else if (player.GetWeapon() == "Glacial Embrace Blade")
                    {
                        Console.WriteLine($"You Glacial Sliced {bossName}");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();


                        isPlayersTurn = false;
                        break;
                    }
                    else if (player.GetWeapon() == "Windshard Longbow")
                    {
                        Console.WriteLine($"You Windshard bowed {bossName}!");
                        System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();

                        isPlayersTurn = false;
                        break;
                    }
                }

                if (isPlayersTurn == false)
                {
                    Console.Clear();
                    System.Console.WriteLine("Now " + bossName + "'s turn to Attack!");
                    System.Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                    LoadingVisual();

                    if (boss3Health <= 0)
                    {
                        LoadingVisual();
                        System.Console.WriteLine("You Killed " + bossName + "!!!");
                        System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Godly!\nYour Heal amount is now 1,000,000!");
                        healAmount = 1000000;
                        playerStrength = "Godly";
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        LoadingVisual();
                        break;
                    }
                    if (playerHealth <= 0)
                    {
                        LoadingVisual();
                        System.Console.WriteLine("YOU DIED\n\nGAME OVER");
                        System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    LoadingVisual();
                    playerHealth = playerHealth - chosenBoss.Attack();
                    System.Console.WriteLine("\nPRESS ANY KEY TO GO CONTINUE");
                    Console.ReadKey();
                    LoadingVisual();
                    isPlayersTurn = true;
                    continue;
                }
            }
            else
            {
                LoadingVisual();

                System.Console.WriteLine("\nCongratulations!\n\nYour strength is now Godly!\nYour Heal amount is now 1,000,000!");
                healAmount = 1000000;
                playerStrength = "Godly";
                System.Console.WriteLine("\nPRESS ANY KEY TO EXIT");
                Console.ReadKey();
                break;
            }
        }
    }
}


