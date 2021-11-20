public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] ori = new int[m+n];
        n--;//use as nums2 index
        m--;//use as nums1 index
        for(int i= nums1.Length-1 ; i >=0  ; i--){
            if(m < 0){
                nums1[i]= nums2[n];
                n--;
                continue;
            }
            if(n < 0){
                break;
            }
            if(nums2[n] >= nums1[m])
            {
                nums1[i]= nums2[n];
                n--;
            }else{
                nums1[i]= nums1[m];
                m--;
            }
        }
    }
}