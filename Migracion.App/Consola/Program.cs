using System;
using Dominio;
using Persistencia;

namespace Consola
{
    class Program
    {
        static private    IRepositorioMigrantes  _repoMigrantes =  new  RepositorioMigrantes ();

        static void Main(string[] args)
        {
       
        AddMigrantes();          
                                  
        }
            
        

         //Proceso Municipio

         private static  void AddMigrantes () 
         {
            var  migrante  =  new  Migrante
            {
                Nombre = "Manuela",
                Apellidos = "Polo",
                Tipo_identificacion = "Pasaporte",
                Numero_identificacion = "100369",
                Pais_origen = "Venezula",
                Fecha_nacimiento ="10/10/1993",
                Direccion_electronica = "",
                Numero_telefono = "",
                Direccion_actual = "",
                Situacion_laboral = "Estudiante"
                
            };
            _repoMigrantes . AddMigrantes ( migrante );
        }
    }
}
                   
               
         
      
     




         
        