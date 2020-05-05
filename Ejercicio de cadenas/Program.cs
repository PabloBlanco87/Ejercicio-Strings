using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Realiza un programa que permita al usuario introducir una cadena, cuente los caracteres que tiene y la cantidad de letras 'a' que tiene. 
             * Después, el usuario podrá introducir una letra, y le dirá en qué posiciones aparece*/

            //Mandamos el mensaje al usuario con las instrucciones a realizar

            Console.WriteLine("Introduzca una palabra o frase y pulse Enter:");

            //Aquí, asignamos a nuestra cadena los valores que ha introducido el usuario, con una variable string 

            string fraseUsuario = Console.ReadLine();

            /*Como los string son arrays, podemos saber directamente su longitud con la funcion Lenght, sabiendo esto, 
             * mandamos un mensaje por pantalla que nos muestre la longitud del mensaje del usuario*/
                         
            Console.WriteLine("Ustéd ha tecleado " + fraseUsuario.Length + " caracteres en su mensaje");


       
            //Ahora quiero saber el numero de veces que el usuario ha tecleado la letra 'a', 
            //por lo que inicio una variable de tipo entero a 0 que me va a servir de contador

            int contadorDeA = 0;


            //Inicio el bucle for para recorrer la frase desde la posición 0 hasta que termine (toda la frase)

            for (int i = 0; i < fraseUsuario.Length; i++)
            {
                //Inicio la variable char con nombre caracterA y la igualo a cada valor que tenga el indice i del string. Es decir, obtengo el char que está en el índice i del string.

                char caracterA = fraseUsuario[i];

                //Pongo la condición de si ese caracter=a, entonces, me suma 1 a mi contador, por lo que al final de terminar el bucle for, sabré gracias a mi contador de As, cuántas 'a' tengo

                if (caracterA == 'a')
                {
                    contadorDeA++; 
                }
            }

            
            Console.WriteLine("Ustéd ha tecleado " + contadorDeA + " veces la letra 'a'");


            //Ahora queremos que el usuario introduzca una letra para saber en qué posiciones se encuentra esa letra

            //Ponemos las instrucciones al usuario por pantalla
            
            Console.WriteLine("Introduzca una letra y pulse Enter para indicarle en qué posiciones se encuentra dicha letra:");

            //Inicio la variable char con nombre caracterUsuario y la igualo al primer caracter que introduce el usuario [0] (por si por error introduce dos, o más caracteres)

            char caracterUsuario = Console.ReadLine()[0];

            //Introducimos un booleano para discriminar cuando el usuario introduce una letra y se encuentra en su mensaje previo, o por si es lo contrario y no se encuentra
            //la inicializamos en false

            bool existeCaracter = false;

            /* Los booleanos funcionan de esta manera:
             * bool passed = false;
             * Console.WriteLine(!passed);   // output: True
             * Console.WriteLine(!true);     // output: False*/


            //Con este bucle for, volvemos a recorrer la frase que ha introducido el usuario entera

            for (int i = 0; i < fraseUsuario.Length; i++)
            {
                // Inicio la variable char con nombre valor y gracias a ella obtengo el char que está en el índice i del string.

                char valorCaracter = fraseUsuario[i];

                if (valorCaracter == caracterUsuario)
                {

                    //Si existe un caracter a lo largo de la frase que coincida con el caracter que ha introducido posteriormente el usuario, nos mostrará esto por consola

                    Console.WriteLine("La letra " + "'" + caracterUsuario + "'" + " está en la posición " + (i+1));

                    /*Si encuentra la letra introducida en la frase, entonces marcaremos a nuestro booleano como true para después poder hacer una condición, 
                     * de que si no ha encontrado, muestre otra cosa por pantalla*/

                    existeCaracter = true;
                }
            }

            //Si no encuentra el caracter introducido en la frase que ha puesto anteriormente, marcamos la condición de que si no (con !) existe la letra introducida, mostrar este mensaje por pantalla

            if (!existeCaracter)
            {
                Console.WriteLine("La letra " + "'" + caracterUsuario + "'" + " no se encuentra en la frase: " + "'" + fraseUsuario + "'");
            }

            Console.ReadLine();

            //FIN




        }
    }
}
