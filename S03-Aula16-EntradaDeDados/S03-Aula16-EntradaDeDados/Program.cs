using System;

namespace S03_Aula16_EntradaDeDados {
    class Program {
        static void Main(string[] args) {
            string x;
            x = Console.ReadLine(); //Lê entrada do teclado e armazena na forma de string
            int y;
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(x, y);
            Console.ReadLine();

        }
    }
}
