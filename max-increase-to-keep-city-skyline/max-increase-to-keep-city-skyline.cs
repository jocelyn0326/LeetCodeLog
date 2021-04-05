public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int[] rowMax = new int[grid.Length];
        int[] columnMax = new int[grid.Length];
        for(int i =0; i<grid[0].Length; i++){
            int row=0;
            int column=0;
            for(int j =0; j< grid.Length; j++)
            {
                row = Math.Max(row,grid[i][j]);
                column = Math.Max(column, grid[j][i]);
            }
            rowMax[i]=row;
            columnMax[i] = column;
        }
        int res=0;
        for(int i =0; i<grid[0].Length; i++){
            for(int j =0; j< grid.Length; j++){
                res += Math.Min(rowMax[i],columnMax[j]) - grid[i][j];
            }
        }
        return res;
    }
}