using System.Numerics;

class OptionChoose
{
    public static void mainMenuOption()
    {
        
        double choice = Input.integerValidity();
       
        switch(choice)
        {
            case 1:
            BasicCalculation.calculation();
            break;

            case 2:
            Menu.trigonometricMenu();
            ScientificCalculation.calculation();
            break;



        }
        
    }
}