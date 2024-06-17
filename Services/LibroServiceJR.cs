using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class LibroServiceJR:ILibroServiceJR
    {
        public List<Libro> ObtenerLibro() {
            return new List<Libro>
            {
                new Libro { Titulo = "Libro1", Autor = "Autor1" },
                   new Libro { Titulo = "Libro2", Autor = "Autor2" },
                      new Libro { Titulo = "Libro3", Autor = "Autor3" },
                         new Libro { Titulo = "Libro4", Autor = "Autor4" },
                            new Libro { Titulo = "Libro5", Autor = "Autor5" },
            };
            
        } }
}
   

