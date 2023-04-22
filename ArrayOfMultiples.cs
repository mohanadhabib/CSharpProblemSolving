/*
 A C# Program to print the array
 of multiples of a given number 
 based on a given length 
*/
namespace CSharpProblemSolving
{
    class ArrayOfMultiplesClass
    {
        public static void ArrayOfMultiples(int num , int length)
        {
            int[] array = new int[length];
            for (int i = 0 ; i < length ;i++)
            {
                array[i] = num * (i+1);
            }
            Console.Write("[ ");
            for(int i = 0 ; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");    
            }
            Console.WriteLine("]"); 
        }
        public static void Main(string[] args) 
        {
            ArrayOfMultiples(7,5);     // [ 7 14 21 28 35 ]
            ArrayOfMultiples(12, 10);  // [ 12 24 36 48 60 72 84 96 108 120 ]
            ArrayOfMultiples(17, 6);   // [ 17 34 51 68 85 102 ]
        }
    }
}