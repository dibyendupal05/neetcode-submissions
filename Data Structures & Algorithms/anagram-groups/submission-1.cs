public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length ==0 || strs == null)
        return new List<List<string>>();

        Dictionary<string,List<string>> groupedAnagrams = new Dictionary<string,List<string>>();

        foreach(string s in strs)
        {
            //count frequencies of english letters
            int[] counts = new int[26];
            foreach(char c in s)
            {
                counts[c -'a']++;
            }
            StringBuilder sb = new StringBuilder();

            for(int i=0;i<26;i++)
            {
                sb.Append(counts[i]);
                sb.Append(",");
            }
            string key = sb.ToString();

            if(!groupedAnagrams.ContainsKey(key))
            {
                groupedAnagrams[key] = new List<string>();
            }
            groupedAnagrams[key].Add(s);

        }
        return groupedAnagrams.Values.ToList();


    }
}
