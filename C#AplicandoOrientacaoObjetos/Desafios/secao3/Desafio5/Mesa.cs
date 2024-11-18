namespace secao3.Desafio5
{
    internal class Mesa
    {
        private int numeroDaMesa;
        private List<Pedido> listaDePedidosDaMesa;

        public Mesa(int numeroDaMesa)
        {
            this.numeroDaMesa = numeroDaMesa;
            listaDePedidosDaMesa = new ();
        }

        public int NumeroDaMesa => numeroDaMesa;

        /// <summary>
        /// Metodo responsável por 
        /// </summary>
        /// <param name="pedidoTerminado"></param>
        /// <returns>Retorna 'true' se tiver conseguido remover o pedido da lista de pedidos. Retorna 'false' se não tiver localizado o pedido.</returns>
        public bool RemoverPedido(Pedido pedidoTerminado)
        {
            return listaDePedidosDaMesa.Remove(pedidoTerminado);
        }

        public bool AdicionarPedido(Pedido pedidoASerAdicionado)
        {
            bool pedidoAdicionado = false;
            
            if (!listaDePedidosDaMesa.Exists(pedido => pedido.IdDoPedido == pedidoASerAdicionado.IdDoPedido))
            {
                listaDePedidosDaMesa.Add(pedidoASerAdicionado);
               pedidoAdicionado = true;
            }

            return pedidoAdicionado;
        }
    }
}
