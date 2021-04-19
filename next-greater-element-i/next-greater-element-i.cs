public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var next_greatest = new Dictionary<int,int>();
        var stack = new Stack<int>();
        foreach(int num in nums2){
            while(stack.Count() !=0 && num > stack.Peek()){
                next_greatest.Add(stack.Pop(), num);
            }
            stack.Push(num);
        }
        
        for(int i =0; i<nums1.Length; i++){
            int value = 0;
            nums1[i]=next_greatest.TryGetValue(nums1[i], out value)? value: -1;
        }
        return nums1;
    }
}