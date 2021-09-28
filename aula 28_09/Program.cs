using System;

namespace aula_28_09
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao gerente = new Gerente();
            gerente.valorBonificacao(500);
            Console.WriteLine("--------");

            CalcularBonificacao analista = new Analista();
            analista.valorBonificacao(300);
            Console.WriteLine("--------");

            CalcularBonificacao secretaria = new Secretaria();
            secretaria.valorBonificacao(100);
            Console.WriteLine("--------");

            Console.ReadKey();
        }
    }
}
