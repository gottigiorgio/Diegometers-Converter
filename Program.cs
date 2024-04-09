using System;

namespace ConvertitoreMisura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel convertitore di misura!");
            Console.WriteLine("Scegli l'unità di misura di partenza:");
            Console.WriteLine("1. Millimetro");
            Console.WriteLine("2. Centimetro");
            Console.WriteLine("3. Decimetro");
            Console.WriteLine("4. Metro");
            Console.WriteLine("5. Decametro");
            Console.WriteLine("6. Ettometro");
            Console.WriteLine("7. Kilometro");
            Console.Write("Scelta: ");
            int unitaDiMisuraDa = int.Parse(Console.ReadLine());

            Console.WriteLine("Scegli l'unità di misura di destinazione:");
            Console.WriteLine("1. Millidiegometri");
            Console.WriteLine("2. Centidiegometri");
            Console.WriteLine("3. Decidiegometri");
            Console.WriteLine("4. Diegometri");
            Console.WriteLine("5. Decadiegometri");
            Console.WriteLine("6. Ettodiegometri");
            Console.WriteLine("7. Kilodiegometri");
            Console.Write("Scelta: ");
            int unitaDiMisuraA = int.Parse(Console.ReadLine());

            Console.Write("Inserisci la lunghezza: ");
            double lunghezza = double.Parse(Console.ReadLine());

            double risultato = Converti(unitaDiMisuraDa, unitaDiMisuraA, lunghezza);
            Console.WriteLine($"Il risultato è: {risultato} {GetNomeUnitaDiMisura(unitaDiMisuraA)}");
        }

        static double Converti(int unitaDiMisuraDa, int unitaDiMisuraA, double lunghezza)
        {
            double fattoreConversione = GetFattoreConversione(unitaDiMisuraDa, unitaDiMisuraA);
            return lunghezza * fattoreConversione;
        }

        static double GetFattoreConversione(int unitaDiMisuraDa, int unitaDiMisuraA)
        {
            double[,] fattoriConversione = {
                {1, 0.157, 0.0157, 0.00157, 0.000157, 0.0000157, 0.000000157}, // millimetro
                {10, 1.57, 0.157, 0.0157, 0.00157, 0.000157, 0.0000157}, // centimetro
                {100, 15.7, 1.57, 0.157, 0.0157, 0.00157, 0.000157}, // decimetro
                {1000, 157, 15.7, 1.57, 0.157, 0.0157, 0.00157}, // metro
                {10000, 1570, 157, 15.7, 1.57, 0.157, 0.0157}, // decametro
                {100000, 15700, 1570, 157, 15.7, 1.57, 0.157}, // ettometro
                {1000000, 157000, 15700, 1570, 157, 15.7, 1.57} // kilometro
            };

            return fattoriConversione[unitaDiMisuraDa - 1, unitaDiMisuraA - 1];
        }

        static string GetNomeUnitaDiMisura(int unitaDiMisura)
        {
            string[] nomiUnitaDiMisura = {
                "millidiegometri",
                "centidiegometri",
                "decidiegometri",
                "diegometri",
                "decadiegometri",
                "ettodiegometri",
                "kilodiegometri"
            };

            return nomiUnitaDiMisura[unitaDiMisura - 1];
        }
    }
}
