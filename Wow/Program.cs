using Wow.Core.Models;
using Wow.Infrastructure.UserAuth;

public class Program
{

    public static void Main(string[] args)
    {

        bool running = true;

        while (running) {

            Console.WriteLine("===================================================");
            Console.WriteLine("1. Lgin");
            Console.WriteLine("2. Registration");
            Console.WriteLine("3. Exit");
            Console.WriteLine();


            switch (Console.ReadLine()) {
                case "1":
                    EFSqliteUserRepository userAuth = new EFSqliteUserRepository();

                    Console.WriteLine("Your name:");
                    string name = Console.ReadLine ();
                    Console.WriteLine("Your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Your password");
                    string password = Console.ReadLine();

                    User user = new(name, email, password);


                    userAuth.SavePlayer(user);
                    Console.WriteLine("Choose your character");
                    break;
                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Невірна команда. Спробуйте ще раз.");
                    break;

            }


        }
    }
}