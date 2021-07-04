public class Solution {
    public string FrequencySort(string s) {
         return string.Join("",s.GroupBy(ch=>ch).OrderByDescending(gr=>gr.Count()).SelectMany(gr=>gr));
        
    }
}