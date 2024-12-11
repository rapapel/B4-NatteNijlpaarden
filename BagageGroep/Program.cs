namespace BagageGroep;

partial class Program
{
    public const int TotalLockers = 100;
    public const string LockerFile = "lockers.txt";
    static void Main(string[] args)
    {
        Console.WriteLine("Welkom bij zwembad de golf!\n");
        //stop hier je hoofd loop

        // Maak een instantie van LockerCount aan met het totaal aantal kluizen en gebruikte kluizen
        LockerCount lockerCount = new LockerCount(100, 30); // 100 kluizen, 30 zijn in gebruik

        // Verkrijg het aantal beschikbare kluizen
        int availableLockers = lockerCount.GetAvailableLockers();
        Console.WriteLine($"Beschikbare kluizen: {availableLockers}"); // Output: Beschikbare kluizen: 70

        // Update het aantal kluizen
        lockerCount.UpdateLockers(120, 50); // 120 kluizen, 50 in gebruik
        availableLockers = lockerCount.GetAvailableLockers();
        Console.WriteLine($"Beschikbare kluizen na update: {availableLockers}"); // Output: Beschikbare kluizen na update: 70

        // Probeer ongeldige invoer (negatieve kluizen)
        try
        {
            lockerCount.UpdateLockers(50, 60); // Fout: meer gebruikte kluizen dan totaal aantal
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Fout: {ex.Message}");
        }
    }

    //laat het menu zien
    // Console.WriteLine("1. Laat het aantal kluizen zien.");
    //etc.

}
}
