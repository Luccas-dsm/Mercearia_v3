using System;
using System.Windows.Forms;

namespace Mercearia_v3
{
    public partial class NotinhaCadastrados : Form
    {
        public static string Prod;//recebe a lista de produtos do carrinho
        public static double Val;//recebe o valor total do carrinho
        public static bool alarmee;
        public NotinhaCadastrados(string prod, double val)//contrutor recebe os dados de produto e valor toal
        {
            Prod = prod;
            Val = val;
            InitializeComponent();
        }//fim do construtor
        public NotinhaCadastrados()//construtor padrão
        {
            InitializeComponent();
        }//fim do construtor

        

        private void bconfirma_Click(object sender, EventArgs e)//botão confirma 
        {
            if (alarmee == true)//adiciona um novo item na lista de notas fiscais do da classe vendas
            {
                NotaFiscal nota = new NotaFiscal(NotaFiscal.numero, lbcliente.Text, lbend.Text, Prod, Val, Convert.ToDateTime(lbdata.Text));
                NotaFiscal.Notas.Add(nota);
                
                foreach (var item in NotaFiscal.Notas)//ira gravar a lista notas
                {
                    if (item.Num == NotaFiscal.numero)
                    {
                        Arquivo.GravaNotinha(item.Num, "notaVenda", item.Cliente, item.End, item.Produto, item.Valor, Convert.ToDateTime(item.dia));
                        NotaFiscal.numero++;
                        alarmee = false;
                        break;
                    }
                }
                this.Close();
            }
           
        }//fim do metodo
        public void ExibeClientes()//exibe a lista com o nome dos clientes cadastrados
        {
            lbcli.Items.Clear();// limpa a lista antes de atualiza-la 
            foreach (var item in Cliente.Clientes)
            {
                lbcli.Items.Add(item.Nome);
            }

        }//fim do metodo
        public void Exibelista()//exibe a lista de produtos un e valores
        {
            string[] sep;
            string[] separador;
            int a = 0;
            sep = Prod.Substring(0, Prod.Length - 1).Split('*', '+');//separa a palavra produtos em determinados pontos
            separador = Prod.Substring(0, Prod.Length - 1).Split('+');//separa a palavra produtos em determinados pontos
          
           
            for (int i = 0; i < separador.Length; i++)
            {

                ListViewItem item = new ListViewItem(Convert.ToString(sep[a]));
                item.SubItems.Add(sep[a + 1]);
                item.SubItems.Add(sep[a + 2]);
                a += 3;
                lvlista.Items.Add(item);//adiciona itens no objeto lista da interface grafica

            }
        }//fim do metodo
        private void lbcli_Click(object sender, EventArgs e) //exibe os dados do nome clicado
        {
            if (lbcli.SelectedItems.Count > 0)
            {
                foreach (var pega in Cliente.Clientes)//percorre a lista de clientes
                {
                    if (pega.Nome == lbcli.Text)
                    {
                        lbcliente.Text = pega.Nome;
                        lbend.Text = pega.End;
                        Exibelista();
                        lbtotal.Text = Convert.ToString(Val);
                        lbdata.Text = Convert.ToString(DateTime.Now).Substring(0, 10);

                        break;
                    }
                }
            }
            alarmee = true;
        }//fim do metodo
        private void NotinhaCadastrados_Load(object sender, EventArgs e)//atualiza a lista de clientes quando a janela é aberta
        {
            ExibeClientes();
        }//fim do metodo
    }
}
