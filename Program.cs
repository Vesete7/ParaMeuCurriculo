using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Título: Verificação de Vogal ou Consoante

        // O que foi utilizado:
        // Foi utilizado o sistema Console para entrada e saída de dados e o método Char.ToLower para garantir que a verificação funcione para letras maiúsculas e minúsculas.
        
        // Etapas implementadas:
        // 1. Solicitação de uma letra ao utilizador.
        // 2. Conversão da letra para minúscula, garantindo uma comparação consistente.
        // 3. Verificação se a letra é uma vogal (a, e, i, o, u).
        // 4. Impressão da mensagem adequada, indicando se a letra é uma vogal ou não.

        Console.Write("Digite uma letra: ");
        char letra = Console.ReadKey().KeyChar; // Recebe a letra do utilizador
        letra = Char.ToLower(letra); // Converte para minúscula

        // Verifica se a letra é uma vogal
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            // Imprime mensagem se for uma vogal
            Console.WriteLine("\nA letra '{0}' é uma vogal.", letra);
        }
        else
        {
            // Imprime mensagem se não for uma vogal
            Console.WriteLine("\nA letra '{0}' não é uma vogal.", letra);
        }

        // Backlog:
        // 1. Implementar suporte para identificar caracteres que não são letras.
        // 2. Verificar e tratar erros de entrada (por exemplo, entradas numéricas ou caracteres especiais).
        // 3. Possibilitar verificação de múltiplas letras numa única execução.

        // Conclusão:
        // Este programa verifica se o caractere fornecido é uma vogal ou consoante. Ele pode ser melhorado para validar se a entrada é uma letra e tratar possíveis erros.
    }
}





