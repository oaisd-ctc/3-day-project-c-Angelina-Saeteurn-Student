
class Program
{

    public static void Main(string[] args)
    {
        PlayerIntroMessage();

        System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
        string userInput = Console.ReadLine();
        while (userInput != "quit")
        {
            if (userInput.ToLower() == "info")
            {
                //Information Options
                System.Console.WriteLine("Health, Strength, Level, bosses, ...");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "health")
                {

                }
                else if (userInput.ToLower() == "strength")
                {

                }
                else if (userInput.ToLower() == "level")
                {

                }
                else if (userInput.ToLower() == "bosses")
                {
                    System.Console.WriteLine("Which level boss do you want information on?\n Level 1. Level 2. Level 3. or Back");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "back")
                    {
                        System.Console.WriteLine("Health, Strength, Level, bosses, ...");
                userInput = Console.ReadLine();
                    }
                }
                else
                {
                    System.Console.WriteLine("Not a valid response");
                }

            }
            if (userInput.ToLower() == "Bosses")
            {
                System.Console.WriteLine("Choose boss");
            }
        }



        // while (userInput.ToLower() != "quit")
        // {
        //     Console.Clear();
        //     switch (userInput.ToLower())
        //     {

        //         case "info":
        //             System.Console.WriteLine("INFORMATION TEXT\n");
        //             System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
        //             break;

        //         case "name":
        //             System.Console.WriteLine("NAME TEXT\n");
        //             System.Console.WriteLine("ENTER INFO, BOSSES, QUIT");
        //             break;

        //         case "bosses":
        //             System.Console.WriteLine("BOSS CHOICES\n");
        //             System.Console.WriteLine("ENTER INFO, NAME, QUIT");
        //             break;

        //         default:
        //             System.Console.WriteLine("NOT VALID INPUT RESPONSE\n");
        //             System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
        //             break;
        //     }
        //     userInput = Console.ReadLine();

        // }



    }

    public static void PlayerIntroMessage()
    {
        System.Console.WriteLine("INTRO MESSAGE");
        System.Console.WriteLine("ENTER NAME");

        string PlayerName = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("INTRO BACKGROUND STORY " + PlayerName);
        //can use the name to implement into the story.
    }
}

