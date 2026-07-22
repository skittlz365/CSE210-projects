using System.Security.Cryptography;
using System.Text;
public class Word
{
    // This class has no attributes, only the method to hide random words from the scripture
    public static string npHideRandomWords(string text, int numberOfWordsToHide)
    {
        var random = new Random();
        var words = text.Split(' ');
        for (int i = 0; i < numberOfWordsToHide && i < words.Length; i++)
        {
            int index = random.Next(words.Length);
            string word = words[index];
            if (!string.IsNullOrWhiteSpace(word))
            {
                // Replace the word with underscores
                words[index] = new string('_', word.Length);
            }
        }
        return string.Join(" ", words);
    }
}