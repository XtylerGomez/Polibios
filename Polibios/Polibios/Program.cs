using System;

namespace Polibios // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrices();
            string input;
            input = Console.ReadLine();

            char[] Array = input.ToCharArray();
            int lenght = Array.Length;
            string[] Array2 = new string[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Array2[i] = Polibio(Array[1]);
            }

            string Polibio(char x)
            {

                return x.ToString();
            }
        }

        static void Matrices()
        {
            int[,] Code = new int[5, 5];
            string[,] ABC = new string[5, 5] { { "A", "B", "C", "D", "E" }, {"F","G","H","I/J","K" }, { "L","M","N","O","P"},
                                                { "Q","R","S","T","U"},{"V","W","X","Y","Z"} };
            
            string holder = "";
            
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        holder = "" + (i + 1) + (j + 1) + "";
                        Code[i, j] = int.Parse(holder);

                        Console.WriteLine(Code[i, j]);
                        Console.WriteLine(ABC[i, j]);
                    }
                }
            }
            

        }
    }
