namespace _00_FirstApplication
{
    // No puede haber más de dos clases con el mismo nombre dentro de la misma aplicación a no ser que se creen namespaces (espacios de nombre) diferentes
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a C#");

            /*
             * Tipos, intervalos y tamaños de enteros: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
             * Tipos, intervalos, precisión y tamaño de punto flotante: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
             */

            // ¡En C# NO se puede utilizar una variable que no se ha iniciado!
            int edad1 = 15; // Declaración e inicialización de una variable
            int edad2; // Declaración de una variable
            edad2 = 28; // Inicialización de una variable

            Console.WriteLine(edad1);
            Console.WriteLine(edad2);
        }
    }
}
