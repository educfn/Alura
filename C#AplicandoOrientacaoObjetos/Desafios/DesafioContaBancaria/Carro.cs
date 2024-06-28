namespace Desafios.DesafioContaBancaria
{
    public class Carro
    {
        private int velocidade = 0;
        private string somDaBuzina = "Bi bi!!";

        public void Acelerar()
        {
            velocidade++;
            Console.WriteLine($"Velocidade: {velocidade}");
        }
        public void Frear()
        {
            if (velocidade > 0) velocidade--;
            Console.WriteLine($"Velocidade: {velocidade}");
        }
        public void Buzinar()
        {
            Console.WriteLine(somDaBuzina);
        }
    }
}