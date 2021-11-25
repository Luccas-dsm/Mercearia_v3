using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia_v3
{
   public class NotaFiscal
    {
        public static double numero=0;
        public static List<NotaFiscal> Notasantigas = new List<NotaFiscal>();
        public static List<NotaFiscal> Notas = new List<NotaFiscal>();
        
        private string cliente, end, produto;
        private double valor,num;
       public NotaFiscal() { }
        public DateTime dia;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public string End
        {
            get { return end; }
            set { end = value; }
        }
        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public double Num
        {
            get { return num; }
            set { num = value; }
        }
      
        public NotaFiscal(double numero,string cli, string ende,string prod,double val,DateTime date) 
        {
            Num = numero;
            Cliente=cli;
            End = ende;
            Produto = prod;
            Valor = val;
            dia = date;

        }

        public Base Base
        {
            get => default;
            set
            {
            }
        }
    }
    
}
