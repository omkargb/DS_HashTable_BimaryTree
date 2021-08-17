using System;

namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to hash table implementation program...\n");
            Console.WriteLine(" --> Finding frequency of words ");

            string inputText = "to be or not to be";
            string[] inputWords = inputText.Split(" ");
            Console.WriteLine(" Input Sentence : "+inputText);
            int count = 0;

            MyMapNode<string, string> node = new MyMapNode<string, string>(6);

            foreach (var text in inputWords)
            {
                node.Add(count.ToString(), text);
                count++;
            }

            int numOfTo = node.GetFrequencyOfWords("to");
            Console.WriteLine(" Frequency of to  : " +numOfTo);
            int numOfbe = node.GetFrequencyOfWords("be");
            Console.WriteLine(" Frequency of be  : " +numOfbe);
            int numOfor = node.GetFrequencyOfWords("or");
            Console.WriteLine(" Frequency of or  : " +numOfor);
            int numOfnot = node.GetFrequencyOfWords("not");
            Console.WriteLine(" Frequency of not  : " +numOfnot);

        }
    }
}
