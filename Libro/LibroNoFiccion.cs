using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    public class LibroNoFiccion:Libro1
    {
        protected string tema;

       
        public LibroNoFiccion(string titulo, string autor, int anioPublicacion, string tema) :base(titulo, autor, anioPublicacion)
        {
            this.tema = tema;
            this.autor = autor;
            this.titulo = titulo;
            this.anioPublicacion = anioPublicacion;
        }
        public LibroNoFiccion(string titulo, string autor, int anioPublicacion) : base(titulo, autor, anioPublicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.anioPublicacion= anioPublicacion;
        }

        public void ImprimirInformacion()
        {
            Console.WriteLine("Titulo: " + this.titulo + " Autor: " + this.autor + " Año de publicacion: " + this.anioPublicacion +"Tema: "+ this.tema);
        }
        public void EstablecerTema(string Tema)
        {
            
            this.tema =Tema;
        }

    public string ObtenerTema()
        {
            return this.tema;
        }
    }
}
