
var res = NumIslands(new char[][] {

 new char[] {'1', '1', '1', '1', '0' },
 new char[] {'1', '1', '0', '1', '0' },
 new char[] {'1', '1', '0', '0', '0' },
 new char[] {'0', '0', '0', '0', '0' }
 });
var qq = res;
int NumIslands(char[][] grid)
{
    var count = 0;
    for (int i = 0; i < grid.Length; i++)
    {
        for (int y = 0; y < grid[i].Length; y++)
        {
            if (grid[i][y] == '0')
                continue;

            if (i == 0)
            {
                if (y == 0)
                {
                    if (grid[i + 1][y] == '0' && grid[i][y + 1] == '0')
                        count++;
                    
                    continue;
                }
                if (grid[i + 1][y] == '0' && grid[i][y - 1] == '0' && grid[i][y + 1] == '0')
                    count++;

                continue;
            }
            else if (y == 0)
            {
                if (grid[i - 1][y] == '0' && grid[i + 1][y] == '0' && grid[i][y + 1])
            }
        }
    }
    return count;
}