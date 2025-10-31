public class Program
{

    public static void Main(string[] args)
    {

        bool running = true;

        while (running) {

            Console.WriteLine("===================================================");
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. Load game");
            Console.WriteLine("3. Exit");
            Console.WriteLine();


            switch (Console.ReadLine()) {
                case "1":
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