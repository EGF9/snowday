
namespace snow_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            string answer = "";

            Console.WriteLine("is it snowing? yes/no");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("it is a snow day");
            }

            else
            {
                Console.WriteLine("no");
            }
            Console.ReadLine();
        }
    }
}
