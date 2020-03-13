using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace The_Clockwise_Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[,] CreateSpiral(int N)
        {
            int number = 1;
            int[,] spiral = new int[N, N];
            

            for (int i = 0; i < N*2-1; i++)
            {
                int total = N;
                if(i % 4 == 0) move("right", total);
                else if(i % 4 == 1) move("down", total);
                else if(i % 4 == 2) move("left", total);
                else if(i % 4 == 3) move("up", total);
                total = Convert.ToInt32(total - 0.5);
            }

            void move(string direction, int total)
            {
                switch (direction)
                {
                    case "right":
                        for (int i = 0; i < total; i++)
                        {
                            
                        }
                        break;
                    case "down":
                        break;
                    case "left":
                        break;
                    default:
                        break;
                }
            }
            //Enumerable.Range(1, N)
            //    .ToList()
            //    .ForEach(x =>
            //    {
            //        Enumerable.Range(0, N).ToList().ForEach(y =>
            //         {
            //             if (spiral[x, y] != null)
            //             {
            //                //rotate right
            //            }

            //         });
            //    });
            return spiral;
        }
    }

}
