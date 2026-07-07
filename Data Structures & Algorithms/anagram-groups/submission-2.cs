public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> groups = new List<List<string>>();
        
        if (strs == null || strs.Length == 0) return groups;

        foreach (string word in strs) {
            bool foundGroup = false;

            foreach (List<string> group in groups) {
                if (IsAnagram(word, group[0])) {
                    group.Add(word); // Capitalized PascalCase
                    foundGroup = true;
                    break; 
                }
            }

            if (!foundGroup) {
                groups.Add(new List<string> { word }); // Capitalized PascalCase
            }
        }

        return groups;
    }

    private bool IsAnagram(string s1, string s2) {
        if (s1.Length != s2.Length) return false;
        
        char[] c1 = s1.ToCharArray();
        char[] c2 = s2.ToCharArray();
        
        Array.Sort(c1);
        Array.Sort(c2);
        
        return new string(c1) == new string(c2);
    }
}