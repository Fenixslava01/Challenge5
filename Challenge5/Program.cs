using System;

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            static string[] SplitText() {
                string userText = Console.ReadLine();
                string[] iResult;
                iResult = userText.Split(" ");
                return iResult;
            }
            static void PrintWords (string [] result) {
                foreach (string word in result)
                {
                    Console.WriteLine(word);
                }
            }
            PrintWords(SplitText());
        }
    }
}
