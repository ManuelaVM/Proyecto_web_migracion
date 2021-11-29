using  System . Collections . Generic ;
using   Dominio ;


namespace  Persistencia
{
    public class RepositorioEvaluar : IRepositorioEvaluar
    {
        //este es el constructor
        private  readonly  AppContext  _appContext  =  new  AppContext ();
        

    
         
        
       public  Evaluar  AddEvaluar ( Evaluar  evaluar )
        {
            var  evaluarAdicionado  =  _appContext.evaluacion.Add ( evaluar );
            _appContext . SaveChanges (); //Guardo 
            return  evaluarAdicionado . Entity ;
        }
        
        

        
    }
}