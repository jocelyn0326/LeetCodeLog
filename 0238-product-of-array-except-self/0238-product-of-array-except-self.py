class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prod = 1
        zero_count = 0
        zero_index = None
        res = []

        for i, num in enumerate(nums):
            if num == 0:
                zero_count += 1
                zero_index = i
                if zero_count > 1:
                    return [0]*len(nums)
            else:
                prod *= num
        if zero_index is not None:
            for  i, num in enumerate(nums):
                if i == zero_index:
                    res.append(prod)
                else:
                    res.append(0)
        else:
            for num in nums:
                res.append(int(prod/num))
        return res