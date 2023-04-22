/*
A program that 
print an array of indexes
of the letters with upper case ' Capital letters ' 
found in a string
*/

using System.Collections;

namespace CSharpProblemSolving
{
    class IndexOfAllCapitalLetters
    {
        public static void IndexOfCapitals(string st)
        {
            ArrayList arr = new ArrayList();
            for (int i = 0; i < st.Length; i++)
            {
                if ((int)st[i] >= 65 && (int)st[i] <= 90)
                {
                    arr.Add(i);
                }
            }
            Console.Write("[ ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine("]");
        }
        public static void Main(string[] args)
        {
            IndexOfCapitals("eDaBiT");     // [ 1 3 5 ]
            IndexOfCapitals("eQuINoX");    // [ 1 3 4 6 ]
            IndexOfCapitals("determine");  // [ ]
            IndexOfCapitals("STRIKE");     // [ 0 1 2 3 4 5 ]
            IndexOfCapitals("sUn");        // [ 1 ]
        }
    }
}
