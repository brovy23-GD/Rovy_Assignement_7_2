using System;

namespace Rovy_Assignement_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------
            // 1. MERGE SORT
            // ---------------------------------------------------------
            Console.WriteLine("Enter numbers separated by spaces:");
            var input = Console.ReadLine();

            // Convert "5 2 9 1" → int[] {5, 2, 9, 1}
            var numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            // Call MergeSort class to sort the array
            MergeSort.Sort(numbers);

            Console.WriteLine("\nSorted Numbers (Merge Sort):");
            Console.WriteLine(string.Join(", ", numbers));

            // ---------------------------------------------------------
            // 2. REVERSE VOWELS
            // ---------------------------------------------------------
            Console.WriteLine("\nEnter a string to reverse vowels:");
            var s = Console.ReadLine();

            var reversed = ReverseVowels.Process(s);
            Console.WriteLine($"Reversed Vowels: {reversed}");

            // ---------------------------------------------------------
            // 3. ANAGRAM CHECK
            // ---------------------------------------------------------
            Console.WriteLine("\nEnter first string for anagram check:");
            var s1 = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            var s2 = Console.ReadLine();

            bool result = AnagramChecker.IsAnagram(s1, s2);
            Console.WriteLine($"Are Anagrams? {result}");
        }
    }
}
