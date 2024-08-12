namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3;
//A classe Professor deve ter informações sobre nome e disciplinas lecionadas.

public class Professor
{
    private string nome;

    private List<Disciplina> disciplinas;

    public Professor(string nome)
    {
        this.nome = nome;
        disciplinas = new();
        Disciplinas = disciplinas;
    }

    public string Nome => nome;

    public List<Disciplina> Disciplinas {get;}

    public void AdicionarDisciplina(Disciplina novaDisciplina)
    {
        if(!disciplinas.Exists(c => c.Nome == novaDisciplina.Nome))
            disciplinas.Add(novaDisciplina);
    }

    public void ExibirDisciplinas()
    {
        Console.Write($"\nProfessor: {nome} - ");
        foreach(var disciplina in disciplinas)
            Console.Write($"{disciplina.Nome}, ");
    }

    public void AtribuirNota(Aluno aluno, Disciplina disciplina, float nota)
    {
        aluno.AdicionarNota(disciplina.Nome, nota);
    }
}