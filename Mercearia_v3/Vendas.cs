using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_v3
{
    public partial class Vendas : Form
    {
        public Image Back_carrinho;

        List<Panel> RolagemdePaineis = new List<Panel>(); // armazenar lista de paineis sobrepostos

        public static double valor;
        public static int quantia;
        public static bool alarme, Condicao, Formato,cancelar=false;
        public Vendas()//construtor
        {
            InitializeComponent();
        }
        public Vendas(int quantidade, bool condição, bool condicao, bool Catch)//construtor recebe as informções do produto
        {
            quantia = 0;
            quantia = quantidade;
            alarme = condição;
            Condicao = condicao;
            Formato = Catch;
        }

        public Quantidade Quantidade1
        {
            get => default;
            set
            {
            }
        }

        public void Atualizalista()//atualiza a lista de produtos
        {
            listView.Items.Clear();
            foreach (var Itens in Base.Produto)
            {
                ListViewItem item = new ListViewItem(Itens.Nomedoproduto);
                item.SubItems.Add(Itens.Categoria);
                item.SubItems.Add(Itens.Codigodebarra);
                item.SubItems.Add(Convert.ToString(Itens.Quantidade));
                item.SubItems.Add(Convert.ToString(Itens.Preço));
                item.SubItems.Add(Convert.ToString(Itens.Datadecompra.ToString("dd/MM/yyyy")));
                item.SubItems.Add(Convert.ToString(Itens.Datadevalidade.ToString("dd/MM/yyyy")));

                listView.Items.Add(item);
            }
        }
        public void AtualizaCarrinho()//atualiza a lista do carrinho
        {
            double soma, valor = 0;
            for (int i = 0; i < lvCarrinho.Items.Count; i++)
            {

                soma = Convert.ToDouble(lvCarrinho.Items[i].SubItems[2].Text) * Convert.ToDouble(lvCarrinho.Items[i].SubItems[1].Text);
                valor += soma;

            }
            lbPagar.Text = Convert.ToString(valor); //E atribuimos o preço total de itens do carrinho

        }
        private void bcancel_Click(object sender, EventArgs e)//cancela todas as vendas e limpa o carrinho
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
        private void badd_Click(object sender, EventArgs e)//painel adicinoar
        {
            pnadd.Enabled = true;
            pnadd.Visible = true;
            RolagemdePaineis[0].BringToFront();
            pncarrinho.Visible = false;
            pncarrinho.Enabled = false;
        }

        private void Vendas_Load(object sender, EventArgs e)//assim que o forms e carregado os seus atributos recebem os seus valores
        {
                    
            RolagemdePaineis.Add(pnadd);
            RolagemdePaineis.Add(pncarrinho);
            RolagemdePaineis[0].BringToFront();
            listView.Items.Clear();
            Atualizalista();
          
           
        }

        private void bcarrinho_Click(object sender, EventArgs e)//vai para o painel carrinho
        {
            pnadd.Enabled = false;
            pnadd.Visible = false;
            RolagemdePaineis[1].BringToFront();
            pncarrinho.Visible = true;
            pncarrinho.Enabled = true;
        }
        private void blimpar_Click(object sender, EventArgs e)//limpa todas as informações do carrinho
        {
           
            lvCarrinho.Items.Clear();
            lbPagar.Text = Convert.ToString(0);
            valor = 0;
            Base.Verificaproduto.Clear();
        }
        private void bfinaliza_Click(object sender, EventArgs e)//finaliza a compra
        {
            Dinheiro AdicionaDinheiro = new Dinheiro();

            if (lvCarrinho.Items.Count > 0) //Verificamos se há produtos no carrinho
            {
                for (int z = 0; z < Base.Produto.Count; z++)
                {
                    foreach (var itens in Base.Verificaproduto)
                    {
                        for (int i = 0; i < lvCarrinho.Items.Count; i++)
                        {
                            

                            if (lvCarrinho.Items.Count == i)
                            {
                                break;
                            }
                            if (Base.Produto[z].Nomedoproduto == lvCarrinho.Items[i].Text && itens.Nomedoproduto == Base.Produto[z].Nomedoproduto)
                            {
                                Base.Produto[z].Quantidade -= itens.Quantidade;//Subtraimos a quantidade de itens comprados do nosso estoque
                                AdicionaDinheiro.Imposto(itens.Quantidade, Base.Produto[z].Categoria, Base.Produto[z].Preço);
                                //Adicionamos o dinheiro com taxa de imposto ao saldo da empresa.
                                itens.Quantidade = 0;

                            }
                        }
                    }
                }
                MessageBox.Show("Venda Finalizada com sucesso!");
                ItensdoCarrinho.imageVenda.Clear();//zeramos a lista de imagens
                listView.Items.Clear(); //Zeramos os itens do listview e atualizamos
                foreach (var itens in Base.Produto)
                {
                    ListViewItem item = new ListViewItem(itens.Nomedoproduto);
                    item.SubItems.Add(itens.Categoria);
                    item.SubItems.Add(itens.Codigodebarra);
                    item.SubItems.Add(Convert.ToString(itens.Quantidade));
                    item.SubItems.Add(Convert.ToString(itens.Preço));
                    item.SubItems.Add(Convert.ToString(itens.Datadevalidade.ToString("dd/MM/yyyy")));

                    listView.Items.Add(item);
                }
                //  SaldoReal.Text = Convert.ToString(AdicionaDinheiro.Saldo.ToString("F2"));
                Dinheiro.alarm = true;

                DialogResult dialogResult = MessageBox.Show("Voce é cliente cadastrado?", "Verifica Cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string produtos = CopiaCarrinho();
                    NotinhaCadastrados nota = new NotinhaCadastrados(produtos, double.Parse(lbPagar.Text));
                    nota.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult dialoResult = MessageBox.Show("Deseja Fazer o nosso Cadastro?", "Verifica Cliente", MessageBoxButtons.YesNo);
                    if (dialoResult == DialogResult.Yes)
                    {
                        string produtos = CopiaCarrinho();
                        AddCl cl = new AddCl(produtos,double.Parse(lbPagar.Text));
                        AddCl client = new AddCl();
                        client.Show();

                    }
                    else if (dialoResult == DialogResult.No)
                    {
                        string produtos = CopiaCarrinho();
                        Notinha nota = new Notinha(produtos,double.Parse(lbPagar.Text),"","","notaVenda");
                        Notinha not = new Notinha();
                        not.Show();
                    }
                }
                lvCarrinho.Items.Clear();
                valor = 0;
                lbPagar.Text = Convert.ToString(0);
            }
            else //Se não tiver exibe uma mensagem!
            {
                MessageBox.Show("O carrinho está vazio!");
            }
        }
        private string CopiaCarrinho()
        {
            string produtos = "";
            int a = 0;
            foreach (var itens in Base.Verificaproduto)
            {
                for (int i = 0; i < lvCarrinho.Items.Count; i++)
                {
                    produtos += lvCarrinho.Items[i].Text + "*" + lvCarrinho.Items[i].SubItems[2].Text + "*" + lvCarrinho.Items[i].SubItems[1].Text + "+";
                }
                
                break;
            }
            return produtos;
        }
        private void listView_Click(object sender, EventArgs e)//aparece informãções o produto
        {
            string diretorio; int i = 0, index;
            if (listView.SelectedItems.Count > 0)
            {
                index = listView.SelectedItems[0].Index;
                foreach (var pega in Base.Produto)
                {
                    if (index == i && pega.Nomedoproduto == listView.SelectedItems[0].Text)
                    {
                        diretorio = Convert.ToString(pega.Local);
                        pbfoto.Image = Image.FromFile(@diretorio);
                        pbfoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbfoto.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
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

        private void button1_Click(object sender, EventArgs e)
        {
            NotaF nota = new NotaF("notaVenda");
            nota.Show();
        }
        private void pbcarrinho_Paint(object sender, PaintEventArgs e)
        {
            if (pbcarrinho.Image == pbcarrinho.ErrorImage)
            {
                // You got the Error image
                MessageBox.Show("joga essa merda fora");
            }
        }
        private void lvCarrinho_Click(object sender, EventArgs e)//seleciona um item da lista carrinho
        {
            
            string diretorio; int i = 0, index;
            if (lvCarrinho.SelectedItems.Count > 0)
            {
                index = lvCarrinho.SelectedItems[0].Index;
                foreach (var pega in ItensdoCarrinho.imageVenda)
                {
                    if (index == i && pega.Nomedoproduto == lvCarrinho.SelectedItems[0].Text)
                    {
                        diretorio = Convert.ToString(pega.Local);
                        MessageBox.Show(diretorio);
                        Back_carrinho = Image.FromFile(@diretorio);
                        pbcarrinho.BackgroundImage = Back_carrinho;
                        pbcarrinho.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbcarrinho.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                        pbcarrinho.Refresh();
                        break;
                    }
                    i++;
                }
            }


        }

        private void bremov_Click(object sender, EventArgs e)//remove um item da lista carrinho
        {
            try {
                foreach (var linha in lvCarrinho.Items)
                {
                    if (linha == lvCarrinho.SelectedItems[0])
                    {
                        lvCarrinho.Items.Remove(lvCarrinho.SelectedItems[0]);

                    }
                }
                AtualizaCarrinho();
            }
            catch { MessageBox.Show("Selecione uma das opções para remover!"); }
}
        
        
        private void listView_DoubleClick(object sender, EventArgs e)//seleciona a quantiade de cada item que é enviada para o carrinho
        {
            double valortotal, Preçototal, soma;
            int quantidade = 0, quantidade2, quantiacarrinho;
            bool alarme2 = false;
            string Pselecionado = listView.SelectedItems[0].Text; //Pega o produto selecionado
            Quantidade Verificador = new Quantidade(Pselecionado);
            Verificador.ShowDialog();
            if(cancelar==true)
            {
                MessageBox.Show("Operação Cancelada!");
                cancelar = false;
            }
         else if (Condicao == true) //Esta variavel testa se o valor digitado é Maior que 0
            {
                if (lvCarrinho.Items.Count > 0)
                {
                    for (int i = 0; i < lvCarrinho.Items.Count; i++)
                    {
                        if (listView.SelectedItems[0].Text == lvCarrinho.Items[i].Text)
                        {
                            alarme2 = true; //Alarme para verificar se o item já existe

                            quantidade += quantia;

                            quantidade2 = Convert.ToInt32(listView.SelectedItems[0].SubItems[3].Text);


                            if (quantidade2 >= quantidade) //Verificamos se a quantidade de itens disponiveis é maior ou igual a pedida.
                            {
                                quantiacarrinho = Convert.ToInt32(lvCarrinho.Items[i].SubItems[2].Text); //Pega a quantidade itens já adicionado no Carrinho

                                foreach (var VariavelP in Base.Verificaproduto)
                                {

                                    if (VariavelP.Nomedoproduto == lvCarrinho.Items[i].Text && quantiacarrinho + quantidade <= quantidade2)//Verificamos se a quantia no
                                    {                                                                                       //Carrinho é menor que a quantidade
                                        VariavelP.Quantidade += quantia;                                                    //do estoque
                                        Preçototal = Convert.ToDouble(listView.SelectedItems[0].SubItems[4].Text);
                                        quantiacarrinho += quantia;
                                        soma = valor;//Pegamos o valor que há na nossa variavel valor
                                        Preçototal *= quantidade;//Pegamos o preço e mutiplicamos pela quantidade pedida
                                        soma += Preçototal;//Somamos o preço que tinha na nossa variavel valor a multiplicação anterior
                                        valor = soma; //Colocamos o novo resultado na nossa variavel valor
                                        lbPagar.Text = Convert.ToString(valor); //E atribuimos o preço total de itens do carrinho
                                        lvCarrinho.Items[i].SubItems[2].Text = Convert.ToString(quantiacarrinho);//Adicionados a nova quantidade ao Carrinho
                                        MessageBox.Show("Quantia adicionado com sucesso!");
                                        break;
                                    }
                                    else if (VariavelP.Nomedoproduto == lvCarrinho.Items[i].Text && quantidade2 < quantiacarrinho + quantidade)//Caso a quantia do carrinho
                                    {                                                                                         //for maior que a do estoque
                                                                                                                              //exibimos uma mensagem.
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
                    ListViewItem item2 = new ListViewItem(Pselecionado);
                    item2.SubItems.Add(Convert.ToString(listView.SelectedItems[0].SubItems[4].Text));

                    item2.SubItems.Add(Convert.ToString(quantia));
                    lvCarrinho.Items.Add(item2);

                    valortotal = Convert.ToDouble(listView.SelectedItems[0].SubItems[4].Text);
                    valortotal *= quantia;

                    valor += valortotal;
                    
                    Base testando = new Base(Pselecionado, quantia);
                    Base.Verificaproduto.Add(testando);


                    lbPagar.Text = Convert.ToString(valor);
                    MessageBox.Show("Quantia adicionado com sucesso!");
                    for(int z = 0; z < Base.Produto.Count; z++)
                    {
                        if (Base.Produto[z].Nomedoproduto == Pselecionado)
                        {
                            string teste = Convert.ToString(Base.Produto[z].Local);
                            ItensdoCarrinho testeee = new ItensdoCarrinho(Pselecionado,teste);
                            ItensdoCarrinho.imageVenda.Add(testeee);
                        }
                    }

                }
                else if (alarme == false)
                {
                    MessageBox.Show("A quantidade pedida excede a do estoque!");
                }
            }
            else if (Condicao == false && Formato == false)
            {
                MessageBox.Show("Por favor, digite valores maior que zero");

            }
        }
    }
}
