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
    int sum = 0;
    public int SumOfLeftLeaves(TreeNode root, bool left=false) {
        if(root == null) return 0;
        if(left && root.left == null && root.right == null) sum+=root.val;
        if (root.left !=null) SumOfLeftLeaves(root.left, true);
        if (root.right !=null) SumOfLeftLeaves(root.right, false);
        return sum;
    }
}