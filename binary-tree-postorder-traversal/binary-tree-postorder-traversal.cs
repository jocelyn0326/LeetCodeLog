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
    public IList<int> PostorderTraversal(TreeNode root) {
       return PostorderTraversalRecursive(root,new List<int>());
            
    }
    public IList<int> PostorderTraversalRecursive(TreeNode root, List<int> ans){
        if (root == null) return ans;
        PostorderTraversalRecursive(root.left, ans);
        PostorderTraversalRecursive(root.right, ans);
        ans.Add(root.val);
        return ans;
        
    }
}