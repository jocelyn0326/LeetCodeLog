# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        res=[]
        q=collections.deque()
        q.append(root)
        while q:
            rightNode=None
            qlen=len(q)
            for i in range(qlen):
                node=q.popleft()

                if node:
                    # In this for loop, will iterate things in current level
                    rightNode=node
                    # Add left first and right
                    q.append(node.left)
                    q.append(node.right)
            if rightNode:
                res.append(rightNode.val)
        return res