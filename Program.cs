using Calculadora;

repetir:
Console.WriteLine("Escolha um número: ");
if(!decimal.TryParse(Console.ReadLine(),out decimal valor1))
{
    Console.WriteLine("Valor Inválido! ");
    goto repetir;
}

repetir_valor2:
Console.WriteLine("Escolha um número: ");
if(!decimal.TryParse(Console.ReadLine(),out decimal valor2))
{
    Console.WriteLine("Valor Inválido! ");
    goto repetir_valor2;
}

Operacoes.RealizarAdicao(valor1,valor2);



