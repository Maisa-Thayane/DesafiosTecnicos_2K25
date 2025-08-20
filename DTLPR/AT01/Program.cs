using System.ComponentModel;          // Importa funcionalidades extras de componentes (não está sendo usado neste código).
using System.Runtime.CompilerServices; // Importa utilitários de compilador (também não está sendo usado aqui).

// Pergunta ao usuário o nome do personagem favorito e armazena na variável 'name'
Console.WriteLine("Qual o nome do seu personagem favorito?");
string? name = Console.ReadLine();

// Pergunta ao usuário em qual obra esse personagem aparece e armazena em 'assunto'
Console.WriteLine("Qual o nome do filme/serie/jogo que esse personagem faz parte?");
string? assunto = Console.ReadLine();

// Pergunta a idade do personagem e converte a resposta para número inteiro
Console.WriteLine("Qual a idade dele?");
int idade = Convert.ToInt32(Console.ReadLine());

// Declaração de variáveis que podem ser usadas depois
int vezes;       // Quantas vezes assistiu (filme)
double finalizar; // Quanto tempo levou para terminar (jogo)
float duracao;    // Duração do filme
int repetiu;      // Quantas vezes jogou novamente
int nota;         // Nota atribuída ao personagem/obra

// Pergunta se é um filme (1 = verdadeiro, 2 = falso)
Console.WriteLine("É um filme? Digite '1' para verdadeiro e '2' para falso.");
int filme = Convert.ToInt32(Console.ReadLine());

// Se for filme:
if (filme == 1) {
    Console.WriteLine("Qual o tempo de duração do filme? Em horas.");
    duracao = Convert.ToInt32(Console.ReadLine()); // Lê a duração em horas

    Console.WriteLine("Quantas vezes ja assistiu?");
    vezes = Convert.ToInt32(Console.ReadLine());   // Lê quantas vezes assistiu
} else {
    // Se não for filme (então é jogo ou série, pelo contexto):
    Console.WriteLine("Quanto tempo levou para terminar o jogo?");
    finalizar = Convert.ToInt32(Console.ReadLine()); // Tempo gasto no jogo

    Console.WriteLine("Quantas vezes ja jogou?");
    repetiu = Convert.ToInt32(Console.ReadLine());   // Quantidade de repetições
}

// Pergunta se recomendaria a outra pessoa
Console.WriteLine("Voce recomendaria para outra pessoa? Digite '1' para verdadeiro e '2' para falso.");
int aprovacao = Convert.ToInt32(Console.ReadLine());

// Exibe mensagem baseada na resposta
if (aprovacao == 1){
    Console.WriteLine("Irei me informar mais sobre!");
} else {
    Console.WriteLine("Não tenho tempo a perder com isso.");
}

// Pergunta a nota atribuída à obra/personagem
Console.WriteLine("Qual nota voce dá?");
nota = Convert.ToInt32(Console.ReadLine());

// Exibe o resumo final com as informações coletadas
Console.WriteLine("Então: " + name + " faz parte de " + assunto + " e tem " + idade + " anos de idade. " + 
                  "A nota dada foi: " + nota + ".");
