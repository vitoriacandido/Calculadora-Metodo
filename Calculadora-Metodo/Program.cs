using Calculadora;

Operações.RealizarAdicao(valor1,valor2);

if(!decimal.TryParse(Console.ReadLine(),out decimal valor1,valor2))
{
    Console.WriteLine("Valor Inválido! ");
}

