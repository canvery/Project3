namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seconds to Minutes");
            Console.Write("Seconds = ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutes = {0}\n", seconds / 60);

            Console.WriteLine("Minutes to Hours");
            Console.Write("Minutes = ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours = {0}\n", minutes / 60);

            Console.WriteLine("Hours to days");
            Console.Write("Hours = ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Days = {0}\n", hours / 24);

            Console.WriteLine("Days to Months");
            Console.Write("Days = ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Months = {0}", days / 30.44);
        }
    }
}