
namespace snow_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            double chance = 0;
            string answer = "";

            Console.WriteLine("what is the temperature");
            answer = Console.ReadLine();
            if (Convert.ToInt32(answer) <= 0)
            {
                chance += 40;
            }
            else
            {
                chance /= 2;
            }

            Console.WriteLine("Is it moist outside");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                chance += 10;
            }
            else
            {
                chance /= 2;
            }

            Console.WriteLine("do you live near the ocean");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                chance /= 2;
            }
            else
            {
                chance += 20 ;
            }

            Console.WriteLine("do you live near the mountains");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                chance += 30 ;
            }
            else
            {
                chance /= 2;
            }

            Console.WriteLine("is it snowing? yes/no");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("it is a snow day");
                chance = 100;
            }



            Console.WriteLine("chance of snow is " + chance + "%");
            Console.ReadLine();
        }
    }
}
