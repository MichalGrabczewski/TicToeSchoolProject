using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] gameBoard = new string[9];
        int currentTurn = 0;
        bool boolKolor;
        public string returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public void checkForWinner()
        {

            for (int i = 0; i < 8; i++)
            {
                String combination = "";
                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }
                if (combination.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("O wygrało", "Jest wygrany", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string writeMe = "O wygrało";
                    File.AppendAllText(@"C:\Users\price\Desktop\c#\c#\WindowsFormsApp1\tictoe.txt", writeMe + Environment.NewLine);

                }
                else if (combination.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("X wygrał", "Jest wygrany", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string writeMe = "X wygrało";
                    File.AppendAllText(@"C:\Users\price\Desktop\c#\c#\WindowsFormsApp1\tictoe.txt", writeMe + Environment.NewLine);
                }
                checkDraw();
            }
        }
        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameBoard = new string[9];
            currentTurn = 0;
        }
        public void checkDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { counter++; }
                if (counter == 9)
                {
                    reset();
                    MessageBox.Show("Remis", "Nikt nie wygral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string writeMe = "Remis";
                    File.AppendAllText(@"C:\Users\price\Desktop\c#\c#\WindowsFormsApp1\tictoe.txt", writeMe + Environment.NewLine);
                }

            }
        }

        public String determineColor(string symbol)
        {
            if (symbol.Equals("O"))
            {
                return "System.Drawing.Color.Highlight";
            }
            else
            {
                return "System.Drawin.Color.Chartreuse";
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
             currentTurn++;
             gameBoard[0] = returnSymbol(currentTurn);
             button1.Text = gameBoard[0];
             checkForWinner();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            button2.Text = gameBoard[1];
            checkForWinner();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            button3.Text = gameBoard[2];
            checkForWinner();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            button4.Text = gameBoard[3];
            checkForWinner();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            button5.Text = gameBoard[4];
            checkForWinner();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            button7.Text = gameBoard[6];
            checkForWinner();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            button6.Text = gameBoard[5];
            checkForWinner();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            button8.Text = gameBoard[7];
            checkForWinner();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            button9.Text = gameBoard[8];
            checkForWinner();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            if (boolKolor == true)
            {
                this.BackColor = Color.White;
                boolKolor = !boolKolor;
            }
            else
            {
                this.BackColor = Color.Black;
                boolKolor = !boolKolor;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var wynikWWW = new czytanieWyniku();
            wynikWWW.wynikWW();
        }
    }
    public class czytanieWyniku
    {   
        public void wynikWW()
        {
            System.Diagnostics.Process.Start(@"C:\Users\price\Desktop\c#\c#\WindowsFormsApp1\tictoe.txt");
            
        }
    }
}

