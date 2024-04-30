/*
A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar então?

    1 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
    2- Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
    3- Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
    4 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
*/

Random rand = new Random();
//1 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
{
    Console.WriteLine("Atividade 1");
    Dictionary<string, float> notasAluno = new();
    notasAluno.Add("Matematica", rand.Next(0,10));
    notasAluno.Add("Portugues", rand.Next(0,10));
    notasAluno.Add("Ingles", rand.Next(0,10));
    notasAluno.Add("Geografia", rand.Next(0,10));
    notasAluno.Add("Historia", rand.Next(0,10));
    float media = 0.0f;
    int quantidadeMateriais = 0;
    foreach(var nota in notasAluno)
    {
        media += nota.Value;
        quantidadeMateriais++;
        Console.WriteLine($"{nota.Key}: {nota.Value}");
    }
    media /= quantidadeMateriais;
    Console.WriteLine($"Media das notas: {media}");
}
//2- Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
{
    Console.WriteLine("\nAtividade 2");
    Dictionary<string, float> produtosDaLoja = new();
    produtosDaLoja.Add("Leite", rand.Next(0,100));
    produtosDaLoja.Add("Saco de Feijão", rand.Next(0,100));
    produtosDaLoja.Add("Bolacha", rand.Next(0,100));
    produtosDaLoja.Add("Salsicha", rand.Next(0,100));
    produtosDaLoja.Add("Iogurte", rand.Next(0,100));

    foreach(var produto in produtosDaLoja)
    {
        Console.WriteLine($"Quantidade de {produto.Key}: {produtosDaLoja[produto.Key]}");
    }
}
//3- Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
{
    Console.WriteLine("\nAtividade 3");
    Dictionary<string, string> perguntas = new();
    perguntas.Add("Quantas rodas tem um carro?", "Quatro");
    perguntas.Add("Quantos pés tem um elefante?", "Quatro");
    perguntas.Add("O nome de um item que tem folhas de papel, palavras e capa?", "Livro");
    perguntas.Add("Se a vida te da x faça uma limonada, o que é x?", "Limões");
    perguntas.Add("Nome do conjunto de lobos", "Alcateia");
    bool jogarQuiz = true;
    int respostasCorretas = 0;
    while(jogarQuiz)
    {
        string respostas = "\nRespostas possiveis:\n";
        foreach(var pergunta in perguntas)
        {
            respostas += $"{pergunta.Value}\n";
        }

        foreach(var pergunta in perguntas)
        {
            Console.WriteLine($"{pergunta.Key}:\n{respostas}");
            string? respostaEscolhida = Console.ReadLine();
            if(respostaEscolhida != null && respostaEscolhida == pergunta.Value)
            {
                respostasCorretas++;
                Console.WriteLine("\nResposta Correta\n");
            }
            else
            {
                Console.WriteLine("\nResposta Errada\n");
            }
            Console.ReadKey();
        }
        Console.WriteLine($"\nVocê acertou {respostasCorretas} de {perguntas.Count()}\nContinuar a jogar?(n/s)");
        string? respostaJogo = Console.ReadLine();
        if(respostaJogo != null && (respostaJogo[0] == 'n' || respostaJogo[0] == 'N')) jogarQuiz = false;
    }
}
//4 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
{
    Dictionary<string,string> contas = new();

    Console.WriteLine("Atividade - 4");
    bool usandoPrograma = true, tudoCorreto = false;
    do
    {
        Console.WriteLine("\n Escolha:\n1-Login\n2-Cadastrar");
        string? resposta = Console.ReadLine();
        if(resposta != null && int.TryParse(resposta, out int escolha))
        {
            switch(escolha)
            {
                case 1:
                {
                    break;
                }
                case 2:
                {
                    tudoCorreto = false;
                    string? nomeLogin = null, senhaLogin = null;
                    do
                    {
                        if(nomeLogin == null)
                        {

                        
                            Console.WriteLine("Bem vindo ao cadastro!\nDigite o nome da conta sem espaço:");
                            do
                            {
                                string? nome = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(nome))
                                    Console.WriteLine("Preenchar algo no nome para o login.");
                                else if (nome.Contains(' '))
                                    Console.WriteLine("O nome no login não pode ter espaço.");
                                else if (contas.ContainsKey(nome))
                                    Console.WriteLine("Nome do login já existe.");
                                else
                                {
                                    nomeLogin = nome;
                                    tudoCorreto = true;
                                }
                            }
                            while(tudoCorreto != true);
                        }
                        else
                        {
                            tudoCorreto = false;
                            Console.WriteLine("\nDigite a senha:");
                            do
                            {
                                string? senha = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(senha))
                                    Console.WriteLine("Preenchar algo no senha do login.");
                                else if (senha.Contains(' '))
                                    Console.WriteLine("O senha do login não pode ter espaço.");
                                else if (contas.ContainsKey(senha))
                                    Console.WriteLine("senha do login já existe.");
                                else
                                {
                                    senhaLogin = senha;
                                    tudoCorreto = true;
                                }
                            }
                            while(tudoCorreto != true);
                        }

                    }
                    while(!tudoCorreto);
                    break;
                }
            }
        }
    }
    while(usandoPrograma);
}