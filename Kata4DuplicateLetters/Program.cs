
using System.Text;
using System.Text.RegularExpressions;

namespace week2_sparta;
public class Program
{

    public static void Main(String[] args) { }
    public static char[] GetArrayDuplicateLetters(string word)
    {
        string result = "";
        string temp = "";
        word = Regex.Replace(word, "\\s", string.Empty);
        Console.WriteLine(word);

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (temp.Contains(c))
            {
                if (!result.Contains(c))
                {
                    result += c.ToString();
                    continue;
                }
            }
            temp += c.ToString();
        }
        return result.ToString().ToCharArray();
    }
}