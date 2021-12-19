public class Solution {
    public void MoveZeroes(int[] nums) {
        int count =0;
        for(int i = 0; i<nums.Length; i++){
            if(nums[i] ==0){
                count++;
            }else{
                nums[i-count] = nums[i];
            }
        }
        for (int j = (nums.Length -count); j< nums.Length; j++){
            nums[j]=0;
        }
    }
}