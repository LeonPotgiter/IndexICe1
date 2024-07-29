namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter your flight name: ");
            string fName = Console.ReadLine();
            Console.Write("Please enter your distance: ");
            double tDistance = double.Parse(Console.ReadLine());

            Pilot pilot = new Pilot(id, name, surname, fName, tDistance);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(pilot[i]);
            }
        }
    }
}
