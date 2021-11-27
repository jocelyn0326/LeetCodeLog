public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length ==0) return 0;
        int res = 0;;
        nums[res]=nums[0];
        res++;
        int j =0;
        for(int i = 1; i<nums.Length; i++){
            if(nums[i] != nums[j]){
                nums[res]=nums[i];
                res++;
                j=i;
            }
        }
        return res;
    }
}