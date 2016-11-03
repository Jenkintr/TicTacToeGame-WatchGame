using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimulator
{
    public partial class TicTacToe : Form
    {
        //Variables:
        bool turn = true; // true = x turn; false = o turn;
        
        const int ROWCOUNT = 3;
        const int COLCOUNT = 3;
        String[,] letters = new String[ROWCOUNT, COLCOUNT]; //Array to hold the letters

        public TicTacToe()
        {
            InitializeComponent();
            turnIdentiferLabel.Text = "Player X's Turn.";
        }

        private Random trueRandom()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            return rnd;
        }//End trueRandom

        private void randomize()
        {
            int lRow;
            int lCol;
            
            for (int row = 0; row < ROWCOUNT; row++)
            {
                for (int col = 0; col < COLCOUNT; col++)
                {
                    while (letters[row, col] == null)
                    {
                        lRow = trueRandom().Next(0, 3);
                        lCol = trueRandom().Next(0, 3);

                        if (turn == true && letters[lRow, lCol] == null)
                        {
                            letters[lRow, lCol] = "X";
                            turn = false;
                        }
                        else if (turn == false && letters[lRow, lCol] == null)
                        {
                            letters[lRow, lCol] = "O";
                            turn = true;
                        }
                        

                    }

                }
            }
        }//End randomize
        
        private void updateView()
        {
            var labels = new[] { A1, A4, A7, A2, A5, A8, A3, A6, A9 };
            int count = 0;

            for (int row = 0; row < ROWCOUNT; row++)
            {
                for (int col = 0; col < COLCOUNT; col++)
                {
                    labels[count].Text = letters[row, col];
                    labels[count].Enabled = false;
                    count++;
                }
            }
            
            bool isWinner = checkForWinner();
            //If winner is found show the winner.
            if (isWinner)
            {
                displayWinner(isWinner);
            }
        }//End updateView method  

        private void populateGameboard(object sender, EventArgs e)
        {
            clear();
            turn = true;
            InstructionsLabel.Visible = true;
            turnIdentiferLabel.Visible = false;
            randomize();
            updateView();
        }//End populateGameboard

        //
        // Code used for multiplayer and watch game
        //
        /**********************************************************************
        * The checkForWinner method will check each turn to see if anyone has*
        * won the game.                                                      *
        **********************************************************************/
        private bool checkForWinner()
        {
            //Variables
            bool isWinner = false;

            //Check Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
            {
                isWinner = true;
            }
            else if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A7.Enabled))
            {
                isWinner = true;
            }

            //Check Vertical
            if ((A1.Text == A4.Text) && (A4.Text == A7.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((A2.Text == A5.Text) && (A5.Text == A8.Text) && (!A2.Enabled))
            {
                isWinner = true;
            }
            else if ((A3.Text == A6.Text) && (A6.Text == A9.Text) && (!A3.Enabled))
            {
                isWinner = true;
            }

            //Check Vertical
            if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }
            else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A7.Enabled))
            {
                isWinner = true;
            }

            return isWinner;
        }//end checkForWinner

        private void displayWinner(bool isWinner)
        {
            String winner;
            if (turn)
            {
                winner = "O";
                o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                MessageBox.Show(winner + " Wins!", "Winner!");
            }
            else if (!turn)
            {
                winner = "X";
                x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                MessageBox.Show(winner + " Wins!", "Winner!");
            }
        }

        /***********************************************************************
         * The clearButton_Click handler will reset all the score values.      *
         ***********************************************************************/
        private void clearButton_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
        }//end clearButton_Click

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear()
        {
            var labels = new[] { A1, A4, A7, A2, A5, A8, A3, A6, A9 };
            int count = 0;

            //Clear the labels Array
            for (int row = 0; row < ROWCOUNT; row++)
            {
                for (int col = 0; col < COLCOUNT; col++)
                {
                    labels[count].Text = "";
                    labels[count].Enabled = true;
                    count++;
                }
            }

            //Clear the letters array
            for (int row = 0; row < ROWCOUNT; row++)
            {
                for (int col = 0; col < COLCOUNT; col++)
                {
                    letters[row, col] = null;
                }
            }
        }//End the button1_Click (Clears labels array and letters array)

        //
        // Code that makes game multiplayer
        //
        /************************************************************************
         * square_click event handler allow the user to take turns making a mark*
         * on the board to determine a winner.                                  *
         ************************************************************************/
        private void square_click(object sender, EventArgs e)
        {
            showTurn();
            Label xo = (Label)sender;
            if (turn)
            {
                xo.Text = "X";
            }
            else
            {
                xo.Text = "O";
            }

            turn = !turn; //Changes the turn 
            xo.Enabled = false;
            bool isWinner = checkForWinner();
            //If winner is found show the winner.
            if (isWinner)
            {
                disableSquares(); //disable buttons if theres a winner
                displayWinner(isWinner);
            }
        }//end square_click
        
        /**********************************************************************
         * The showTurn method will reset all the values so that a new game   *
         * can begin.                                                         *
         **********************************************************************/
        private void showTurn()
        {
            if (turn)
                turnIdentiferLabel.Text = "Player O's Turn.";
            else
                turnIdentiferLabel.Text = "Player X's Turn.";
        }//end showTurn

        /**********************************************************************
         * The disableSquares method will disable all of the squares so that  *
         * a player cannot change another users choice.                       *
         **********************************************************************/
        private void disableSquares()
        {
            var labels = new[] { A1, A4, A7, A2, A5, A8, A3, A6, A9 };
            int count = 0;

            //Clear the labels Array
            for (int row = 0; row < ROWCOUNT; row++)
            {
                for (int col = 0; col < COLCOUNT; col++)
                {
                    labels[count].Enabled = false;
                    count++;
                }
            }
        }//end disableSquares

        /***********************************************************************
         * The startNewGame method will reset all the values so that a new game*
         * can begin.                                                          *
         ***********************************************************************/
        private void startNewGame(object sender, EventArgs e)
        {
            InstructionsLabel.Visible = false;
            turnIdentiferLabel.Visible = true;
            turn = true;
            turnIdentiferLabel.Text = "Player X's Turn.";
            clear();

        }//end startNewGame
        
    }
}
