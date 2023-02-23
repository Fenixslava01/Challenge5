using System;

namespace Challenge5 {
    class Program {
        static string[] SplitText()
        {
            string userText = Console.ReadLine();
            string[] iResult;
            iResult = userText.Split(" ");
            return iResult;
        }
        static string[] SplitText(string text)
        {
            string[] iResult;
            iResult = text.Split(" ");
            return iResult;
        }
        static void PrintWords(string[] result) {
            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }
        static void PrintReversePhrase(string [] words) {
            string resultReversePrase = "";
            for (int i = words.Length-1; i >= 0; i--) {
                resultReversePrase += words[i] + " ";
            }
            Console.WriteLine(resultReversePrase);
        }
        static void ReverseWords(string inputPhrase)
        {
            string[] phraseWords = SplitText(inputPhrase);
            PrintReversePhrase(phraseWords);
        }
        static void Main(string[] args) {
            #region первое задание
            Console.WriteLine("Первое задание, разделение строки на слова. Введите предложение: ");
            PrintWords(SplitText());
            Console.ReadKey();
            #endregion
            Console.Clear();
            #region второе задание
            Console.WriteLine("Второе задание, перестановка слов в предложении. Введите предложение: ");
            ReverseWords(Console.ReadLine());
            Console.ReadKey();
            #endregion
        }
    }
}