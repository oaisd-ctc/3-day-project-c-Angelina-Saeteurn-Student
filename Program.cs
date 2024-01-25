
using System.Security.Cryptography.X509Certificates;
using Items;


class Program
{

    public static void Main(string[] args)
    {

        Console.Clear();
        System.Console.WriteLine("INTRO MESSAGE");
        System.Console.WriteLine("ENTER NAME");

        System.Console.Clear();

        System.Console.WriteLine("WELCOME MESSAGE");
        System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");

        string userInput = Console.ReadLine();

        while (userInput != "quit")
        {

        System.Console.WriteLine("ENTER INFO, NAME, QUIT");
        userInput = Console.ReadLine();

            if (userInput.ToLower() == "info")
            {
                LoadingVisual();
                Console.Clear();
                Console.Clear();
            
            switch (userInput.ToLower())
            {
                    
            case "info":

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

