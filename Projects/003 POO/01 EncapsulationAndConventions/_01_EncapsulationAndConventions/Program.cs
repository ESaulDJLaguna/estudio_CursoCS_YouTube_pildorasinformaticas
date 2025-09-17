/*
 * Convenciones a la hora de programar en C#:
 * 
 * Los identificadores "public" deben comenzar con letra mayúscula.
 *  - Notación "PascalCase". `public double CalculoArea(){...}`
 * Los identificadores que no son "public" deben empezar por letra minúscula:
 *  - Notación "camelCase": longitudRadio
*/
namespace _01_EncapsulationAndConventions
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();

            // Un inconveniente de NO encapsular un campo, es que erróneamente o malintencionadamene se pueden poner valores erróneos, como un valor negativo.
            //obt.factorEuro = -7.85;

            obj.CambiaValorEuro(-1.45);
            Console.WriteLine(obj.Convierte(50));
        }
    }

    class Circulo
    {
        /*
         * Cuando no sea necesario que una variable, constante o método sea accesible desde fuera de su propia clase, lo que se hace es encapsularlo, lo cual consiste en quitar esa visibilidad externa a la variable, constante o método.
         * 
         * Para encapsular datos en C#, se utiliza la palabra reservada private y solo será visible (accesible) desde la propia clase (desde su ámbito) donde se encuentra. En C# cuando no se utiliza ningún modificador de acceso (public, private, etc.), por defecto es private, pero es recomendable agregarlo de manera explícita.
         * 
         * No es una buena práctica dejar los campos como públicos y permitir que sean modificados desde el exterior, para eso es recomendable utilizar un "método de acceso".
         */
        private const double pi = 3.1416;

        public double CalculoArea(int radio)
        {
            return pi * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double factorEuro = 1.253;

        public double Convierte(double eurosToConvert)
        {
            return eurosToConvert * factorEuro;
        }

        //! Método de acceso. La utilidad de establecer un nuevo valor a un campo desde un método de acceso, es que se puede validar que se agregue un valor correcto
        public void CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor > 0)
            {
                factorEuro = nuevoValor;
            }
        }
    }
}