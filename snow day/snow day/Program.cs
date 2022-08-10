
namespace snow_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            double chance;
            string answer = "";

            Console.WriteLine("is it snowing? yes/no");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("it is a snow day");
                chance = 100;
            }

            else
            {
                Console.WriteLine("no");
                chance = 50;
            }

            Console.WriteLine("what is the temperature");
            answer = Console.ReadLine();
            if (Convert.ToInt32(answer) <= 0)
            {
                chance += 75 / 2;
            }
            else
            {
                chance /= 2;
            }

            Console.WriteLine("Is it moist outside");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                chance += 75 / 1.5;
            }
            else
            {
                chance /= 1.5;
            }

            Console.WriteLine("chance of snow is " + chance + "%");
            Console.ReadLine();
        }
    }
}
