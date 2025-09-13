namespace _01_UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked
            //{
            //! Vamos a ver un comportamiento bastante curioso que tiene el compilador de C# a la hora de trabajar con operaciones aritméticas que pueden lanzar un error.
            int maxValue = int.MaxValue; //! MaxValue: propiedad de la clase Integer que devuelve el valor más alto que admite el tipo primitivo int
            int minValue = int.MinValue;
            /*
             *! Esta expresión debería dar una error (una excpeción) de tipo Overflow, porque 'resultado' está almacenando el valor máximo de un entero y además se le está sumando 20, por lo tanto, está superando el valor máximo que acepta un entero, por lo que tendría que haber un desbordamiento. Sin embargo, si se ejecuta el programa veremos que no se detiene la ejecución ni da ningún error, sin embargo, podemos notar que da una respuesta errónea, es decir, pone un número negativo. La explicación de este comportamiento es: rendimiento, es decir, se intenta que los programas tengal el máximo rendimiento en C#, eso es lo que intenta el compilador, de tal forma que permite, de manera transparente para el usuario, hacer un overflow y generar una respuesta errónea, es decir, el compilador sabe que existe un desbordamiento, pero antes de dejar que caiga el programa, lo que hace es que de forma transparente trata la excepción y nos devuelve una respuesta errónea porque no sabe qué hacer. Nos referimos a que lo hace por rendimiento porque las operaciones aritméticas son las más frecuentes en los programas y si en un programa complejo tiene que ver si hay desbordamiento o no en cada una de las operaciones aritméticas, esto ocasionaría un rendimiento muy pobre por parte del compilador, de tal forma que lo que hace es asumir que puede haber un posible error y continua con la ejecución del programa hacia adelante, si hubiese más líneas a continuación, después de haber tratado la excepción y devolver una respuesta errónea, seguiría ejecutando las líneas que hay más adelante.
             * 
             * En ocasiones, este comportamiento del compilador de C# no nos será de utilidad, es decir, habrá veces que lo que queremos es que si ocurre una circunstancia de estas características se lance una excpeción. En este caso se utilizará la expresión 'checked { }'. Lo que se le éstá diciendo con esto al programa, es que lo que hay dentro de este checked lo "checkee", de tal forma que si hay un error de estas características (una excepción de desbordamiento), no siga hacia adelante, sino que el programa caiga.
             */
            //int resultado = maxValue + 20;



            /*
             * El entorno de desarrollo de Visual Studio tiene una opción para que este checked no lo tengamos que programar "manualmente" y el compilador haga un checkeo exhaustivo de cada una de las operaciones aritméticas para que en el caso de que lance una excepción caiga el programa sin la necesidad de poner el checked. Para habilitar esto, hacemos lo siguiente:
             * 
             * Explorador de soluciones (clic derecho en nuestro proyecto) > Propiedades > Compilación (para cambiar de alguna forma el comportamiento por defecto del compilador de C#) > Opciones avanzadas > Activar el check de la opción "Comprobar el desbordamiento aritmético"
             * 
             * Hacer lo anterior, es como si nosotros hubiéramos programado el 'checked', pero de forma implícita (sin la necesidad de ponerlo). Si se vuelve a ejecutar el programa, a pesar de no haber checked, lanzará la excepción.
             * 
             * Para ver de manera "rápida" si está habilitada esta opción, damos doble clic al proyecto en el "Explorador de soluciones" y vemos si se encuentra la opción: <CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
             */

            /*
             * Existe una forma abreviada de utilizar la expresión checked, con esta forma, tenemos que detectar qué línea de código es la que realmente necesita ese checkeo. Esto se hace de la siguiente manera.
             */
            //int resultado = checked(maxValue + 20);

            /*
             * Si en nuestro proyecto hemos habilitado de manera global la opción "Comprobar el desbordamiento aritmético" (como se explicó anteriormente) y hay alguna expresión en concreto que queremos omitir este checkeo, es decir, que si falla no lance una excepción, sino que la salte (como lo haría el compilador inicialmente), se utilizaría unchecked (también se puede encerrar un bloque de código entre llaves (unchecked { }), igual que se hace con checked.
             * 
             * IMPORTANTE: las expresiones checked y unchecked solamente funcionan con primitivos de tipo int y long
             */
            int resultado = unchecked(maxValue + 20);

            Console.WriteLine($"intMax: {maxValue}");
            Console.WriteLine($"intMin: {minValue}");
            Console.WriteLine($"intMax + 20 (desbordamiento): {resultado}");

            Console.ReadLine();
            //} //! Fin de checked que encierra un bloque de código
        }
    }
}