class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        target = {}
        for r in ransomNote:
            if r in target.keys():
                target[r] += 1
            else:
                target[r] = 1
        for m in magazine:
            if m in target.keys() and target[m] >0:
                target[m] -= 1
        for t in target.values():
            if t >0:
                return False
        return True