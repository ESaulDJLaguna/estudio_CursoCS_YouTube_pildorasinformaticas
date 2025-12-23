/* POO IX. Clases anónimas. Vídeo 35
 * [Tuplas y tipos anónimos](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/types/anonymous-types)
 * Clases anónimas:
 * Estas clases son llamadas así porque son clases que no tienen nombre y suelen tener aplicaciones muy concretas.
 * El uso de una clase anónima en determinados escenarios, ahorra muchas líneas de código. En C# en concreto,
 * se utilizan mucho para las denominadas expresiones Query (cuando se van a hacer consultas).
 * 
 * Clases anónimas (requisitos):
 *      - Solo pueden contener campos públicos.
 *      - Todos los campos deben estar iniciados.
 *      - Los campos no pueden ser static.
 *      - No se pueden definir métodos.
 */

// Cuando en un programa se estén utilizando varios métodos estáticos de una clase, podemos importar todos los métodos estáticos de dicha clase
using static System.Math;
using static System.Console;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //RealizarTarea();

            // Muchos no recomiendan realizar la importación de los métodos estáticos de las clases, ya que podría provocar confución por otros programadores de saber si son métodos propios o de otra clase.
            //double raiz = Sqrt(9);
            //double potencia = Pow(3, 4);
            //WriteLine(raiz);
            //WriteLine(potencia);

            // miVariable NO es el nombre de la clase, es el nombre de la variable que contiene una instancia de una clase anónima. Tampoco se declara el tipo de dato de las variables, sino que el compilador lo asume dependiendo de lo que almacena.
            var miVariable = new { Nombre = "Juan", Edad = 30 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            // Para el compilador tenemos dos instancias que pertenecen a la misma clase anónima, ya que tienen la misma estructura (mismos nombres y tipos de propiedades).
            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };

            // Podemos asignar el valor de una variable anónima a otra variable anónima siempre y cuando ambas pertenezcan a la misma clase anónima.
            miVariable = miOtraVariable;
        }

        static void RealizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(700, 1000);

            Punto otherPoint = new Punto();

            /*
             * Visual Studio cuenta con el "Pánel lista de tareas", el cual nos va a mostrar una lista donde tenemos comentarios de tipo 'TODO'. Para poder visualizar este pánel, se debe ir a:
             * Ver > Lista de tareas
             */
            // TODO: continuar con las siguientes tareas
            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Cantidad de objetos 'Punto' creados: {Punto.GetObjectsCounter()}");
            WriteLine($"Constante de clase: {Punto.testConstant}");
        }
    }
}