public class Solution {
    public bool CheckIfExist(int[] arr) {
        bool res = false;
        for(int i = 0; i<arr.Length; i++){
            for(int j = i+1 ; j<arr.Length; j++)
            if(arr[i]*2 == arr[j] || ((arr[i]/2) == arr[j] && arr[i]% 2 == 0) ){
                res= true;
                break;
            }
            if(res == true){
                break;
            }
        }
        return res;
    }
}