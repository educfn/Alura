namespace Desafios.DesafioContaBancaria
{
    internal class DesafioContaBancariaProgram
    {
        private static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.titular = "Eduardo Cardoso";
            conta.saldo = 10f;
            Console.WriteLine($"Titular:{conta.titular} \nSaldo:{conta.saldo}");
            conta.MostrarDadosDaConta();

            Carro carro = new Carro();
            carro.Acelerar();
            carro.Frear();
            carro.Buzinar();
        }
    }
}