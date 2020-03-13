using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Tic_Tac_Toe_Checker
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int IsSolved(int[,] board)
        {
            //Check hor&ver
                var winner = Enumerable.Range(0, 3)
                    .Select(i => board[i, i] == board[i, (i + 1) % 3] && board[i, i] == board[i, (i + 2) % 3]
                                 || board[i, i] == board[(i + 1) % 3, i] && board[i, i] == board[(i + 2) % 3, i] ? board[i, i] : 0).ToList();
                if (winner.Contains(1)) return 1;
                else if (winner.Contains(2)) return 2;
                //check dig
                else if ((board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] ||
                         board[2, 0] == board[1, 1] && board[2, 0] == board[0, 2]) && board[1,1] != 0) return board[1, 1];
                //check empty
                else if (Enumerable
                    .Range(0, board.Length)
                    .Count(i => board[i % 3, Convert.ToInt32(i / 3)] == 0) > 0) return -1;
                return 0;
        }
    }
}
