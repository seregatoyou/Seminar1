// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, какое число большее, 
// а какое меньшее.
    static void CompareNumbers (int firstNumber, int secondNumber){
        //System.Console.WriteLine("Введите первое число: ");
        //int first = int.Parse(System.Console.ReadLine());
        //System.Console.WriteLine("Введите второе число: ");
        //int second = int.Parse(System.Console.ReadLine());
        if (firstNumber>secondNumber){
            System.Console.WriteLine("Первое число больше второго.");
        }
        else if(secondNumber>firstNumber){
            System.Console.WriteLine("Второе число больше первого.");
        }
        else if(firstNumber == secondNumber){
    System.Console.WriteLine($"Введенные числа равны {secondNumber}");
        }
    }
CompareNumbers(10, 5);