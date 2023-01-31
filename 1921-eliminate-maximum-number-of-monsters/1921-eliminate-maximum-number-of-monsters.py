class Solution:
    def eliminateMaximum(self, dist: List[int], speed: List[int]) -> int:
        killed_count = 0
        time = sorted(d / s for d, s in zip(dist, speed))
        for t in time:
            if t <= killed_count:
                return killed_count
            killed_count += 1
        return killed_count