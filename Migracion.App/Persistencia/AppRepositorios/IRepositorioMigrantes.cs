using  System ;
using  System.Collections.Generic ;
using  Dominio ;

namespace Persistencia{

    public interface IRepositorioMigrantes
    {

        //Por el momento solo voy a poner add y consultar
        Migrante AddMigrantes (Migrante migrantes );
        Migrante  GetMigrante ( string  Numero_identificacion);
    }
}