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
    public IList<int> PreorderTraversal(TreeNode root) {
        return PreorderTraversalRecursive(root,new List<int>());
    }
    public IList<int> PreorderTraversalRecursive(TreeNode root, List<int> ans){
        if(root == null) return ans;
        ans.Add(root.val);
        PreorderTraversalRecursive(root.left,ans);
        PreorderTraversalRecursive(root.right,ans);
        return ans;
    }
}