using System;

namespace TabelUlarTangga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("╔");
            for (int i = 0; i < 40; i++)
            {
                if (i == 18)
                {
                    Console.Write("╦");
                }
                else if ( i == 39)
                {
                    Console.Write("╗");
                }
                else
                {
                    Console.Write("═");
                }
            }
            Console.WriteLine();
            Console.Write("║" + "       ULAR       " + "║" + "       TANGGA       " + "║");
            Console.WriteLine();
            Console.Write("╠");
            for (int i = 0; i < 40; i++)
            {
                if (i == 18 )
                {
                    Console.Write("╬");
                }
                else if (i == 39)
                {
                    Console.Write("╣");
                }
                else
                {
                    Console.Write("═");
                }
            }
            Console.WriteLine();
            Console.Write("║" + "  Kepala " + "║" + "  Ekor  " + "║" + "   Atas   " + "║" + "  Bawah  " + "║");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 40; j++)
                {
                    if (i != 0)
                    {
                        if (j == 0 || j == 19 || j == 40)
                        {
                            Console.Write("║");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
