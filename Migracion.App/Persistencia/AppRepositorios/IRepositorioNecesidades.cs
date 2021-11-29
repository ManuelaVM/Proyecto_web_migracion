using  System ;
using  System.Collections.Generic ;
using  Dominio ;

namespace Persistencia{

    public interface IRepositorioNecesidades
    {

        //Por el momento solo voy a poner add y consultar
        Necesidades AddNecesidad (Necesidades necesidades );
        Necesidades  GetNecesidad ( string  Numero_identificacion);
    }
}