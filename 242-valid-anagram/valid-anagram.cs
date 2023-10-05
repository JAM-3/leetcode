public class Solution {
    public bool IsAnagram(string s, string t) {
        var ss = s.OrderBy(x => x);
        var tt = t.OrderBy(x => x);
        s = new string(ss.ToArray());
        t = new string(tt.ToArray());
        return (s == t);        
    }
}