Console.WriteLine("Tente advinhar o número que estou pensando: ");
int numeroAleatorio = GerarNumeroAleatorio();
int numeroAdvinhado = -1;
string mensagem = string.Empty;
while (numeroAdvinhado != numeroAleatorio)
{
    string? resposta = Console.ReadLine();
    
    if (resposta == null || !(int.TryParse(resposta, null, out numeroAdvinhado)))
    {
        mensagem = "escolha um numero inteiro";
    }
    else if (numeroAdvinhado != numeroAleatorio)
    {
        mensagem = "Numero adivinhado é ";
        if (numeroAdvinhado > numeroAleatorio) mensagem += "maior";
        else mensagem += "menor";
        mensagem += " que o numero escolhido.";
    }

    Console.WriteLine(mensagem);
    mensagem = string.Empty;
}

Console.WriteLine("Parabéns você advinhou o número!");

int GerarNumeroAleatorio()
{
    int numeroAleatorio;
    Random rand = new Random();
    numeroAleatorio = rand.Next(1, 100);
    return numeroAleatorio;
}
