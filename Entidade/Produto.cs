using System.Globalization;

namespace ConsolePOOProduto.Entidade
{
    internal class Produto
    {
        public string Nome = "";
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quaitidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quaitidade;
        }
        public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;// Ou não informar nada
        }

        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return this.Quantidade * this.Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            this.Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            this.Quantidade -= quantity;
        }

        public override string ToString()
        {
            return this.Nome + ", $" +
                   this.Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                   this.Quantidade + " unidades, Total: " +
                   this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
