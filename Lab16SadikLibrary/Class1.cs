namespace Lab16SadikLibrary;

public class Class1
{
    public static int[,] GenerateMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double a = Math.Pow(((7 + i) / (9.0 + j)), i - j) + Math.Exp(Math.Cos(j) - 3 * Math.PI);
                    matrix[i, j] = (int)a;
                }
            }

            return matrix;
        }

        public static double[] CalculateVector(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            double[] vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = 0;
                for (int j = 0; j < m; j++)
                {
                    vector[i] += matrix[i, j] * (j == i ? matrix[i, j] : 0);
                }
            }

            return vector;
        }

        public static int CalculateResult(double[] vector)
        {
            int maxIndex = 0, minIndex = 0;

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > vector[maxIndex])
                {
                    maxIndex = i;
                }
                else if (vector[i] < vector[minIndex])
                {
                    minIndex = i;
                }
            }

            return maxIndex * maxIndex * minIndex * minIndex;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintVector(double[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write($"{element,10:F4} ");
            }
        }
    }
