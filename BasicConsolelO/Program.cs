using System;

namespace BasicConsolelO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeMetod();

            Console.WriteLine();
            Console.ReadLine();
        }

        private static void SomeMetod()
        {
            Console.WriteLine("=> Jagged multidimensional array."); 
            
            // Зубчатый многомерный массив (т.е. массив массивов). 
            // Здесь мы имеем массив из 5 разных массивов,
            int[] [] myJagArray = new int [5] []; 
            
            // Создать зубчатый массив.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray [i] = new int[i + 7];

            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
