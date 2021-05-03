using ChessBoardLibrary;
using System;
using System.Linq;

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
            // Valid user inputs.
            string [] acceptedArray = { "1", "2", "3", "4", "5", "6", "7", "8" };

            // Row input.
            Console.WriteLine("Enter a number (1-8) for the current row number.");
            string currentRow = Console.ReadLine();

            // If user input for row is not valid.
            if(!acceptedArray.Contains(currentRow))
            {
                Console.WriteLine("Invalid entry please try again.");
                setCurrentCell();
            }

            // Column input.
            Console.WriteLine("Enter a number (1-8) for the current column number.");
            string currentColumn = Console.ReadLine();

            // If user input for column is not valid.
            if (!acceptedArray.Contains(currentColumn))
            {
                Console.WriteLine("Invalid entry please try again.");
                setCurrentCell();
            }

            return myBoard.theGrid [int.Parse(currentRow) - 1, int.Parse(currentColumn) - 1];

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
