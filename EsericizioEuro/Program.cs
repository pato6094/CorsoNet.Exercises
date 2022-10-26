using System;
using System.Globalization;

namespace EsericizioEuro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryEU_ONU italiaCountry = new CountryEU_ONU(60000, 324000, "Europa", "Italia", "Costituzione Italiana", "VerdeBiancoRosso", "Euro", "Italiano", 100, false);
            CountryEU_ONU franciaCountry = new CountryEU_ONU(67000, 675000, "Europa", "Francia", "Costituzione Francesce", "BluBiancoRossa", "Euro", "Francese", 150, false);
            CountryEU_ONU germaniaCountry = new CountryEU_ONU(83001, 35700, "Europa", "Germania", "Legge Fondamentale", "NeraGiallaRossa", "Euro", "Tedesco", 180, false);
            CountryONU cinaCountry = new CountryONU(150000, 9706000, "Asia", "Cina", "Costituzione Cinese", "RossoGiallo", "Renmimbi Cinese", "Cinese Mandarino", 43, true);
            
            Console.WriteLine("Italia");
            italiaCountry.PenaMorte();
            italiaCountry.calculateSpread();
            italiaCountry.monetaUnica();
            italiaCountry.checkEuroZona();
            Console.WriteLine("-----");
            
            Console.WriteLine("Cina");
            cinaCountry.PenaMorte();
            
            Console.WriteLine("-----");

        }
    }
}
