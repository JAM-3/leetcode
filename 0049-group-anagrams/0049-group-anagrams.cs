public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var storedAnagrams = new Dictionary<string, List<string>>();
        foreach(string str in strs) {
            string key = new string(str.OrderBy(c => c).ToArray());
            if (storedAnagrams.ContainsKey(key)) {
                storedAnagrams[key].Add(str);
            }
            else {
                storedAnagrams[key] = new List<string>{str};
            }
        }
        var groupedAnagrams = new List<IList<string>>();
        foreach(var val in storedAnagrams.Values) {
            groupedAnagrams.Add(val);
        }
        return groupedAnagrams;
    }
}