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
    public partial class NotaF : Form
    {
        public static string Local="",Pasta;//recebe o local do arquivo
        
        public NotaF(string pasta)//construtor recebe o local de onde o arquivo se encontra
        {
            InitializeComponent();//inicia a janela
            Pasta = pasta;
            Local = Application.StartupPath + @"\" + pasta + @"\";
        }//fim do construtor

        public Notinha Notinha
        {
            get => default;
            set
            {
            }
        }

        public void AtualizaLista()//atualiza a lista de produtos
        {
            lbnotas.Items.Clear();//limpa as notas antigas
            if (Pasta == "notaVenda")
            {
                foreach (var item in NotaFiscal.Notasantigas)//percorre a lista com as notas antigas
                {
                    lbnotas.Items.Add(Convert.ToString(item.Num));
                }
            }
            else if(Pasta=="notaCompra")
            {
                
                foreach (var item in NotaCompra.NotasCompras)//percorre a lista com as notas antigas
                {
                    lbnotas.Items.Add(Convert.ToString(item.Num));
                }
            }

        }//fim do metodo
        public void ExibeNota()//exibe os dados dos produtos
        {
            string[] sep;//separador de  un e valor
            string[] separador;//separador de produto
            int a = 0, b = 1, c = 2;//varivaveis com as posições dos produtos
            
            if (lbnotas.SelectedItems.Count > 0)
            {
                if (Pasta == "notaVenda")
                {
                    lvlista.Items.Clear();//limpa a lsita

                    lvlista.Items.Clear();//limpa a lsita
                    foreach (var pega in NotaFiscal.Notasantigas)//percorre a lista de notinhas selecionadas
                    {
                        if (pega.Num == double.Parse(lbnotas.Text))
                        {

                            sep = pega.Produto.Split('+');//separa um produto do outro
                            separador = pega.Produto.Split('*', '+');//separa un de valor
                            lbcliente.Text = pega.Cliente;//o nome do clietne é impresso na tela
                            lbend.Text = pega.End;// o endereço é impresso na tela

                            for (int i = 0; i < sep.Length; i++)//percorre entre a quantidade de produtos
                            {
                                ListViewItem item = new ListViewItem(Convert.ToString(separador[a]));
                                item.SubItems.Add(separador[a + b]);
                                item.SubItems.Add(separador[a + c]);
                                a += 3;
                                lvlista.Items.Add(item);//adiciona o item na lista
                            }
                            lbtotal.Text = Convert.ToString(pega.Valor);//o valor total é impresso

                            lbdata.Text = Convert.ToString(pega.dia).Substring(0, 10);//a data é impressa

                            break;
                        }
                    }

                }
                else if (Pasta == "notaCompra")
                {
                    lvlista.Items.Clear();//limpa a lsita
                    foreach (var pega in NotaCompra.NotasCompras)//percorre a lista de notinhas selecionadas
                    {
                        if (pega.Num == double.Parse(lbnotas.Text))
                        {

                            sep = pega.Produto.Split('+');//separa um produto do outro
                            separador = pega.Produto.Split('*', '+');//separa un de valor
                            lbcliente.Text = pega.Cliente;//o nome do clietne é impresso na tela
                            lbend.Text = pega.End;// o endereço é impresso na tela

                            for (int i = 0; i < sep.Length; i++)//percorre entre a quantidade de produtos
                            {
                                ListViewItem item = new ListViewItem(Convert.ToString(separador[a]));
                                
                                item.SubItems.Add(separador[a + b]);
                                item.SubItems.Add(separador[a + c]);
                                a += 3;
                                lvlista.Items.Add(item);//adiciona o item na lista
                            }
                            lbtotal.Text = Convert.ToString(pega.Valor);//o valor total é impresso

                            lbdata.Text = Convert.ToString(pega.Dia).Substring(0, 10);//a data é impressa

                            break;
                        }
                    }
                }
            }
        }//fim do metodo
        private void NotaF_Load(object sender, EventArgs e)//assim que a janela e aberta
        {
            tbnomearq.Text = "Digite a data, ex: 26-5-2020";
        }//fim do metodo
         
        private void bconfirma_Click(object sender, EventArgs e)//ira ler o arquivo digitado
        {
            lbnotas.Items.Clear();
            Arquivo leitura = new Arquivo();//instancia a classe arquivo
            string diretorio = Local;//armazena o valor de local
            diretorio += tbnomearq.Text + ".txt";//soma um valor +outro
            leitura.LeitordeNotinha(diretorio,Pasta);//envia o nome para o metodo de leitura de notinha
            AtualizaLista();//atualiza a lista de notas do dia  
        }//fim do metodo

        private void lbnotas_Click(object sender, EventArgs e)
        {
            ExibeNota();//exibe os produtos
        }//fim do metodo

        private void bsair_Click(object sender, EventArgs e)
        {
            this.Close();//fecha a janela 
        }//fim do metodo

        private void tbnomearq_Click(object sender, EventArgs e)
        {
            tbnomearq.Text = "";//renomeia o textbox
        }//fim do metodo 
    }
}
