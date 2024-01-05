string curso = "C# Criando sua primeira aplicação.";

Console.WriteLine(curso);

string nome, sobrenome;
string? texto;

Console.WriteLine("Digite o nome: ");
texto = Console.ReadLine();
nome = texto is null? "" : texto;

Console.WriteLine("Digite o sobrenome: ");
texto = Console.ReadLine();
sobrenome = texto is null? "" : texto;

Console.WriteLine(nome+sobrenome);

string nomeDoPrimeiroInstrutor = "Daniel Portugal";
string nomeDoSegundoInstrutor = "Guilherme Lima";

Console.WriteLine($"Este curso é ministrado por:\n-{nomeDoPrimeiroInstrutor}\n-{nomeDoSegundoInstrutor}");