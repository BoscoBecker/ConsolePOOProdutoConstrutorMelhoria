using System.Globalization;

namespace ConsolePOOProduto.Entidade
{
    internal class Produto
    {
        /*
        public string Nome = "";
        public double Preco;
        public int Quantidade;
        */

        ///Usando Encapsulamento ...
        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto(string nome, double preco, int quaitidade) : this(nome, preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quaitidade;
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto()
        {
            _quantidade = 10;
        }

        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }

        public string GetNome() {return _nome;}

        public int GetQuantidade() { return _quantidade; }

        public double Preco  /// Usando Getter ...
        {
            get { return _preco; }
        }

        public string Nome  /// Usando Getter e setters ...
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1)_nome = value;}
        }
        public override string ToString()
        {
            return _nome + ", $" +
                   _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                   _quantidade + " unidades, Total: " +
                   ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
