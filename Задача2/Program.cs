// Внутри класса Answer напишите метод FindMax, 
// который принимает на вход три числа и выдаёт максимальное из этих чисел.
static void FindMax (int firstNumber, int secondNumber, int thirdNumber){
        int result = firstNumber;
        if (secondNumber>firstNumber){
            result = secondNumber;
        }
        else if(thirdNumber>secondNumber){
            result = thirdNumber;
        }
        else if(firstNumber>thirdNumber){
            result = firstNumber;
        }

         System.Console.WriteLine($"{result}");
    }
FindMax(6, 6, 10);