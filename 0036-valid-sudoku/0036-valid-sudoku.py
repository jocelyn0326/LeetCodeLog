class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for x in range(0,9):
            row_dict = defaultdict(int)
            col_dict = defaultdict(int)
            for y in range(0,9):
                row_val = board[x][y]
                col_val =  board[y][x]
                
                if row_val != '.' and  row_dict[row_val] > 0:
                    return False
                else:
                    row_dict[row_val] += 1

                if col_val != '.' and col_dict[col_val] > 0:
                     return False
                else:
                    col_dict[col_val] += 1

            for x in (0, 3, 6):
                for y in (0, 3, 6):
                    block_dict = defaultdict(int)
                    for dx in range(3):
                        for dy in range(3):
                            val = board[x+dx][y+dy]

                            if val != '.' and  block_dict[val] > 0:
                                return False
                            else:
                                block_dict[val] +=1
        
        return True