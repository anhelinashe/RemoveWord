using System;
namespace removeword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello,user! Enter the text:");
            string inputText = Console.ReadLine();


            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());

            string[] words = inputText.Split(' ');


            if (x < words.Length)
            {
                for (int i = x; i < words.Length; i++)
                {
                    Console.Write(words[i] + " ");
                }
            }
        }
    }
}
