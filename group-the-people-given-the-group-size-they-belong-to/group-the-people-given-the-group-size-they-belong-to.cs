public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        IList<IList<int>> ans = new List<IList<int>>();
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        for(int i =0; i<groupSizes.Length; i++){ // i is the index of person
            
            int key = groupSizes[i]; //Number Of People
            
            if(!dict.ContainsKey(key)){
                dict.Add(key,new List<int>());
                dict[key].Add(i);
            }else{
                if(dict[key].Count == key){ // check if this group is full, add to ans and emty current value
                    ans.Add(dict[key]);
                    dict[key] = new List<int>(); 
                }
                dict[key].Add(i);
            }
            
        }
        foreach(var index in dict.Values){
            ans.Add(index);
        }
        return ans;
    }
}