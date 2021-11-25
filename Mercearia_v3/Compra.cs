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
    public partial class Compra : Form
    {
        List<Panel> RolagemdePaineis = new List<Panel>(); // armazenar lista de paineis sobrepostos
        public static double valor;
        public static int quantia;
        public static bool alarme, Condicao, Formato,Cancelar=false;
        public static bool TwoAlarme;
        public Compra(int quantidade, bool condição, bool condicao, bool Format)//construtor recebe dados de um produto
        {
            quantia = 0;
            quantia = quantidade;
            alarme = condição;
            Condicao = condicao;
            Formato = Format;
        }
        public Compra()//cosntrutor
        {
            InitializeComponent();
        }

        public AddCompra AddCompra
        {
            get => default;
            set
            {
            }
        }

        public void Atualizalista()//atualiza a lista de produtos
        {
            listView.Items.Clear();
            foreach (var Itens in Base.Fornecedor)
            {
                ListViewItem item = new ListViewItem(Itens.Nomedoproduto);
                item.SubItems.Add(Itens.Categoria);
                item.SubItems.Add(Itens.Codigodebarra);
                item.SubItems.Add(Convert.ToString(Itens.Quantidade));
                item.SubItems.Add(Convert.ToString(Itens.Preço));
                item.SubItems.Add(Convert.ToString(Itens.Data.ToString("dd/MM/yyyy")));

                listView.Items.Add(item);
            }
        }
        public void AtualizaCarrinho()//atualiza o carrinho
        {
            double soma, valor = 0;
            for (int i = 0; i < lvCarrinho.Items.Count; i++)
            {

                soma = Convert.ToDouble(lvCarrinho.Items[i].SubItems[2].Text) * Convert.ToDouble(lvCarrinho.Items[i].SubItems[1].Text);
                valor += soma;

            }
            lbPagar.Text = Convert.ToString(valor); //E atribuimos o preço total de itens do carrinho

        }
        private void Compra_Load(object sender, EventArgs e)//carrega atributos ao iniciar o programa
        {
            RolagemdePaineis.Add(pnadd);
            RolagemdePaineis.Add(pncarrinho);
            RolagemdePaineis[0].BringToFront();
            listView.Items.Clear();
            Atualizalista();

        }
      

        private void blimpar_Click(object sender, EventArgs e)//limpa os itens do carrinho
        {
            lvCarrinho.Items.Clear();
            lbPagar.Text = Convert.ToString(0);
            valor = 0;
            Base.Verificaproduto.Clear();
        }

        private void bcancel_Click(object sender, EventArgs e)//cancela as compras do carrinho
        {
            if (lvCarrinho.Items.Count > 0)
            {
                lvCarrinho.Items.Clear();
                MessageBox.Show("Compra cancelada com sucesso!");
                lbPagar.Text = Convert.ToString(0);
                valor = 0;
                Base.Verificaproduto.Clear();
                RolagemdePaineis[0].BringToFront();
                pnadd.Enabled = true;
                pnadd.Visible = true;
                pncarrinho.Enabled = false;
                pncarrinho.Visible = false;
            }
            else
            {

                RolagemdePaineis[0].BringToFront();
                pnadd.Enabled = true;
                pnadd.Visible = true;
                pncarrinho.Enabled = false;
                pncarrinho.Visible = false;
            }
        }

        private void bremov_Click(object sender, EventArgs e)//remove um item da lista do carrinho
        {
            try
            {
                foreach (var linha in lvCarrinho.Items)
                {
                    if (linha == lvCarrinho.SelectedItems[0])
                    {
                        lvCarrinho.Items.Remove(lvCarrinho.SelectedItems[0]);

                    }
                }
                AtualizaCarrinho();
            }
            catch { MessageBox.Show("Selecione uma opção para remover!"); }
        }

        private void bcarrinho_Click(object sender, EventArgs e)//seleciona o painel carrinho
        {
            pnadd.Enabled = false;
            pnadd.Visible = false;
            RolagemdePaineis[1].BringToFront();
            pncarrinho.Visible = true;
            pncarrinho.Enabled = true;
        }

        private void badd_Click(object sender, EventArgs e)//vai para o painel adicionar
        {
            pnadd.Enabled = true;
            pnadd.Visible = true;
            RolagemdePaineis[0].BringToFront();
            pncarrinho.Visible = false;
            pncarrinho.Enabled = false;
        }

        private void listView_Click(object sender, EventArgs e)//seleciona um item da lista de fornecedor
        {
            string diretorio; int i = 0, index;
            if (listView.SelectedItems.Count > 0)
            {
                index = listView.SelectedItems[0].Index;

                foreach (var pega in Base.Fornecedor)
                {
                    if (index == i && pega.Nomedoproduto == listView.SelectedItems[0].Text)
                    {
                        diretorio = Convert.ToString(pega.Local);
                        pbimage.Image = Image.FromFile(@diretorio);
                        pbimage.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                        pbimage.SizeMode = PictureBoxSizeMode.StretchImage;
                        lbprod.Text = Convert.ToString(Encoding.UTF8);
                        lbprod.Text = pega.Nomedoproduto;
                        tbdado.Text = Convert.ToString(Encoding.UTF8);
                        tbdado.Text = pega.Descricao;
                        break;
                    }
                    i++;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//botão nota
        {
            NotaF nota = new NotaF("notaCompra");
            nota.Show();
        }

        private void listView_DoubleClick(object sender, EventArgs e)//carrega a quantidade que deseja comprar
        {

            double valortotal = 0, Preçototal, soma;
            string Pselecionado=listView.SelectedItems[0].Text;
            int quantidade = 0, quantidade2, quantiacarrinho;
            bool alarme2 = false;
            string envia = listView.SelectedItems[0].Text;
            AddCompra teste = new AddCompra(envia);
            teste.ShowDialog();

            if (Cancelar == true)
            {
                MessageBox.Show("A operação foi cancelada");
                Cancelar = false;
            }
           else if (Condicao == true) //Esta variavel testa se o valor digitado é Maior que 0
            {
                if (lvCarrinho.Items.Count > 0)
                {
                    for (int i = 0; i < lvCarrinho.Items.Count; i++)
                    {
                        if (listView.SelectedItems[0].Text == lvCarrinho.Items[i].Text)
                        {
                            alarme2 = true;//Alarme para verificar se o item já existe

                            quantidade += quantia;

                            quantidade2 = Convert.ToInt32(listView.SelectedItems[0].SubItems[3].Text);

                            if (quantidade2 >= quantidade)//Verificamos se a quantidade de itens disponiveis é maior ou igual a pedida.
                            {
                                quantiacarrinho = Convert.ToInt32(lvCarrinho.Items[i].SubItems[2].Text);//Pega a quantidade itens já adicionado no Carrinho

                                foreach (var variaveldeteste in Base.VerificaFornecedor)
                                {

                                    if (variaveldeteste.Nomedoproduto == lvCarrinho.Items[i].Text && quantiacarrinho + quantidade <= quantidade2)//Verificamos se a quantia no
                                    {                                                                                             //Carrinho é menor que a quantidade
                                        variaveldeteste.Quantidade += quantia;                                                    //do estoque

                                        Preçototal = Convert.ToDouble(listView.SelectedItems[0].SubItems[4].Text);


                                        quantiacarrinho += quantia;

                                        soma = valor;//Pegamos o valor que há na nossa variavel valor
                                        Preçototal *= quantidade;//Pegamos o preço e mutiplicamos pela quantidade pedida
                                        soma += Preçototal;//Somamos o preço que tinha na nossa variavel valor a multiplicação anterior
                                        valor = soma;//Colocamos o novo resultado na nossa variavel valor
                                        lbPagar.Text = Convert.ToString(valor);//E atribuimos o preço total de itens do carrinho
                                        lvCarrinho.Items[i].SubItems[2].Text = Convert.ToString(quantiacarrinho); ;//Adicionados a nova quantidade ao Carrinho
                                    
                                        MessageBox.Show("Quantia adicionado com sucesso!");
                                       

                                        break;
                                    }
                                    else if (variaveldeteste.Nomedoproduto == lvCarrinho.Items[i].Text && quantidade2 < quantiacarrinho + quantidade)//Caso a quantia do carrinho
                                    {                                                                                                  //for maior que a do estoque
                                                                                                                                       //exibimos uma mensagem
                                        MessageBox.Show("A quantidade pedida excede a do estoque!");
                                        break;
                                    }
                                  
                                }
                            
                            }
                       
                        }
                    }
                }
               
                if (alarme == true && alarme2 == false) //Fazer uma condição de dois alarmes para checar se o item ja existe!
                {
                    ListViewItem item2 = new ListViewItem(envia);
                    item2.SubItems.Add(Convert.ToString(listView.SelectedItems[0].SubItems[4].Text));

                    item2.SubItems.Add(Convert.ToString(quantia));
                    lvCarrinho.Items.Add(item2);

                    valortotal = Convert.ToDouble(listView.SelectedItems[0].SubItems[4].Text);
                    valortotal *= quantia;

                    valor += valortotal;

                    Base testando = new Base(envia, quantia);
                    Base.VerificaFornecedor.Add(testando);


                    lbPagar.Text = Convert.ToString(valor);
                    MessageBox.Show("Quantia adicionado com sucesso!");
                    for (int z = 0; z < Base.Fornecedor.Count; z++)
                    {
                        if (Base.Fornecedor[z].Nomedoproduto == Pselecionado)
                        {
                            
                            string testee = Convert.ToString(Base.Fornecedor[z].Local);
                            ItensdoCarrinho testeee = new ItensdoCarrinho(Pselecionado, testee);
                            ItensdoCarrinho.imageCompra.Add(testeee);
                        }
                    }
                }
                else if (alarme == false) //Verifica se a quantia pedida é maior que a do estoque
                {
                    MessageBox.Show("A quantidade pedida excede a do estoque!");
                }
            }
            else if (Condicao == false && Formato == false && Cancelar==false) //Verifica se o valor pedido é maior que 0 e não tem nenhum parametro digitado errado!
            {
                MessageBox.Show("Por favor, digite valores maior que zero");

            }
        }
        private string CopiaCarrinho()
        {
            string produtos = "";
         
            foreach (var itens in Base.VerificaFornecedor)
            {
                for (int i = 0; i < lvCarrinho.Items.Count; i++)
                {
                    produtos += lvCarrinho.Items[i].Text + "*" + lvCarrinho.Items[i].SubItems[2].Text + "*" + lvCarrinho.Items[i].SubItems[1].Text + "+";
                }

                break;
            }
           
            return produtos;
        }
        private void bfinaliza_Click(object sender, EventArgs e)//finaliza a compra
        {
            Dinheiro AdicionaDinheiro = new Dinheiro();
            int i = 0;
            if (lvCarrinho.Items.Count > 0)
            {
                if (AdicionaDinheiro.Saldo >= valor) //Se o valor pedido for igual ou menor ao dinheiro da empresa
                {
                    TwoAlarme = true;
                }

                if (TwoAlarme == true) //Se o alarme for verdadeiro significa que temos saldo para comprar!
                {
                    AdicionaDinheiro.Saldo -= valor;
                    Dinheiro.alarm = true;
                    for (int z = 0; z < Base.Produto.Count; z++)
                    {
                        i = 0;
                        foreach (var teste in Base.VerificaFornecedor)
                        {
                            if (lvCarrinho.Items.Count == i)
                            {
                                i = 0;
                            }
                            if (Base.Produto[z].Nomedoproduto == lvCarrinho.Items[i].Text && teste.Nomedoproduto == Base.Produto[z].Nomedoproduto)
                            {

                                Base.Produto[z].Quantidade += teste.Quantidade;


                            }
                            i++;
                        }
                    }

                    for (int x = 0; x < Base.Fornecedor.Count; x++)
                    {

                        {
                            i = 0;
                            foreach (var pegando in Base.VerificaFornecedor)
                            {

                                if (lvCarrinho.Items.Count == i)
                                {
                                    i = 0;
                                }
                                if (Base.Fornecedor[x].Nomedoproduto == lvCarrinho.Items[i].Text && pegando.Nomedoproduto == Base.Fornecedor[x].Nomedoproduto)
                                {

                                    Base.Fornecedor[x].Quantidade -= pegando.Quantidade;
                                    pegando.Quantidade = 0;


                                }
                                i++;
                            }
                        }
                    }

                    MessageBox.Show("Compra Realizada com sucesso!"); //Sinalizamos que a compra foi realizada com sucesso
                    listView.Items.Clear();
                    ItensdoCarrinho.imageCompra.Clear();
                    foreach (var pega in Base.Fornecedor)
                    {


                        ListViewItem item = new ListViewItem(pega.Nomedoproduto);
                        item.SubItems.Add(pega.Categoria);
                        item.SubItems.Add(pega.Codigodebarra);
                        item.SubItems.Add(Convert.ToString(pega.Quantidade));
                        item.SubItems.Add(Convert.ToString(pega.Preço));
                        item.SubItems.Add(Convert.ToString(pega.Data.ToString("dd/MM/yyyy")));


                        listView.Items.Add(item);

                    }

                    string produtos = CopiaCarrinho();
                    Notinha nota = new Notinha(produtos, double.Parse(lbPagar.Text), "Mercearia Forms", "---------", "notaCompra");
                    Notinha not = new Notinha();
                    not.Show();
                    
                }
                else if (TwoAlarme == false) //Se for Falso sinalizamos que não temos saldo suficiente!
                {
                    MessageBox.Show("Saldo insuficiente tente novamente!");
                    lvCarrinho.Items.Clear();
                    lbPagar.Text = Convert.ToString(0);
                    Base.VerificaFornecedor.Clear();
                }

                lvCarrinho.Items.Clear();
                valor = 0;
                lbPagar.Text = Convert.ToString(0);
                TwoAlarme = false;
            }
            else
            {
                MessageBox.Show("O carrinho está vazio!");
            }

        }     
        private void lvCarrinho_Click(object sender, EventArgs e)//seleciona um item da lista carrinho
        {
           
            string diretorio; int i = 0, index;
            if (lvCarrinho.SelectedItems.Count > 0)
            {
                index = lvCarrinho.SelectedItems[0].Index;

                foreach (var pega in ItensdoCarrinho.imageCompra)
                {
                    if (index == i && pega.Nomedoproduto == lvCarrinho.SelectedItems[0].Text)
                    {
                       
                        diretorio = Convert.ToString(pega.Local);
                        
                        pbcarrinho.Image = Image.FromFile(@diretorio);
                        pbcarrinho.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                        pbcarrinho.SizeMode = PictureBoxSizeMode.StretchImage;
                       
                        break;
                    }
                    i++;

                }
            }
        }
    }
}
