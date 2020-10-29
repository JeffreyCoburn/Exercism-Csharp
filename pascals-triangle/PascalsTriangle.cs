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
            rowValues[0] = 1;
            rowValues[row] = 1;        
            for (int column = 1; column < row; column++) {
                int left = pascalsTriangle[row-1][column-1];
                int right = pascalsTriangle[row-1][column];
                rowValues[column] = left + right;
            }
            pascalsTriangle.Add(rowValues);
        }
        return pascalsTriangle;
    }

}