using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flavio
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string daltonico;

            int seleccion_SINO;
            string[] array_SINO = { "Si", "No" };

            int seleccionado;
            string[] array_opciones = { "Mar", "Hacha", "Libro", "Pinturas" };

            Bloques bloque = new Bloques();


            nombre = bloque.MLG_quien_eres();
            bloque.MLG_instrucciones();
            while (true)
            {
                System.Console.Clear();
                seleccion_SINO = bloque.MLG_selectObjectos(array_SINO, "¿Eres daltónico?");
                // Asignamos a daltonico el elemento Si o No elegido, porque MLG_selectObjectos() devuelve el índice
                daltonico = array_SINO[seleccion_SINO];
                bloque.MLG_elefante(nombre);
                seleccionado = bloque.MLG_selectObjectos(array_opciones, "Escoge una opción:");
                
                switch (seleccionado)
                {
                    case 0: // "Mar"
                        bloque.MLG_mar(daltonico.ToUpper());
                        break;
                    case 1: // "Hacha"
                        bloque.MLG_hacha();
                        break;
                    case 2: // "Libro"
                        bloque.MLG_libro();
                        break;
                    case 3: // "Pinturas"
                        bloque.MLG_pinguras();
                        break;
                }
            }
        }
    }
}
