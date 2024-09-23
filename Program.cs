using Fundamentos_de_C_Sharp.Welcomes;
using Fundamentos_de_C_Sharp.Calculator;
using Fundamentos_de_C_Sharp.plateAuthenticator;
using Fundamentos_de_C_Sharp.CurrentDate;
using System.Globalization;

namespace Fundamentos_de_C_Sharp;

public class Program
{
     static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

        string name = Welcome.Name();
        Welcome.Message(name);

        try
        {

            Console.WriteLine("Agora vamos utilizar a calculadora");
            Console.WriteLine("Insira dois numeros abaixo os quais quer realizar as operações matematicas");

            Calculato calculator = new Calculato(number1:Console.ReadLine(), number2:Console.ReadLine());

            Console.WriteLine("Vamos começar utilizar a calculadora");

            Console.WriteLine($"A soma entre os numeros {calculator.Number1} + {calculator.Number2} é igual a {calculator.Sum()}");

            Console.WriteLine($"A subtração entre os numeros {calculator.Number1} - {calculator.Number2} é igual a {calculator.Subtraction()}");

            Console.WriteLine($"A multiplicação entre os numeros {calculator.Number1} * {calculator.Number2} é igual a {calculator.Multiplication()}");

            Console.WriteLine($"A divisão entre os numeros {calculator.Number1} / {calculator.Number2} é igual a {calculator.Division()}");

            Console.WriteLine($"A média entre os numeros (({calculator.Number1} + {calculator.Number2}) / 2) é igual a {calculator.Average()}");


            Console.WriteLine("Agora vamos realizar a contagem de caracter de qualquer item inserido abaixo");
            calculator.CountString(calculator.InsertText());

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); 
        }
       

        bool result = true;
        Console.WriteLine("Entrando no sistema de verificação de placas abaixo vamos verificar se a mesma é valida");
        do
        {
            if (!result)
            {
                Console.WriteLine("Insira o numero correto da placa por favor");
            }

            Console.WriteLine("Insira o numero da placa:");
            string plate = Console.ReadLine();
            AuthenticatorPlate authenticator = new AuthenticatorPlate(plate);
            result = authenticator.Authenticator();
        }

        while (result == false);
        


        Console.WriteLine("Agora vamos Apresentar a data de hoje e dia em varios formatos, segue abaixo a data ");

        CurrentDat date = new CurrentDat();
        date.CompletDate();
        date.PatternDate();
        date.ExtendedDate();
    }
   

}


