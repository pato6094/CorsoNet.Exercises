namespace EsericizioEuro
{
     public class Country : Territory
    {
       protected string _costituzione;
       protected string _bandiera;
       protected string _moneta;
       protected string _linguaufficiale;
       protected float  _pil;
       protected bool   _penamorte;
       protected string _nome;

        public Country(int popolazione, float areaGeografica, string continente,string costituzione, string bandiera, string moneta, string linguaufficiale, float pil, bool penamorte,string nome):base(popolazione,areaGeografica,continente)
        {
            _costituzione = costituzione;
            _bandiera = bandiera;
            _pil = pil;   
            _moneta = moneta;
            _linguaufficiale = linguaufficiale;
            _penamorte = penamorte;
            _nome = nome;
            

        }
             
    }
    

}
