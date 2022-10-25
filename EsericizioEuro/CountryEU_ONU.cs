using System;

namespace EsericizioEuro
{
    internal class CountryEU_ONU : Country, UnioneEuropea, ONU, CorteEuropea
    {
        public CountryEU_ONU(int popolazione, float areaGeografica, string continente, string nome, string costituzione, string bandiera, string moneta, string linguaUfficiale, float pil, bool penaMorte) : base(popolazione, areaGeografica, continente, nome, costituzione, bandiera, moneta, pil, penaMorte, linguaUfficiale)
        {

        }
        public void monetaUnica()
        {
            if (this._moneta.ToLower() == "euro")
                Console.WriteLine   (this._nome+" e un paese con moneta unica");
            else Console.WriteLine(this._nome+"non e un paese con moneta unica");
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

        public void OMS()
        {
            Console.WriteLine("Questo paese aderisce all'OMS");
        }

        public void FMI()
        {
            Console.WriteLine("Questo paese aderisce al FMI");
        }

        public void PenaMorte()
        {
            if (this._penamorte)
                Console.WriteLine("Questo paese non rispetta i diritti umani");
            else Console.WriteLine("Questo paese rispetta i diritti umani");

        }
    
        public void calculateSpread()
        {
            Random random = new Random();
            
               

            Console.WriteLine("SPREAD: "+this._pil + random.Next(100, 300));

        }


    }



   
}
