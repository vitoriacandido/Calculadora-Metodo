# Calculadora-Metodo
**Criando metodos no uso do cs em C#.**

# PRIMEIRO MÉTODO
![alt text](image.png)
=======
# SEGUNDO MÉTODO
![alt text](IMG/(2).png)

---------------------------------------------------------------------------------------------------------
### Estrutura Geral do Método:

[modificador] [tipo de retorno]
NomeDoMetodo([parâmetros])
{
    // Código do método
    return valor; // (Se necessário)
}
---------------------------------------------------------------------------------------------------------

- **[modificador]**: Esse é o modificador de acesso ou de comportamento do método. No exemplo, `public` é um modificador que indica que o método pode ser acessado de qualquer lugar. Outros exemplos incluem `private`, `protected`, etc.
  
- **[tipo de retorno]**: Especifica o tipo de valor que o método vai retornar. Por exemplo, `decimal` ou `void` (quando não retorna nada). No exemplo dado, temos `decimal` para o método `ObterValor` e `void` para o método `RealizarAdicao`, o que significa que `RealizarAdicao` não retorna nada.

- **NomeDoMetodo**: O nome do método, que neste caso é `ObterValor` e `RealizarAdicao`. Esse é o identificador usado para chamar o método em outro lugar no código.

- **[parâmetros]**: São os valores que você passa para o método ao chamá-lo. No exemplo, o método `RealizarAdicao` recebe dois parâmetros do tipo `decimal`, chamados `valor1` e `valor2`. O método `ObterValor` não tem parâmetros.

### Explicando o Código:

1. **Namespace `Calculadora`:**
   - É uma maneira de organizar o código, criando um "espaço" onde você pode agrupar suas classes e métodos relacionados. No exemplo, ele está agrupando a classe `Operacoes` dentro de um namespace `Calculadora`.

2. **Classe `Operacoes`:**
   - Dentro do namespace, a classe `Operacoes` contém dois métodos: `ObterValor` e `RealizarAdicao`. A classe pode ter métodos, propriedades e outros membros.

3. **Método `ObterValor`:**
   - **Tipo de Retorno:** `decimal` (o método retorna um valor do tipo `decimal`).
   - **Objetivo:** Este método pede para o usuário inserir um valor. Se o valor inserido não for um número válido (não puder ser convertido para `decimal`), ele exibe uma mensagem de erro e repete o processo até que o valor seja válido.
   - **Explicação:**
     - O método usa o `decimal.TryParse` para tentar converter o valor inserido pelo usuário em um número decimal.
     - Se a conversão falhar, o código utiliza um `goto` para repetir o processo de leitura.
     - Quando um valor válido é inserido, o método retorna esse valor.
   
4. **Método `RealizarAdicao`:**
   - **Tipo de Retorno:** `void` (não retorna nenhum valor).
   - **Objetivo:** Este método recebe dois parâmetros do tipo `decimal` (valores para somar) e exibe o resultado da soma na tela.
   - **Explicação:**
     - O método imprime na tela uma mensagem que mostra o resultado da soma de `valor1` e `valor2`.

### Resumo:

- **Modificadores e Tipos de Retorno:**
  - O modificador `public` permite que o método seja acessado fora da classe.
  - O tipo de retorno (`decimal` ou `void`) indica se o método vai retornar algum valor ou não.
  
- **Métodos:**
  - `ObterValor` solicita um número ao usuário e retorna esse número.
  - `RealizarAdicao` recebe dois valores e imprime o resultado da soma.
  
- **Controle de Fluxo:**
  - O `goto repetir;` é usado no método `ObterValor` para criar um loop caso o valor digitado não seja válido.



