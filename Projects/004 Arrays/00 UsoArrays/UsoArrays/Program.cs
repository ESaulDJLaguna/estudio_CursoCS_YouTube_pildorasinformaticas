using System.ComponentModel;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************************************************************************
             * Arrays I. Vídeo 36
             * - ¿Qué es? Estructura de datos que contiene una colección de valores del mismo tipo.
             * - ¿Para qué sirve? Para almacenar valores que normalmente tiene alguna relación entre sí.
             * - Sintaxis:
             * 	- Declaración: Tipo[] nombreDelArreglo;
             * 	- Inicialización: nombreDelArreglo = new Tipo[tamaño];
             * 	- Declaración e inicialización conjunta: Tipo[] nombreDelArreglo = new Tipo[tamaño];
             * 	- Declaración e inicialización con valores: Tipo[] nombreDelArreglo = {valor1, valor2, valor3, ...}; // El tamaño se define dependiendo de la cantidad de valores.

             * Los arreglos no reservan espacio en memoria a menos que se utilice la palabra clave "new" para inicializarlos.
             * Si a un arreglo no se le asigna ningún valor, sus elementos contendrán el valor por defecto del tipo de dato que almacena (0 para tipos numéricos, false para booleanos, null para tipos referencia, etc.).
             *************************************************************************/
            int[] edades; // Declaración
            edades = new int[4]; // Inicialización
            edades[0] = 15; // Asignación de valores
            // ...
            edades[3] = 42;

            int[] edades2 = { 15, 27, 35, 42 }; // Declaración e inicialización con valores
            int[] ages = new int[5] { 10, 20, 30, 40, 50 }; // Declaración e inicialización con tamaño y valores

            Console.WriteLine(edades[2]);



            /*************************************************************************
             * Arrays II. Vídeo 37
             * - Arrays implícitos: se trata de un arreglo que almacena datos pero no se específica el tipo de dato ni cuántos elementos contendrá. No es posible inicializarlo con valores de diferente tipo (como string e int juntos), pero sí es posible utilizar tipos "casteables", es decir, enteros y doubles, en estos casos el compilador elegirá el tipo de dato más "grande" que pueda contener a todos los valores.
             * - Arrays de tipos anónimos
             * - Reccorrido y acceso de arrays con bucle for
             *************************************************************************/

            // Array implícito
            var datos = new[] { "Juan", "Díaz", "España" };
            var valores = new[] { 10, 20.5, 30, 40.75 }; // Array implícito con tipos casteables (el compilador elegirá double)

            // Array de objetos
            Empleado newEmployee = new Empleado("Luis", 30);
            Empleado[] empleados = new Empleado[2];

            empleados[0] = new Empleado("Ana", 25);
            empleados[1] = newEmployee;

            // Array de tipos o clases anónimos
            var personas = new[]
            {
                new { Nombre = "Juan", Edad = 19 },
                new { Nombre = "Maria", Edad = 49 },
                new { Nombre = "Diana", Edad = 35 }
            };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(valores[i]);
            }
            Console.WriteLine();

            int contador = 0;
            for (int i = 15; i >= 12; i--)
            {
                Console.WriteLine(valores[contador++]);
            }
            Console.WriteLine();

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
            Console.WriteLine();
            /*
             * Documentación Array Class: https://learn.microsoft.com/en-us/dotnet/api/system.array
             */
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine($"Empleado {i + 1}: {empleados[i].GetEmployeeInfo()}");
            }
            Console.WriteLine();

            /*
             * El bucle foreach puede utilizarse en arrays implicitos, arrays de tipos anónimos y arrays de objetos.
             * El bucle foreah se puede utilizar solo para recorrer arreglos, no para modificarlos.
             */
            // empleado es un iterador y debe ser del mismo tipo que el array que se está recorriendo
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"Empleado: {empleado.GetEmployeeInfo()}");
            }
            Console.WriteLine();

            foreach (double variable in valores)
            {
                Console.WriteLine($"Valor: {variable}");
            }
            Console.WriteLine();

            foreach (var persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
            }
            Console.WriteLine();
            Console.WriteLine();


            /*************************************************************************
             *Arrays V.Vídeo 40
             * -Arrays como parámetros de métodos
             * -Arrays como devolución de métodos (return)
             *************************************************************************/
            int[] numeros = { 7, 9, 15, 3 };
            ProcesaDatos(numeros);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] datosLeidos = LeerDatos();
            Console.WriteLine("Imprimiendo desde el main");
            foreach (var item in datosLeidos)
            {
                Console.WriteLine(item);
            }
        }

        /*
         * Los arrays son referencias a objetos. Si se modifica el contenido de un array dentro de un método, el cambio se reflejará fuera del método.
         */
        static void ProcesaDatos(int[] datos)
        {
            // El foreach no permite modificar los elementos del array
            foreach (int i in datos)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el array? ");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];
            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el valor del elemento {i + 1}: ");
                respuesta = Console.ReadLine();
                datos[i] = int.Parse(respuesta);
            }

            return datos;
        }
    }

    class Empleado
    {
        public Empleado(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String GetEmployeeInfo()
        {
            return $"Nombre: {nombre}, Edad: {edad}";
        }

        private String nombre;
        private int edad;
    }
}