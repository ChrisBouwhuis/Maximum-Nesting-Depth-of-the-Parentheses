using Classlib;
namespace Maximum_Nesting_Depth_of_the_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            string s = "(1+(2*3)+((8)/4))+1";
            System.Console.WriteLine(sol.MaxDepth(s));
        }
    }
}
