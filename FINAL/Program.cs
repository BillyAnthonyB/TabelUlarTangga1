using System;

namespace FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random RANDOM = new Random();
            int[] KEPALA = new int[6];
            int[] EKOR = new int[6];
            int[] ATAS = new int[6];
            int[] BAWAH = new int[6];
            for (int i = 1; i <= 5; i++)
            {
                KEPALA[i] = RANDOM.Next(10, 99);
                EKOR[i] = RANDOM.Next(1, 89);
                ATAS[i] = RANDOM.Next(10, 100);
                BAWAH[i] = RANDOM.Next(2, 89);
                while (KEPALA[i] == EKOR[i])
                {
                    KEPALA[i] = RANDOM.Next(10, 99);
                    EKOR[i] = RANDOM.Next(1, 89);
                }
                while (KEPALA[i] == ATAS[i])
                {
                    KEPALA[i] = RANDOM.Next(10, 99);
                    ATAS[i] = RANDOM.Next(1, 89);
                }
                while (KEPALA[i] == BAWAH[i])
                {
                    KEPALA[i] = RANDOM.Next(10, 99);
                    BAWAH[i] = RANDOM.Next(1, 89);
                }
                while (KEPALA[i] < EKOR[i])
                {
                    KEPALA[i] = RANDOM.Next(10, 99);
                    EKOR[i] = RANDOM.Next(1, 89);
                }
                while (ATAS[i] < BAWAH[i])
                {
                    ATAS[i] = RANDOM.Next(10, 100);
                    BAWAH[i] = RANDOM.Next(2, 89);
                }
                if (ATAS[i] == 100)
                {
                    BAWAH[i] = RANDOM.Next(80, 89);
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            Console.Write("╔");
                        }
                        else if (j == 19)
                        {
                            Console.Write("╦");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╗");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                    else if (i == 1)
                    {
                        if (j == 0 || j == 16 || j == 31)
                        {
                            Console.Write("║");
                            if (j == 31)
                            {
                                Console.WriteLine();
                            }
                        }
                        else if (j == 8)
                        {
                            Console.Write("ULAR");
                        }
                        else if (j == 24)
                        {
                            Console.Write("TANGGA");
                        }
                        else if (j < 31 && j != 0 && j != 16 && j != 8 && j != 24)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 2)
                    {
                        if (j == 0)
                        {
                            Console.Write("╠");
                        }
                        else if (j == 19)
                        {
                            Console.Write("╬");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╣");
                        }
                        else if (j == 10 || j == 30)
                        {
                            Console.Write("╦");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 0 || j == 5 || j == 11 || j == 19 || j == 24)
                        {
                            Console.Write("║");
                            if (j == 24)
                            {
                                Console.WriteLine();
                            }
                        }
                        else if (j == 3)
                        {
                            Console.Write("Kepala");
                        }
                        else if (j == 8)
                        {
                            Console.Write("Ekor");
                        }
                        else if (j == 15)
                        {
                            Console.Write("Atas");
                        }
                        else if (j == 21)
                        {
                            Console.Write("Bawah");
                        }
                        else if (j < 24 && j != 0 && j != 5 && j != 11 && j != 19 && j != 3 && j != 8 && j != 15 && j != 21)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 0)
                        {
                            Console.Write("╠");
                        }
                        else if (j == 19 || j == 10 || j == 30)
                        {
                            Console.Write("╬");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╣");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                    else if (i < 10 && i > 4)
                    {
                        if (j == 0 || j == 9 || j == 17 || j == 27 || j == 35)
                        {
                            Console.Write("║");
                            if (j == 35)
                            {
                                Console.WriteLine();
                            }
                        }
                        else if (j == 4 || j == 13 || j == 22 || j == 31)
                        {
                            if (j == 4)
                            {
                                i = i - 4;
                                if (KEPALA[i] > 9)
                                {
                                    Console.Write(KEPALA[i]);
                                }
                                else if (KEPALA[i] < 10)
                                {
                                    Console.Write(" " + KEPALA[i]);
                                }
                                i = i + 4;
                            }
                            else if (j == 13)
                            {
                                i = i - 4;
                                if (EKOR[i] > 9)
                                {
                                    Console.Write(EKOR[i]);
                                }
                                else if (EKOR[i] < 10)
                                {
                                    Console.Write(EKOR[i] + " ");
                                }
                                i = i + 4;
                            }
                            else if (j == 22)
                            {
                                i = i - 4;
                                if (ATAS[i] > 9)
                                {
                                    Console.Write(ATAS[i]);
                                }
                                else if (ATAS[i] < 10)
                                {
                                    Console.Write(ATAS[i] + " ");
                                }
                                i = i + 4;
                            }
                            else if (j == 31)
                            {
                                i = i - 4;
                                if (BAWAH[i] > 9)
                                {
                                    Console.Write(BAWAH[i]);
                                }
                                else if (BAWAH[i] < 10)
                                {
                                    Console.Write(BAWAH[i] + " ");
                                }
                                i = i + 4;
                            }
                        }
                        else if (j < 35 && j != 0 && j != 9 && j != 17 && j != 27)
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == 10)
                    {
                        if (j == 0)
                        {
                            Console.Write("╚");
                        }
                        else if (j == 19 || j == 10 || j == 30)
                        {
                            Console.Write("╩");
                        }
                        else if (j == 39)
                        {
                            Console.WriteLine("╝");
                        }
                        else
                        {
                            Console.Write("═");
                        }
                    }
                }
            }
        }
    }
}
