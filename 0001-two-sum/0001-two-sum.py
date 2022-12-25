class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        parsed_dict={}
        for key, val in enumerate(nums):
            x = target - val
            if x in parsed_dict: return [key, parsed_dict[x]]
            parsed_dict[val] = key