class Solution:
    def search(self, nums: List[int], target: int) -> int:
        left = 0
        right = len(nums) - 1
        while left <= right:
            cur = int((right + left) / 2)
            if nums[cur] == target:
                return cur
            elif nums[cur] > target:
                right = cur - 1
            else:
                left = cur + 1
        return -1