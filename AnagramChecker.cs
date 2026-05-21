using System;

namespace Rovy_Assignement_7._2
{
    internal class AnagramChecker
    {
        // Given two strings, return true if they are anagrams
        // Anagram: same letters, same frequency, different order
        public static bool IsAnagram(string s, string t)
        {
            // If either is null → cannot be anagrams
            if (s == null || t == null)
                return false;

            // If lengths differ → cannot be anagrams
            if (s.Length != t.Length)
                return false;

            int[] count = new int[26]; // Array to count letters a-z

            // Count letters in s
            foreach (var ch in s)
            {
                int idx = char.ToLowerInvariant(ch) - 'a';
                if (idx < 0 || idx >= 26)
                    return false; // contains non a-z character - treat as not an anagram
                count[idx]++;
            }

            // Subtract letters in t
            foreach (var ch in t)
            {
                int idx = char.ToLowerInvariant(ch) - 'a';
                if (idx < 0 || idx >= 26)
                    return false;
                count[idx]--;
            }

            // If all counts return to zero → anagram
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                    return false;
            }

            return true;
        }
    }
}