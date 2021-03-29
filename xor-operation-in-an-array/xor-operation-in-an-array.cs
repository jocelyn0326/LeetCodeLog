public class Solution {
    public int XorOperation(int n, int start) {
        int res = start;
        for(int i =1; i<n; i++){
            res = res ^ start+ 2*i;
        }
        return res;
    }
}