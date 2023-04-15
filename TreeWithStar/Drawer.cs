using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWithStar
{
    public class Drawer
    {
        public void Tree(int layer)
        {
            if (layer <= 0)
            {
                Console.WriteLine("please enter number bigger than zero");
                return;
            }
            string row;

            string[] arrStar = new string[layer];
            arrStar[0] = "X";

            for (int i = 1; i < arrStar.Length; i++)
            {
                for (int j = 0; j < arrStar[i - 1].Length + 2; j++)
                {
                    arrStar[i] += "X";
                }
            }

            int lastRowCount = arrStar[arrStar.Length - 1].Length;
                                                                 
            for (int i = 0; i < arrStar.Length; i++)
            {
                int spaceCount = (lastRowCount - arrStar[i].Length) / 2;
                row = "";
                for (int k = 0; k < spaceCount; k++)
                {
                    row += " ";
                }

                row += arrStar[i];
                Console.WriteLine(row);
            }


            Console.WriteLine("I".PadLeft((lastRowCount/2) + 1, ' '));
        }
                 
        public void TreePerformanced(int layer)
        {
            if (layer <= 0)
            {
                Console.WriteLine("please enter number bigger than zero");
                return;
            }
            string row;
            string[] arrStar = new string[layer];
         
            for (int i = 0; i < arrStar.Length; i++)
            {
                    arrStar[i] = "X".PadLeft((2 * (i+1)) - 1, 'X');
            }


            int lastRowCount = arrStar[arrStar.Length - 1].Length;

            //for (int i = 0; i < arrStar.Length; i++)
            //{
            //    int spaceCount = (lastRowCount - arrStar[i].Length) / 2;
            //    //row = "";
            //    //row += arrStar[i].PadLeft(spaceCount, ' ');
            //    //for (int k = 0; k < spaceCount; k++)
            //    //{
            //    //    row += " ";
            //    //}       
            //    //row += arrStar[i];
            //    Console.WriteLine(arrStar[i].PadLeft(spaceCount, ' '));
            //}

            for (int i = 0; i < arrStar.Length; i++)
            {
                int spaceCount = (lastRowCount - arrStar[i].Length) / 2;
                row = "";
                for (int k = 0; k < spaceCount; k++)
                {
                    row += " ";
                }

                row += arrStar[i];
                Console.WriteLine(row);
            }

            Console.WriteLine("I".PadLeft((lastRowCount / 2) + 1, ' '));
        }


        public void TreeWithStarOnTop(int layer)
        {
            if (layer <= 0)
            {
                Console.WriteLine("please enter number bigger than zero");
                return;
            }
            layer += 1;
            string row;
            string[] arrStar = new string[layer];
            arrStar[0] = "*";
            arrStar[1] = "X";

            for (int i = 2; i < arrStar.Length; i++)
            {
                for (int j = 0; j < arrStar[i - 1].Length + 2; j++)
                {
                    arrStar[i] += "X";
                }
            }

            int lastRowCount = arrStar[arrStar.Length - 1].Length;

            for (int i = 0; i < arrStar.Length; i++)
            {
                int spaceCount = (lastRowCount - arrStar[i].Length) / 2;
                row = "";
                for (int k = 0; k < spaceCount; k++)
                {
                    row += " ";
                }

                row += arrStar[i];
                Console.WriteLine(row);
            }


            Console.WriteLine("I".PadLeft((lastRowCount / 2) + 1, ' '));
        }
    }

}      