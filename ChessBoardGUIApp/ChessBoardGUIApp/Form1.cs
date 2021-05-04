using ChessBoardLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        // Reference to the class Board. Contains values of the board.
        static Board myBoard = new Board(8);

        // 2D array of buttons whose values are determined by myBoard.
        public Button [,] btnGrid = new Button [myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            // Create buttons and place into panel 1.
            int buttonSize = panel1.Width / myBoard.Size;

            // Ensure panel is a square
            panel1.Height = panel1.Width;

            // Create buttons and print to screen.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid [i, j] = new Button();
                    btnGrid [i, j].Height = buttonSize;
                    btnGrid [i, j].Width = buttonSize;

                    // Add click event to each button
                    btnGrid [i, j].Click += GridButtonClick;

                    // Add new button to the panel.
                    panel1.Controls.Add(btnGrid [i, j]);

                    // Set location of new button on panel.
                    btnGrid [i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid [i, j].Text = $"{i} | {j}";
                    btnGrid [i, j].Tag = new Point(i, j);
                }
            }
        }

        private void GridButtonClick(object sender, EventArgs e)
        {
            // Get the row and column number of the button clicked
            Button clickedButton = (Button) sender;
            Point location = (Point) clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid [x, y];

            // Get piece to check.
            string comboBoxText = comboBox1.Text.ToString();


            // Confirm piece selection has been made.
            if (!string.IsNullOrWhiteSpace(comboBoxText))
            {
                // Format combo box text selection.
                string chessPiece;
                if (comboBoxText == "Knight")
                    chessPiece = "h";
                else
                    chessPiece = comboBoxText.Substring(0, 1).ToLower();

                // Determine next legal moves
                myBoard.MarkNextLegalMoves(currentCell, chessPiece);

                // Update text on each button.
                for (int i = 0; i < myBoard.Size; i++)
                {
                    for (int j = 0; j < myBoard.Size; j++)
                    {
                        // Clear previous moves.
                        btnGrid [i, j].Text = "";

                        if (myBoard.theGrid [i, j].CurrentlyOccupied == true)
                            btnGrid [i, j].Text = comboBoxText;
                        else if (myBoard.theGrid [i, j].LegalNextMove == true)
                            btnGrid [i, j].Text = "Legal";
                    }
                }
            }
            else
                MessageBox.Show("Select a chess piece to continue.");
        }
    }
}
