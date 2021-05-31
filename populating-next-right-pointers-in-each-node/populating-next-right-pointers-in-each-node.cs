/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Connet(root,null);
        return root;
    }
    private void Connet(Node cNode, Node cRight){
        if(cNode == null)
            return;
        cNode.next = cRight;
        Connet(cNode.left,cNode.right);
        if(cRight !=null){
            Connet(cRight.left, cRight.right);
            Connet(cNode.right, cRight.left);
        }
    }
    
}