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
  List<int> result = new List<int>();
	public IList<int> InorderTraversal(TreeNode root) {
		if(root == null) return new List<int>();
		if(root.left != null) InorderTraversal (root.left);
		if(root.val != null) result.Add(root.val);
		if(root.right !=null) InorderTraversal (root.right);
		return result;
    }
}