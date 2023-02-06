import string

class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = s.lower()
        new_str = ""
        for c in s:
            if self.isAlphaNum(c):
                new_str += c
        return new_str ==  new_str[::-1]
    def isAlphaNum(self, c: str) -> bool:
        return (ord('A') <= ord(c) <= ord('Z') or
                ord('a') <= ord(c) <= ord('z') or
                ord('0') <= ord(c) <= ord('9'))
          
                    
