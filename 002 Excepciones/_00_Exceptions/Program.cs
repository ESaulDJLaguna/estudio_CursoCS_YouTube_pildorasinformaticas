/*
 * Las excepciones son errores en tiempo de ejecución del programa que escapan al control del programador y se manejan con un try-catch.
 * try... (intenta)
 * catch... (captura)
 */
namespace _00_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int intentos = 0;
            int miNumero;

            Console.WriteLine("Introduce un n. entre 0 y 100");

            do
            {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                //! 'catch', recibe como parámetro un objeto de tipo excepción
                /*
                      catch (FormatException ex)
                      {
                        Console.WriteLine("No has introducido un valor numérico válido. Se toma como número introducido el 0");
                        miNumero = 0;
                      }
                  //! Se pueden capturar más de una excepción
                      catch (OverflowException ex)
                      {
                        Console.WriteLine("Has introducido un valor demasiado alto. Se toma como número introducido el 0");
                        miNumero = 0;
                      }
                */
                /*
                 * Para evitar tener que manetar varias exepciones, se podría utilizar Exception que es la clase de la que heredan todas las demás excepciones. Pero en la medida de lo posible, a la hora de programar se tiene que tener la máxima presición para especificar cuál es la excepción capturada y tratada.
                 * Manejar todo con Exception, nos limita a que no podemos especificar al usuario cuál fue el error que cometió, ya que siempre se mostraría el mismo mensaje de error.
                 * En la medida de lo posible hay que ser preciso con las capturas de las excepciones, afinando todo lo posible, PERO, habrá programas que por su complejidad no podamos construir tantos catch para afinar todo lo posible y se tenga que construir una excepción general.
                 */

                //! Si se va a utilizar una excepción genérica (Exception) puede omitirse (Exception ex), quedando solo 'catch', pero solo si será una excepción genérica (Exception). Aunque NO es recomendable, ya que no es una buena práctica de programación.
                //catch
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Ha habido un error. Se toma como número introducido el 0");
                //    Console.WriteLine(ex.Message);
                //    miNumero = 0;
                //}
                //! Si un catch superior (sin filtro) YA está capturando errores en una "herencia" superior, va a marcar un error. Los "tratamientos especiales" o excepciones más concretas, tienen que ir antes que una más genérica (a menos que se esté utilizando un filtro como se muestra a continuación).
                //x catch(FormatException e) { }


                /*
                 * Cuando queremos capturar muchas excepciones y darles a todas un tratamiento genérico excepto a una de ellas, podemos utilizar algo llamado "Excepciones con filtro".
                 * Supongamos que a FormatException queremos darle un tratamiento especial, en este caso se solucionará utilizando filtros. Para hacer esto, a continuación de la captura de la Excepción genérica, debe incluirse la clausula 'when' y a continuación se debe especificar cuál es la excepción que queremos exluir de esta captura
                 */
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error. Se toma como número introducido el 0");
                    miNumero = 0;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Has introducido texto.");
                    miNumero = 0;
                }


                if (miNumero > aleatorio) Console.WriteLine("El n. es más bajo");
                if (miNumero < aleatorio) Console.WriteLine("El n. es más alto");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            Console.WriteLine("A partir de esta línea de código el programa continuará");
        }
    }
}