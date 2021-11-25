using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_v3
{
    public class Base
    {

        public static List<Base> Produto = new List<Base>(); //List de objetos produto sera caracterizada pelo estoque
        public static List<Base> Verificaproduto = new List<Base>();//Usada para verificar a quantia no Metodo de Vendas
        public static List<Base> Fornecedor = new List<Base>();//List de objetos Fornecedor sera carcterizada pelo Fornecedor
        public static List<Base> VerificaFornecedor = new List<Base>();//Usada para verificar a quantidade no metodo comprar do fornecedor.
        public static double Contagem = 679000000000; //Contagem, cada vez que um novo produto é cadastrado atualizamos o contador.
        protected string codigodebarra, categoria, nomedoproduto, local, descricao;
        protected int quantidade;
        protected double preço;
        public DateTime Data { get; set; }
        public DateTime Datadecompra { get; set; }
        public DateTime Datadevalidade { get; set; }

        public Base() { }
     
        public Base(double cod)
        {
            Contagem = cod;
        }
        public Base(string nomedoproduto, string categoria, string codigodebarra, int quantidade, double preço, string local, string descricao, DateTime datadecompra, DateTime datadevalidade)
        {
            this.codigodebarra = codigodebarra;
            this.categoria = categoria;
            this.nomedoproduto = nomedoproduto;
            this.quantidade = quantidade;
            this.preço = preço;
            this.local = local;
            this.descricao = descricao;
            this.Datadecompra = datadecompra;
            this.Datadevalidade = datadevalidade;

        }
        public Base(string nome, int quantia)
        {
            this.nomedoproduto = nome;
            this.quantidade = quantia;
        }
        public Base(string nomedoproduto, string categoria, string codigodebarra, int quantidade, double preço, string local, string descricao, DateTime date)
        {
            this.codigodebarra = codigodebarra;
            this.categoria = categoria;
            this.nomedoproduto = nomedoproduto;
            this.quantidade = quantidade;
            this.preço = preço;
            this.local = local;
            this.descricao = descricao;
            Data = date;

        }


        public string Codigodebarra
        {
            get
            {
                return codigodebarra;
            }
            set
            {
                codigodebarra = value;
            }

        }
        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }
        public string Nomedoproduto
        {
            get
            {
                return nomedoproduto;
            }
            set
            {
                nomedoproduto = value;
            }
        }
        public int Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
            }
        }
        public double Preço
        {
            get
            {
                return preço;
            }
            set
            {
                preço = value;
            }
        }
        public string Local
        {
            get
            {
                return local;
            }
            set
            {
                local = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        public void Altera(string nome) //Metodo para retirar o Objeto da nossa lista Produto e Fornecedor
        {
            foreach (var altera in Produto)
            {
                if (altera.Nomedoproduto == nome)
                {
                    Produto.Remove(altera);
                    MessageBox.Show("Removido com sucesso!");
                    break;
                }
            }
            foreach (var remove in Fornecedor)
            {
                if (remove.Nomedoproduto == nome)
                {
                    Fornecedor.Remove(remove);
                    break;
                }
            }
      
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }
    }
} 
