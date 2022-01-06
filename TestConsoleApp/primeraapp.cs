using System; 
/* Esto quiere decir que va a utilizar el namespace System, que está predefinido en este lenguaje,
y aquí dentro están las clases, entre las cuales se encuentra Console (sin la línea 1, el programa
no podría funcionar, es decir, esto es como un import) */

namespace appuno {
  class Hola {
    public static void Saludar() {
      Console.WriteLine("Funciona C#"); // Funciona gracias a la línea uno del código. Hay una alternativa
      // Sin la línea 1, tendríamos que escribir todo el rato System.Console.loquesea
      // System.Console.WriteLine("Funciona sin using System");
    }
  }

  class Edad {
    static void Main(string[] args) {
      int edad = 25;
      Console.WriteLine("Mi edad es " + edad + " años");
      edad++; // Incremento
      Console.WriteLine($"Mi edad es {edad} años"); // Interpolación de strings. Y la edad ahora es 26
      Console.WriteLine($"Mi edad es {edad++} años"); // Imprime 26 y luego incrementa. El compilador lee de izq a der
      Console.WriteLine($"Mi edad es {edad} años"); // Ahora sí que imprime 27
      Console.WriteLine($"Mi edad es {++edad} años"); // Imprime 28 porque el incremento está como prefijo
      Hola.Saludar();
      edad -= 3;
      Console.WriteLine($"Mi edad es {edad} años");
      Console.Read(); // Es una de las maneras de recoger input del usuario
      // Además, me permite ejecutar la aplicación desde el archivo TestConsoleApp.exe sin que se cierre al instante
    }
  }
}
