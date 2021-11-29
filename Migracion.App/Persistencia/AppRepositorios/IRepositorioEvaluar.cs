using  System ;
using  System.Collections.Generic ;
using  Dominio ;

namespace Persistencia{

    public interface IRepositorioEvaluar
    {

        //Por el momento solo voy a poner add y consultar
        Evaluar AddEvaluar (Evaluar evaluar );
        //Evaluar  GetEvaluar ( string  Numero_identificacion);
    }
}