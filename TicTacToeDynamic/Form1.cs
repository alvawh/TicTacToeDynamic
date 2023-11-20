using System;
using System.Windows.Forms;

namespace TicTacToeDynamic
{
    public partial class Form1 : Form
    {
        private char[,] gameBoard = new char[3, 3];
        private Button[,] buttons = new Button[3, 3];
        private bool player1turn = true; // true = X, false = O
        private int turnCount = 0;
        private int player1Score = 0;
        private int player2Score = 0;
        private Label playerscore1;
        private Label playerscore2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = ' ';

                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(114, 119);
                    buttons[i, j].Location = new Point(i * 120, j * 125);
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "" )
            {
                if (player1turn)
                    b.Text = "X";
                else
                    b.Text = "O";

                player1turn = !player1turn;

                int row = -1;
                int column = -1;

                // Find the button's location in the array
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (buttons[i, j] == b)
                        {
                            row = i;
                            column = j;
                            break;
                        }
                    }
                }

                if (row != -1 && column != -1)
                {
                    gameBoard[row, column] = b.Text[0];
                }

                displayTurn.Text = (player1turn ? "X" : "O");
                turnCount++;

                CheckForWinner();
            }
        }
        private void updatePlayerScores()
        {
            if (player1turn)
            {
                playerscore2.Text = "" + player2Score;
            }
            else
            {
                playerscore1.Text = "" + player1Score;
            }
        }

        private bool IsWinner()
        {
            // Check if the game has already been won
            return player1Score > 0 || player2Score > 0;
        }

        private char CheckForWinner()
        {
            char winner = CheckLines(gameBoard);

            if (winner != ' ')
            {
                MessageBox.Show("Player " + winner + " won!");
                if (winner == 'X')
                    player1Score++;

                else if (winner == 'O')
                    player2Score++;


                updatePlayerScores();
                
            }
            else if (turnCount == 9)
            {
                MessageBox.Show("Typical, It's a draw!");
                
            }

            return winner;
        }

        private char CheckLines(char[,] board)
        { //checks for horizontal,vertical and diagonal winners
            for (int i = 0; i < 3; i++)
            {
                char rowValue = board[i, 0];
                char columnValue = board[0, i];

                if (rowValue != ' ' && board[i, 1] == rowValue && board[i, 2] == rowValue)
                    return rowValue;

                if (columnValue != ' ' && board[1, i] == columnValue && board[2, i] == columnValue)
                    return columnValue;
            }

            char diagValue = board[1, 1];

            if (diagValue != ' ' &&
                ((board[0, 0] == diagValue && board[2, 2] == diagValue) ||
                 (board[0, 2] == diagValue && board[2, 0] == diagValue)))
            {
                return diagValue;
            }

            return ' ';
        }


        private void resetGame()
        {

            // Clear the game board and button texts
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = ' ';
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }

            // Reset turn count
            turnCount = 0;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            resetGame();
            
        }
    }
}
