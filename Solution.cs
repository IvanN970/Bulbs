using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Bulbs
{
    class Program
    {
        static void FillArray(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool IsValidInput(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]!=1 &&  array[i]!=0)
                {
                    return false;
                }
            }
            return true;
        }
        static int GetFirstNotLitBulbPosition(int[] array,int startPosition)
        {
            for(int i=startPosition;i<array.Length;i++)
            {
                if(array[i]==0)
                {
                    return i;
                }
            }
            return -1;
        }
        static void ChangeBulbState(int[] array,int position)
        {
            for(int i=position;i<array.Length;i++)
            {
                if(array[i]==0)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = 0;
                }
            }
        }
        static void PrintArray(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int CountNumberOfSwitchesNeeded(int[] array)
        {
            int counter = 0, startIndex = 0, position;
            if(IsValidInput(array)==false)
            {
                Console.WriteLine("Array is not in a valid format");
            }
            else
            {
                while (true)
                {
                    position=GetFirstNotLitBulbPosition(array, startIndex);
                    if(position==-1)
                    {
                        break;
                    }
                    ChangeBulbState(array, position);
                    counter++;
                    startIndex = position;
                }
            }
            return counter;
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter length of the array:");
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Number of switches needed is:" + " " + CountNumberOfSwitchesNeeded(array));
        }
    }
}
