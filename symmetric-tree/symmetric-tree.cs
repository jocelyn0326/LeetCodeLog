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
 public bool IsSymmetric(TreeNode root) {
        return isMirror(root, root);
    }
    public bool isMirror(TreeNode left, TreeNode right){
        if(left == null && right == null){
            return true;
        }else if (left == null || right == null){
            return false;
        }else{
            return (left.val == right.val)
                && isMirror(left.left,right.right)
                && isMirror(left.right,right.left);

        }
                    
    }
}
