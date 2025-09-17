namespace _02_DeclarationsAndConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ DECLARACIÓN IMPLÍCITA DE VARIABLES ------------
            // Le indicamos al compilador de C# que asigne en tiempo de ejecución el tipo que corresponde a esta variable.
            // NO se puede modificar el tipo de dato, es decir, SIEPMRE será un entero.
            // SIEMPRE se debe declarar e inicializar en la misma línea cuando se usa 'var'
            var edadPersona5 = 25;

            Console.WriteLine(edadPersona5);






            // ------------ CONVERSIONES EXPLÍCITAS E IMPLÍCITAS ------------
            double temperatura = 34.5;
            int temperaturaMadrid;

            // Conversión explícita (casting)
            temperaturaMadrid = (int)temperatura; // Ignora los decimales NO redondea

            Console.WriteLine(temperaturaMadrid);

            // Conversión implícita. Se da con tipos compatibles pero de diferente alcance
            // Conversiones numéricas implícitas: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            int habitantesCiudad = 10000000;
            long habitantesCiudad2018 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2018);

            float pesoMaterial = 5.78F;
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine(pesoMaterialPrec);






            // typeConversion: convertir un tipo a uno totalmente diferente, tipos que no son compatibles. Generalmente de texto a número (int.Parse(), decimal.Parse(), etc.) y de número a texto
            Console.WriteLine("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es {numero1 + numero2}");






            // Definición y uso de constantes
            const int VALOR = 15;
            const int VALOR2 = 7;

            Console.WriteLine("El valor de las constantes son: {0} y {1}", VALOR, VALOR2);

            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio: ");

            double radio = double.Parse(Console.ReadLine());
            //double area = radio * radio * PI;
            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del circulo es: {area}");
        }
    }
}
