using System;
using System.Drawing;
using System.Windows.Forms;

namespace CandyCrush
{
    public partial class Form1 : Form
    {
        private MyButton [,] btnGrid;
        private Color currentColor, origColor;
        private int rows, cols, clicks;

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }


        // Fill panel with buttons.
        public void populateGrid()
        {
            int x, y, clicks = 0;
            lblClicks.Text = clicks.ToString();

            // Calculate number of rows and columns based on panel and button size.
            cols = panel1.Height / MyButton.btnSize;
            rows = panel1.Width / MyButton.btnSize;

            // New 2D array of buttons.
            btnGrid = new MyButton [rows, cols];

            // Create new button at each row and column location.
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    btnGrid [r, c] = new MyButton();
                    btnGrid [r, c].Row = r;
                    btnGrid [r, c].Col = c;

                    // Assign the same event handler to every button in panel.
                    btnGrid [r, c].Click += gridButtonClick;

                    // Add button to panel.
                    panel1.Controls.Add(btnGrid [r, c]);

                    // Change location of the button to the correct x, y coordinate
                    btnGrid [r, c].Location = new Point(r * MyButton.btnSize, c * MyButton.btnSize);
                }
            }
        }

        private void colorButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            currentColor = btn.BackColor;
            pictureBox1.BackColor = currentColor;
        }

        private void gridButtonClick(object sender, EventArgs e)
        {
            // Set random row and col.
            Random rand = new Random();
            int randRow = rand.Next(0, rows);
            int randCol = rand.Next(0, cols);

            // Increment click counter.
            clicks++;
            lblClicks.Text = clicks.ToString();

            MyButton btn = (MyButton)sender;
            origColor = btn.BackColor;

            // On every 10th turn set random button to pink per
            // user requirements otherwise floodFill.
            if (clicks % 10 == 0)
                btnGrid [randRow, randCol].BackColor = Color.HotPink;
            else if (!origColor.Equals(currentColor))
            {
                floodFill(btn.Row, btn.Col);
                checkForWinner();
            }

        }


        private bool colorIsMatch(int r, int c)
        {
            return (btnGrid [r, c].BackColor == currentColor);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            populateGrid();
        }

        private void floodFill(int r, int c)
        {
            if (isValid(r, c) && btnGrid[r,c].BackColor.Equals(origColor))
            {
                // Change color of cell clicked.
                btnGrid [r, c].BackColor = currentColor;

                // Apply to the cell to the east.
                floodFill(r + 1, c);

                // Apply to the cell to the west.
                floodFill(r - 1, c);

                // Apply to the cell to the north.
                floodFill(r, c+1);

                // Apply to the cell to the south.
                floodFill(r, c-1);
            }

        }

        private bool isValid(int r, int c)
        {
            return (r >= 0 && r < rows && c >= 0 && c < cols);
        }


    }
}
