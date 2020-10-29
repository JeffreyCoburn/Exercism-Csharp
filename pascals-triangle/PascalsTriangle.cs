using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<int[]> pascalsTriangle = new List<int[]>(); // { {1} };
        if (rows > 0) { pascalsTriangle.Add(new int[] {1}); }
        for (int row = 1; row < rows; row++) {
            int[] rowValues = new int[row+1];            
            for (int column = 0; column <= row; column++) {
                int left = column > 0 ? pascalsTriangle[row-1][column-1] : 0;
                int right = column < row ? pascalsTriangle[row-1][column] : 0;
                rowValues[column] = left + right;
            }
            pascalsTriangle.Add(rowValues);
        }
        return pascalsTriangle;
    }

}