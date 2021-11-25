using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia_v3
{
    public class Dinheiro
    {
        public static bool alarm;
        public static double saldo=500;//se o arquivo do saldo não existir ele inicia com R$500,00
        public Dinheiro() { }
        public Dinheiro(double caixa)
        {
            Saldo = caixa;
        }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }

        public Estoque Estoque
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

        public Vendas Vendas
        {
            get => default;
            set
            {
            }
        }

        public void Imposto(int quantidade, string categoria, double preço)//metodo calcula o imposto sobre cada produto
        {
            double imposto;
            switch (categoria)
            {
                case "Alimento":
                    {
                        imposto = preço * 0.07;
                        preço -= imposto;
                        Saldo += quantidade * preço;
                        break;
                    }
                case "Limpeza":
                    {
                        imposto = preço * 0.18;
                        preço -= imposto;
                        Saldo += quantidade * preço;
                        break;
                    }
                case "Higiene":
                    {
                        imposto = preço * 0.215;
                        preço -= imposto;
                        Saldo += quantidade * preço;
                        break;
                    }
                case "Diversos":
                    {
                        imposto = preço * 0.27;
                        preço -= imposto;
                        Saldo += quantidade * preço;
                        break;
                    }
            }
        }

    }
}
