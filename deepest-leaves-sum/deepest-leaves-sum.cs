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
        var cur = new Queue<TreeNode>();
        int deepestLeavesSum = 0;
        cur.Enqueue(root);
        while(cur.Count() > 0){
            deepestLeavesSum =0;
            var count = cur.Count();
            for (int i =0; i<count; i++){
                var node = cur.Dequeue();
                deepestLeavesSum+=node.val;
                if (node.left != null) cur.Enqueue(node.left);
                if (node.right != null) cur.Enqueue(node.right);
            }
                       
        }
        return deepestLeavesSum;
    }
}