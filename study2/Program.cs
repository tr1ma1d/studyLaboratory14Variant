using System;

namespace lab1_2023
{
   
    class Matrix
    {
        int[,] data;
        int[,] bata;
        int sum;

        public void GererateMatrix(int m, int n)
        {
            Console.WriteLine("-------------------MATRIX----------------BY_NIKITA<3");
            int x = m;
            int y = n;
            data = new int[m, n];
            Random rnd = new Random();
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    data[i, j] = rnd.Next(1, 10);
                    
                    
                }
                
               
                
            }
            Console.WriteLine();
            Print(x, y);
            Transsform(x, y);
            Console.WriteLine();
        }
        
        public void Print(int m, int n)
        {
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{data[i, j]} \t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        void Transsform(int m, int n) 
        {
            Console.WriteLine("-------------------TRANSFORMMATRIX----------------BY_NIKITA<3");
            bata = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bata[i,j] = data[j ,i];
                    Console.Write($"{bata[i, j]} \t");
                }
                Console.WriteLine();
            
            }
            Console.WriteLine();
            Middle_Arifmetics(m,n);
            
        }
        void Middle_Arifmetics(int m,int n)
        {

            Console.WriteLine("----------------------OMG------------------------------BY_NIKITA<3");
            sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum+= data[j ,i];
                }
                

            }
            Console.WriteLine($"Не среднеарифметическое число: {sum}" );
            Console.WriteLine($"Среднеарифметичкое число: {sum / bata.Length}");



        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            Matrix matr = new Matrix();
            matr.GererateMatrix(x, y);
            
        }
    }
}