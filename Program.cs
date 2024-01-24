
using System.Security.Cryptography.X509Certificates;

class Program
{

    public static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("INTRO MESSAGE");
        System.Console.WriteLine("ENTER NAME");
        string userInput = Console.ReadLine();

        while (userInput != "quit")
        {
        System.Console.WriteLine("ENTER INFO, NAME, QUIT");
        userInput = Console.ReadLine();

            if (userInput.ToLower() == "info")
            {
                LoadingVisual();
                Console.Clear();

                //Information Options
                System.Console.WriteLine("Health, Strength, Level, bosses, ...");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "health")
                {
                    System.Console.WriteLine("Your current health is:");
                    System.Console.WriteLine("Enter Back to go back");
                    userInput = Console.ReadLine();

                }

                else if (userInput.ToLower() == "bosses")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    System.Console.WriteLine("Which level boss do you want information on?\n Level: 1, 2, 3, or Back");
                    userInput = Console.ReadLine();
                }

                else if (userInput.ToLower() == "strength")
                {

                }

                else if (userInput.ToLower() == "level")
                {

                }



                else
                {
                    Console.Clear();
                    NotValidResponseMessage();
                    userInput = Console.ReadLine();


                }
            }
            if(userInput.ToLower() == "quit")
            {
                break;
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

    public static void NotValidResponseMessage()
    {
        System.Console.WriteLine("NOT A VALID RESPONSE.");
        System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
    }

}

