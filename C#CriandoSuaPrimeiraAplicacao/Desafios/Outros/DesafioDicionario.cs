/*
04 - Dicionarios e avaliação de bandas
Desafio


    1.Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
    2.Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
    3.Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
    4.Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas. 
*/

using System.Runtime.CompilerServices;
using System.Linq;
using System.Security.AccessControl;
using Microsoft.VisualBasic;

namespace ScreenSound
{

    public static class DesafioDicionario
    {
        public static void Rodar()
        {
            int escolha = -1;
            
            if (escolha == -1)
            {
                var programa = new Escola();
                programa.Rodar();
            }
        }
    }

    internal class Escola
    {
        private struct Notas
        {
            private Dictionary<Disciplinas, float> notasDisciplinas;

            public Notas()
            {
                notasDisciplinas = new Dictionary<Disciplinas, float>();
                foreach(var enumerador in Enum.GetNames(typeof(Disciplinas)))
                {
                    notasDisciplinas.Add(
                        (Disciplinas)Enum.Parse(typeof(Disciplinas),enumerador)
                        ,0.0f);
                }
            }

            public bool MudarNota(Disciplinas dis, float novaNota)
            {
                if (novaNota < 0 || novaNota > 10) return false;

                notasDisciplinas[dis] = novaNota;
                return true;
            }

            public enum Disciplinas
            {
                Matematica,
                Portugues,
                Ingles,
                Fisica,
                Geografia,
                Historia
            }
        }

        Dictionary<string, Notas> alunos;

        public Escola()
        {
            alunos = new();
        }

        private bool Cadastrar(string nomeDoAluno)
        {
            if(nomeDoAluno is null) return false;

            return alunos.TryAdd(nomeDoAluno, new Notas());
        }

        private bool AdicionarNota(string nomeDoAluno, float nota)
        {
            if(nomeDoAluno is null || (alunos.TryGetValue(nomeDoAluno, out float[]? notasObtidas))) 
                return false;

            if(notasObtidas is null) notasObtidas = Array.Empty<float>();

            alunos[nomeDoAluno] = notasObtidas.Append(nota).ToArray();

            return true;
        }

        private bool MudarNota(string nomeDoAluno, float notaRemover)
        {
            if(nomeDoAluno is null 
            || (alunos.TryGetValue(nomeDoAluno, out float[]? notasObtidas))
            || notasObtidas is null) 
                return false;

            bool valorEncontrado = false;

            for(int i = 0;i < notasObtidas.Length && valorEncontrado == false; i++)
            {
                if(notasObtidas[i] == notaRemover)
                {

                }
            }

            alunos[nomeDoAluno] = notasObtidas.Append(nota).ToArray();

            return true;
        }

        private bool Remover(string nomeDoAluno, out float[]? notas)
        {
            if (nomeDoAluno is null)
            {
                notas = null;
                return false;
            }

            bool alunoEncontrado = alunos.TryGetValue(nomeDoAluno, out notas);
            
            if(alunoEncontrado == true) alunos.Remove(nomeDoAluno);

            return alunoEncontrado;
        }

        private float MediaDoAluno(string nomeDoAluno)
        {
            if(nomeDoAluno is null) return -1;

            bool alunoEncontrado = alunos.TryGetValue(nomeDoAluno, out var notas);

            if (alunoEncontrado) return notas is null ? -1 : notas.Average();

            return -1;
        }

        public void Rodar()
        {
            bool NaoTerminou = true;
            while(NaoTerminou)
            {
                Console.WriteLine(
                $"Bem vindo ao sistema de notas da Escola X"+
                "\nEscolha no menu abaixo o que deseja fazer: "+
                "\n1 - Cadastrar novo aluno"+
                "\n2 - Remover aluno"+
                "\n3 - Ver a media das notas de um aluno"+
                "\n4 - Sair do programa"
                );
                bool rodarPrograma = true;
                while(rodarPrograma)
                {
                    int escolha = -1;
                    char caracter = ' ';
                    caracter = (char)Console.Read();

                    switch(caracter)
                    {
                        case '1':
                            escolha = 1;
                        break;

                        case '2':
                            escolha = 2;
                        break;

                        case '3':
                            escolha = 3;
                        break;
                        
                        case '4':
                            escolha = 4;
                        break;

                        default:
                            Console.Write("\b \b");
                        break;
                    }

                    if(escolha != -1)
                    {
                        if(escolha == 1)
                        {
                            Console.WriteLine($"Escreva o nome do aluno: ");
                            string? nome = null;
                            while(nome is null)
                            {
                                nome = Console.ReadLine();
                            }
                            Console.WriteLine($"Escreva o nome do aluno: ");
                            while(nome is null)
                            {
                                nome = Console.ReadLine();
                            }
                            Cadastrar(nome,);
                        }
                    }

                }
                Console.WriteLine("Deu certo!");
            }
            Console.WriteLine("Terminou");
        }
    }

    internal class Estoque
    {
        Dictionary<string,int> estoque;

        public Estoque()
        {
            estoque = new();
        }

        public void Adicionar(string nomeDoProduto, int quantidadeDoProduto)
        {
            if (nomeDoProduto is null) return;

            estoque.TryAdd(nomeDoProduto, quantidadeDoProduto);
        }

        public bool Remove(string nomeDoProduto)
        {
            if(nomeDoProduto is null) return false;

            return estoque.Remove(nomeDoProduto);
        }

        public int MostrarQuantidade(string nomeDoProduto)
        {
            int quantidade = -1;

            if(nomeDoProduto is null) return quantidade;

            estoque.TryGetValue(nomeDoProduto, out quantidade);

            return quantidade;
        }
    }

    internal class Quiz
    {
        Dictionary<string, string> perguntasRespostas;

        public Quiz()
        {
            perguntasRespostas = new();
        }

        public void Adicionar(string pergunta, string resposta)
        {
            if (pergunta is null || resposta is null) return;

            perguntasRespostas.TryAdd(pergunta, resposta);
        }

        public bool Remover(string pergunta)
        {
            if (pergunta is null) return false;

            perguntasRespostas.Remove(pergunta);

            return true;
        }

        public void Perguntar()
        {
            Random rand = new();
            var lista = perguntasRespostas.ToList();
            string[] respostas = new string[3];
            int numeroRespostaCorreta = rand.Next(respostas.Length-1);

            Console.WriteLine("Qual a resposta correta para a seguinte pergunta:");

            for(int i = 0; i <= respostas.Length-1; i++)
            {
                int numeroRespostaAleatorio = rand.Next(lista.Count()-1);

                if(i == numeroRespostaCorreta) Console.WriteLine(lista[numeroRespostaAleatorio].Key);

                respostas[i] = lista[numeroRespostaAleatorio].Value;
            }

            Console.WriteLine($"\n1.{respostas[0]}\n 2.{respostas[1]}\n 3.{respostas[2]}\n");
            Console.ReadKey();
        }
    }

    internal class Login
    {
        Dictionary<string,string> contas;

        public Login()
        {
            contas = new();
            contas.Add("admin","admin");
        }

        public string Cadastrar(string nomeDoUsuario, string senha)
        {
            if (nomeDoUsuario is null) return "Nome do Usuario não foi preenchido";
            if (senha is null) return "Senha não foi preenchida";

            bool contaJaExiste = !(contas.TryAdd(nomeDoUsuario, senha));
            if (contaJaExiste) return "Conta já foi cadastrada.";
            return "Conta foi cadastrada com sucesso!";
        }

        public bool DeletarConta(string nomeDoUsuario, string senha)
        {
            if (nomeDoUsuario is null|| senha is null) return false;

            bool usuarioEncontrado = contas.TryGetValue(nomeDoUsuario, out var senhaObtida);

            if (usuarioEncontrado && senhaObtida is not null && senhaObtida == senha)
            {
                contas.Remove(nomeDoUsuario);
                return true;
            }
            return false;
        }

        public bool RealizarLogin(string nomeDoUsuario, string senha)
        {
            if (nomeDoUsuario is null || senha is null)
            {
                Console.WriteLine("Nome do Usuario ou Senha vazia!");
                return false;
            }

            bool usuarioEncontrado = contas.TryGetValue(nomeDoUsuario, out var senhaObtida);

            if (usuarioEncontrado && senhaObtida is not null && senhaObtida == senha)
            {
                Console.WriteLine("Você realizou o login com sucesso!");
                return true;
            }

            return false;
        }
    }
}