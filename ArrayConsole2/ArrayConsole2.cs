namespace OOPLab3
{
    internal class ArrayConsole2
    {
        static void Initialize(out int variable, string variableName)
        {
            bool isConvert;
            do
            {
                System.Console.Write($"Введіть {variableName}: ");
                isConvert = int.TryParse(System.Console.ReadLine(), out variable);

                if (!isConvert | variable == 0)
                {
                    System.Console.WriteLine("Введено некоректне значення! Будь ласка повторіть введення");
                }
                else
                {
                    break;
                }
            } while (true);
        }


        static void InitializeArray(ref double[,] array)
        {
            System.Random rand = new System.Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-28305, 12951) / 1000.0;
                }
            }
        }

        static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write($"{array[i, j],6} ");
                }
                System.Console.WriteLine();
            }
        }

        static void SwapArrayColon(ref double[,] array, int colA, int colB)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double temp = array[i, colA];
                array[i, colA] = array[i, colB];
                array[i, colB] = temp;
            }
        }

        static double SumCol(double[,] array, int Col)
        {
            double sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += System.Math.Abs(array[j, Col]);
            }
            return sum;
        }

        static void Main()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            System.Console.WriteLine("Лабораторна робота №3.");
            System.Console.WriteLine("Виконав: Грех В.В. група. СН-21");
            System.Console.WriteLine("Варіант 3");
            System.Console.WriteLine("Завдання 2.\n");

            double[,] array;
            int col, row;

            Initialize(out col, "кількість стовпців");
            Initialize(out row, "кількість рядків");

            array = new double[row, col];

            InitializeArray(ref array);
            System.Console.WriteLine();
            PrintArray(array);

            // -------------- Exercise 1 -------------- 
            double[] minElements = new double[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double min = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }

                minElements[i] = min;
            }

            // Вивівд мінімальних елементів
            foreach (var element in minElements)
            {
                System.Console.Write(element + " ");
            }
            System.Console.WriteLine();

            // Вивід максимального елемента з  мінімальних елементів рядків
            System.Console.WriteLine(minElements.Max());

            // -------------- Exercise 2 -------------- 
            for (int i = 0; i < array.GetLength(1); i += 2)
            {
                int index = 0;
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        double temp = array[i, j];

                        array[i, j] = array[i, index];
                        array[i, index++] = temp;
                    }
                }
            }
            System.Console.WriteLine("\nСтовпці матриці відсортовані в залежності від суми модулів її елементів:");
            PrintArray(array);

            System.Console.ReadKey();
        }
    }
}
