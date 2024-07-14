using System;
using System.Collections.Generic;

    /// <summary>
    /// Determine if 'word1' and 'word2' are anagrams.  An anagram
    /// is when the same letters in a word are re-organized into a 
    /// new word.  A dictionary is used to solve the problem.
    /// 
    /// Examples:
    /// is_anagram("CAT","ACT") would return true
    /// is_anagram("DOG","GOOD") would return false because GOOD has 2 O's
    /// 
    /// Important Note: When determining if two words are anagrams, you
    /// should ignore any spaces.  You should also ignore cases.  For 
    /// example, 'Ab' and 'Ba' should be considered anagrams
    /// 
    /// Reminder: You can access a letter by index in a string by 
    /// using the [] notation.
    /// </summary>
    /// #############
    /// # Problem 3 #
    /// #############
 
public static class AnagramTester 
{
    public static bool IsAnagram(string word1, string word2)
    {
        // Remove spaces and convert to lowercase
        word1 = word1.Replace(" ", "").ToLower();
        word2 = word2.Replace(" ", "").ToLower();

        // If the lengths are different, they can't be anagrams
        if (word1.Length != word2.Length)
            return false;

        // Create a dictionary to store character counts
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count characters in word1
        for (int i = 0; i < word1.Length; i++)
        {
            char c = word1[i];
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        // Check characters in word2
        for (int i = 0; i < word2.Length; i++)
        {
            char c = word2[i];
            if (!charCount.ContainsKey(c))
                return false;
            
            charCount[c]--;
            if (charCount[c] == 0)
                charCount.Remove(c);
        }

        // If the dictionary is empty, all characters matched
        return charCount.Count == 0;
    }

}
