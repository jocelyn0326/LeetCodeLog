class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        res = []
        nums.sort()
        l, r = 0, len(nums)
    
        for i, num in enumerate(nums):
            # Avoid we return duplicate triplets
            if i > 0 and num == nums[i-1]:
                continue
            # Two sum 2
            l , r = i +1, len(nums) -1
            while l < r:
                ts = num + nums[l] + nums[r]
                if ts > 0:
                    r -= 1
                elif ts < 0:
                    l += 1
                else:
                    res.append([num, nums[l], nums[r]])
                    # Keep finding nex combination
                    l += 1
                    # Avoid we l still ident to l-1
                    while  nums[l] ==  nums[l-1] and l < r:
                        l += 1
        return res