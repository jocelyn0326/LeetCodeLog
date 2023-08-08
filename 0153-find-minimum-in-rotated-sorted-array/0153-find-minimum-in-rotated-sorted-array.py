class Solution:
    def findMin(self, nums: List[int]) -> int:
        # We're using binary search to acheive O(log n)
        # We need to first find out we're in left portion of the arry or the right portion of the array
        # Algorithm:
        # If in left: (nums[m] >= l) ->search right: l=m+1 and compare with nums[m]
        # else: -> search right: r = m-1 and comare with nums[m]
        res=nums[0]
        l, r = 0, len(nums)-1
        
        while l <= r:
            # If the array is sorted
            if nums[l] < nums[r]:
                res = min(res, nums[l])
                break
            # Do the binary search here
            m = (l+r) // 2
            res = min(res, nums[m])
            if nums[m] >= nums[l]:
                l = m+1
            else:
                r = m-1
        return res
            