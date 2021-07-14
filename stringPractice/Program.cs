using System;

namespace stringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceInWonderlandSentance = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("What word would you like to search?");
            string searchedWord = Console.ReadLine();
            bool wordFound = true;
            string upperSearchWord = searchedWord.ToUpper();
            string upperAliceInWonderlandSentance = aliceInWonderlandSentance.ToUpper();
            if (upperAliceInWonderlandSentance.Contains(upperSearchWord))
                {
                wordFound = true;
                Console.WriteLine(wordFound);
                int indexOfSearchedWord = upperAliceInWonderlandSentance.IndexOf(upperSearchWord);
                Console.WriteLine(indexOfSearchedWord);
                int lengthOfSearchedWord = searchedWord.Length;
                Console.WriteLine(lengthOfSearchedWord);
                string newSentance = aliceInWonderlandSentance.Remove(indexOfSearchedWord, lengthOfSearchedWord);
                Console.WriteLine(newSentance);
                } else
                {
                wordFound = false;
                Console.WriteLine(wordFound);
                }
            
        }
    }
}
