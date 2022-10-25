namespace EsericizioEuro
{
    abstract public class Territory
    {
        private int _popolazione;
        private float _areaGeografica;
        private string _continente;

        public Territory(int popolazione,float areaGeografica,string continente)
        {
            _continente = continente;
            _popolazione = popolazione;
            _areaGeografica = areaGeografica;
        }
    }    

}
