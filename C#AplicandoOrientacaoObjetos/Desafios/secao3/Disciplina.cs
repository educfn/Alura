namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3;
//A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

public class Disciplina
{
    public string nome;

    public List<Aluno> alunos;

    public Disciplina(string nome)
    {
        this.nome = nome;
        alunos = new();
    }

    public string Nome => nome;

    public void AdicionarAlunos(Aluno novoAluno)
    {
        alunos.Add(novoAluno);
    }

    public void ExibirAlunos()
    {
        Console.Write($"Disciplina: {nome} - ");
        foreach(Aluno aluno in alunos)
            Console.Write($"{aluno.Nome}, ");
        Console.Write("\n");
    }
}