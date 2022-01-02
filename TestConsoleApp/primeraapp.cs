using System; 
/* Esto quiere decir que va a utilizar el namespace System, que está predefinido en este lenguaje,
y aquí dentro están las clases, entre las cuales se encuentra Console (sin la línea 1, el programa
no podría funcionar, es decir, esto es como un import) */

namespace appuno {
  class Hola {
    static void Main(string[] Args) {
      Console.WriteLine("Funciona C#"); // Funciona gracias a la línea uno del código. Hay una alternativa
      // Sin la línea 1, tendríamos que escribir todo el rato System.Console.loquesea
      // System.Console.WriteLine("Funciona sin using System");
    }
  }
}
