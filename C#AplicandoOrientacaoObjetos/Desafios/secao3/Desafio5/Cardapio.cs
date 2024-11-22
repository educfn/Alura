namespace secao3.Desafio5
{
    internal class Cardapio
    {
        //Criar um metodo que pergunta quais são os pedidos do cliente e devolve um pedido.

        public Cardapio()
        {
        }

        public static Pedido EscolherPedido(Mesa mesaDoPedido, ItensDoCardapio[] itensDoCardapio)
        {
            


            return new Pedido(mesaDoPedido, Array.Empty<ItensDoCardapio>());
        }

        public static string ItensDoCardapioParaTexto(ItensDoCardapio item)
        {
            switch (item)
            {
                case ItensDoCardapio.ArrozFeijaoFrango:
                    return "Um prato com arroz e feijão, com um pedaço de frango grelhado.";
                case ItensDoCardapio.ArrozFeijaoBife:
                    return "Um prato com arroz e feijão, com um pedaço de bife frito.";
                case ItensDoCardapio.BifeACavalo:
                    return "Um prato de arroz a grega com um bife a cavalo.";
                case ItensDoCardapio.Cerveja:
                    return "Uma cerveja da marca X";
                case ItensDoCardapio.DobradinhaPaulista:
                    return "Um prato de arroz e feijão com 2 dobrabinhas a paulista.";
                case ItensDoCardapio.FrangoALaKife:
                    return "Um prato de arroz a grega com um frango a la kife.";
                case ItensDoCardapio.MacarraoComAlmondega:
                    return "Um prato de macarrão X com almondegas.";
                case ItensDoCardapio.PetitGateau:
                    return "Um prato de sobremesa com um Petit Gateau.";
                case ItensDoCardapio.Refrigerante:
                    return "Um refrigerante da marca Y.";
                case ItensDoCardapio.Sorvete:
                    return "Uma taça de sorvete com 3 bolas de sorvete.";
                case ItensDoCardapio.Vinho:
                    return "Uma garrafa de vinho da marca X.";

                default:
                    break;
            }

            return string.Empty;
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
