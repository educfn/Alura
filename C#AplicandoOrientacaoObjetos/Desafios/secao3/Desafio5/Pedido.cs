using static secao3.Desafio5.Cardapio;

namespace secao3.Desafio5
{
    internal class Pedido
    {
        //Os pedidos podem estar associados a uma mesa.
        private Mesa mesaDoPedido;
        private DateTime quandoFoiPedido;
        private List<ItensDoCardapio> itensDoCardapio;

        public Pedido(Mesa mesaDoPedido)
        {
            this.mesaDoPedido = mesaDoPedido;
            quandoFoiPedido = DateTime.Now;
            itensDoCardapio = new List<ItensDoCardapio>();
        }

        public string IdDoPedido => mesaDoPedido.NumeroDaMesa + quandoFoiPedido.ToString();

        
    }
}
