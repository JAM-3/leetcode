public class Solution {
    public bool IsValidSudoku(char[][] board) {

        bool validRows = validateRows(board);
        bool validColumns = validateColumns(board);
        bool validBoxes = validateBoxes(board);
        return validRows && validColumns && validBoxes;

    }

    bool validateRows(char[][] board) {
        foreach(char[] row in board) {
            if (checkIfRepeats(row)) return false;
        }
        return true;
    }

    bool validateColumns(char[][] board) {
        //char[] set = new char[9];
        for(int i = 0; i < 9; i++) {
            char[] tempSet = new char[9];
            for(int j = 0; j < 9; j++) {
                tempSet[j] += board[j][i];
            }
            if (checkIfRepeats(tempSet)) {return false;}
        }
        return true;
    }

    bool validateBoxes(char[][] board) {
        var boxes = new Dictionary<string, List<char>>();       
        boxes.Add("A", new List<char>());
        boxes.Add("B", new List<char>());
        boxes.Add("C", new List<char>());
        boxes.Add("D", new List<char>());
        boxes.Add("E", new List<char>());
        boxes.Add("F", new List<char>());
        boxes.Add("G", new List<char>());
        boxes.Add("H", new List<char>());
        boxes.Add("I", new List<char>());

        for(int i = 0; i < 9; i++) {
            char[] tempSet = new char[9];
            for(int j = 0; j < 9; j++) {
                if (j < 3) {
                if (i < 3) {
                    boxes["A"].Add(board[j][i]);
                }
                else if (i < 6) {
                    boxes["B"].Add(board[j][i]);
                }
                else if (i < 9) {
                    boxes["C"].Add(board[j][i]);
                }
                }
                else if (j < 6) {
                if (i < 3) {
                    boxes["D"].Add(board[j][i]);
                }
                else if (i < 6) {
                    boxes["E"].Add(board[j][i]);
                }
                else if (i < 9) {
                    boxes["F"].Add(board[j][i]);
                }
                }
                else if (j < 9) {
                if (i < 3) {
                    boxes["G"].Add(board[j][i]);
                }
                else if (i < 6) {
                    boxes["H"].Add(board[j][i]);
                }
                else if (i < 9) {
                    boxes["I"].Add(board[j][i]);
                }
                }

            }
        }
        foreach(var val in boxes.Values) {
            char[] charsVal = val.ToArray();
            if (checkIfRepeats(charsVal)) return false;
        }
        return true;
    }

    bool checkIfRepeats(char[] set) {
        List<char> duplicates = new List<char>();
        foreach (char cha in set) {
            if (cha != '.') {
                if (duplicates.Contains(cha)) {
                    return true;
                }
                duplicates.Add(cha);
            }
        }
        return false;
    }

}