using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    public class Libro1
    {
        protected string titulo;
        protected string autor;
        protected int anioPublicacion;

        public Libro1() { }

        public Libro1(string titulo, string autor, int anioPublicacion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
        }

        public void imprimirInformacion()
        {
            Console.WriteLine("Titulo: " + this.titulo + " Autor: " + this.autor + " Año de publicacion: " + this.anioPublicacion);
        }
    }
}
