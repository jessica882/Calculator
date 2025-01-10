using System.Collections;

class PostfixEvaluation: Stack
{
    public static double postfixEvaluationResult(string postfix)
    {

        Stack<double> stack = new();
        
        foreach(char ch in postfix)
        {
            if(char.IsDigit(ch))
            {
                stack.Push(ch);
            }
            else if(PostfixConversion.validOperator(ch))
            {
                double operand1 = stack.Pop();
                double operand2 = stack.Pop();

                double result = 0;

                if(ch == '+')
                {
                    result = operand2 + operand1;
                }
                else if (ch == '-')
                {
                    result = operand2 - operand1;
                }
                else if (ch == '*')
                {
                    result = operand2 * operand1;
                }
                else if(ch == '/')
                {
                    result = operand2 / operand1;
                }
                else
                {
                    result = Math.Pow(operand2, operand1);
                }

                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}