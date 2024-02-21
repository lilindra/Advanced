
namespace _02The_Gambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четем размера от конзолата
            int size = int.Parse(Console.ReadLine());

            // създаваме матрица от чарове
            char[,] matrix = new char[size, size];

            // ред
            int currentRow = 0;
            // колона
            int currentCol = 0;

            int enteringTheGame = 100;

            // четем матрицата и намираме позицията на "G"
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                    if (matrix[row, col] == 'G')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            // четем команда
            string command = Console.ReadLine();

            while(command != "end")
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

                // проверяваме дали гамблъра не е излезнал от размерите на матрицата
                if (currentRow < 0 || currentRow >= size || currentCol < 0 || currentCol >= size)
                {
                    Console.WriteLine("You left the board boundaries!");
                    return;
                }

                if (matrix[currentRow, currentCol] == 'W')
                {
                    matrix[currentRow, currentCol] = '-';
                    enteringTheGame += 100;
                }
                else if (matrix[currentRow, currentCol] == 'P')
                {
                    enteringTheGame -= 200;
                    // Check if the gambler has lost all the money
                    if (enteringTheGame <= 0)
                    {
                        Console.WriteLine("Game over! You lost everything!");
                        return;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'J')
                {
                    enteringTheGame += 100000;

                    Console.WriteLine("You win the Jackpot!");
                        Console.WriteLine($"End of the game. Total amount: {enteringTheGame}$");

                    // принтираме матрицата
                    for (int roww = 0; roww < matrix.GetLength(0); roww++)
                    {
                        for (int colw = 0; colw < matrix.GetLength(1); colw++)
                        {
                            Console.Write(matrix[roww, colw]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }

                matrix[currentRow, currentCol] = 'G';
                command = Console.ReadLine();
            }

            Console.WriteLine($"End of the game. Total amount: {enteringTheGame}$");

            if(enteringTheGame > 0)
            {
                // принтираме матрицата
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
}