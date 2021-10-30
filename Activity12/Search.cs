using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity12
{
    class Search
    {
        public string SearchPhrase(string phrase)
        {
            // Declared variable.
            int count = 0;

            // Created HashSets for letters and punctuation marks.
            var letters = new HashSet<char> { 't', 'e' };
            var punctuation = new HashSet<char> { '.', '?', '!' };

            // Used delimiters to separate phrase and assigned words into array words.
            string[] words = phrase.Split(' ');
            
            // Created list for each word to be saved at.
            List<string> wordList = new List<string>();

            // Used foreach loop to remove any punctuation marks from words.
            foreach (string word in words)
            {
                // Checked whether any word in words array contained a punctuation mark.
                if (punctuation.Contains(word[word.Length - 1]))
                {
                    // If so, character at the end is removed and word is added to wordList list.
                    string wordMinus1 = word.Remove(word.Length - 1, 1);
                    wordList.Add(wordMinus1);
                }
                else
                {
                    // If word does not contain a punctuation mark, word is added to wordList list.
                    wordList.Add(word);
                }
            }

            // Used foreach loop to check whether any word ended with letters "t" or "e".
            foreach (string word in wordList)
            {
                if (letters.Contains(word[word.Length - 1]))
                {
                    // If so, count increments.
                    count++;
                }

            }
            // Count as a string is returned.
            return count.ToString();
        }
    }
}
