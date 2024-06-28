namespace Desafios.DesafioContaBancaria
{
    public class ContaBancaria
    {
        public int indicador = 0;
        public string titular = string.Empty;
        public float saldo = 0f;
        public string senha = string.Empty;

        public void MostrarDadosDaConta()
        {
            Console.WriteLine($"Indicar: {indicador}\nTitular: {titular}\nSaldo: {saldo}\nSenha: {senha}");
        }
    }
}
