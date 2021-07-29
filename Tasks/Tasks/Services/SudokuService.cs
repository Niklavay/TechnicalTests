using System;

namespace Tasks.Services
{
    public class SudokuService
    {
        private static bool IsInRange(int[,] sudokuBoard)
        {
            
            if (Math.Abs(sudokuBoard.Length) % 1 != 0)
            {
                return false;
            }

            int length = Convert.ToInt32(Math.Sqrt(sudokuBoard.Length));

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (sudokuBoard[i,j] <= 0 ||
                        sudokuBoard[i,j] > 9)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool isValidSudoku(int[,] sudokuBoard)
        {
            if (IsInRange(sudokuBoard) == false)
            {
                return false;
            }

            int length = Convert.ToInt32(Math.Sqrt(sudokuBoard.Length));

            bool[] unique = new bool[length + 1];

            for (int i = 0; i < length; i++)
            {
                Array.Fill(unique, false);

                for (int j = 0; j < length; j++)
                {
                    int Z = sudokuBoard[i, j];

                    if (unique[Z])
                    {
                        return false;
                    }

                    unique[Z] = true;
                }
            }

            for (int i = 0; i < length; i++)
            {
                Array.Fill(unique, false);

                for (int j = 0; j < length; j++)
                {
                    int Z = sudokuBoard[j, i];

                    if (unique[Z])
                    {
                        return false;
                    }

                    unique[Z] = true;
                }
            }

            for (int i = 0; i < length - 2; i += 3)
            {
                for (int j = 0; j < length - 2; j += 3)
                {
                    Array.Fill(unique, false);

                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            int X = i + k;

                            int Y = j + l;

                            int Z = sudokuBoard[X, Y];

                            if (unique[Z])
                            {
                                return false;
                            }

                            unique[Z] = true;
                        }
                    }
                }
            }
            return true;
        }


        public static int[,] FillSudoku()
        {
            int[,] sudokuBoard =
            {
                {7, 8, 4, 1, 5, 9, 3, 2, 6},
                {5, 3, 9, 6, 7, 2, 8, 4, 1},
                {6, 1, 2, 4, 3, 8, 7, 5, 9},
                {9, 2, 8, 7, 1, 5, 4, 6, 3},
                {3, 5, 7, 8, 4, 6, 1, 9, 2},
                {4, 6, 1, 9, 2, 3, 5, 8, 7},
                {8, 7, 6, 3, 9, 4, 2, 1, 5},
                {2, 4, 3, 5, 6, 1, 9, 7, 8},
                {1, 9, 5, 2, 8, 7, 6, 3, 4}
            };

            return sudokuBoard;
        }
    }
}