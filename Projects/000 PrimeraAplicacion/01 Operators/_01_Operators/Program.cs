namespace _01_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ OPERADORES ------------
            Console.WriteLine("Mult: " + 7*5);
            Console.WriteLine("Mult: " + 7*5*3);
            // Como los dos valores son enteros, el resultado es un valor entero ("trunca" el decimal)
            Console.WriteLine("Div: " + 5/2);
            // El compilador considera por defecto el '2.0' como un double.
            // Si existe un valor decimal en una operación, se "castea" el resultado a un decimal.
            Console.WriteLine("Div decimal: " + 5/2.0);
            Console.WriteLine("Módulo / Residuo: " + 9%3);


            int edad = 19;
            edad++;
            edad += 8;
            edad -= 5;
            edad--;

            // Concatenación de strings
            Console.WriteLine("Tienes una edad de " + edad + " años");

            // Interpolación de strings
            Console.WriteLine($"Tienes una edad de {edad} años");






            // ------------ OPERADOR "=" ------------
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            // Se inician las 4 variables con el mismo valor (27)
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
            Console.WriteLine(edadPersona4);

            // Declara todas las variables en una sola línea e inicializa solo edadPersona4
            // int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27;
        }
    }
}
