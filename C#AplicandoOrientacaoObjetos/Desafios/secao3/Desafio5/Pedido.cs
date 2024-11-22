using System.Linq;
using static secao3.Desafio5.Cardapio;

namespace secao3.Desafio5
{
    internal class Pedido
    {
        //Os pedidos podem estar associados a uma mesa.
        private readonly Mesa mesaDoPedido;
        private readonly DateTime quandoFoiPedido;
        private readonly List<ItensDoCardapio> itensDoCardapio;

        public Pedido(Mesa mesaDoPedido, ItensDoCardapio[] itensPedidosDoCardapio)
        {
            this.mesaDoPedido = mesaDoPedido;
            quandoFoiPedido = DateTime.Now;
            itensDoCardapio = itensPedidosDoCardapio.ToList<ItensDoCardapio>();
        }

        public string IdDoPedido => mesaDoPedido.NumeroDaMesa + quandoFoiPedido.ToString();
    }
}
