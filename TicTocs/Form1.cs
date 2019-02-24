using System;
using System.Windows.Forms;

namespace TicTocs
{
    enum WhoWin
    {
        Draw,
        X,
        O,
        Exception,
        GameIsInProgress
    }

    public partial class Form1 : Form
    {
        private int turns = 0;
        private int XWins = 0;
        private int OWins = 0;
        private int Draws = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (((Button) sender).Text == "")
            {
                ((Button) sender).Text = turns++ % 2 == 0 ? "X" : "O";

                WhoWin winner = CheckWinner();
                switch (winner)
                {
                    case WhoWin.Draw:
                        Draws++;
                        MessageBox.Show("Tie game");
                        NewGame();
                        break;
                    case WhoWin.O:
                        OWins++;
                        MessageBox.Show("O won");
                        NewGame();
                        break;
                    case WhoWin.X:
                        XWins++;
                        MessageBox.Show("X won");
                        NewGame();
                        break;
                    case WhoWin.Exception:
                        MessageBox.Show("Something goes wrong, game will reset");
                        Reset();
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            turns = 0;
            B00.Text = B01.Text = B02.Text = B12.Text = B11.Text = B10.Text = B22.Text = B21.Text = B20.Text = "";
            labelXWins.Text = "X: " + XWins;
            labelYWins.Text = "O: " + OWins;
            labelDraw.Text = "Draws: " + Draws;
        }

        private WhoWin CheckWinner()
        {
            string winner = "";
            if (turns == 9)
            {
                return WhoWin.Draw;
            }
            //Horizontal lines
            if ((B00.Text == B01.Text) && (B01.Text == B02.Text) && (B00.Text !=  ""))
            {
                winner = B00.Text;
            }
            else if ((B10.Text == B11.Text) && (B11.Text == B12.Text) && (B12.Text !=  ""))
            {
                winner = B10.Text;
            }
            else if ((B20.Text == B21.Text) && (B21.Text == B22.Text) && (B22.Text !=  ""))
            {
                winner = B20.Text;
            }
            //Vertical lines
            else if ((B00.Text == B10.Text) && (B10.Text == B20.Text) && (B00.Text !=  ""))
            {
                winner = B00.Text;
            }
            else if ((B01.Text == B11.Text) && (B11.Text == B21.Text) && (B01.Text !=  ""))
            {
                winner = B01.Text;
            }
            else if ((B02.Text == B12.Text) && (B12.Text == B22.Text) && (B02.Text !=  ""))
            {
                winner = B02.Text;
            }
            //Diagonal lines
            else if ((B00.Text == B11.Text) && (B11.Text == B22.Text) && (B00.Text !=  ""))
            {
                winner = B00.Text;
            }
            else if ((B02.Text == B11.Text) && (B11.Text == B20.Text) && (B02.Text !=  ""))
            {
                winner = B02.Text;
            }

            if (winner != "")
            {
                return winner == "X" ? WhoWin.X : WhoWin.O;
            }

            return WhoWin.GameIsInProgress;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            turns = 0;
            B00.Text = B01.Text = B02.Text = B12.Text = B11.Text = B10.Text = B22.Text = B21.Text = B20.Text = "";
            labelXWins.Text = "X: " + (XWins = 0);
            labelYWins.Text = "O: " + (OWins = 0);
            labelDraw.Text = "Draws: " + (Draws = 0);
        }
    }
}
