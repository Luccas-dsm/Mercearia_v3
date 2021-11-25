using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mercearia_v3
{
    public partial class Form1 : Form
    {

        public static string Nomes, categorias, codigodebarras, descricaos, locais;
        public static int quantidades; public static bool alarmes = true;
        public static double Precos;
        public bool alarm = true;
        Dinheiro Empresa;
        // //////////////DECLARA OBJETOS IMAGENS//////////////
        public Image bestoque_leave;
        public Image bestoque_enter;
        public Image bvendas_leave;
        public Image bvendas_enter;
        public Image bcompras_leave;
        public Image bcompras_enter;
        public Image bcliente_leave;
        public Image bcliente_enter;
        public Image binfo_enter;
        public Image binfo_leave;
        public Image bsair_leave;
        public Image bsair_enter;
        // //////////FIM DOS OBJ///////////////////////
        public Form1()
        {
            Empresa = new Dinheiro();
           
           
            Arquivo Teste = new Arquivo();//declara a classe arquivo
            Base test3 = new Base();//declara a classe base
            string ArquivodeProdutos = "DadosProdutos1.txt", ArquivodeClientes = "Clientes.txt", saldo = "Caixa.txt";
            Teste.Ler_Arquivo(ArquivodeProdutos);//chama o metodo lerarquivo e armazena seus dados na classe base
            Teste.Ler_Arquivo(ArquivodeClientes);
            Teste.Ler_Arquivo(saldo);
            InitializeComponent();
            
            lbSaldo.Text = Convert.ToString(Empresa.Saldo.ToString("F2")); //Pegamos o dinheiro atual da empresa

        }
       
        public Form1(bool alarme)//construtor
        {
            alarmes = alarme;
        }
        private Form Form_Ativo = null;//declara um objeto do form

        private void bvenda_Click(object sender, EventArgs e)
        {
            if (alarm == true)//verifica se o alarme e verdadeiro, se sim ele abrirar o forms estoque
            {
                obj_Form = new Vendas();
                AbrirPanel();
                alarm = !alarm;
            }
            else//se não ele fecha o form estoque
            {
                obj_Form.Close();
                alarm = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//salva os arquivos quando o forms é fechado
        {
            bool alarme = false;
         
            foreach (var items in Base.Produto)
            {

                Arquivo.Grava(items.Nomedoproduto, items.Categoria, items.Codigodebarra, items.Quantidade, items.Preço, items.Local, items.Descricao, items.Datadecompra, items.Datadevalidade,alarme);
                alarme = true;
            }
            alarme = false;
            foreach (var item in Cliente.Clientes)
            {
                Arquivo.GravaCliente(item.Nome, item.End, item.Tel, item.Email, item.Cep,item.NumCadastro,item.Local,alarme);
                alarme = true;
            }
          
            Arquivo.Caixa();

        }

        private void tmAttSaldo_Tick(object sender, EventArgs e)//atualiza o saldo toda vez que é alterado
        {
            if(Dinheiro.alarm==true)
            {
                Empresa = new Dinheiro();
                lbSaldo.Text = Convert.ToString(Empresa.Saldo.ToString("F2")); //Pegamos o dinheiro atual da empresa
                Dinheiro.alarm = false;
            }
           
        }

        private void bcompra_Click(object sender, EventArgs e)//vai para o forms compras/fornecedores
        {
            if (alarm == true)//verifica se o alarme e verdadeiro, se sim ele abrirar o forms estoque
            {
                obj_Form = new Compra();
                AbrirPanel();
                alarm = !alarm;
            }
            else//se não ele fecha o form estoque
            {
                obj_Form.Close();
                alarm = true;
            }
        }

        private void bclient_Click(object sender, EventArgs e)//vai para o forms clientes
        {
            if (alarm == true)//verifica se o alarme e verdadeiro, se sim ele abrirar o forms estoque
            {
                obj_Form = new Fclientes();
                AbrirPanel();
                alarm = !alarm;
            }
            else//se não ele fecha o form estoque
            {
                obj_Form.Close();
                alarm = true;
            }
        }

        private void binfo_Click(object sender, EventArgs e)//vai para o painel informações
        {
            if (alarm == true)//verifica se o alarme e verdadeiro, se sim ele abrirar o forms estoque
            {
                obj_Form = new Info();
                AbrirPanel();
                alarm = !alarm;
            }
            else//se não ele fecha o form estoque
            {
                obj_Form.Close();
                alarm = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)//carrega o local de cada imagem nos objetos imagens
        {
            string localdasImagens = Application.StartupPath + @"\layout\";
            bestoque_enter = Image.FromFile(localdasImagens + "bestoque_enter.png");
            bestoque_leave = Image.FromFile(localdasImagens + "bestoque_leave.png");
            bvendas_enter = Image.FromFile(localdasImagens + "bvenda_enter.png");
            bvendas_leave = Image.FromFile(localdasImagens + "bvenda_leave.png");
            bcompras_enter = Image.FromFile(localdasImagens + "bcompra_enter.png");
            bcompras_leave = Image.FromFile(localdasImagens + "bcompra_leave.png");
            bcliente_enter = Image.FromFile(localdasImagens + "bcliente_enter.png");
            bcliente_leave = Image.FromFile(localdasImagens + "bcliente_leave.png");
            binfo_enter = Image.FromFile(localdasImagens + "binfo_enter.png");
            binfo_leave = Image.FromFile(localdasImagens + "binfo_leave.png");
            bsair_enter = Image.FromFile(localdasImagens + "bsair_enter.png");
            bsair_leave = Image.FromFile(localdasImagens + "bsair_leave.png");
            Arquivo leitor = new Arquivo();
            leitor.LeitordeNotinhadodia();
            
        }

        private void best_MouseEnter(object sender, EventArgs e)//botao estoque mouse enter
        {
            best.BackgroundImage = bestoque_enter;
        }

        private void best_MouseLeave(object sender, EventArgs e)//botao estoque leave
        {
            best.BackgroundImage = bestoque_leave;
        }

        private void bvenda_MouseEnter(object sender, EventArgs e)//botao vendas enter
        {
            bvenda.BackgroundImage = bvendas_enter;
        }

        private void bvenda_MouseLeave(object sender, EventArgs e)//botao vendas leave
        {
            bvenda.BackgroundImage = bvendas_leave;
        }

        private void bcompra_MouseEnter(object sender, EventArgs e)//botao compra enter
        {
            bcompra.BackgroundImage = bcompras_enter;
        }

        private void bcompra_MouseLeave(object sender, EventArgs e)//botao compra leave
        {
            bcompra.BackgroundImage = bcompras_leave;
        }

        private void bclient_MouseEnter(object sender, EventArgs e)//botao cliente enter
        {
            bclient.BackgroundImage = bcliente_enter;
        }

        private void bclient_MouseLeave(object sender, EventArgs e)//botao cliente leave
        {
            bclient.BackgroundImage = bcliente_leave;
        }

        private void binfo_MouseEnter(object sender, EventArgs e)//botao info enter
        {
            binfo.BackgroundImage = binfo_enter;
        }

        private void binfo_MouseLeave(object sender, EventArgs e)//botao info leave
        {
            binfo.BackgroundImage = binfo_leave;
        }

        private void bsair_MouseEnter(object sender, EventArgs e)//botao sair enter
        {
            bsair.BackgroundImage = bsair_enter;
        }

        private void bsair_MouseLeave(object sender, EventArgs e)//botao sair leave
        {
            bsair.BackgroundImage = bsair_leave;
        }

        private void Form1_Shown(object sender, EventArgs e)//apos o forms1 aberto a janela telainicial é carregada
        {
            Telainicial open = new Telainicial();

            open.Show();
            open.BringToFront();
        }

        private Form obj_Form;//declara um objeto do form

        private void AbrirPanel()//chama o metodo abrir painel onde o form desejado será aberto
        {
            // metodo para abrir janelas no panel_Tela

            if (Form_Ativo != null) { Form_Ativo.Close(); }

            Form_Ativo = obj_Form;
            obj_Form.TopLevel = false;
            obj_Form.FormBorderStyle = FormBorderStyle.None;
            obj_Form.Dock = DockStyle.Fill;
            pPrincipal.Controls.Add(obj_Form);
            obj_Form.Show();
        }
        private void bsair_Click(object sender, EventArgs e)//botão Sair
        {
            this.Close();
        }

        private void best_Click(object sender, EventArgs e)
        {
            if (alarm == true)//verifica se o alarme e verdadeiro, se sim ele abrirar o forms estoque
            {
                obj_Form = new Estoque();
                AbrirPanel();
                alarm = !alarm;
            }
            else//se não ele fecha o form estoque
            {
                obj_Form.Close();
                alarm = true;
            }
        }

        public Telainicial Telainicial
        {
            get => default;
            set
            {
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

        public Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        public Info Info
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
    }
}
