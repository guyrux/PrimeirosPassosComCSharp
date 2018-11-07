using System;

/*
Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular
com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casa decimais.
Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço
do terreno, ambos com duas casas decimais.
 */

namespace S03_Aula18_ExercicioResolvido01 {
    class Program {
        static void Main(string[] args) {
            double largura, comprimento, valorMetroQquadrado;

            Console.Write("Digite a largura: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do metro quadrado: ");
            valorMetroQquadrado = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do terreno é "+ (largura*comprimento).ToString("F2") + ".");
            Console.WriteLine("O preço do terreno é "+ (largura*comprimento*valorMetroQquadrado).ToString("F2") + ".");

            Console.ReadLine();
        }
    }
}
