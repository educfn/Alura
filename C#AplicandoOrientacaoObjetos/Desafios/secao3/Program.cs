/*
1-Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
2-Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
3-Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
4-Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
5-Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
*/
using CSharpAplicandoOrientacaoObjetos.Desafios.secao3;
using System;

Console.WriteLine("Secao 3 Desafio!");

Console.WriteLine("Secao 3 Desafio 1, 2");
Conta conta;

conta = new(new Titular(25988864578, "Alberto de Souza Fernandes"), 2, 3);

conta.ExtratoDaConta();

Console.WriteLine("Secao 3 Desafio 3");

EstoqueProdutos estoque = new();

for(int i=0; i < 10; i++)
    estoque.AdicionarProduto(new Produto($"Produto " + i.ToString()));

estoque.ExibirProdutos();

Console.WriteLine("\n\nSecao 3 Desafio 4");

List<Professor> professores = new();
List<Disciplina> disciplinas = new();
List<Aluno> alunos = new();
Random rnd = new();

for(int i=0, j=0, l=0; i < 10; i++)
{
    alunos.Add(new($"Aluno {i+1}", rnd.Next(1,100)));

    if(i < 3)
        disciplinas.Add(new Disciplina($"Disciplina {++j}"));

    if(i > 6)
    {
        var novoProfessor = new Professor($"Professor {++l}");
            for(int z = 0; z < rnd.Next(1,3);z++)
                novoProfessor.AdicionarDisciplina(disciplinas[rnd.Next(1,3)]);
        professores.Add(novoProfessor);
    }
}

//TODO Adicionar de forma aleatoria alunos nas Disciplinas.

foreach(Aluno aluno in alunos)
{
    foreach(Professor professor in professores)
    {
        foreach(Disciplina disciplina in disciplinas)
        {
            if(professor.Disciplinas.Exists(c => c.Nome == disciplina.Nome))
                professor.AtribuirNota(aluno, disciplina, (float)rnd.Next(0,10)); //TODO verificar se o aluno esta na disciplina.
        }
    }
}

Console.WriteLine("\n\nAlunos: \n");
foreach(var aluno in alunos)
{
    aluno.DadosDoAluno();
    aluno.ExibirNotas();
}

Console.WriteLine("\n\nProfessores: \n");
foreach(var professor in professores)
{
    professor.ExibirDisciplinas();
}

Console.WriteLine("\n\nDisciplinas: \n");
foreach(var disciplina in disciplinas)
{
    disciplina.ExibirAlunos();
}

