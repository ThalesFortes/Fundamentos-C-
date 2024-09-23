namespace Fundamentos_de_C_Sharp.Calculator;
public class Calculato
{
    public double Number1 { get; set; }

    public double Number2 { get; set; }
 
    public static (bool success, double newNumber1, double newNumber2) TryConvert(string number1, string number2)
    {
        bool success1 = double.TryParse(number1.Replace('.', ','), out double newNumber1);
        bool success2 = double.TryParse(number2.Replace('.', ','), out double newNumber2);

        return (success1 && success2, newNumber1, newNumber2);
    }


    public Calculato(string number1, string number2)
    {
        var (success, newNumber1, newNumber2) = TryConvert(number1, number2);

        if (!success)
        {
            throw new ArgumentException("As entradas não são válidas. Insira um numero");
        }


        Number1 = newNumber1;
        
        Number2 = newNumber2;
    }



    public double Sum() => Number1 + Number2;

    public double Subtraction() => Number1 - Number2;

    public double Multiplication() => Number1 * Number2;

    public double Division() => Number2 == 0 ? Number1 : Number1 / Number2;

    public double Average() => (Number1 + Number2) / 2;

    public string InsertText()
    {
        Console.WriteLine("Insira qualquer coisa abaixo:");
        string text = Console.ReadLine();
        return text;
    }

    public void CountString(string text)
    {
        var textResult = text.Replace(" ","");
        var result = textResult.Count();
        Console.WriteLine($"O texto ou palavra digitada possui {result} caracters, sem contar os espaçoes em branco.");
    }

}
