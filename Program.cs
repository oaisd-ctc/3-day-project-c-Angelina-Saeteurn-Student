
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{

    public static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("INTRO MESSAGE");
        System.Console.WriteLine("ENTER NAME");
        string userInput = Console.ReadLine();
        string userName = userInput;
        LoadingVisual();
        Console.Clear();

        while (userInput != "quit")
        {
            System.Console.WriteLine("ENTER: INFO, NAME, QUIT");
            userInput = Console.ReadLine();

            while (userInput.ToLower() != "quit")
            {

                if (userInput.ToLower() == "info")
                {
                    LoadingVisual();
                    Console.Clear();

                    System.Console.WriteLine("Health, Strength, Level, bosses, ...");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "health")
                    {
                        LoadingVisual();
                        Console.Clear();
                        System.Console.WriteLine("Your current health is: \n");
                        while (userInput != "back")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Type back to go back");
                            userInput = Console.ReadLine();
                        }


                        userInput = Console.ReadLine();
                        continue;

                    }

                    else if (userInput.ToLower() == "bosses")
                    {
                        LoadingVisual();
                        Console.Clear();


                        while (userInput.ToLower() != "quit")
                        {
                            System.Console.WriteLine("Which level boss do you want information on?\n Level: 1, 2, 3, or Back");
                            userInput = Console.ReadLine();
                            if (userInput == "1")
                            {
                                System.Console.WriteLine("This is boss 1.\n");
                                System.Console.WriteLine("Type Back to go back");
                                userInput = Console.ReadLine();
                                LoadingVisual();
                                continue;
                            }
                            else if (userInput == "2")
                            {
                                System.Console.WriteLine("This is boss 2.\n");
                                System.Console.WriteLine("Type Back to go back");
                                userInput = Console.ReadLine();
                                LoadingVisual();
                                Console.Clear();
                                continue;
                            }
                            else if (userInput == "3")
                            {

                                System.Console.WriteLine("This boss is the boss of the ... . It has ... health and can ... .\n");
                                System.Console.WriteLine("Type Back to go back");
                                userInput = Console.ReadLine();
                                LoadingVisual();
                                continue;
                            }
                            else
                            {
                                while (userInput != "back")
                                {
                                    LoadingVisual();
                                    Console.Clear();
                                    System.Console.WriteLine("Type back to go back");
                                    userInput = Console.ReadLine();
                                }

                                Console.Clear();
                                continue;
                            }
                        }
                    }

                    else if (userInput.ToLower() == "strength")
                    {

                    }

                    else if (userInput.ToLower() == "level")
                    {

                    }

                    else if (userInput.ToLower() == "back")
                    {
                        Console.Clear();
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        NotValidResponseMessage();
                        continue;
                    }
                }


                if (userInput.ToLower() == "name")
                {
                    LoadingVisual();
                    Console.Clear();
                    System.Console.WriteLine("Your name is: " + userName + ".\n");

                    while (userInput != "back")
                    {
                        System.Console.WriteLine("Type back to go back or Edit to edit your name.");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == "quit")
                        {
                            break;
                        }
                        else if (userInput.ToLower() == "edit")
                        {
                            LoadingVisual();
                            Console.Clear();
                            System.Console.WriteLine("Enter your new name.\n");
                            userName = Console.ReadLine();
                            LoadingVisual();
                            Console.Clear();
                            System.Console.WriteLine("Your new name is: " + userName + ".\n");
                            System.Console.WriteLine("Type back to go back or Edit to edit your name.");
                            userInput = Console.ReadLine();
                        }
                        else
                        {
                            LoadingVisual();
                            Console.Clear();
                        }
                    }

                    LoadingVisual();
                    Console.Clear();
                    continue;
                }

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                else
                {
                    Console.Clear();
                    NotValidResponseMessage();
                    System.Console.WriteLine("ENTER: INFO, NAME, QUIT");
                    userInput = Console.ReadLine();
                    LoadingVisual();
                    continue;
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

        static void LoadingVisual()
        {
            int loadingPauseTime = 300;
            int numberOfDots = 3;

            for (int i = 0; i < numberOfDots; i++)
            {
                System.Console.Write(".");
                Thread.Sleep(loadingPauseTime);

            }

        }

        static void NotValidResponseMessage()
        {
            System.Console.WriteLine("NOT A VALID RESPONSE.");
        }
    }
}

