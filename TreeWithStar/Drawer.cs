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
            arrStar[0] = "*";

            for (int i = 1; i < arrStar.Length; i++)
            {
                for (int j = 0; j < arrStar[i - 1].Length + 2; j++)
                {
                    arrStar[i] += "*";
                }
            }

            int lastRowCount = arrStar[arrStar.Length - 1].Length;
            //for (int i = 0; i < arrStar.Length; i++)
            //{
            //    int spaceCount = (lastRowCount - arrStar[i].Length) / 2;
            //    row = arrStar[i].PadLeft(spaceCount, '-');
            //    Console.WriteLine(row);
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


            Console.WriteLine("I".PadLeft((lastRowCount/2) + 1, ' '));
        }
    }
}
