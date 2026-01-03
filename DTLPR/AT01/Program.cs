// Coletando informações sobre um personagem favorito

Console.WriteLine("Qual o nome do seu personagem favorito?");
string? nome = Console.ReadLine();

Console.WriteLine("Em qual filme, série ou jogo ele aparece?");
string? obra = Console.ReadLine();

Console.WriteLine("Qual a idade do personagem?");
int idade;
while (!int.TryParse(Console.ReadLine(), out idade))
{
    Console.WriteLine("Digite uma idade válida:");
}

// Pergunta se é um filme
Console.WriteLine("É um filme? Digite 1 para SIM ou 2 para NÃO.");
int tipo;
while (!int.TryParse(Console.ReadLine(), out tipo) || (tipo != 1 && tipo != 2))
{
    Console.WriteLine("Opção inválida. Digite 1 ou 2.");
}

if (tipo == 1)
{
    Console.WriteLine("Qual a duração do filme (em horas)?");
    double duracao;
    while (!double.TryParse(Console.ReadLine(), out duracao))
    {
        Console.WriteLine("Digite um valor válido:");
    }

    Console.WriteLine("Quantas vezes você já assistiu?");
    int vezes;
    while (!int.TryParse(Console.ReadLine(), out vezes))
    {
        Console.WriteLine("Digite um número válido:");
    }
}
else
{
    Console.WriteLine("Quanto tempo levou para finalizar o jogo (em horas)?");
    double tempoFinalizacao;
    while (!double.TryParse(Console.ReadLine(), out tempoFinalizacao))
    {
        Console.WriteLine("Digite um valor válido:");
    }

    Console.WriteLine("Quantas vezes você jogou?");
    int repeticoes;
    while (!int.TryParse(Console.ReadLine(), out repeticoes))
    {
        Console.WriteLine("Digite um número válido:");
    }
}

// Recomendação
Console.WriteLine("Você recomendaria essa obra? Digite 1 para SIM ou 2 para NÃO.");
int recomendaria;
while (!int.TryParse(Console.ReadLine(), out recomendaria) || (recomendaria != 1 && recomendaria != 2))
{
    Console.WriteLine("Opção inválida. Digite 1 ou 2.");
}

Console.WriteLine(recomendaria == 1
    ? "Vou procurar mais informações sobre isso!"
    : "Talvez não seja do meu interesse.");

// Nota final
Console.WriteLine("Qual nota você dá para essa obra?");
int nota;
while (!int.TryParse(Console.ReadLine(), out nota))
{
    Console.WriteLine("Digite uma nota válida:");
}

// Resumo
Console.WriteLine($"\nResumo:");
Console.WriteLine($"{nome} faz parte de {obra} e tem {idade} anos.");
Console.WriteLine($"Nota atribuída: {nota}");
