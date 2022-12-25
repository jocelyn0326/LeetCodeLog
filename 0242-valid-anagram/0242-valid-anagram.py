class Solution(object):
    def isAnagram(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: bool
        """
        # O(Max(len(t), len(s)))
        if (len(t) != len(s)):
            return False
        str_count_map = {}
        for character in s:
            if character in str_count_map:
                str_count_map[character] += 1
            else:
                str_count_map[character] = 1

        for character in t:
            if character in str_count_map:
                str_count_map[character] -= 1
            else:
                return False
        for key in str_count_map:
            if str_count_map[key] != 0:
                return False
        return True