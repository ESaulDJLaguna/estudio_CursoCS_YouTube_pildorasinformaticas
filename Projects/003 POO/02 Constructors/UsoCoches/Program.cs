/*
 * Los constructores tienen como finalidad dar un estado inicial a los objetos. Cuando construimos un objeto debe de tener un estado inicial y dicho estado podrá modificarse después
 */
namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            // new crea una instancia de tipo Coche. Es decir, new llama al constructor de la clase.
            Coche coche1 = new Coche(); // crear objeto/instancia de tipo Coche. Dar un estado inicial a nuestro Coche.
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.GetInfoCoche());
            Console.WriteLine(coche2.GetInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.GetInfoCoche());
        }
    }

    class Coche
    {
        /*
         * Se produce una "Sobrecarga de constructores", cuando la clase tiene más de un constructor y cada constructor debe recibir diferente número de parámetros.
         * 
         * Cuando una clase NO tiene constructores, se dice que tiene un constructor por defecto. El interprete de C#, interpreta que aunque no está presente hay un constructor sin parámetros que está vacío: 
         * public Coche() { }
         */
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        public String GetInfoCoche()
        {
            return $"Información del coche:\nRuedas: {ruedas}\tLargo: {largo}\tAncho: {ancho}";
        }

        /*
         * Para evitar modificar un campo de clase con un valor que no tenga sentido, se recomienda encapsularlo y acceder a ellos a través de un método de acceso. Estos métodos que permiten acceder a propiedades, se les denomina "Métodos getters", son métodos que dan información de propiedades. Por convención, el nombre de estos métodos suelen empezar con get.
         */
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}