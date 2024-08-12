namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3
{
    public class Titular
    {
        public long CPF { get; set;}

        public string NomeDoTitular {get; set;}

        public Titular(long cpf, string nomeDoTitular)
        {
            CPF = cpf;
            NomeDoTitular = nomeDoTitular; 
        }
    }
}
