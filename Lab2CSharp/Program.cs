namespace Lab2CSharp
{
     class Program
    {
        static void task1_1()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
                        double sum = 0;

            foreach (int element in myArray)
            {
                sum += element;
            }

            double average = sum / n;
            Console.WriteLine($"Arithmetic average of array elements: {average}");
        
    }
        static void task1_2()
        {
            Console.WriteLine("Enter the size of the array:");
            Console.WriteLine("n:");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m:");
            int m = int.Parse(Console.ReadLine());

            int[,] myArray = new int[n, m];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            double sum = 0;

            foreach (int element in myArray)
            {
                sum += element;
            }
            double average = sum / (n * m);

            Console.WriteLine($"Arithmetic average of array elements: {average}");
    }
 static void task1_3()
 {
     Console.WriteLine("Enter the size of the array:");
     int n = int.Parse(Console.ReadLine());

     double[] myArray = new double[n];

     Console.WriteLine("Enter the elements:");

     for (int i = 0; i < n; i++)
     {
         Console.Write($"a[{i}] = ");
         myArray[i] = double.Parse(Console.ReadLine());
     }
     double max = myArray[0];
     for (int i = 1; i<n; i++)
     {
         if (myArray[i] > max)
         {
             max = myArray[i];
         }
     }
     Console.WriteLine("Numbers of all elements that do not match the maximum:");
     for (int i = 0; i < n; i++)
     {
         if (myArray[i] != max)
         {
             Console.WriteLine(i);
         }
     }
 }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab2");
            Console.WriteLine("Please input task");
            Console.Write("Task=");

            byte n = byte.Parse(Console.ReadLine());
            switch (n) {
                case 1: task1_1(); break;
                case 2: task1_2(); break;
                case 3: task1_3(); break;
               //case 4: task1_4(); break;
               //case 5: task1_5(); break;

            }
        }
    }
}
