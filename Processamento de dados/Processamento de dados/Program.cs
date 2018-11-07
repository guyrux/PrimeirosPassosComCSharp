using System;

namespace Processamento_de_dados {
    class Program {
        static void Main(string[] args) {
            // Verificando uso de diferenes tipos primitivos
            int x;
            double y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Exemplo 3) Calculando área do trapézio
            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;
            area = (b + B) / 2 * h;
            Console.WriteLine("A área é " + area.ToString("F2") + ".");

            //Exemplo 4) influência dos tipos primitivos
            int ax, bx;
            double resultado;
            ax = 5;
            bx = 2;
            resultado = (double) ax / bx; // "Forçar" a conversão de tipo de variável é chamado de casting.
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
