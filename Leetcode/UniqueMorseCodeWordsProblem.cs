using System.Text;

namespace Leetcode;

public class UniqueMorseCodeWordsProblem
{
    public int UniqueMorseRepresentations(string[] words)
    {
        string[] morse =
        [
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        ];
        HashSet<string> transformations = [];
        foreach (var word in words)
        {
            var builder = new StringBuilder();
            foreach (var c in word)
                builder.Append(morse[c - 'a']);
            transformations.Add(builder.ToString());
        }
        return transformations.Count;
    }
}