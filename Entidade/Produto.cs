using System.Globalization;

namespace ConsolePOOProduto.Entidade
{
    internal class Produto
    {

        ///Usando Encapsulamento ...
        private string _nome;
        //private double _preco;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //Private int _quantidade;
        public Produto(string nome, double preco, int quaitidade) : this(nome, preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quaitidade;
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(){ Quantidade = 10;}

        public double ValorTotalEmEstoque() { return Quantidade * Preco; }

        public void AdicionarProdutos(int quantity) { Quantidade += quantity;}

        public void RemoverProdutos(int quantity) { Quantidade -= quantity;}

        public string GetNome() { return _nome;}

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1)_nome = value;}
        }
        public override string ToString()
        {
            return _nome + ", $" +
                   Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                   Quantidade + " unidades, Total: " +
                   ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
