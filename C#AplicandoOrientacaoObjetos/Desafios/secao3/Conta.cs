namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3
{
    public class Conta
    {
        private Titular titular;

        private long numeroDaAgencia;

        private long numeroDaConta;

        private double saldo;

        private double limite;

        public Conta(Titular titular,long numeroDaAgencia,long numeroDaConta)
        {
            this.titular = titular;
            this.numeroDaAgencia = numeroDaAgencia;
            this.numeroDaConta = numeroDaConta;
            limite = 0.0;
            saldo = 0.0;
        }

        public void AlterarSaldo(double valor)
        {
            saldo += valor;
        }

        public void ExtratoDaConta()
        {
            Console.WriteLine($"\nTitular:" 
            + $"\n Nome: {titular.NomeDoTitular}"
            + $"\n CPF: {titular.CPF}"
            + $"\nNumero da Agência: {numeroDaAgencia}"
            + $"\nNumero da Conta: {numeroDaConta}"
            + $"\nSaldo: R${saldo}"
            + $"\nLimite da Conta: R${limite}");
        }
    }
};
