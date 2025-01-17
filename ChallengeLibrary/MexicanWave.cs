namespace ChallengeLibrary;

// Rules: Input is always lowercase, whitespace is skipped.
public class MexicanWave
{
    public List<string> Wave(string str)
    {
        if (str == String.Empty)
        {
            return new List<string>();
        }
        
        List<string> waveList = new List<string>();

        for (int i = 0; i < str.Length; i++)
        {
            
            char[] characterArray = str.ToCharArray();
            if (char.IsWhiteSpace(characterArray[i]))
            {
                continue;
            }
            characterArray[i] = char.ToUpper(characterArray[i]);
            waveList.Add(new string(characterArray));
        }
        
        return waveList;
    }
}