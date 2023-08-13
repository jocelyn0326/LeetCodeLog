class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        # Since this is a sorted array, so we could take advantage from it
        # By sum up left and right pointer, we switch the left if sum < target, 
        # or switch the right pointer if else until we reach the target
        l, r = 0, len(numbers)-1
        while l < r:
            sum = numbers[l] + numbers[r]
            if sum == target:
                return [ l+1, r+1]
            elif sum < target:
                l += 1
            else:
                r -= 1
                