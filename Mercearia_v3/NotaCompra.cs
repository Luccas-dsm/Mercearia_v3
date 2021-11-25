using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia_v3
{
    public class NotaCompra : NotaFiscal
    {
        public static List<NotaCompra> NotasCompras = new List<NotaCompra>();
        public DateTime Dia;
        public static double numero=0;

        public NotaCompra() { }
        public NotaCompra(double num, string nome, string end, string produto, double val, DateTime dia)

        {
            Num = num;
            Cliente = nome;
            End = end;
            Produto = produto;
            Valor = val;
            Dia = dia;
        }

        public NotinhaCadastrados NotinhaCadastrados
        {
            get => default;
            set
            {
            }
        }
    }
}
