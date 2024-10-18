using System.Runtime.ExceptionServices;

namespace UnitTest_PracticalTask
{
    public class PracticalTask
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pracical task");
        }

        public static int MaxConsecutiveDistinctCharacters(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentNullException(nameof(word), "Input cannot be null or empty.");
            }

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }

            maxLength = Math.Max(maxLength, currentLength);
            return maxLength;
        }

        public static int MaxConsecutiveIdenticalLetters(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentNullException(nameof(word), "Input cannot be null or empty.");
            }

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]) && char.IsLetter(word[i - 1]) && word[i] == word[i - 1] && IsLatinLetter(word[i]))
                {
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                }
                else
                {
                    currentLength = 1;
                }
            }
            return maxLength;
        }

        private static bool IsLatinLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public static int MaxConsecutiveIdenticalDigits(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentNullException(nameof(word), "Input cannot be null or empty.");
            }

            int maxLength = 1;
            int currentLength = 1;

            bool hasDigits = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    hasDigits = true;
                    break;
                }
            }

            if (!hasDigits)
            {
                return 0;
            }

            for (int i = 1; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]) && char.IsDigit(word[i - 1]) && word[i] == word[i - 1])
                {
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                }
                else if (char.IsDigit(word[i])) 
                {
                    currentLength = 1;
                }
                else
                {
                    currentLength = 0;
                }
            }
            return maxLength;
        }
    }
    
}
