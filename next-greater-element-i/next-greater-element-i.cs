public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var dic = new Dictionary<int,int>();
        var stack = new Stack<int>();
        for(int i = nums2.Length -1 ; i >= 0 ; i--){
            while(stack.Count >0 && nums2[i] > stack.Peek()){
                stack.Pop();
            }
            dic.Add(nums2[i],stack.Count >0 ? stack.Peek(): -1);
            stack.Push(nums2[i]);
        }
        var res = new int[nums1.Length];
        int j = 0;
        foreach(int num in nums1){
            res[j] = dic[num];
            j++;
        }
        return res;
    }
}