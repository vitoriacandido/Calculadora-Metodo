using Layout;

namespace Calculadora
{
    class Operacoes
    {

        public static decimal ObterValor()
        {
        repetir:
            Console.WriteLine("Informe um valor: ");
            Formatacao.Cor("Informe um valor: ", ConsoleColor.Blue);
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor Inválido! ");
                goto repetir;
            }
            else
            {
                return valor;
            }
        }


        public static void RealizarAdicao(
            decimal valor1,
            decimal valor2
        )

        {
            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {valor1 + valor2}. ");
        }

    }
}