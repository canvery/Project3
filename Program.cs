using System.Reflection.PortableExecutable;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            //Console.ReadLine();
            MainMenu();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Seconds to Minutes");
            Console.WriteLine("2. Minutes to Hours");
            Console.WriteLine("3. Hours to Days");
            Console.WriteLine("4. Days to Months\n");
            Console.Write("Please type what you would like to convert: ");
            switch (Console.ReadLine())
            {
                case "1":
                    SectoMin();
                    break;
                case "2":
                    MintoHr();
                    break;
                case "3":
                    HtoD();
                    break;
                case "4":
                    DtoM();
                    break;
            }


            MainMenu();
        }
        static void SectoMin()
        {
            Console.WriteLine("");
            Console.WriteLine("Seconds to Minutes");
            Console.Write("Seconds = ");
            double seconds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Minutes = {0}\n", seconds / 60);
            Console.WriteLine("");
            Console.Write("Press Enter to return");
            Console.ReadLine();
        }
        static void MintoHr()
        {
            Console.WriteLine("");
            Console.WriteLine("Minutes to Hours");
            Console.Write("Minutes = ");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours = {0}\n", minutes / 60);
            Console.WriteLine("");
            Console.Write("Press Enter to return");
            Console.ReadLine();
        }
        static void HtoD()
        {
            Console.WriteLine("");
            Console.WriteLine("Hours to days");
            Console.Write("Hours = ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Days = {0}\n", hours / 24);
            Console.WriteLine("");
            Console.Write("Press Enter to return");
            Console.ReadLine();
        }
        static void DtoM()
        {
            Console.WriteLine("");
            Console.WriteLine("Days to Months");
            Console.Write("Days = ");
            double days = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Months = {0}", days / 30.44);
            Console.WriteLine("");
            Console.Write("Press Enter to return");
            Console.ReadLine();
        }
    }
}