//ADIVINHAÇÃO

Random aleatorio = new Random();

int numeroSecreto = aleatorio.Next(1,101);

do {
    Console.WriteLine("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    } else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior que o seu chute.");
    } else
    {
        Console.WriteLine("O número secreto é menor que o seu chute.");
    }
} while (true);