using System.Collections;

class PostfixConversion: Stack
{
    public static bool validOperator(char character)
    {
        return character == '+' || character == '-' || character == '*' || character == '/' || character == '^' || character == '$' ;
    }

    public static int operatorPrecedence(char character)
    {
        if(character == '+' || character == '-')
        {
            return 1;
        }
        else if(character =='*' || character == '/')
        {
            return 2;
        }
        else if(character =='^' || character == '$')
        {
            return 3;
        }
        else
        return 0;
    }

    public static string postfixExpression()
    {
        string expression = Input.arithmeticExpressionInput();
        Stack<char> stack = new();
        string postfix = "";

        foreach(char ch in expression)
        {
            if(char.IsDigit(ch))
            {
                postfix += ch;
            }
            else if(ch == '(')
            {
                stack.Push(ch);
            }
            else if(ch == ')')
            {
                while(stack.Count >0 && stack.Peek() == '(')
                {
                    postfix += stack.Pop();
                }
                stack.Pop();
            }
            else if(validOperator(ch))
            {
                while (stack.Count >0 && stack.Peek()  >= operatorPrecedence(ch))
                {
                    postfix += stack.Pop();
                }
                stack.Push(ch);
            }
        }
        while(stack.Count > 0)
        {
            postfix+=stack.Pop();
        }
        return postfix;
    }
}