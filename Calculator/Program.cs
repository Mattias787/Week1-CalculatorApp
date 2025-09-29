// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter first number followed by the enter key");
int firstNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the operation (+, -, *, /): ");

char operation = Convert.ToChar(Console.ReadLine());
int result = 0;

 switch (operation)
   
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }
Console.WriteLine($"Result: {result});
 }
                  
                
                  


Console.WriteLine("adding {0} and {1} equals {2}", firstNumber, secondNumber, Result);
