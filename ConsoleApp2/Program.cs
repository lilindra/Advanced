using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int currentRow = 0;
            int currentCol = 0;

            int caughtFish = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                    if (matrix[row, col] == 'S')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while(command != "collect the nets")
            {
                // маркираме вмоментъшната позиция с '-'
                matrix[currentRow, currentCol] = '-';

                // команди
                if (command == "up")
                {
                    currentRow--;
                    if (currentRow < 0)
                    {
                        currentRow = size - 1;
                    }
                }
                else if (command == "down")
                {
                    currentRow++;
                    if (currentRow >= size)
                    {
                        currentRow = 0;
                    }
                }
                else if (command == "left")
                {
                    currentCol--;
                    if (currentCol < 0)
                    {
                        currentCol = size - 1;
                    }
                }
                else if (command == "right")
                {
                    currentCol++;
                    if (currentCol >= size)
                    {
                        currentCol = 0;
                    }
                }

                // ако паднем във водовъртеж
                if (matrix[currentRow, currentCol] == 'W')
                {

                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentCol}]");
                    return;
                }

                if (char.IsDigit(matrix[currentRow, currentCol]))
                {
                    caughtFish += int.Parse(matrix[currentRow, currentCol].ToString());
                }

                matrix[currentRow, currentCol] = 'S';

                command = Console.ReadLine();
            }

            if (caughtFish < 20)
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - caughtFish} tons of fish more.");
            }
            else
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }


            if (caughtFish > 0)
                Console.WriteLine($"Amount of fish caught: {caughtFish} tons.");

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