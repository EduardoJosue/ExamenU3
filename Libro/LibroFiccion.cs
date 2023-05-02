using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    public class LibroFiccion : Libro1
    {

        protected string genero;
       
        public LibroFiccion(string titulo, string autor, int anioPublicacion, string genero) : base(titulo, autor, anioPublicacion)
        {
            this.genero = genero;
        }
        public LibroFiccion(string titulo, string autor, int anioPublicacion): base(titulo, autor, anioPublicacion)
            
        { 

        }

        public void ImprimirInformcion()
        {
            Console.WriteLine("Titulo: " + this.titulo + " Autor: " + this.autor + " Año de publicacion: " + this.anioPublicacion+ "Genero"+genero);
            Console.WriteLine(genero);
        }

        public void EstablecerGenero(string Genero)
        {
 
            this.genero = Genero;

        }
        public string ObtenerGenero()
        {
            return this.genero;
        }
        

        


    }
}
