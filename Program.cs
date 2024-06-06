using System;
using System.Globalization;

public enum Moeda
{
    Real,
    Euro,
    Iene,
    Libra,
    Dolar
}

class ConversorMoeda
{
    private static readonly decimal[,] taxasDeCambio =
    {
        {1.0m, 0.19m, 0.20m, 23.30m, 0.15m }, //Real
        {5.30m, 1.0m, 1.60m, 124.25m, 0.85m }, //Euro
        {5.0m, 0.94m, 1.0m, 117.33m, 0.80m }, //Dolar
        {0.043m, 0.0080m, 0.0085m, 1.0m, 0.0068m }, //Iene
        {6.27m, 1.18m, 1.25m, 146.25m, 1.0m }, //Libra
    };

    public static decimal Conversor(decimal valor, Moeda de, Moeda para)
    {
        if (de == para) return valor;
        decimal taxa = taxasDeCambio[(int)de, (int)para];
        return valor * taxa;
    }

    public static string FormatarMoeda(decimal valor, Moeda moeda)
    {
        CultureInfo culture = moeda switch
        {
            Moeda.Real => new CultureInfo("pt-BR"),
            Moeda.Euro => new CultureInfo("fr-FR"),
            Moeda.Dolar => new CultureInfo("en-US"),
            Moeda.Iene => new CultureInfo("ja-JP"),
            Moeda.Libra => new CultureInfo("en-GB"),
            _ => CultureInfo.InvariantCulture
        };
        return string.Format(culture, "{0,C}", valor);
    }

    class Program
    {
         static void Main()
        {
            decimal valorOriginal = 100.0m;
            Moeda moedaOrigem = Moeda.Real;
            Moeda moedaDestino = Moeda.Dolar;

            decimal valorConvertido = ConversorMoeda.Conversor(valorOriginal, moedaOrigem, moedaDestino);
            Console.WriteLine($"{valorOriginal} {moedaOrigem} é igual a {valorConvertido} {moedaDestino}");
        }
        static void Main2()
        {
            decimal valorOriginal = 100.0m;
            Moeda moedaOrigem = Moeda.Real;
            Moeda moedaDestino = Moeda.Dolar;

            decimal valorConvertido = ConversorMoeda.Conversor(valorOriginal, moedaOrigem, moedaDestino);
            Console.WriteLine($"{valorOriginal} {moedaOrigem} é igual a {valorConvertido} {moedaDestino}");
        }
    }
}


