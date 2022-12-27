class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = defaultdict(list)
        for word in strs:
            from collections import Counter
            counter = Counter(word)
                
            key_list = []
            for char in "abcdefghijklmnopqrstuvwxyz":
                key_list.append(char + str(counter[char]))
            key = "".join(key_list)
            
            res[key].append(word)
        return res.values()
        