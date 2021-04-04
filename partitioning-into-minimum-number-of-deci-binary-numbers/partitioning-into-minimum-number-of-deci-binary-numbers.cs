public class Solution {
    public int MinPartitions(string n) {
        int highest = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if(n[i]-'0' == 9){
                return n[i]-'0';
            }
            highest = Math.Max(highest,n[i]-'0');
        }
        return highest;
    }
}