using System;
using Tasks.Services;
namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sudokuBoard = SudokuService.FillSudoku();
            
            Console.WriteLine(SudokuService.isValidSudoku(sudokuBoard));
        }
    }
}