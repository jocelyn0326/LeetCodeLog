public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        int start = 0;
        int end = nums.Length-1;
        int resIndex = nums.Length-1;
        while(start<=end){
            if(Math.Abs(nums[start]) > Math.Abs(nums[end])){
                result[resIndex--]=nums[start]*nums[start];
                start++;
            }else{
                result[resIndex--]=nums[end]*nums[end];
                end--;
            }
        }
        return result;
        
    }
}