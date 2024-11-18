namespace CSharpAplicandoOrientacaoObjetos.Desafios.secao3
{
    public class EstoqueProdutos
    {
        List<Produto> listaDeProdutos;

        public EstoqueProdutos()
        {
            listaDeProdutos = new();
        }

        public void AdicionarProduto(Produto produto)
        {
            if(listaDeProdutos == null)
                return;

            listaDeProdutos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            if(listaDeProdutos == null)
                return;

            listaDeProdutos.Remove(produto);
        }

        public void ExibirProdutos()
        {
            if(listaDeProdutos == null)
                return;
            
            Console.WriteLine($"Estoque de Produtos:");
            foreach(Produto produto in listaDeProdutos)
            {
                Console.WriteLine($"{produto.nome}");
            }
        }
    }

    public struct Produto
    {
        public string nome;

        public Produto(string nome)
        {
            this.nome = nome;
        }
    }
}