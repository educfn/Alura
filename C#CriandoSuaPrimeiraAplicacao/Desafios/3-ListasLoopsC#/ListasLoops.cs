/*
    Modulo 3 - Listas de Loops
    1.Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
    2.Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
    3.Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
    4.Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
*/
// Atividade-1
{
    string? valor = string.Empty;
    bool continuarLoop = true;
    float? a = null, b = null; 
    Console.WriteLine($"\nAtividade 1");
    do
    {
        if (a == null)
            Console.WriteLine("Digite o primeiro valor: ");
        else
            Console.WriteLine("Digite o segundo valor: ");
        valor = Console.ReadLine();
        if(float.TryParse(valor, out float valorFloat))
        {
            if(a == null) a = valorFloat;
            else b = valorFloat;
        }

        if (a != null && b != null) continuarLoop = false;
    }
    while (continuarLoop);
    float x = (float)a!, y = (float)b!;
    CalculadoraQuatroBasicas(x, y);
}

void CalculadoraQuatroBasicas(float a, float b)
{
    float soma = 0.0f, subtracao = 0.0f, divisao = 0.0f, multiplicacao = 0.0f;

    soma = a + b;
    subtracao = a - b;
    if (a == 0.0f || b == 0.0f)
    {
        divisao = 0.0f;
        multiplicacao = 0.0f;
    }
    else
    {
        divisao = a / b;
        multiplicacao = a * b;
    }

    Console.WriteLine($"\nSoma: {soma}\nSubtração: {subtracao}\nDivisão: {divisao}\nMultiplicacao: {multiplicacao}");
}


