public class Solution {
    public bool IsValidSudoku(char[][] board) {
         HashSet<string> seen = new HashSet<string>();

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char number = board[r][c];
                
                if (number != '.') {
                    // Calculate the unique box index (0 to 8)
                    int boxIndex = (r / 3) * 3 + (c / 3);

                    // Formulate unique identifier strings
                    string rowKey = $"{number} in row {r}";
                    string colKey = $"{number} in col {c}";
                    string boxKey = $"{number} in box {boxIndex}";

                    // HashSet.Add returns false if the element already exists in the set
                    if (!seen.Add(rowKey) || !seen.Add(colKey) || !seen.Add(boxKey)) {
                        return false; // Duplicate found!
                    }
                }
            }
        }

        return true;
    }
}
