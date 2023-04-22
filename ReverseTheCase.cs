/*
A program to 
reverse the case of letters of 
a given string 
'lower case' -> 'upper case'
'upper case' -> 'lower case' 
*/ 
namespace CSharpProblemSolving
{
    class ReverseTheCase
    {
        public static string ReverseCase(string st)
        {
            string newSt="";
            for(int i = 0; i < st.Length; i++)
            {
                if ((int) st[i] >=97 && (int)st[i] <= 122)      //ASCII Code from a to z
                {
                    newSt += (char) ((int)st[i] - 32); 
                }
                else if ((int)st[i] >= 65 && (int)st[i] <= 90)  //ASCII Code from A to Z
                {
                    newSt += (char)((int)st[i] + 32);
                }
                else
                {
                    newSt += ' ';
                }
            }
            return newSt;
        }
        public static void Main(string[] args)
        {
            // Console.WriteLine((int) 'a'); //97
            // Console.WriteLine((int) 'z'); //122

            // Console.WriteLine((int)'A'); //65
            // Console.WriteLine((int)'Z'); //90

            Console.WriteLine(ReverseCase("Happy Birthday")); // hAPPY bIRTHDAY
            Console.WriteLine(ReverseCase("MANY THANKS"));    // many thanks
            Console.WriteLine(ReverseCase("sPoNtAnEoUs"));    // SpOnTaNeOuS
        }
    }
}
