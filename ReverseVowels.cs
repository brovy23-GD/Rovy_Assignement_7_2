using System;
using System.Collections.Generic;
using System.Text;

namespace Rovy_Assignement_7._2
{
    internal class ReverseVowels
    {
        // Given a string, reverse only the vowels
        // Vowels: a, e, i, o, u (both upper and lower case)
        public static string Process(string s)
        {
            var vowels = "aeiouAEIOU";      // All vowels
            var chars = s.ToCharArray();    // Convert string to char array

            var left = 0;                   // Left pointer
            var right = s.Length - 1;       // Right pointer

            // Move two pointers toward each other
            while (left < right)
            {
                // Move left pointer until it finds a vowel
                while (left < right && !vowels.Contains(chars[left]))
                    left++;

                // Move right pointer until it finds a vowel
                while (left < right && !vowels.Contains(chars[right]))
                    right--;

                // Swap vowels
                var temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;   // Move left pointer inward
                right--;  // Move right pointer inward
            }

            return new string(chars);       // Return the modified string
        }
    }
}