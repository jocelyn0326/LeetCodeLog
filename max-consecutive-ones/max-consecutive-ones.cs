public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ans = 0;
        int temp = 0;
        for(int i = 0; i< nums.Length; i++){
            if(nums[i]== 1){
                temp+=1;
                if(temp > ans)ans=temp;
            } else{
                temp=0;
            } 
        }
        return ans;
    }
}