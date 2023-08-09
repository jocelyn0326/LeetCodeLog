class Solution:
    def maxArea(self, height: List[int]) -> int:
        # l, r = 0, len(height) -1
        # res=0
        # # Brute force
        # for l in range(len(height)):
        #     for r in range(l+1, len(height)):
        #         res= max(res, (r-l) * min(height[r],height[l]))
        # return res
        l, r = 0, len(height) -1
        res=0
        # Brute force
        while l < r:
            amt =  (r-l) * min(height[r],height[l])
            res = max(res, amt)
            if height[l] < height[r]:
                l += 1
            else:
                r -= 1
        return res
