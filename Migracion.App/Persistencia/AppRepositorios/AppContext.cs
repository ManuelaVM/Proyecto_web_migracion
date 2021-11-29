using Microsoft . EntityFrameworkCore ;
using Dominio ;

namespace Persistencia{

    /*El nombre de la clase no debe ser el mismo que el archivo en C# pero por 
    buenas practicas lo voy a poner*/
    public class AppContext : DbContext{

        public DbSet <Migrante> migrantes {get;set;}
        public DbSet <Necesidades> necesidads {get;set;}
        
        public DbSet <Evaluar> evaluacion {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        
            
            if ( ! optionsBuilder . IsConfigured ){
            

                 optionsBuilder . UseSqlServer ("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MigrantesData");
               // optionsBuilder . UseSqlServer ( " Fuente de datos = (localdb) \\ MSSQLLocalDB; Catálogo inicial = Migrantes " );
            }
        }
    }
}