public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        string result = "";
        bool anotherLetter = true;
        int letterCount = 0;

        while (anotherLetter) 
        {
            anotherLetter = false;
            char actualLetter = '\0';
            

            for (int i = 0; i < strs.Length; i++) 
            {
                if (letterCount == strs[i].Length) 
                {
                    return result;
                }

                if (i == 0) 
                {
                    string actualWord = strs[i];
                    actualLetter = actualWord[letterCount];
                } 
                else 
                {
                    string actualWord = strs[i];
                    if (actualWord[letterCount] != actualLetter) 
                    {
                        return result;
                    }
                }
            }

            result += actualLetter;
            letterCount++;
            anotherLetter = true;
        }

        return result;
    }
}