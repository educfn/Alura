namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3;

//A classe Aluno deve ter informações como nome, idade e notas.
public class Aluno
{
    private string nome;
    private int idade;
    private Dictionary<string,float> notas;

    public Aluno(string nomeDoAluno, int idadeDoAluno)
    {
        nome = nomeDoAluno;
        idade = idadeDoAluno;
        notas = new();
    }

    public string Nome => nome;

    public int Idade => idade;

    public void AdicionarNota(string nomeDaNota, float nota)
    {
        notas.TryAdd(nomeDaNota,nota);
    }

    public void DadosDoAluno()
    {
        Console.WriteLine($"\nNome: {nome} - Idade: {idade}");
    }

    public void ExibirNotas()
    {
        Console.Write($"\nAluno: {nome} - notas: ");
        foreach(float nota in notas.Values)
            Console.Write($"{nota}, ");
    }
}