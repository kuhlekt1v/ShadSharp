using System;

namespace KnightsTour
{
    class Program
    {
        static int boardSize = 8;
        static int attemptedMoves = 0;

        static int [] xMove = {2, 1, -1, -2, - 2, -1, 1, 2};
        static int [] yMove = {1, 2, 2, 1, -1, -2, -2, -1 };

        static int [,] boardGrid = new int [boardSize, boardSize];

        static void Main(string [] args)
        {
            solveKT();
            Console.ReadLine();
        }

        static void solveKT()
        {
            // Initialize all squares to not visited.
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    // Set initial value to -1 not visited. 
                    boardGrid [i, j] = -1;
                }
            }

            // Initialize starting point, number of moves.
            int startX = 0;
            int startY = 0;
            boardGrid [startX, startY] = 0;
            attemptedMoves = 0;

            // Recursively try all possible legal moves. Backtrack on dead end solutions.
            if(!solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("No solution for {0}, {1}", startX, startY);
            }
            else
            {
                printBoard(boardGrid);
                Console.WriteLine("Total attempted moves {0}", attemptedMoves);
            }

            bool solveKTUtil(int x, int y, int moveCount)
            {
                // Update user every 1 million move attempts.
                attemptedMoves++;
                if (attemptedMoves % 1000000 == 0)
                    Console.WriteLine("Attempted {0} moves", attemptedMoves);

                int k;
                int next_x, next_y;

                // Check to see if we solved the problem.
                if (moveCount == boardSize * boardSize)
                    return true;

                // Cycle through all possible next moves for knight
                for (k = 0; k < 8; k++)
                {
                    next_x = x + xMove [k];
                    next_y = y + yMove [k];

                    if(safeSquare(next_x, next_y))
                    {
                        boardGrid [next_x, next_y] = moveCount;
                        if(solveKTUtil(next_x, next_y, moveCount + 1))
                            return true;
                        else
                            boardGrid [next_x, next_y] = -1;
                    }
                }
                return false;
            }

            bool safeSquare(int x, int y)
            {
                // Check to see if x, y is on the board to prevent out of bounds errors.
                // Also, check to see if the square is visited or not.
                return (x >= 0 && x < boardSize && y >= 0 && y < boardSize && boardGrid [x, y] == -1);

            }

            void printBoard(int [,] boardToPrint)
            {
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        if (boardToPrint [i, j] < 10)
                            Console.Write(" ");
                        Console.Write(boardGrid [i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
