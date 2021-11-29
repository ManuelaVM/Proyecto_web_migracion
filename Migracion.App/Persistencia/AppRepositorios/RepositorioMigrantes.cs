using  System . Collections . Generic ;
using   Dominio ;


namespace  Persistencia
{
    public class RepositorioMigrantes : IRepositorioMigrantes
    {
        //este es el constructor
        private  readonly  AppContext  _appContext  =  new  AppContext ();
        

    
         
        
       public  Migrante  AddMigrantes ( Migrante  migrantes )
        {
            var  migranteAdicionado  =  _appContext . migrantes . Add ( migrantes );
            _appContext . SaveChanges (); //Guardo 
            return  migranteAdicionado . Entity ;
        }
        
        

        public  Migrante  GetMigrante ( string Numero_identificacion ) 
        {
            return _appContext . migrantes . Find ( Numero_identificacion );
        }

        
    }
}