namespace guessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este projeto trabalha com:
            //  - variáveis do tipo int e bool
            //  - condicionais
            //  - operador lógico &&
            //  - operadores de comparação
            //  - loop while

            string input;
            int numeroDigitado = -1;
            int tentativa = 1;
            ConsoleColor color = Console.ForegroundColor; // Salva a cor atual do texto no console

            // Sorteia um número inteiro de 1 a 100
            Random rnd = new Random();
            int numeroSorteado = rnd.Next(1, 101);

            // Exibe o número sorteado
            // Console.WriteLine("Número sorteado: " + numeroSorteado);

            Console.WriteLine("Tente adivinhar o número de 1 a 100! \n");

            do
            {
                Console.Write("Tentativa " + tentativa + ": ");
                input = Console.ReadLine();

                if(inputEhValido(input))
                {
                    numeroDigitado = Int32.Parse(input);
                    if(numeroDigitado > numeroSorteado)
                        Console.WriteLine("O número sorteado é menor que " + numeroDigitado + ". \n");
                    else if(numeroDigitado < numeroSorteado)
                        Console.WriteLine("O número sorteado é maior que " + numeroDigitado + ". \n");
                    
                    tentativa++;
                }
                else
                    Console.WriteLine("Tentativa inválida! Digite um  inteiro de 1 a 100. \n");

            } while(numeroDigitado != numeroSorteado);

            // Muda a cor do texto do console para verde
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Você adivinhou! O número sorteado era " + numeroDigitado + "! \n");

            // Retorna a cor do texto do console para a cor original
            Console.ForegroundColor = color;

            Console.WriteLine("Pressione qualquer tecla para fechar.");
            Console.ReadLine();
            
            // Método de validação do input do usuário
            bool inputEhValido(string input)
            {
                // Checa se o input do usuário pode ser convertido para número e se está entre 1 e 100.
                if(Int32.TryParse(input, out int numero) && numero <= 100 && numero >= 1)
                    return true;

                return false;
            }
        }
    }
}