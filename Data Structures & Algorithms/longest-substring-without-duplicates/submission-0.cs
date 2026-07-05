public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int[] charMap = new int[128];
        int maxLength =0;
        int left =0;

        for(int right =0;right <s.Length;right++)
        {
            char currentChar = s[right];

            if(charMap[currentChar] > left)
            {
                left = charMap[currentChar];
            }

            charMap[currentChar] = right+1;

            maxLength = Math.Max(maxLength,right -left +1);


        }

        return maxLength;


    }
}
