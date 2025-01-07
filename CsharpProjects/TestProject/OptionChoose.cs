using System.Numerics;

class OptionChoose
{
    public static void mainMenuOption()
    {
        Console.WriteLine("Enter your choice:");
        double choice = Input.integerValidity();

       
        switch(choice)
        {
            case 1:
            BasicCalculation.calculation();
            break;

        }
        
    }
}