namespace secao3.Desafio5
{
    internal class Restaurante
    {
        //A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos.
        private List<Mesa> mesasDisponiveis;
        private List<Mesa> mesasReservadas;

        public Restaurante()
        {
            mesasDisponiveis = new ();
            mesasReservadas = new ();

            for (int i = 1; i < 21; i++)
            {
                mesasDisponiveis.Add(new(i));
            }
        }

        public void AdicionarMesaReservada(Mesa mesa)
        {
            if (mesasDisponiveis.Exists
                (mesaEncontrada => mesaEncontrada.NumeroDaMesa == mesa.NumeroDaMesa))
            {
                mesasReservadas.Add(mesa);
                mesasDisponiveis.Remove(mesa);
            }
                
        }

        public void RemoverMesaReservada(Mesa mesa)
        {
            if (mesasReservadas.Exists
                (mesaEncontrada => mesaEncontrada.NumeroDaMesa == mesa.NumeroDaMesa))
            {
                mesasDisponiveis.Add(mesa);
                mesasReservadas.Remove(mesa);
            }
        }
    }
}


