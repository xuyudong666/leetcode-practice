namespace leetcode;

public class NeighborSum
{
    private readonly int[][] _grid;
    private readonly Dictionary<int, (int row, int col)> indexDict = [];
    public NeighborSum(int[][] grid)
    {
        _grid = grid;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                indexDict[grid[i][j]] = (i, j);
            }
        }
    }

    public int AdjacentSum(int value)
    {
        int result = 0;

        var (row, col) = indexDict[value];

        if (row > 0)
        {
            result += _grid[row - 1][col];
        }

        if (row < _grid.Length - 1)
        {
            result += _grid[row + 1][col];
        }

        if (col > 0)
        {
            result += _grid[row][col - 1];
        }

        if (col < _grid.Length - 1)
        {
            result += _grid[row][col + 1];
        }

        return result;
    }

    public int DiagonalSum(int value)
    {
        int result = 0;

        var (row, col) = indexDict[value];

        if (row > 0 && col > 0)
        {
            result += _grid[row - 1][col - 1];
        }

        if (row < _grid.Length - 1 && col > 0)
        {
            result += _grid[row + 1][col - 1];
        }

        if (row > 0 && col < _grid.Length - 1)
        {
            result += _grid[row - 1][col + 1];
        }

        if (row < _grid.Length - 1 && col < _grid.Length - 1)
        {
            result += _grid[row + 1][col + 1];
        }

        return result;
    }
}
