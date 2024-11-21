namespace secao3.Desafio5
{
    internal class Cardapio
    {
        //Criar um metodo que pergunta quais são os pedidos do cliente e devolve um pedido.

        private Dictionary<ItensDoCardapio, string> itensCardapioEDefinicao;

        public Cardapio()
        {
            itensCardapioEDefinicao = new();
            itensCardapioEDefinicao.Add(ItensDoCardapio.ArrozFeijaoBife, "\nArroz, Feijão e Bife grelhado");
            itensCardapioEDefinicao.Add(ItensDoCardapio.ArrozFeijaoFrango, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.BifeACavalo, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.Cerveja, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.DobradinhaPaulista, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.FrangoALaKife, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.MacarraoComAlmondega, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.PetitGateau, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.Refrigerante, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.Sorvete, "\n");
            itensCardapioEDefinicao.Add(ItensDoCardapio.Vinho, "\n");
        }

        public static Pedido EscolherPedido(ItensDoCardapio itemDoCardapio)
        {

            return new Pedido(new(0));
        }

        public static string? ItensDoCardapioParaTexto(ItensDoCardapio item)
        {

            return null;
        }

        [Flags]
        public enum ItensDoCardapio : ushort
        {
            ArrozFeijaoFrango = 0,
            ArrozFeijaoBife,
            DobradinhaPaulista,
            BifeACavalo,
            MacarraoComAlmondega,
            FrangoALaKife,
            Sorvete,
            PetitGateau,
            Refrigerante,
            Cerveja,
            Vinho
        }
    }
}
