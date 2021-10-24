public class Solution {
    public void DuplicateZeros(int[] arr) {
        int j =0;
        int[] ori = new int[arr.Length];
        arr.CopyTo(ori, 0);
        for(int i =0; j< arr.Length; i++){
            arr[j]=ori[i];
            if(ori[i] == 0 && j+1 < arr.Length){
                j++;
                arr[j]=0;
            }
            j++;
        }   
    }
}