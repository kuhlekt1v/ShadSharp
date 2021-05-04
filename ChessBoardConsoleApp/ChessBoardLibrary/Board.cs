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

        public bool isSafe(int rowPosition, int colPosition)
        {
            if ((rowPosition < 0 || rowPosition > 7) || (colPosition < 0 || colPosition > 7))
                return false;
            else
                return true;

        }

        public void ClearAllPreviousmoves()
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
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            ClearAllPreviousmoves();

            // Step 2 - Find all legal moves and mark the cells as 'legal'.
            switch (chessPiece)
            {
                // Knight.
                case "h":
                    if(isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                        theGrid [currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if(isSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                        theGrid [currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                        theGrid [currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                        theGrid [currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                        theGrid [currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                        theGrid [currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                        theGrid [currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                        theGrid [currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;
                // King.
                case "k":
                    if (isSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber))
                        theGrid [currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber))
                        theGrid [currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + 1))
                        theGrid [currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - 1))
                        theGrid [currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    break;
                // Rook.
                case "r":
                    for (int i = 0; i <= 8; i++)
                    {
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColumnNumber))
                            theGrid [currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColumnNumber))
                            theGrid [currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + i))
                            theGrid [currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - i))
                            theGrid [currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                // Bishop.
                case "b":
                    for (int i = 0; i <= 8; i++)
                    {
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColumnNumber + i))
                            theGrid [currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColumnNumber - i))
                            theGrid [currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColumnNumber + i))
                            theGrid [currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColumnNumber - i))
                            theGrid [currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                // Queen.
                case "q":
                    for (int i = 0; i <= 8; i++)
                    {
                        // Horizontal / vertical moves.
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColumnNumber))
                            theGrid [currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColumnNumber))
                            theGrid [currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber + i))
                            theGrid [currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber, currentCell.ColumnNumber - i))
                            theGrid [currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;

                        // Diagonal moves.
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColumnNumber + i))
                            theGrid [currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber + i, currentCell.ColumnNumber - i))
                            theGrid [currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColumnNumber + i))
                            theGrid [currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (isSafe(currentCell.RowNumber - i, currentCell.ColumnNumber - i))
                            theGrid [currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;
                default:
                    break;
            }

            // Mark current user position.
            theGrid [currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }
    }
}
