using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia_v3
{
   public class ItensdoCarrinho : Base
    {
        public static List<Base> imageVenda = new List<Base>();//carrinho de Vendas
        public static List<Base> imageCompra = new List<Base>();//carrinho de Compra
        public ItensdoCarrinho() { }
        public ItensdoCarrinho(string nomeArq, string local) { Local = local; Nomedoproduto = nomeArq; }

        public Vendas Vendas
        {
            get => default;
            set
            {
            }
        }

        public Compra Compra
        {
            get => default;
            set
            {
            }
        }
    }

 
}
