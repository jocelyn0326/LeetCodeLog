class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        seen ={}
        res = 0
        l = 0
        for r in range(len(s)):
            if s[r] not in seen:
                res = max(res, r - l +1)
            else:
                if seen[s[r]] < l:
                    res = max(res, r - l +1)
                else:
                    l = seen[s[r]] +1
            seen[s[r]] = r
        return res
    
    # seen = {a:3, b:7, c:5}
    # res = 3
    # l = 7
    # r = 7
    
    
    # len(s) = 7