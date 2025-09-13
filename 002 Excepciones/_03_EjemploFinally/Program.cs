/*
 * En general, se va a utilizar finally siempre que necesitemos liberar recursos (como bases de datos, lectura de ficheros externos, etc.)
 */
namespace _03_EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            //! Lo que se almacenará es un archivo. Se abrirá un canal (un StreamReader) hacia un archivo, para acceder a la información que hay en su interior.
            StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\FileTest\testFile.txt";
                /*
                 * ! Indicamos que en archivo se debe almacenar la ruta al archivo (abrir el canal hacia ese path).
                 * ! Abre un canal de comunicación con el sistema de archivos (un StreamReader) para poder leer el fichero y eso está consumiendo recursos de la máquina.
                 */
                archivo = new StreamReader(path);

                do
                {
                    linea = archivo.ReadLine();
                    Console.WriteLine(linea);
                    contador++;
                } while (linea != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            //! finally se ejecuta siempre, aunque el flujo de ejecución termine en el try o en el catch.
            finally
            {
                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexión con el fichero cerrada");
            }
        }
    }
}