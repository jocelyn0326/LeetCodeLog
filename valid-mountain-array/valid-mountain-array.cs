public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if (arr.Length < 3){
            return false;
        }
        bool reverse_flag = false;
        for(int i = 0; i < arr.Length-1 ; i++){
            if(!reverse_flag  && arr[i] < arr[i+1]){
                continue;
            }else if(reverse_flag && arr[i] > arr[i+1]){
                continue;
            }
            else if(arr[i] == arr[i+1]){
                return false;
            }else if(!reverse_flag && arr[i] > arr[i+1]&& i !=0){
                reverse_flag = true;
            }else{
                return false;
            }
        }
        if(reverse_flag){
            return true;
        }
        return false;
    }
}