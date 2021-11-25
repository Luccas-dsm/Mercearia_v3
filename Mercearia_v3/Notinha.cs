using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_v3
{
    public partial class Notinha : Form
    {
        public static string Prod,Pasta, cli, end;//recebe o produto, cliente, endereço do cliente
        public static double total;//recebe o valor total do carrinho
        public static bool alarmee;//verifica se 

        // List<Notinha> Notinhas = new List<Notinha>();
        public Notinha(string prod, double tot, string cliente, string ende,string pasta)//recebe os dados do usuario 
        {
            
                if (cliente == "")
                {
                    cli = "---------------";
                    end = "----------------";
                }
                else
                {
                    cli = cliente;
                    end = ende;
                }
            
            
            Prod = prod;
            total = tot;
            Pasta = pasta;
        }//fim do construtor
        public Notinha()//construtor padrão
        {
            InitializeComponent();//inicializa o forms
            ExibeLista();//exibe a lista de produtos
        }//fim do construtor

        public AddCl AddCl
        {
            get => default;
            set
            {
            }
        }

        public void ExibeLista()//exibe a lista de prdutos 
        {
            string[] sep;//separa un e valor do produto
            string[] separador;//separa um produto do outro
            int a = 0;
           
            sep = Prod.Substring(0, Prod.Length - 1).Split('*', '+');//recebe o nome do separador
            separador = Prod.Substring(0, Prod.Length - 1).Split('+');//recebe o nome do separador
           
            string data = Convert.ToString(DateTime.Now);//pega sua data atual
            for (int i = 0; i < separador.Length; i++)//percorre o separador de produtos
            {

                ListViewItem item = new ListViewItem(Convert.ToString(sep[a]));
                item.SubItems.Add(sep[a + 1]);
                item.SubItems.Add(sep[a + 2]);
                a += 3;
                lvlista.Items.Add(item);//adiciona um novo produto a lista 

            }
            lbcliente.Text = cli;//nomeia a label cliente
            lbend.Text = end;//nomeia a label endereço
            lbdata.Text = data.Substring(0, 10);//nomeia a label data
            lbtotal.Text = Convert.ToString(total);//nomeia a label valor total
        }

        private void bconfirma_Click(object sender, EventArgs e)//confirma os dados da nota
        {
        
               
            if (Pasta == "notaVenda")
            {
                NotaFiscal nota = new NotaFiscal(NotaFiscal.numero, lbcliente.Text, lbend.Text, Prod, total, Convert.ToDateTime(lbdata.Text));//adicona um novo produto na classe NotaFiscal
                NotaFiscal.Notas.Add(nota);//adiciona um novo produto na lista notas
                                           //acrescenta +1 na variavel numero da classe NotaFiscal

                foreach (var item in NotaFiscal.Notas)//percorre a lista de notas para gravar seus dados
                {
                    if (item.Num == NotaFiscal.numero)

                    {
                        Arquivo.GravaNotinha(item.Num,"notaVenda", item.Cliente, item.End, item.Produto, item.Valor, Convert.ToDateTime(item.dia));
                        //metodo acima invoca o metodo gravanotinha da classe arquivo para gravar os dados da lista
                        break;
                    }
                }
                NotaFiscal.numero++;
            }
            else if (Pasta=="notaCompra")
                    {
                NotaCompra nota = new NotaCompra(NotaCompra.numero, lbcliente.Text, lbend.Text, Prod, total,Convert.ToDateTime(lbdata.Text));//adicona um novo produto na classe NotaFiscal
                NotaCompra.NotasCompras.Add(nota);//adiciona um novo produto na lista notas
                                           //acrescenta +1 na variavel numero da classe NotaFiscal

                foreach (var item in NotaCompra.NotasCompras)//percorre a lista de notas para gravar seus dados
                {
                    if (item.Num == NotaCompra.numero)

                    {
                       // MessageBox.Show(item.Dia);
                        Arquivo.GravaNotinha(item.Num, "notaCompra", item.Cliente, item.End, item.Produto, item.Valor, item.Dia);
                        //metodo acima invoca o metodo gravanotinha da classe arquivo para gravar os dados da lista
                        break;
                    }
                }
                NotaCompra.numero++;
            }
                this.Close();//fecha a janela atual
        }
    }
}
