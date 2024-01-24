
class Program
{

    public static void Main(string[] args)
    {


        System.Console.WriteLine("WELCOME MESSAGE");
        System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "quit")
        {
            switch (userInput.ToLower())
            {

                case "info":
                    System.Console.WriteLine("INFORMATION TEXT");
                    break;

                case "name":
                    System.Console.WriteLine("RETURNING NAME TEXT");
                    break;

                case "bosses":
                    System.Console.WriteLine("BOSS CHOICES");
                    break;

                default:
                    System.Console.WriteLine("NOT VALID INPUT RESPONSE");
                    System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
                    break;
            }
            userInput = Console.ReadLine();
        }
    }
}
