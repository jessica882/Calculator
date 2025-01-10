using System.Numerics;

class MainOptionChoose
{
    public static void mainMenuOption()
    {
        while (true)
        {
            Console.WriteLine("Enter your choice:");
            double choice = Input.integerValidity();
        
            switch(choice)
            {
                case 1:
                BasicCalculation.calculation();
                break;

                case 2:
                string infixExpression = Input.arithmeticExpressionInput();
                string postfixExpression = PostfixConversion.postfixExpression(infixExpression);
                PostfixEvaluation.postfixEvaluationResult(postfixExpression);
                break;

                case 3:
                Menu.trigonometricMenu();
                ScientificCalculation.calculation();
                break;

                case 5:
                return;
            }

        }
        
    }
}