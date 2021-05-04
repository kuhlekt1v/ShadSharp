using System;
using System.Linq;
using ChessBoardLibrary;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string [] args)
        {
            // Display an empty chess board.
            printBoard(myBoard);

            // Ask user to select the type of piece they would like to move.
            Console.WriteLine("Which piece would you like to move?\n(K)-King, (Q)-Queen, (R)-Rook, (B)-Bishop, (H)-Knight");
            string pieceToMove = Console.ReadLine().ToLower();
            selectChessPiece(pieceToMove);

            // Ask user for an x and y coordinate where piece will be placed on board.
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            // Calculate all legal moves for piece at given coordinate.
            myBoard.MarkNextLegalMoves(currentCell, pieceToMove);

            // Print chess board. Use an X for occupied space. Use a + for legal move. Use . for empty cell
            printBoard(myBoard);

            // Ask user to play again or exit application.
            Console.WriteLine("\n\nCheck more moves? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
                restartGame("=================================\n");   
            else
                Environment.Exit(0);
        }

        // Clear console and start again.
        private static void restartGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            myBoard.ClearAllPreviousmoves();
            Main(null);
        }

        private static void selectChessPiece(string userInput)
        {
            // Valid user inputs.
            string [] chessPieceArray = { "k", "q", "r", "b", "h"};

            // If user input for piece is not valid.
            if(!chessPieceArray.Contains(userInput))
                restartGame("Invalid entry please try again.\n\n");
        }

        private static Cell setCurrentCell()
        {
            // Valid user inputs.
            string [] acceptedArray = { "1", "2", "3", "4", "5", "6", "7", "8" };

            // Row input.
            Console.WriteLine("Enter a number (1-8) for the current row number.");
            string currentRow = Console.ReadLine();

            // Restart game if row is invalid.
            if (!acceptedArray.Contains(currentRow))
                restartGame("Invalid row please try again.\n\n");

            // Column input.
            Console.WriteLine("Enter a number (1-8) for the current column number.");
            string currentColumn = Console.ReadLine();

            // Restart game if column is invalid.
            if (!acceptedArray.Contains(currentColumn))
                restartGame("Invalid column please try again.\n\n");

            // Display user specified positon and available moves.
            Console.WriteLine($"\nYou have chose to put the piece at ({currentRow}, {currentColumn}).\nHere are the legal moves you can now make.\n");
            return myBoard.theGrid [int.Parse(currentRow) - 1, int.Parse(currentColumn) - 1];
        }

        private static void printBoard(Board myBoard)
        {
            // Print chess board. Use an X for occupied space. Use a + for legal move. Use . for empty cell.
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid [i, j];

                    if (c.CurrentlyOccupied == true)
                        Console.Write("| X ");
                    else if (c.LegalNextMove == true)
                        Console.Write("| + ");
                    else
                        Console.Write("|   ");
                }
                Console.WriteLine("|\n+---+---+---+---+---+---+---+---+");
            }
        }
    }
}
