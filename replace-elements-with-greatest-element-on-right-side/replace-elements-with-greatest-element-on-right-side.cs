public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int[] res = new int[arr.Length];
        if (res.Length == 1){
            res[0] = -1;
            return res;
        }
        int max = 0;
        for(int i = res.Length-1 ; i>=0 ; i--){
            if ((i+1) == res.Length){
                max = arr[i];
                res[i] =-1;
                continue;
            }else{
                res[i]= max;
                if(arr[i] > max )
                {
                    max = arr[i];
                }
            }
        }
        return res;
    }
}