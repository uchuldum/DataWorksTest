using System;

namespace DataWorks.ParenthesesBalance
{
    public class BalanceParantheses
    {
        public bool CheckBalance(string parantheses)
        {
            int count = 0;
            for(int i = 0; i < parantheses.Length; i++)
            {
                if (parantheses[i] == '(')
                    count += 1;
                else if (parantheses[i] == ')')
                    count -= 1;
            }
            if (count == 0) return true;
            return false;
        }
    }
}
