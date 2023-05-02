using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libro;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro1 novela = new Libro1("HarryPother", "JKRowling", 2016);
            LibroFiccion libroFiccion = new LibroFiccion("La bliblia", "San Pedro",0000, "religion");
            LibroNoFiccion libroNoFiccion = new LibroNoFiccion("Biologia", "Gallileo", 1850, "Educativo");


            novela.imprimirInformacion();
            
                        
            libroFiccion.imprimirInformacion();      
            libroNoFiccion.imprimirInformacion();

            libroFiccion.EstablecerGenero("accion");     
            libroNoFiccion.EstablecerTema("ciencia");

            libroFiccion.imprimirInformacion();
            libroNoFiccion.imprimirInformacion();


        }
    }
}
