using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Flavio
{
    class Bloques
    {

        public Bloques()
        {
            //Se pueden inicializar variables de la clase Bloques
        }

        public string MLG_quien_eres()
        {
            string nombre;
            SystemSounds.Beep.Play();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("S");
            System.Threading.Thread.Sleep(100);
            Console.Write("T");
            System.Threading.Thread.Sleep(100);
            Console.Write("U");
            System.Threading.Thread.Sleep(100);
            Console.Write("D");
            System.Threading.Thread.Sleep(100);
            Console.Write("I");
            System.Threading.Thread.Sleep(100);
            Console.Write("O");
            System.Threading.Thread.Sleep(100);
            Console.Write("`");
            System.Threading.Thread.Sleep(100);
            Console.Write("S");
            System.Threading.Thread.Sleep(100);
            Console.Write(" ");
            System.Threading.Thread.Sleep(100);
            Console.Write("T");
            System.Threading.Thread.Sleep(100);
            Console.Write("0");
            System.Threading.Thread.Sleep(100);
            Console.Write("R");
            System.Threading.Thread.Sleep(100);
            Console.Write("I");
            System.Threading.Thread.Sleep(1500);
            System.Console.Clear();
            Console.WriteLine("¿Quién eres?");
            nombre = Console.ReadLine();
            if (nombre.ToUpper() == "ELENA")
            {
                System.Console.Clear();
                Console.WriteLine("Hola moniata, este juego tiene 3 raglas para funcionar:");
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Hola {0}, este juego tiene 3 raglas para funcionar:", nombre.ToUpper());
            }
            return nombre.ToUpper();
        }

        public void MLG_instrucciones()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. El texto aparece automaticamente.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2. Da igual la mayúscula en la primera letra, pudes ponerla o no. ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3. Para salir cierra la ventana. ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4. No pulses [ENTER] si no es para responder.");
            System.Threading.Thread.Sleep(3500);
        }
        public void MLG_elefante(string nombre)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ahora,{0}, imagina un elefante.", nombre);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("¿Preparado?");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("El elefante se llama Flavio.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Flavio tiene una cola, una panza redonda y una cabecita con trompa.");
            System.Threading.Thread.Sleep(3500);
            System.Console.Clear();
        }
        public int MLG_selectObjectos(string[] objetos, string pregunta)
        {
            string obj;
            // creamos objetosUPPER con la misma longitud que objetos
            string[] objetosUPPER = new string[objetos.Length];
            while (true)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine(pregunta);
                // bucle para recorrer objetos
                for (int i = 0; i < objetos.Length; i++)
                {
                    // iniciamos objetosUPPER con el mismo elemento que objetos pero en mayúsuclas
                    objetosUPPER[i] = objetos[i].ToUpper();
                    // mostramos la opción en pantalla, pero no en mayúsculas, como ha llegado a la función
                    Console.WriteLine("\t> " + objetos[i]);
                }
                // dejamos una línea en blanco
                Console.WriteLine("");
                obj = Console.ReadLine();
                // ahora buscamos lo introducido por el usuario pasado a mayúsculas en el array objetosUPPER
                int index = Array.IndexOf(objetosUPPER, obj.ToUpper());
                // si devuelve < 0 es que no lo ha encontrado
                if (index < 0)
                {
                    System.Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sé que lo sabes hacer mejor...'{0}' no es una opción.", obj);
                    //Console.WriteLine("'{0}' no es una opción.", obj);
                    Console.WriteLine("NO EXISTE EL LIBRE ALBEDRÍO\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    System.Console.Clear();
                    // devolvemos index (elemento que ocupa en el array)  para despues poder tratarlo
                    return index;
                }
            }
        }
        public void MLG_mar(string daltonico)
        {
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.Clear();
            Console.WriteLine("*Flavio juega en el mar.*");
            if (daltonico == "SI")
            {
                System.Threading.Thread.Sleep(1500);
                System.Console.Clear();
                Console.WriteLine("Un momento...");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Tu no eras daltónico?");
                System.Threading.Thread.Sleep(1500);
                System.Console.Clear();
                Console.WriteLine("oh no, nononon");
                System.Threading.Thread.Sleep(1500);
                System.Console.Clear();
                Console.WriteLine("EL MAR ES AZUL! TU LO HAS PUESTO EN LAVA!");
                System.Threading.Thread.Sleep(1500);
                System.Console.Clear();
                Console.WriteLine("*Flavio ha muerto por tu daltonismo*");
                System.Threading.Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Happy ending]");
                MLG_fin();
            }
            else
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("*Se le mete sal en el ojo.*");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("*Se rasca con la trompa.*");
                System.Threading.Thread.Sleep(1500);
                System.Console.Clear();
                Console.WriteLine("*Ahora Flavio te odia.*");
                System.Threading.Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Salty Ending]");
                MLG_fin();
            }
        }

        public void MLG_hacha()
        {
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.Clear();
            Console.WriteLine("¡Mira! ¡Agarra el hacha!");
            System.Threading.Thread.Sleep(2000);
            System.Console.Clear();
            Console.WriteLine("*Flavio no sabe que hacer*");
            System.Threading.Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[*Flavio confuso*]");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(2000);
            System.Console.Clear();
            Console.WriteLine("Vale...");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("...yo también esperaba más...");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("¡No me mires así!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("ADIOS");
            MLG_fin();
        }

        public void MLG_libro()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int objetoSeleccionado;
            string[] objetos = { "Quemarlo", "Leerlo" };
            System.Console.Clear();
            Console.WriteLine("Flavio tiene un libro");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Oh, también hay un mechero.");
            System.Threading.Thread.Sleep(1500);
            objetoSeleccionado = MLG_selectObjectos(objetos, "¿Qué hace Flavio?");
            System.Console.Clear();
             Console.ForegroundColor = ConsoleColor.White;
            switch (objetoSeleccionado)
            { 
                case 0: // "Quemarlo"
                    Console.WriteLine("*Flavio acciona el mechero y quema el libro*");
                    System.Threading.Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("[Fahrenheit 451 Ending]");
                    MLG_fin();
                    break;
                case 1: // "Leerlo"
                    Console.WriteLine("*Flavio abre y libro y comienza a leer*");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("*Se vuelve físico teórico*");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("¿Algo qué decirnos Falvio?");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("......");
                    System.Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Flavio:");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Debes saber que el tiempo no se puede detener.");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Solo podemos movernos a dimensiones de X tiempo,");
                    System.Threading.Thread.Sleep(1500);
                   Console.WriteLine("o viajar en un bucle temporal al tiempo X.");
                    System.Threading.Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("[Perhaps Ending]");
                    MLG_fin();
                    break;
            }

        }

        public void MLG_pinguras()
    {
            Console.ForegroundColor = ConsoleColor.White;
            int objetoSeleccionado;
            string[] objetos = { "Ta bonito", "Caca" };
            System.Console.Clear();
            Console.WriteLine("¿Qué esta haciendo? ");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("¿Es un dibujo?");
            System.Threading.Thread.Sleep(1500);
            System.Console.Clear();
            Console.WriteLine("*Flavio te muestra su dibujo*");
            System.Threading.Thread.Sleep(1500);
            objetoSeleccionado = MLG_selectObjectos(objetos, "¿Qué te parece?");
            //System.Console.Clear();
            switch (objetoSeleccionado)
            {
                case 0: // "Ta bonito"
                    System.Console.Clear();
                    Console.WriteLine("*Flavio se pone contento*");
                    System.Threading.Thread.Sleep(1500);
                    System.Console.Clear();
                    Console.WriteLine("Gracias");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Salvaste el mundo.");
                    System.Threading.Thread.Sleep(1500);
                    System.Console.Clear();
                    Console.WriteLine("Solo por eso te doy la prueba especial.");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Si la fallas tendras que empezar de 0.");
                    System.Threading.Thread.Sleep(3000);
                    System.Console.Clear();
                    SystemSounds.Beep.Play();
                    Console.WriteLine("¿Qué es 109?");
                    string elef;
                    elef = Console.ReadLine();
                    if (elef.ToUpper() == "ELEFANTE" || elef.ToUpper() == "FLAVIO" || elef.ToUpper() == "UN ELEFANTE")
                    {
                        System.Console.Clear();
                        Console.Write("109              []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("..109            []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("...109           []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("....109          []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write(".....109         []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("......109        []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write(".......109       []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("........109      []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write(".........109     []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write(".........109     []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("..........109    []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("...........109    []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("............109   []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write(".............109  []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("..............109 []");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("...............109[]");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("................109]");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write(".................10]");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("..................1]");
                        System.Threading.Thread.Sleep(50);
                        System.Console.Clear();
                        Console.Write("..................[]");
                        System.Threading.Thread.Sleep(50);
                        Console.WriteLine("Omedetoo!!");
                        System.Threading.Thread.Sleep(1500);
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Easter ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Egg");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" Ending");
                        Console.Write(" ]");

                        MLG_fin();
                    }
                    else
                    {
                        System.Console.Clear();
                        Console.WriteLine("F");
                        MLG_fin();
                    }
                    break;
                case 1: // "Caca"
                    System.Console.Clear();
                    Console.WriteLine("Nuuuuuuu");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Ahora Flavio esta triste.");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Flavio...");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Calmate Flavio...suelta esa escopeta...");
                    System.Threading.Thread.Sleep(2000);
                    System.Console.Clear();
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("...........");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("*31 doritos más tarde*");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("...........");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("*Comienza el Cuarto Reich*");
                    System.Threading.Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[Heil Flavio Ending]");
                    MLG_fin();
                    break;
            }
        }

        private void MLG_fin()
        {
            SystemSounds.Beep.Play();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPulsa cualquier tecla para volver a intentarlo...");
            Console.ReadLine();
        }
    }
}

