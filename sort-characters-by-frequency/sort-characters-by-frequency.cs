public class Solution {
    public string FrequencySort(string s) {
         return new string(s.GroupBy(c => c)
                    .OrderByDescending(chars => chars.Count())
                    .SelectMany(chars => chars)
                    .ToArray());
        
        
    }
}