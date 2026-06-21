public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //null check
        if(strs == null || strs.Length == 0)
        {
            return new List<List<string>>();
        }
        //Dictionary
        Dictionary<string,List<string>> groupedAnagrams = new Dictionary<string,List<string>>();

        foreach(string s in strs)
        {
            //ToCharArray for sorting
           char[] charArray = s.ToCharArray();
           Array.Sort(charArray);

           string sortedString = new string(charArray);

           if(!groupedAnagrams.ContainsKey(sortedString))
           {
                groupedAnagrams.Add(sortedString,new List<string>(){s});
           }
           else
           groupedAnagrams[sortedString].Add(s);
            
        }

        return groupedAnagrams.Values.ToList();

    }
}
