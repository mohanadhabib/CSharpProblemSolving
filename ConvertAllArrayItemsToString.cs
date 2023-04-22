/*
A program 
that convert all elements
of an array of objects
into an array of strings 
and print value : type pair of each element
*/


namespace CSharpProblemSolving
{
    class ConvertAllArrayItemsToString
    {

        public static string[] ParseArray(object[] arr)
        {
            string[] newArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                    newArr[i] = arr[i].ToString()!;
            }
            return newArr;  
        }
        public static void PrintNewArray(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(ParseArray(arr)[i] + ":" + ParseArray(arr)[i].GetType().Name);
            }
            Console.WriteLine("--------");
        }

        public static void Main(string[] args)
        {
            object[] arr = { 1, 2, "a", "b" };
            PrintNewArray(arr);
            /*
             1:String
             2:String
             a:String
             b:String
             */
            object[] arr2 = { "abc", 123, "def", 456 };
            PrintNewArray(arr2);
            /*
             abc:String
             123:String
             def:String
             456:String
             */
            object[] arr3 = { 1, 2, 3, 17, 24, 3, "a", "123b" };
            PrintNewArray(arr3);
            /*
             1:String
             2:String
             3:String
             17:String
             24:String
             3:String
             a:String
             123b:String
             */
            object[] arr4 = { };
            PrintNewArray(arr4);
            /*
              
             */
        }
    }
}
