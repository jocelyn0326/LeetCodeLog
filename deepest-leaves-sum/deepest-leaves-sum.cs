/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
//
public class Solution {
    //BFS
    public int DeepestLeavesSum(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var result = 0;
        queue.Enqueue(root);
        while(queue.Count > 0){

            var count = queue.Count;
            result = 0;

            for (var i = 0; i < count; i++){
                var node = queue.Dequeue();

                result += node.val;
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }                       
        }
     return result;
    }
    
    
    //DFS
    //int deepest =0, sum=0;
    //public int DeepestLeavesSum(TreeNode root, int depth = 0){
    //    if(root == null) return 0; // current node is NULL - just return.
    //    if(root.left == null && root.left == null)
    //    if(depth == deepest){
    //        sum += root.val;// if current is a leaf node
            
    //    } 
    //    else if(depth> deepest)
    //    { 
     //       deepest = depth;
     //       sum = root.val; // if depth is exactly equal to deepest, add to sum
    //    }
     //   DeepestLeavesSum(root.left,depth+1);
     //   DeepestLeavesSum(root.right,depth+1);
     //   return sum;
    //}
}