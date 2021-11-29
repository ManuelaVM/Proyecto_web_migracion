using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Necesidades
    {
        public int Id {get; set;}

        //Descripcion del servicio
        public string Salud {get; set;}

        //Aqui se escoge con un combo box si es bueno, malo o regular
        public string Clasificacion_Salud {get; set;}

        //Descripcion del servicio
        public string  Alimentacion {get; set;}

        //Aqui se escoge con un combo box si es bueno, malo o regular
        public string  Clasificacion_Alimentacion {get; set;}

        //Descripcion del servicio
        public string Empleo  {get; set;}

        //Aqui se escoge con un combo box si es bueno, malo o regular
        public string Clasificacion_Empleo  {get; set;}

        //Descripcion del servicio
        public string Alojamiento_temporal  {get; set;}

        
        //Aqui se escoge con un combo box si es bueno, malo o regular
        public string Clasificacion_Alojamiento_temporal  {get; set;}

        //Descripcion del servicio
        public string Alojamiento_permanente {get; set;}

        //Aqui se escoge con un combo box si es bueno, malo o regular
        
        public string Clasificacion_Alojamiento_permanente  {get; set;}

        //Descripcion del servicio
        public string Educacion {get; set;}

        //Aqui se escoge con un combo box si es bueno, malo o regular
        public string Clasificacion_Educacion {get; set;}

        //Descripcion del servicio
        public string Ayuda_legal {get; set;}

        //Aqui se escoge con un combo box si es bueno, malo o regular
        public string Clasificacion_Ayuda_legal {get; set;}

    }
}