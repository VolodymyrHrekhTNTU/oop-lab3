namespace OOPLab3
{
    internal class Program
    {
        public static void Initialize(ref double[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i] = rand.Next(-153, 533) / 10.0;
                }
            }
        }

        static void Main(string[] args)
        {

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            System.Console.WriteLine("Лабораторна робота №3.");
            System.Console.WriteLine("Виконав: Грех В.В. група. СН-21");
            System.Console.WriteLine("Варіант 3");
            System.Console.WriteLine("Завдання 1.\n");

            int size;
            bool isConvert;

            do
            {
                System.Console.Write("Введіть розмір масиву: ");
                isConvert = int.TryParse(System.Console.ReadLine(), out size);

                if (!isConvert || size <= 0)
                {
                    System.Console.WriteLine("Введено некоректне значення! Будь ласка повторіть введення");
                }
                else
                {
                    break;
                }
            } while (true);

            double[] array = new double[size];

            Initialize(ref array);

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] - (int)array[i] >= 0.5)
                {
                    sum += System.Math.Abs(array[i]);
                }
            }

            Console.WriteLine("Масив: ");
            foreach (var ele in array)
            {
                System.Console.Write(ele + " ");
            }
            System.Console.WriteLine();


            System.Console.WriteLine("Сума модулів елементів, які мають дробову частину більшу або рівну 0.5: ");
            System.Console.WriteLine(sum);

            int middleEle = array.Length / 2;

            Array.Sort(array, middleEle, array.Length - middleEle);
            Array.Reverse(array, middleEle, array.Length - middleEle);

            System.Console.WriteLine("Впорядкування другої половину масиву за спаданням значень елементів:");
            foreach (var ele in array)
            {
                System.Console.Write(ele + " ");
            }
            System.Console.WriteLine();
        }
    }
}