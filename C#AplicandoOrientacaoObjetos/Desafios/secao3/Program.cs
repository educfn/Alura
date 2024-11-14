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

for(int numeroDeAlunos=0, numeroDeDisciplinas=0, numeroDeProfessores=0; numeroDeAlunos < 10; numeroDeAlunos++)
{
    // Criar alunos
    alunos.Add(new($"Aluno {numeroDeAlunos + 1}", rnd.Next(1,100)));

    // Criar as disciplinas
    if(numeroDeDisciplinas <= 3)
        disciplinas.Add(new Disciplina($"Disciplina {++numeroDeDisciplinas}"));
    // Criar os professores e adiciona-los a alguma das disciplinas.
    else if(numeroDeProfessores <= 4)
    {
        var novoProfessor = new Professor($"Professor {++numeroDeProfessores}");
            for(int disciplinasAdicionadaAoProfessor = 0; disciplinasAdicionadaAoProfessor < rnd.Next(1,3);disciplinasAdicionadaAoProfessor++)
                novoProfessor.AdicionarDisciplina(disciplinas[rnd.Next(1,3)]);
        professores.Add(novoProfessor);
    }
}

//Adicionar de forma aleatoria alunos nas Disciplinas.
foreach(Disciplina disciplina in disciplinas)
{
    foreach(Aluno aluno in alunos)
    {
        var AlunoSeraAtribuidoAEssaDisciplina = ((rnd.Next(0,100)) >= 50);
        if (AlunoSeraAtribuidoAEssaDisciplina)
            disciplina.AdicionarAlunos(aluno);
    }
}

// Atribuir nota aos alunos
foreach (Disciplina disciplina in disciplinas)
{
    foreach (Professor professor in professores)
    {
        if (professor.Disciplinas.Exists(c => c.Nome == disciplina.Nome))
        {
            foreach (Aluno aluno in alunos)
            {
                professor.AtribuirNota(aluno, disciplina, (float)rnd.Next(0, 10));
            }
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

