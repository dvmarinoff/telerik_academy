using System;
//03. We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 
class Program
{
    static void Main()
    {
        Console.Write("N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("M: ");
        int M = int.Parse(Console.ReadLine());
        string[,] array = new string[N, M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("array[{0},{1}]: ", i, j);
                array[i, j] = Console.ReadLine();
            }
        }
        int maxSequenceXIndex = 0;
        int maxSequenceYIndex = 0;
        int maxSequenceLength = 1;
        string maxSequenceType = "none";
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                string elementToCheck = array[i, j];
                int currentLength = 1;
                int rowSequence = i + 1;
                while (rowSequence < N)
                {
                    if (elementToCheck == array[rowSequence, j])
                    {
                        currentLength++;
                        rowSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    maxSequenceType = "row";
                    maxSequenceLength = currentLength;
                }

                currentLength = 1;
                int lineSequence = j + 1;
                while (lineSequence < M)
                {
                    if (elementToCheck == array[i, lineSequence])
                    {
                        currentLength++;
                        lineSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    maxSequenceType = "line";
                    maxSequenceLength = currentLength;
                }

                currentLength = 1;
                int diagonalX = i + 1;
                int diagonalY = j + 1;
                while (diagonalX < N && diagonalY < M)
                {
                    if (elementToCheck == array[diagonalX, diagonalY])
                    {
                        currentLength++;
                        diagonalX++;
                        diagonalY++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    maxSequenceType = "diagonal";
                    maxSequenceLength = currentLength;
                }
            }
        }
        if (maxSequenceType == "none")
        {
            Console.WriteLine("No sequences");
        }
        else
        {
            for (int i = 0; i < maxSequenceLength; i++)
            {
                Console.Write(array[maxSequenceXIndex, maxSequenceYIndex] + " ");
            }
        }
    }
}

