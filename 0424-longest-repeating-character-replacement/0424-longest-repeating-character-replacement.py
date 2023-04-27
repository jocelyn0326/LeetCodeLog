class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        # The check will be the current window size - max frequent <= k  
        l = 0
        freq_map={}
        res=0
        for r in range(len(s)):
            if s[r] in freq_map:
                freq_map[s[r]]+=1
            else:
                freq_map[s[r]]=1
            if (r-l+1) - max(freq_map.values()) <= k:
                res = max((r-l+1), res)
            else:
                freq_map[s[l]]-=1
                l+=1
        return res
    
    # l :0
    # r : 0
    # req_map: {}
    # res : 0                    
        