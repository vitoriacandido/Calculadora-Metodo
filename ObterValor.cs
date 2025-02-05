namespace ObterValor

{
    class MetodoAlternativo
{
     public static void ObterValor(
      decimal num1,
      decimal num2,
      decimal valores
     )
      
     {
            if (valores=num1+num2)
        {
            Console.WriteLine($"A soma dos valores {num1} e {num2} é {valores}. ");
        
        }
        else
        {
            Console.WriteLine($"Opção inválida");
        }
     }


}

}
