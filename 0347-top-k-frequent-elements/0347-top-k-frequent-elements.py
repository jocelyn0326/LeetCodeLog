class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        num_freq = defaultdict(int)
        res = []
        for num in nums:
            num_freq[num] += 1
        freq_order = {k: v for k, v in sorted(num_freq.items(), key=lambda item: item[1], reverse=True)}

        keys_list=list(freq_order.keys())
        for i in range (0, k):
            res.append(keys_list[i])
        return res
        