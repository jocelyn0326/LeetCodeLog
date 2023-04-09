class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        pattern_map = {"]": "[", ")": "(", "}": "{"}
        for c in s:
            if c in pattern_map:
                if stack and stack[-1] == pattern_map[c]:
                    stack.pop()
                else:
                    return False
            else:
                stack.append(c)
        return True if not stack else False