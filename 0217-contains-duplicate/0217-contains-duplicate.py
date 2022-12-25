class Solution(object):
    def containsDuplicate(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """
        if len(nums) < 2:
            return False
        result = set()
        for num in nums:
            if num in result:
                return True
            result.add(num)
        return False