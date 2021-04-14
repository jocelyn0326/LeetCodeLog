public class Solution {
    public int BalancedStringSplit(string s) {
        int res = 0;
        int R=0;
        int L=0;
        foreach(var c in s){
            
            if(c=='R'){
                R++ ;
            }else{
                L++;
            }  
            if(R==L){
                res++;
                R=0;
                L=0;
            }
        }
        return res;
    }
}