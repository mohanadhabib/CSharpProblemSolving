/*
A program 
that check the equality 
of two objects
they must be of the same value and type to return true
otherwise it would return false
*/ 

namespace CSharpProblemSolving
{
    class EqualityCheck
    {

        public static bool CheckEquality(object a ,object b)
        {
            if(a.GetType() == b.GetType())
            {
                if (a.Equals(b))
                {
                    return true;
                }
                else
                {
                    return false;   
                }
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(CheckEquality(1,true)); 
            // False  
            // same value but different type 
            Console.WriteLine(CheckEquality(0, "0")); 
            // False
            // same value but different type
            Console.WriteLine(CheckEquality(1, 1));   
            // True
            // same value with same type
        }
    }
}
