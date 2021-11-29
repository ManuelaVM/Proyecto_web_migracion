using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Dominio 
{

    public class Migrante{

        //aqui prestendo que l numero de identificacion sea la llave foranea
        public int Id {get;set;}
        [Required]
        public string Nombre {get;set;}

        [Required]
        public string Apellidos {get;set;}
        [Required]
        public string Tipo_identificacion {get;set;}

        [Required]
        public string Numero_identificacion {get;set;}

        [Required]
        public string Pais_origen {get;set;}

        [Required]
        public string Fecha_nacimiento {get;set;}

        //Los siguientes datos no son obligatorios por llenar
        public string Direccion_electronica {get;set;}
        public string Numero_telefono {get;set;}
        public string Direccion_actual {get;set;}

        public string Ciudad  {get;set;}
        public string Situacion_laboral {get;set;}
  }
}