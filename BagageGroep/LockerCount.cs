using System;

namespace BagageGroep;

{
    public class LockerCount
    {
        // Property voor het totaal aantal kluizen
        public int TotalLockers { get; set; }

        // Property voor het aantal gebruikte kluizen
        public int UsedLockers { get; set; }

        // Constructor om het totaal aantal kluizen en het aantal gebruikte kluizen in te stellen
        public LockerCount(int totalLockers, int usedLockers)
        {
            if (totalLockers < 0 || usedLockers < 0 || usedLockers > totalLockers)
            {
                throw new ArgumentException("Ongeldige waarden voor kluizen: controleer de invoer.");
            }

            TotalLockers = totalLockers;
            UsedLockers = usedLockers;
        }

       
        public int GetAvailableLockers()
        {
            // Het aantal beschikbare kluizen is het totaal aantal kluizen min het aantal gebruikte kluizen
            return TotalLockers - UsedLockers;
        }

   
        public void UpdateLockers(int totalLockers, int usedLockers)
        {
            if (totalLockers < 0 || usedLockers < 0 || usedLockers > totalLockers)
            {
                throw new ArgumentException("Ongeldige waarden voor kluizen: controleer de invoer.");
            }

            TotalLockers = totalLockers;
            UsedLockers = usedLockers;
        }
    }
}



