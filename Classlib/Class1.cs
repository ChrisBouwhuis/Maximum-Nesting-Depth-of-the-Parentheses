namespace Classlib
{
    public class Solution
    {
        public int MaxDepth(string s)
        {
            int max = 0;
            int count = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                    max = count > max ? count : max;
                }
                else if (c == ')')
                {
                    count--;
                }
            }
            return max;
        }
    }
}
