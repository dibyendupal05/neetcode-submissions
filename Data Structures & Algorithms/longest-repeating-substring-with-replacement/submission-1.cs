public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charCounts = new int[26];

        int left =0;
        int maxCount=0;
        int maxLength =0;

        for(int right =0;right < s.Length;right++)
        {
            int currentClassIndex = s[right] - 'A';
            charCounts[currentClassIndex]++;

            maxCount = Math.Max(maxCount,charCounts[currentClassIndex]);

            int windowLength = right -left+1;

            if(windowLength -maxCount> k )
            {
                charCounts[s[left] - 'A'] --;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
