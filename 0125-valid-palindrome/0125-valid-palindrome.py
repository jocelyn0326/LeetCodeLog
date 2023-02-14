import string

class Solution:
    # 1. Covert the string to lowercase
    # 2. Determine if the charater is alphanumeric
    # 3. Use two pointers to compare
    def isPalindrome(self, s: str) -> bool:
        s = s.lower()
        print(s)
        newS = ""
        for c in s:
            if self.isAlphanmeric(c):
                newS += c
        l, r = 0, len(newS)-1
        while l < r:
            if newS[l] != newS[r]:
                return False
            l += 1
            r -= 1
        return True
    def isAlphanmeric(self, c: str) -> bool:
        if ord('a') <= ord(c) <= ord('z') or ord('0') <=  ord(c) <= ord('9'):
                return True
    
