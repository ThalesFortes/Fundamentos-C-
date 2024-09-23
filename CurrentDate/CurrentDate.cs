using System.Globalization;

namespace Fundamentos_de_C_Sharp.CurrentDate;
public class CurrentDat
{
    public DateTime Date { get; set; }

    public CurrentDat() 
    {
        Date = DateTime.Now;
    }

    public void CompletDate()
    {
        string[] diasDaSemana = new [] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };

        int diasDaSemanaIndex = (int)Date.DayOfWeek;

        Console.WriteLine($"{Date.ToString(new CultureInfo("pt-BR"))} hoje é  {diasDaSemana[diasDaSemanaIndex]}");

    }

    public void PatternDate() => Console.WriteLine($"A data de hoje é {Date.ToString("dd/MM/yyyy")}");

    public void Hour() => Console.WriteLine($"Agora são {Date.ToString("HH/mm/ss")} horas");

    public void ExtendedDate() => Console.WriteLine($"{Date.ToLongDateString()}");






}
