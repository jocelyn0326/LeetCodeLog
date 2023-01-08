class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for row in board:
            if not self.is_valid(row):
                return False
        
        for col in zip(*board):
            if not self.is_valid(col):
                return False
        
        for r in (0, 3, 6):
            for c in (0, 3, 6):
                square = []
                for dr in range(3):
                    for dc in range(3):
                        square.append(board[r+dr][c+dc])
                if not self.is_valid(square):
                    return False
        return True
        
    def is_valid(self, nums: list[str]):
        seen = set()
        for n in nums:
            if n in seen and n != ".":
                return False
            seen.add(n)
        return True
        
#         for x in range(0,9):
#             row_dict = defaultdict(int)
#             col_dict = defaultdict(int)
#             for y in range(0,9):
#                 row_val = board[x][y]
#                 col_val =  board[y][x]
                
#                 if row_val != '.' and  row_dict[row_val] > 0:
#                     return False
#                 else:
#                     row_dict[row_val] += 1

#                 if col_val != '.' and col_dict[col_val] > 0:
#                      return False
#                 else:
#                     col_dict[col_val] += 1

#             for x in (0, 3, 6):
#                 for y in (0, 3, 6):
#                     block_dict = defaultdict(int)
#                     for dx in range(3):
#                         for dy in range(3):
#                             val = board[x+dx][y+dy]

#                             if val != '.' and  block_dict[val] > 0:
#                                 return False
#                             else:
#                                 block_dict[val] +=1
        
#         return True