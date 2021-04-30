using ChessBoardLibrary;
using System;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string [] args)
        {
            // Display an empty chess board.
            printBoard(myBoard);

            // Ask user for an x and y coordinate where piece will be placed on board.
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            // Calculate all legal moves for piece at given coordinate.
            myBoard.MarkNextLegalMoves(currentCell, "Knight");

            // Print chess board. Use an X for occupied space. Use a + for legal move. Use . for empty cell
            printBoard(myBoard);

            // Wait for another key press before program closes.
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            // Get X and Y coordinate from user. Return cell location
            Console.WriteLine("Enter the current row number.");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current column number.");
            int currentColumn = int.Parse(Console.ReadLine());

            return myBoard.theGrid [currentRow - 1, currentColumn - 1];

        }

        private static void printBoard(Board myBoard)
        {
            // Print chess board. Use an X for occupied space. Use a + for legal move. Use . for empty cell.
            for (int i = 0; i < myBoard.Size; i++)
            {

                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid [i, j];

                    if (c.CurrentlyOccupied == true)
                        Console.Write("X");
                    else if (c.LegalNextMove == true)
                        Console.Write("+");
                    else
                        Console.Write(".");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("======================================");
        }
    }
}
