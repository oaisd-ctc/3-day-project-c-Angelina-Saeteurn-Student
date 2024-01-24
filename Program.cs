
class Program
{

    public static void Main(string[] args)
    {


        System.Console.WriteLine("WELCOME MESSAGE");
        System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();
            switch (userInput.ToLower())
            {
                    
                case "info":

                System.Console.WriteLine("INFORMATION TEXT\n");
                System.Console.WriteLine("ENTER NAME, BOSSES, QUIT");
                break;

            case "name":
                System.Console.WriteLine("NAME TEXT\n");
                System.Console.WriteLine("ENTER INFO, BOSSES, QUIT");
                break;

            case "bosses":
                System.Console.WriteLine("BOSS CHOICES\n");
                System.Console.WriteLine("ENTER INFO, NAME, QUIT");
                break;

            default:
                System.Console.WriteLine("NOT VALID INPUT RESPONSE\n");
                System.Console.WriteLine("ENTER INFO, NAME, BOSSES, QUIT");
                break;
            }
            userInput = Console.ReadLine();
        }


        
    }
}
