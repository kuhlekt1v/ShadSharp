using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardLibrary
{
    public class Board
    {
        // Size of board typically 8x8.
        public int Size { get; set; }

        // 2d array of type cell.
        public Cell[,] theGrid { get; set; }

        // Constructor.
        public Board(int s)
        {
            // Initial board size.
            Size = s;

            // Create new 2d array of type cell.
            theGrid = new Cell [Size, Size];

            for (int i = 0; i < Size; i++)
            {

                for (int j = 0; j < Size; j++)
                {
                    theGrid [i, j] = new Cell(i, j);

                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            // Step 1 - Clear all previous legal moves.
            for (int i = 0; i < Size; i++)
            {

                for (int j = 0; j < Size; j++)
                {
                    theGrid [i, j].LegalNextMove = false;
                    theGrid [i, j].CurrentlyOccupied = false;
                }
            }

            // Step 2 - Find all legal moves and mark the cells as 'legal'.
            switch (chessPiece)
            {
                case "Knight":
                    theGrid [currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid [currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid [currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid [currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid [currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid [currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    theGrid [currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid [currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;
                case "King":
                    break;
                case "Rook":
                    break;
                case "Bishop":
                    break;
                case "Queen":
                    break;
                default:
                    break;
            }

            theGrid [currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }
    }
}
