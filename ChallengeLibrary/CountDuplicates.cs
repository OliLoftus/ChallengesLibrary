namespace ChallengeLibrary;

public class CountDuplicates
{
    public int Count(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input cannot be null or empty.");
        }

        var duplicatedChars = 0;
        
        string sanitisedInput = input.ToLower();

        var characterDictionary = new Dictionary<char, int>();
        
        foreach (char character in sanitisedInput)
        {
            if (!characterDictionary.TryAdd(character, 1))
            {
                characterDictionary[character]++;
            }
        }
        
        foreach (var keyValuePair in characterDictionary)
        {
            if (keyValuePair.Value > 1)
            {
                duplicatedChars++;
            }
        }
        
        return duplicatedChars;
    }
    
    
}