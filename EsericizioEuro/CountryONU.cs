using System;

namespace EsericizioEuro
{
    internal class CountryONU : Country, ONU { 
        public CountryONU(int popolazione, float areaGeografica, string continente, string nome, string costituzione, string bandiera, string moneta, string linguaUfficiale, float pil, bool penaMorte) : base(popolazione, areaGeografica, continente, nome, costituzione, bandiera, moneta, linguaUfficiale, pil, penaMorte)
    {

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
    }



}
