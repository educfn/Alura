namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3;

//A classe Aluno deve ter informações como nome, idade e notas.
public class Aluno
{
    private string nome;
    private int idade;
    private Dictionary<string,float> notasDasDisciplinas;

    public Aluno(string nomeDoAluno, int idadeDoAluno)
    {
        nome = nomeDoAluno;
        idade = idadeDoAluno;
        notasDasDisciplinas = new();
    }

    public string Nome => nome;

    public int Idade => idade;

    public void AdicionarNota(string nomeDaNota, float nota)
    {
        notasDasDisciplinas.TryAdd(nomeDaNota,nota);
    }

    public void DadosDoAluno()
    {
        Console.Write($"\nNome: {nome} - Idade: {idade}");
    }

    public void ExibirNotas()
    {
        if (notasDasDisciplinas.Count == 0 )
            Console.Write($"\nAluno não está matriculado em nenhuma disciplina.");
        else
        {
            Console.Write($"\nAluno: {nome} - notas: ");
            foreach(string nomeDaDisciplina in notasDasDisciplinas.Keys)
                Console.Write($"{nomeDaDisciplina} - nota {notasDasDisciplinas[nomeDaDisciplina]}, ");
        }
    }
}