using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CaseExit = "exit";
            const string CaseSum = "sum";
            int[] array = new int[0];
            bool isEndProgram = false;
            int arraySum;

            while (isEndProgram == false)
            {
                Console.Clear();
                Console.WriteLine("Вы можете ввести либо число, которое добавится в массив, либо команду " + CaseSum + ", которая высчитает сумму чисел в массиве, либо команду " + CaseExit + ", для выхода из программы.");
                Console.WriteLine();
                Console.WriteLine("Введите команду или число: ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case CaseSum:
                        arraySum = 0;

                        for(int arrayIndex=0; arrayIndex < array.Length; arrayIndex++)
                        {
                            arraySum+=array[arrayIndex];
                        }

                        Console.WriteLine("Сумма элементов массива: " + arraySum);
                        Console.ReadKey();
                        break;
                    case CaseExit:
                        isEndProgram = true;
                        break;
                    default:
                        int[] arrayTemp = new int[array.Length + 1];

                        for (int arrayIndex=0; arrayIndex<array.Length; arrayIndex++)
                        {
                            arrayTemp[arrayIndex] = array[arrayIndex];
                        }

                        arrayTemp[arrayTemp.Length-1]= Convert.ToInt32(command);
                        array = arrayTemp;
                        break;
                }
            }
        }
    }
}