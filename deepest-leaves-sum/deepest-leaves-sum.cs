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
public class Solution {
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
}