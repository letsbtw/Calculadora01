using System.Runtime.Intrinsics.Arm;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            string stop = "";
            string operation = "";
            decimal result = 0;


            Console.WriteLine("CALCULADORA");


            do {
                Console.WriteLine("MENU:");
                Console.WriteLine("Para fazer uma operação de soma, digite o sinal de soma.");
                Console.WriteLine("Para fazer uma operação de subtração, digite o sinal de subtração.");
                Console.WriteLine("Para fazer uma operação de multiplicação, digite o sinal de multiplicação.");
                Console.WriteLine("Para fazer uma operação de divisão, digite o sinal de divisão.");
                Console.WriteLine("Para desligar a calculadora, digite off.");
                operation = Console.ReadLine();

                if(operation == "off")
                {
                    break;
                }


                Console.WriteLine("Digite o primeiro número:");
                num1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                num2 = Convert.ToInt16(Console.ReadLine());

                    if (operation == "/" && num2 == 0){

                        Console.WriteLine("Qualquer número em divisão por 0 resultará nele mesmo. Escolha outro número.");
                        num2 = Convert.ToInt16(Console.ReadLine());

                    }   else if (operation == "*" && num2 == 0){

                            Console.WriteLine("Qualquer número em multiplicação por 0 resultará em 1. Escolha outro número.");
                            num2 = Convert.ToInt16(Console.ReadLine());
                        }


                    switch (operation) {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        case "off":
                            stop = "sim";
                            break;
                        default:
                            Console.WriteLine("Operação inválida.");
                            break;
                    }
                
             
                Console.WriteLine("O resultado é: " + result);
           
            } while (stop != "sim");

        
                
    
        }
    }
}
