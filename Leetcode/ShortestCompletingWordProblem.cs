using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ShortestCompletingWordProblem
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            static int[] CountLetters(string word){
                var counts = new int[26];
                foreach(var c in word){
                    if (char.IsLetter(c)){
                        counts[char.ToLower(c) - 'a']++;
                    }
                }
                return counts;
            } 
            var charPool = CountLetters(licensePlate);
            string? matchWord = null;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (matchWord != null && words[i].Length > matchWord.Length) continue;
                var pool = CountLetters(words[i]);
                bool isMatch = true;
                for(int j = 0; j < charPool.Length; j++)
                {
                    if (charPool[j] == 0) continue;
                    if (charPool[j] > pool[j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (!isMatch) continue;
                matchWord = words[i];
            }
            return matchWord!;
        }
    }
}