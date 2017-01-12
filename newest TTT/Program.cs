using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static string[] board = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        static string playa = "X";
        static int choice;
        private static void drawBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
        }

        static bool winner()
        {
            if (board[0] == board[1] && board[1] == board[2])
                return true;
            if (board[3] == board[4] && board[4] == board[5])
                return true;
            if (board[6] == board[7] && board[7] == board[8])
                return true;
            if (board[0] == board[3] && board[3] == board[6])
                return true;
            if (board[1] == board[4] && board[4] == board[7])
                return true;
            if (board[2] == board[5] && board[5] == board[8])
                return true;
            if (board[0] == board[4] && board[4] == board[8])
                return true;
            if (board[2] == board[4] && board[4] == board[6])
                return true;
            else
                return false;
        }
        private static void nextTurn()
        {
            drawBoard();
            Console.WriteLine($"Player {playa} Pick a spot");
            choice = int.Parse(Console.ReadLine());
            if (choice < 0 || choice > 9 || board[choice].Equals("X") || board[choice].Equals("O"))
                Console.WriteLine("TRY AGAIN SUCKA!");
            else
             
                if (playa == "X") // marks x or o
            {
                board[choice] = "X";
            }
            else
                board[choice] = "O";
            playa = playa == "X" ? "O" : "X"; //changes player turn
            
        }

        private static void Main(string[] args)
        {
           
            while (winner() == false)
            {
                nextTurn();
                
            }

            if (winner() == true)
            {
                Console.WriteLine("Congrats You Da Real MVP!");
            }
        
        }
         
    }
}
