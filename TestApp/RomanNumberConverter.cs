namespace TestApp
{
    public class RomanNumberConverter
    {
        public static readonly Dictionary<char, int> RomanNumberDictionary;

        static RomanNumberConverter()
        {
            RomanNumberDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
        }

        public static int FromRoman(string roman)
        {
            int total = 0;

            int current, previous = 0;
            char currentRoman, previousRoman = '\0';

            for (int i = 0; i < roman.Length; i++)
            {
                currentRoman = roman[i];

                previous = previousRoman != '\0' ? RomanNumberDictionary[previousRoman] : '\0';

                try
                {
                    current = RomanNumberDictionary[currentRoman];
                }
                catch (Exception)
                {
                    return 0;
                }
                

                if (previous != 0 && current > previous)
                {
                    total = total - (2 * previous) + current;
                }
                else
                {
                    total += current;
                }

                previousRoman = currentRoman;
            }

            return total;
        }
    }
}
