class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = {}
        for value in strs:
            char_dict: dict[str, int] = {}
            for char in value:
                if char in char_dict:
                    char_dict[char] += 1
                else:
                    char_dict[char] = 1
            key_list=[]
            for k,v in char_dict.items():
                key_list.append(k+ str(v))
                
            key_list.sort()
            key = "".join(key_list)
            if key not in res:
                res[key] = [value]
            else:
                res[key].append(value)
        return res.values()
        