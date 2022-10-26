using System;

namespace EsericizioEuro
{
    internal class CountryUE : Country, UnioneEuropea
    {
        public CountryUE(int popolazione, float areaGeografica, string continente, string nome, string costituzione, string bandiera, string moneta, string linguaUfficiale, float pil, bool penaMorte) : base(popolazione, areaGeografica, continente, nome, costituzione, bandiera, moneta, linguaUfficiale, pil, penaMorte)
        {

        }
        public void monetaUnica()
        {
            if (this._moneta.ToLower() == "euro")
                Console.WriteLine(" e un paese con moneta unica");
            else Console.WriteLine("non e un paese con moneta unica");
        }

        public void costituzioneEuro()
        {
            Console.WriteLine("Questo paese aderisce alla Costituzione Europea");
        }

        public void EMA()
        {
            Console.WriteLine("Questo paese aderisce all'EMA");
        }

        public bool checkEuroZona()
        {
            if (this._moneta.ToLower().Contains("euro"))
                return true;
            else return false;
        }

        public void calculateSpread()
        {
            Random random = new Random();



            Console.WriteLine("SPREAD: " + this._pil + random.Next(100, 300));
           

        }

        public void PenaMorte()
        {
            if (this._penamorte)
                Console.WriteLine("Questo paese non rispetta i diritti umani");
            else Console.WriteLine("Questo paese rispetta i diritti umani");

        }
    }
}
