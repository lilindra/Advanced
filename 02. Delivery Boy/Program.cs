using System.Drawing;

namespace _02._Delivery_Boy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];

            // ред
            int currentRow = 0;
            // колона
            int currentCol = 0;

            int startRow = -1;
            int startCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                    if (matrix[row, col] == 'B')
                    {
                        currentRow = row;
                        currentCol = col;

                        startRow = row;
                        startCol = col;
                    }
                }
            }

            bool hasLeft = false;

            while (true)
            {
                string command = Console.ReadLine();

                // команди
                if (command == "up")
                {
                    currentRow--;
                    if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols)
                    {
                        hasLeft = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");

                        break;
                    }
                    if (matrix[currentRow, currentCol] == '*')
                    {
                        currentRow++;
                        continue;
                    }

                }
                else if (command == "down")
                {
                    currentRow++;
                    if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols)
                    {
                        hasLeft = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");

                        break;
                    }
                    if (matrix[currentRow, currentCol] == '*')
                    {
                        currentRow--;
                        continue;
                    }

                }
                else if (command == "left")
                {
                    currentCol--;
                    if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols)
                    {
                        hasLeft = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");

                        break;
                    }
                    if (matrix[currentRow, currentCol] == '*')
                    {
                        currentCol++;
                        continue;
                    }

                }
                else if (command == "right")
                {
                    currentCol++;
                    if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols)
                    {
                        hasLeft = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");

                        break;
                    }
                    if (matrix[currentRow, currentCol] == '*')
                    {
                        currentCol--;
                        continue;
                    }
                    
                }


                if (matrix[currentRow, currentCol] == '-')
                {

                    matrix[currentRow, currentCol] = '.';
                }

                if (matrix[currentRow, currentCol] == 'P')
                {

                    matrix[currentRow, currentCol] = 'R';

                    Console.WriteLine("Pizza is collected. 10 minutes for delivery.");

                    continue;
                }

                /*if (matrix[currentRow, currentCol] == 'B')
                {
                    matrix[currentRow, currentCol] = 'B';
                }*/

                if (matrix[currentRow, currentCol] == 'A')
                {

                    matrix[currentRow, currentCol] = 'P';

                    Console.WriteLine("Pizza is delivered on time! Next order...");
                    break;
                }

            }

            if (hasLeft)
            {
                matrix[startRow, startCol] = ' ';
            }

            for (int roww = 0; roww < matrix.GetLength(0); roww++)
            {
                for (int colw = 0; colw < matrix.GetLength(1); colw++)
                {
                    Console.Write(matrix[roww, colw]);
                }
                Console.WriteLine();
            }
        }
    }
}