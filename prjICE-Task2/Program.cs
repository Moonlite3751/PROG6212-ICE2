namespace prjICE_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating class
            Thunderbolts thunderboltsInt = new Thunderbolts(100, "Bucky Barnes", "Peak Physical Strength & Metal Arm", "Winter Soldier", "Guilt Ridden");
            Thunderbolts thunderboltsStr = new Thunderbolts(30, "Bob", "Super Strength, Super Speed & Flight", "Sentry", "Depressed");

            //Display data using int indexers
            Console.WriteLine("Displaying Thunderbolt team member with Integer Indexers");
            Console.WriteLine(thunderboltsInt[0]);
            Console.WriteLine(thunderboltsInt[1]);
            Console.WriteLine(thunderboltsInt[2]);
            Console.WriteLine(thunderboltsInt[3]);
            Console.WriteLine(thunderboltsInt[4]);

            Console.WriteLine("");

            //Display data using string indexers
            Console.WriteLine("Displaying Thunderbolt team member with Integer Indexers");
            Console.WriteLine(thunderboltsStr["age"]);
            Console.WriteLine(thunderboltsStr["name"]);
            Console.WriteLine(thunderboltsStr["power"]);
            Console.WriteLine(thunderboltsStr["heroName"]);
            Console.WriteLine(thunderboltsStr["personality"]);
        }
    }
}
