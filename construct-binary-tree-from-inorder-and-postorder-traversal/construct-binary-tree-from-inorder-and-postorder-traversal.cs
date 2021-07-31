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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        var post = new Stack<int>(postorder);
        var index = inorder.Select((val, index) => (val, index))
                           .ToDictionary(x => x.val, x => x.index);
        return Build(0, inorder.Length - 1);

        TreeNode Build(int left, int right) {
            if (left > right) return null;

            var val = post.Pop();
            var i = index[val];

            return new TreeNode(val) {
                right = Build(i + 1, right),//index of right subtree
                left = Build(left, i - 1)//index of left subtree
            };
        }
    }
}