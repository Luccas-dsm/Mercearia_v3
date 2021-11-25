using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mercearia_v3
{
    public partial class Estoque : Form
    {
       
        List<Panel> RolagemdePaineis = new List<Panel>(); // armazenar lista de paineis sobrepostos
        public static int cont = 1;
        public static string Diretorio;
        public static string Nomes, categorias, codigodebarras, descricaos, locais;
        public static int quantidades; public static bool alarmes = true,Cancela=false;
        public static double Precos;
        public Estoque()//construtor
        {
            InitializeComponent();
            tbcod.Text = Convert.ToString(Base.Contagem);
            listView.Items.Clear();
        }
        public Estoque(string nome, string categoria, string codigodebarra, double preço, string descricao, string local)//construtor recebe os dados quando algum produto é alterado
        {
            Nomes = nome;
            categorias = categoria;
            codigodebarras = codigodebarra;
            descricaos = descricao;
            locais = local;
            Precos = preço;
        }

        public Estoque(bool alarme)//construtor
        {
            alarmes = alarme;
        }

        public Alterar Alterar
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
            pbfoto.Image = null;
            pbfoto.BackColor = Color.Transparent;
            tbdado.Text = "";
            lbprod.Text = "";
        }
        private void badd_Click(object sender, EventArgs e)//ativa o painel adicionar e desativa os demais
        {
             pnadd.Enabled = true;
            pnadd.Visible = true;
            RolagemdePaineis[1].BringToFront();
            pnestoque.Visible = false;
            pnestoque.Enabled = false;
        }

        private void Estoque_Load(object sender, EventArgs e)//assim que o forms é carregado ele coloca valores iniciais aos seus atributos
        {
            tbdado.MaxLength=40;
            tbnome.MaxLength = 23;
            tbpreco.MaxLength = 10;
            tbdes.MaxLength = 40;
            pnadd.Enabled = false;
            pnadd.Visible = false;
            RolagemdePaineis.Add(pnestoque);
            RolagemdePaineis.Add(pnadd);
            RolagemdePaineis[0].BringToFront();
            Atualizalista();
        }

        private void bremov_Click(object sender, EventArgs e)//remove um produto
        {
            Base Remover = new Base();
            int i = 0, index;
            if (listView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja " + "\ndeseja remover o produto: " +
                listView.SelectedItems[0].Text + " ?", "Remover Produto", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    index = listView.SelectedItems[0].Index;

                    foreach (var itens in Base.Produto)
                    {
                        if (index == i && itens.Nomedoproduto == listView.SelectedItems[0].Text)
                        {
                            Remover.Altera(listView.SelectedItems[0].Text);
                            Arquivo.Deleta(itens.Local);
                            break;
                        }
                        i++;
                    }
                }
            }
            Atualizalista();
        }

        private void batt_Click(object sender, EventArgs e)//atualiza a lista de produtos
        {
                     Atualizalista();
        }

        private void tbnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void tbpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "1234567890,";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void listView_Click(object sender, EventArgs e)//seleciona um produto que está listado
        {
            string diretorio = Application.StartupPath + @"\"; int i = 0;
            if (listView.SelectedItems.Count > 0)
            {
                int index = listView.SelectedItems[0].Index;

                foreach (var pega in Base.Produto)
                {
                    if (index == i && pega.Nomedoproduto == listView.SelectedItems[0].Text)
                    {
                        diretorio += Convert.ToString(pega.Local);
                        pbfoto.Image = Arquivo.Carregar(diretorio);
                        pbfoto.BackColor= Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                        pbfoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        lbprod.Text = Convert.ToString(Encoding.UTF8);
                        lbprod.Text = pega.Nomedoproduto;
                       // lbprod.Location = new Point(pictureBox2.Location.X + ((pictureBox2.Width - coloca1.Width) / 2), pictureBox2.Location.Y + ((pictureBox2.Height - coloca1.Height) / 2));
                        tbdado.Text = Convert.ToString(Encoding.UTF8);
                        tbdado.Text = pega.Descricao;
                        //coloca2.Location = new Point(pictureBox1.Location.X + ((pictureBox1.Width - coloca2.Width) / 2), pictureBox1.Location.Y + ((pictureBox1.Height - coloca2.Height) / 2));

                        break;
                    }
                    i++;
                }
            }
        }

        private void pbcarregafoto_Click(object sender, EventArgs e)//carrega a imagem do produto na picture box
        {
            OpenFileDialog CarregaImagem = new OpenFileDialog();
            CarregaImagem.ShowDialog();
            Diretorio = CarregaImagem.FileName;
            try
            {
                // pbfoto.Image = Image.FromFile(Diretorio);
                pbcarregafoto.Image = Arquivo.Carregar(Diretorio);

                if (Diretorio != "")
                {
                    
                    pbcarregafoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbcarregafoto.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));

                }
                else
                {
                    pbcarregafoto.BackColor = Color.Transparent;
                }
            }
            catch { }
        }

        private void bconfirma_Click(object sender, EventArgs e)//assim que os dados estiverem corretos ele adiciona o novo produto
        {
            bool arquivo = true;
            try
            {
                string nome = tbnome.Text;
                string categoria = lbcat.Text;
                string codigo = tbcod.Text;
                double preço = Convert.ToDouble(tbpreco.Text);
                int quant = 0;
                string descricao = tbdes.Text;
                DateTime data = DateTime.Now;
                DateTime data2 = data.AddYears(1);
                string saida = @"images\" + codigo + ".png";
                string diretorio = Diretorio;

                Arquivo.alarme = true;
                Arquivo.Copiar(diretorio, saida);
                Arquivo.Grava(nome, categoria, codigo, quant, preço, saida, descricao, data, data2, arquivo);
                Base Adiciona = new Base(nome, categoria, codigo, quant, preço, saida, descricao, data, data2);
                Base.Produto.Add(Adiciona);
                Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

                var Random = new Random(random.Next(1, 100));

                quant = Random.Next(1, 100);
                Thread.Sleep(200);

                Adiciona = new Base(nome, categoria, codigo, quant, preço, saida, descricao, data2);
                Base.Fornecedor.Add(Adiciona);
                MessageBox.Show("Produto cadastrado com sucesso!");
                Base.Contagem++;

                tbcod.Text = Convert.ToString(Base.Contagem);
                tbnome.Text = null;
                lbcat.Text = "";
                tbpreco.Text = null;
                tbdes.Text = null;
                pbcarregafoto.Image = null;
                pbcarregafoto.BackColor = Color.Transparent;
                pnadd.Visible = false;
                pnadd.Enabled = false;
                pnestoque.Enabled = true;
                pnestoque.Visible = true;
                RolagemdePaineis[0].BringToFront();

                // MessageBox.Show("Os dados não foram inceridos corretamente.\nPor favor, verfique novamente se os dados estão corretos.");
            }
            catch { MessageBox.Show("Dados incorretos, por favor digite novamente"); }
        }

        private void bcancela_Click(object sender, EventArgs e)//cancela a adição do produto
        {
            tbnome.Text = null;
            lbcat.Text = "";
            tbpreco.Text = null;
            tbdes.Text = null;
            pbcarregafoto.Image = null;
            pbcarregafoto.BackColor = Color.Transparent;
            pnadd.Visible = false;
            pnadd.Enabled = false;
            pnestoque.Enabled = true;
            pnestoque.Visible = true;
            RolagemdePaineis[0].BringToFront();
            pnestoque.Enabled = true;
            pnestoque.Visible = true;
            RolagemdePaineis[0].BringToFront();
            pnadd.Visible = false;
            pnadd.Enabled = false;
        }

        private void listView_DoubleClick(object sender, EventArgs e)//abre a janela para alteração dos dados do produto
        {
            string Nome = "", Categoria = "", Codigo = "", Descricao = "", Local = "";
            int Quantidade = 0, index, i = 0;
            double Preçoproduto = 0;

            if (listView.SelectedItems.Count > 0)
            {
                index = listView.SelectedItems[0].Index;

                foreach (var itens in Base.Produto)
                {
                    if (index == i && itens.Nomedoproduto == listView.SelectedItems[0].Text)
                    {

                        Nome = itens.Nomedoproduto;
                        Categoria = itens.Categoria;
                        Codigo = itens.Codigodebarra;
                        Descricao = itens.Descricao;
                        Quantidade = itens.Quantidade;
                        Preçoproduto = itens.Preço;
                        Local = itens.Local;
                        break;
                    }
                    i++;

                }
            }
            Alterar exibe2 = new Alterar(Nome, Categoria, Codigo, Preçoproduto, Descricao, Quantidade, Local);
            exibe2.ShowDialog();
        if(Cancela==true)
            {
                MessageBox.Show("Alteração cancelada!");
                Cancela = false;
            }
            else if (alarmes == true)//Testa se nenhum parametro foi digitado errado!
            {
                if (listView.SelectedItems.Count > 0)
                {
                    index = listView.SelectedItems[0].Index;

                    foreach (var itens in Base.Produto)
                    {
                        for (int z = 0; z < listView.SelectedItems.Count; z++)
                        {
                            if (itens.Nomedoproduto == listView.SelectedItems[0].Text)
                            {
                                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja " + "\ndeseja alterar o produto: " +
                                listView.SelectedItems[0].Text + " ?", "Alterar Produto", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if(Arquivo.alarme==true)
                                    {
                                        string saida = @"images\" + itens.Codigodebarra + ".png";
                                        Arquivo.Copiar(locais, saida);
                                    }
                                                                  
                                    itens.Nomedoproduto = Nomes;
                                    itens.Categoria = categorias;
                                    itens.Codigodebarra = codigodebarras;
                                    itens.Descricao = descricaos;
                                    itens.Preço = Precos;
                                    
                                    MessageBox.Show("Produto alterado com sucesso!");
                                   
                                    break;
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    MessageBox.Show("Alteração cancelada!");
                                }
                                break;
                            }

                        }

                    }
                    Atualizalista();
                }
            }

        }
    }
    
}
