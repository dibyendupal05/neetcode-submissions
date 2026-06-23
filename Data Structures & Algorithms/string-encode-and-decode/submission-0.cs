public class Solution {

    public string Encode(IList<string> strs) {
        if(strs ==null || strs.Count ==0 )
            return "";

        StringBuilder sb = new StringBuilder();
        foreach(string s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }
    //5#Hello5#World


    public List<string> Decode(string s) {
        var result = new List<string>();
        int i=0;

        while(i < s.Length)
        {
            int j=i;
            while(s[j] != '#')
            {
                j++; 
            }
            int length = int.Parse(s.Substring(i,j-i)); //0,0 and 

            i=j+1;

            string word = s.Substring(i,length);
            result.Add(word);

            i+= length;
        }

        return result;

   }
}
