using Calculadora;

repetir:
Console.WriteLine("Escolha um número: ");
if(!decimal.TryParse(Console.ReadLine(),out decimal valor1))
{
    Console.WriteLine("Valor Inválido! ");
    goto repetir;
}

Console.WriteLine("Escolha um número: ");
if(!decimal.TryParse(Console.ReadLine(),out decimal valor2))
{
    Console.WriteLine("Valor Inválido! ");
    goto repetir;
}

Operacoes.RealizarAdicao(valor1,valor2);



