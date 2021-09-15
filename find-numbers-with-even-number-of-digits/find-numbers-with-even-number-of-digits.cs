public class Solution {
    public int FindNumbers(int[] nums) {
        //Cause the max num is 10^5= 100000, list every case which is 10~99, 1000~9999, 100000
        int ans = 0;
        foreach(int i in nums){
            if( (9 < i && i < 100) || (999 < i && i <10000) || (i == 100000) ){
                ans++;
            }
        }
        return ans;
    }
}