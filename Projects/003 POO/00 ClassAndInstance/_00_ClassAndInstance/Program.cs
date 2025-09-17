namespace _00_ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia (objeto) de tipo Circulo
            Circulo miCirculo; // Cración (declaración) de objeto de tipo Circulo. Variable/objeto de tipo Circulo
            /*
             * Inicialización de variable/objeto de tipo Circulo (se le dio un valor a la variable miCirculo de tipo Circulo). También se conoce como 'instanciar' una clase.
             * 
             * Siempre que se vea la palabra reservada 'new', lo que se está haciendo es una instancia. Algunos sinónimos son: Instanciación. Ejemplarización. Creación de ejemplar de clase.
             */
            miCirculo = new Circulo();
            Console.WriteLine(miCirculo.calculoArea(7));

            //! Declarar e iniciar un objeto
            Circulo miCirculo2 = new Circulo();
            Console.WriteLine(miCirculo2.calculoArea(10));
        }
    }

    class Circulo
    {
        //! Cuando se definen variables dentro de una clase, estamos definiendo propiedades de esa clase y a estas propiedades también se les conoce como 'Campos de clase'.
        //! Se declara como constante para evitar que pueda modificarse desde una clase externa o desde la misma clase.
        const double pi = 3.1416; // propiedad de la clase Circulo. Campo de clase.

        //! Cambiamos la protección o nivel de acceso para poder accer desde otras clases
        public double calculoArea(int radio) // método (comportamiento) de clase. ¿Qué pueden hacer los objetos de tipo 'Circulo'?
        {
            return pi * radio * radio;
        }
    }
}