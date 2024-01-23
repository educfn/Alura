/*
    Desafio: Tipos e Funcoes C#
    1- Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
    2- Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
    3- Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
    4- Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
*/

// Atividade 1
{
    Console.WriteLine("Atividade 1");

    Console.WriteLine("\nDigite o valor da nota:");
    bool numeroValido = false;
    int nota = -1;

    while(numeroValido == false)
    {
        string? valorDigitado = null;
        valorDigitado = Console.ReadLine();
        if (valorDigitado != null && int.TryParse(valorDigitado, out nota) && (nota >=0) && (nota <=10))
            numeroValido = true;
        else Console.WriteLine("\nNumero da nota deve ser entre 0 e 10.");
    }

    if (nota >= 5) Console.WriteLine("\nNota suficiente para aprovação");
    else Console.WriteLine("\nNota insuficiente para aprovação");
}
//Atividade 2 e 3
{
    Console.WriteLine("\nAtividade 2 e 3");

    Console.WriteLine("\nEscolha uma linguagem\n1-C#\n2-Java\n3-Javascript");

    bool linguagemEscolhida = false;
    int numeroLinguagemEscolhida = -1;
    string mensagem = "\nLinguagem escolhida: ";

    while(linguagemEscolhida == false)
    {
        string? escolhaDaLinguagem = null;
        escolhaDaLinguagem = Console.ReadLine();
        
        if(int.TryParse(escolhaDaLinguagem, out numeroLinguagemEscolhida))
        switch(numeroLinguagemEscolhida)
        {
            case 1:
                mensagem += "C#";
                linguagemEscolhida = true;
                break;
            case 2:
                mensagem += "Java";
                linguagemEscolhida = true;
                break;
            case 3:
                mensagem += "Javascript";
                linguagemEscolhida = true;
                break;
            default:
                Console.WriteLine("Escolha uma das três linguagem.");
                break;
        }
    }

    Console.WriteLine(mensagem);
}
// Atividade 4
{    
    Console.WriteLine("\n\nAtividade 4");

    System.Random rnd = new();
    int [] arrayDeNumeros = new int [100];
    bool valorErrado = true;

    for(int i = 0; i < 100; i++) arrayDeNumeros[i] = rnd.Next(int.MinValue, int.MaxValue);

    Console.WriteLine("Selecione um numero de 0 a 100 que represente uma posicao da lista: ");
    do
    {
        string? numeroEscolhido = Console.ReadLine();
        if(int.TryParse(numeroEscolhido, out int nEsimaPosicao) && (nEsimaPosicao >=0) && (nEsimaPosicao<=100))
        {
            Console.WriteLine($"Valor escolhido: {arrayDeNumeros[nEsimaPosicao]}");
            valorErrado = false;
        }
        else Console.WriteLine("Escolha um numero entre 0 e 100.");
    }
    while(valorErrado);
}
