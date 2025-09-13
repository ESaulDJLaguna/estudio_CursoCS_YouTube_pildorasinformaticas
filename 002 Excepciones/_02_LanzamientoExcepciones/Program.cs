//! Podemos forzar a un programa a que lance una excepción. Esto es útil para obligar a otros programadores que estén participando en la elaboración de ese programa a capturar una excepción cuando se llama, por ejemplo, a un método.
namespace _02_LanzamientoExcepciones
{
    //! Este programa consistirá en que el programa nos pida introducir un número de mes
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce n de mes: ");
            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreDelMes(numeroMes));
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensaje de la excepción: " + e.Message);
            }

            Console.WriteLine("Aquí continuaría la ejecución del resto del programa.");
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                /*
                 * ! throw: se traduce como 'LANZAR'.
                 * 
                 * ! Cada vez que lancemos una excepción, tenemos que buscar la que más se adapte al posible error, para ello, podemos ver alguna de las documentaciones de Microsoft.
                 * 
                 * ! Excepciones más comunes:
                 *      https://learn.microsoft.com/es-es/dotnet/standard/exceptions/#common-exceptions
                 * ! .NET API Browser. Todos los Namespace del API de .NET. Aquí podemos buscar un namespace específico y dentro buscar alguna excepción que nos sea de utilidad:
                 *      https://learn.microsoft.com/es-es/dotnet/api/?view=net-9.0
                 * ! System. Listado de las clases dentro del namespace System. Podemos buscar alguna excepción que se adapte a nuestro problema:
                 *      https://learn.microsoft.com/es-es/dotnet/api/system?view=net-9.0
                 *      
                 * ! Otras referencias interesantes
                 * 
                 * ! Propiedades de la clase Exception:
                 *      https://learn.microsoft.com/es-es/dotnet/standard/exceptions/exception-class-and-properties
                 * ! Cómo crear excepciones definidas por el usuario:
                 *      https://learn.microsoft.com/es-es/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
                 * ! Creación de excepciones definidas por el usuario con mensajes de excepción localizados:
                 *      https://learn.microsoft.com/es-es/dotnet/standard/exceptions/how-to-create-localized-exception-messages
                 * ! Uso de controladores de excepciones filtradas por el usuario:
                 *      https://learn.microsoft.com/es-es/dotnet/standard/exceptions/using-user-filtered-exception-handlers
                 * 
                 */
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}