namespace _00_Methods
{
    class Program
    {
        // Todo el código declarado dentro de unas llaves se denomina: ÁMBITO, CONTEXTO o ALCANCE
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            sumaNumerosVoid(5, 7);
            Console.WriteLine("La suma de los números es: {0}", sumaNumerosInt(7, 10));
            Console.WriteLine("La división de los números es: {0}", divideNumeros(18, 5));
            Console.WriteLine("La multiplicación de los números es: {0}", multiplicaNumeros(3, 8));
            showMessage("Mensaje de texto en método de una sola línea");
            Console.WriteLine(sumaSobrecargada(10, 15));
            Console.WriteLine(sumaSobrecargada(10, 15.0)); // No suma, solo muestra el primer número
            Console.WriteLine(sumaSobrecargada(1, 2, 3, 4)); // No suma todos los números, solo los primeros dos


            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(SumaParamsOpcionales(valor1, valor2));
            Console.WriteLine(SumaParamsOpcionales(valor1, valor2, valor3));
        }

        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");
        }

        // num1 y num2 son PARÁMETROS
        static void sumaNumerosVoid(int num1, int num2)
        {
            Console.WriteLine("La suma de los números es: " + (num1 + num2));
        }

        static double sumaNumerosInt(double num1, int num2)
        {
            return num1 + num2;
        }

        // "ERROR": La división entre dos int SIEMPRE "truncará" la parte decimal, así indiquemos que el valor de retorno es un double, porque operar entre enteros dará un entero
        //static double divideNumeros(int num1, int num2) 
        static double divideNumeros(double num1, int num2) // La división entre un double y un int siempre da un double.
        {
            return num1 / num2;
        }

        // Declarar métodos "de una sola línea". Se les denomina: EXPRESSION-BODIED. El operador => se le denomina, LAMBDA
        static int multiplicaNumeros(int num1, int num2) => num1*num2;

        static void showMessage(string message) => Console.WriteLine(message);

        void ambitoExplicacion()
        {
            int numero1 = 5; // numero1 tiene un ÁMBITO LOCAL
            int numero2 = 7; // numero2 tiene un ÁMBITO LOCAL

            Console.WriteLine(numero1 + numero2);
        }

        void ambitoExplicacion2()
        {
            // numero1 y numero2 son campos con un ámbito de clase
            Console.WriteLine(numero1 + numero2);
        }

        // SOBRECARGA DE MÉTODOS. Se puede tener métodos con el mismo nombre siempre y cuando reciban diferentes tipos de parámetros o diferentes números de parámetros
        static int sumaSobrecargada(int operador1, int operador2) => operador1 + operador2;

        static int sumaSobrecargada(int numero1, double numero2) => numero1;

        static int sumaSobrecargada(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;


        // PARÁMETROS OPCIONALES. Los parámetros opcionales SIEMPRE van después de los parámetros obligatorios
        // Cuando se tiene una AMBIGÜEDAD, como en este caso que se sobrecargó el método y uno de ellos recibe parámetros opcionales pero en la llamada solamente utiliza parámetros obligatorios, en este caso se llamará al método que se adapte al número de parámetros. Es decir, si se hace una llamada al método SumaParamsOpcionales() y solo se envían dos parámetros, aunque también sería correcto llamar al método con el tercer parámetro opcional NO se hace así, ya que se le da preferencia al método que tiene dos parámetros
        static double SumaParamsOpcionales(int num1, double num2, double num3 = 0)
        {
            return num1 + num2 + num3;
        }

        static double SumaParamsOpcionales(int num1, double num2)
        {
            return num1 + num2;
        }

        // Las variables con un alcance de clase se denominan CAMPOS DE CLASE y son accesibles por cualquier método. Además, son una "excepción a la regla" de que el programa se ejecuta de arriba abajo
        int numero1 = 15; // numero1 tiene un ÁMBITO DE CLASE
        int numero2 = 17; // numero2 tiene un ÁMBITO DE CLASE
    }
}
