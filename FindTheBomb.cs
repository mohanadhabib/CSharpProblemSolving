/*
A program 
that return word 'Duck!!!'
if there is word 'bomb' in the given string 
otherwise it would return word 'There is no bomb, relax.'
*/
namespace CSharpProblemSolving
{
    class FindTheBomb
    {

        public static string Bomb(string st)
        {
            string res;
            if (st.Contains("bomb")||st.Contains("Bomb")||st.Contains("BOMB"))
            {
                res = "Duck!!!";
            }
            else
            {
                res = "There is no bomb, relax.";
            }
            return res;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Bomb("There is a bomb."));                    // Duck!!!
            Console.WriteLine(Bomb("Hey, did you think there is a bomb?")); // Duck!!!
            Console.WriteLine(Bomb("This goes boom!!!"));                   // There is no bomb, relax.

        }
    }
}
