public class Solution {
    public int[] MinOperations(string boxes) {
        int countOf1 = 0;
        int len = boxes.Length;
        int[] ans = new int[len];
        for(int i = 0; i<len ; i++){
            //find left side
            for(int j = i-1 ; j>=0; j--){
                if (boxes[j] == '1') ans[i]+=i-j;
            }
            //find right side
            for(int j = i+1; j<len; j++){
                if (boxes[j]=='1') ans[i]+=j-i;
            }
        }
        return ans;
    }
}