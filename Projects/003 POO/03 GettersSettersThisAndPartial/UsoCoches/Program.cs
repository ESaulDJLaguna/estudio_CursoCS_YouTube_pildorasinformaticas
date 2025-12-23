/*
 * Cuando no se especifica el valor de una variable, esta tomará el valor por defecto:
 * - bool: false
 * - string: cadena vacía
 */
namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.GetInfoCoche());
            Console.WriteLine(coche2.GetInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.GetInfoCoche());

            coche3.SetExtras(true, "cuero");

            Console.WriteLine(coche3.GetExtras());
        }
    }

    /*
     * Una utilidad que tiene C# y Visual Studio, es la posibilidad de dividir las clases en trozos. Para esto las clases tiene que tener el mismo nombre y utilizar la palabra reservada "partial"
     */
    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------
    partial class Coche
    {
        public String GetInfoCoche()
        {
            return $"Información del coche:\nRuedas: {ruedas}\tLargo: {largo}\tAncho: {ancho}";
        }

        public void SetExtras(bool climatizador, String tapiceria)
        {
            // this: uno de los usos que se le puede dar, es diferenciar entre un campo de clase y un parámetro. Para indicar que se está refiriendo al campo de clase, se le pone this
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public String GetExtras()
        {
            return $"Extras del coche:\nTapicería: {tapiceria}\tClimatizador: {climatizador}";
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}