/*
 * Existen dos formas de crear una clase nueva en un archivo aparte, las cuáles son:
 * 
 * 1) Explorador de soluciones (clic derecho al proyecto actual) > Agregar > Clase...
 * 2) Proyecto (menú superior) > Agregar clase...
 * 
 * Esto de dividir un proyecto en varias clases se le conoce como "Modularización".
 */

/* POO VIII. Variables y métodos static. Vídeo 34
 * Todas aquellas variables o métodos que se declaran como 'static' pertenecen a la clase en sí misma y no a las instancias de la clase.
 * Por eso suelen nombrarse como variables/métodos de clase y no es posible acceder a ellas desde una instancia de la clase.
 * 
 * En C# cuando se crea una constante estática NO es necesario agregar el modificador 'static' ya que el compilador lo asume automáticamente.
 * Es decir, todas las constantes en C# se asumen que son estáticas.
 */
namespace ConceptosPOO
{
    class Punto
    {
        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            // 'this' hace referencia a la propia clase donde nos encontramos
            this.x = x;
            this.y = y;
            objectsCounter++;
        }

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto");
            x = y = 0;
            objectsCounter++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int deltaX = this.x - otroPunto.x;
            int deltaY = this.y - otroPunto.y;
            // https://learn.microsoft.com/es-es/dotnet/api/: buscador de clases y métodos del api de .NET (en el buscador escribir "Math")
            double pointsDistance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return pointsDistance;
        }

        // El método que nos devolverá el valor de una variable estática no tiene porque ser obligatoriamente estático, pero en este caso, por la naturaleza de la variable, se requiere que sea estático (para no depender de una instancia de la clase).
        public static int GetObjectsCounter() => objectsCounter;

        // Campos de clase encapsulados. El ámbito de las variables 'x' e 'y' es desde la llave de apertura hasta la llave de cierre de la clase 'Punto'.
        private int x, y;

        private static int objectsCounter = 0;

        public const int testConstant = 7;
    }
}
