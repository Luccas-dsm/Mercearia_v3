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
    public partial class Fclientes : Form
    {
        List<Panel> RolagemdePaineis = new List<Panel>(); // armazenar lista de paineis sobrepostos

        public static string Diretorio;
        public static int cont;
        public static string Nome, End, Tel, Cep, Email, Local;
        public static double Cadastro;
        public static bool alarmes = true, cancelar = false,alarme;
        public Fclientes()
        {
            InitializeComponent();
        }
        public Fclientes(string nome, string end, string tel, string mail, string cep, double cad, string dir)//recebe os valores de cada item do cliente
        {
            Nome = nome;
            End = end;
            Tel = tel;
            Cep = cep;
            Email = mail;
            Cadastro = cad;
            Local = dir;
        }

        public AlterarCliente AlterarCliente
        {
            get => default;
            set
            {
            }
        }

        private void Fclientes_Load(object sender, EventArgs e)//carrega os valores dos atributos ao iniciar o forms
        {
            pnadd.Enabled = false;
            pnadd.Visible = false;
            RolagemdePaineis.Add(pndados);
            RolagemdePaineis.Add(pnadd);

            RolagemdePaineis[0].BringToFront();

            AtualizaCliente();
        }
        public void AtualizaCliente()//atualiza a lista cliente
        {
            lvusuario.Items.Clear();
            foreach (var item in Cliente.Clientes)
            {
                lvusuario.Items.Add(item.Nome);
            }
        }
        private void tbpesq_KeyPress(object sender, KeyPressEventArgs e)//pesquisa por cliente
        {

            Cliente buscar = new Cliente();
            string nomePessoa = tbpesq.Text.ToLower();
            string nomedoprocurado;
            string sep;
            cont = tbpesq.Text.Length;

            lvusuario.Items.Clear();

            foreach (var Pessoa in Cliente.Clientes)
            {

                nomedoprocurado = Pessoa.Nome.ToLower();

                try
                {
                    sep = nomedoprocurado.Substring(0, cont);
                    if (nomePessoa == sep)
                    {

                        lvusuario.Items.Add(Pessoa.Nome);
                    }
                }
                catch { }
            }
        }
        public void ExibeUsuario()//exibe os dados de um usuario
        {
            string diretorio = Application.StartupPath + @"\"; int i = 0;
            if (lvusuario.SelectedItems.Count > 0)
            {

                foreach (var pega in Cliente.Clientes)
                {
                    if (pega.Nome == lvusuario.Text)
                    {
                        diretorio += pega.Local;
                        pbfoto.Image = Arquivo.Carregar(diretorio);
                        pbfoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        lbnome.Text = pega.Nome;
                        lbend.Text = pega.End;
                        lbtel.Text = pega.Tel;
                        lbmail.Text = pega.Email;
                        lbcep.Text = pega.Cep;
                        break;
                    }
                    i++;
                }
            }
        }
        private void lvusuario_Click(object sender, EventArgs e)//exibe os dados do usuario selecionado
        {
            ExibeUsuario();
        }

        private void pbimgadd_Click(object sender, EventArgs e)//carrega a foto do cliente ao fazer o cadastro
        {
            OpenFileDialog CarregaImagem = new OpenFileDialog();
            CarregaImagem.ShowDialog();
            Diretorio = CarregaImagem.FileName;
            try
            {
                // pbfoto.Image = Image.FromFile(Diretorio);
                pbimgadd.Image = Arquivo.Carregar(Diretorio);

                if (Diretorio != "")
                {

                    pbimgadd.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbimgadd.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));

                }
                else
                {
                    pbimgadd.BackColor = Color.Transparent;
                }
            }
            catch { }
        }

        private void tbpesq_Click(object sender, EventArgs e)//limpa a barra de pesquisa 
        {
            tbpesq.Text = "";
        }

        private void tbpesq_Leave(object sender, EventArgs e)//inclementa a palavra "pesquisa" na barra
        {
            tbpesq.Text = "Pesquisar";
        }

        private void lvusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up||e.KeyCode==Keys.Down)
            {
                alarme = true;
            }
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

        private void tbend_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "123456789,ABCDEFGHIJKLMNOPQRSTUVXWYZ";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void tbcep_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbtel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "123456789,ABCDEFGHIJKLMNOPQRSTUVXWYZ,@-_.";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void tmatt_Tick(object sender, EventArgs e)
        {
            if(alarme==true)
            {
                ExibeUsuario();
                alarme = false;
            }
        }

        private void bremov_Click(object sender, EventArgs e)//remove um cliente 
        {
            Cliente Remover = new Cliente();
            int i = 0;
            if (lvusuario.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja " + "\ndeseja remover o cliente: " +
                lvusuario.Text + " ?", "Remover cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    foreach (var itens in Cliente.Clientes)
                    {
                        if (itens.Nome == lvusuario.Text)
                        {
                            Remover.Altera(lvusuario.Text);
                            Arquivo.Deleta(itens.Local);
                            break;
                        }
                        i++;

                    }
                }
            }
            AtualizaCliente();
        }

        private void bconfAdd_Click(object sender, EventArgs e)//confirma o cadastramento de um novo cliente
        {

            string nome = tbnome.Text;
            string end = tbend.Text;
            string tel = tbtel.Text;
            string cep = tbcep.Text;
            string email = tbmail.Text;
            double cad = Cliente.Cadastro++;
            string saida = @"perfis\" + cad + ".png";
            string diretorio = Diretorio;
            Arquivo.alarme = true;

            Arquivo.Copiar(diretorio, saida);

            Cliente Adiciona = new Cliente(nome, end, tel, email, cep, cad, saida);
            Cliente.Clientes.Add(Adiciona);


            tbnome.Text = null;
            tbend.Text = null;
            tbtel.Text = null;
            tbmail.Text = null;
            tbcep.Text = null;
            pbimgadd.Image = null;
            pbimgadd.BackColor = Color.Transparent;
            pnadd.Visible = false;
            pnadd.Enabled = false;
            pndados.Enabled = true;
            pndados.Visible = true;
            RolagemdePaineis[0].BringToFront();
            AtualizaCliente();


        }

        private void bacancelAdd_Click(object sender, EventArgs e)
        {
            pndados.Enabled = true;
            pndados.Visible = true;
            RolagemdePaineis[0].BringToFront();
            pnadd.Visible = false;
            pnadd.Enabled = false;
            AtualizaCliente();
        }

        private void badd_Click(object sender, EventArgs e)//botao adicionar
        {
            pnadd.Enabled = true;
            pnadd.Visible = true;
            RolagemdePaineis[1].BringToFront();
            pndados.Visible = false;
            pndados.Enabled = false;
        }

        private void bdados_Click(object sender, EventArgs e)//botao dados
        {
            pndados.Enabled = true;
            pndados.Visible = true;
            RolagemdePaineis[0].BringToFront();
            pnadd.Visible = false;
            pnadd.Enabled = false;
        }

        private void lvusuario_DoubleClick(object sender, EventArgs e)//altera os dados de um cliente
        {
            string nome = "", end = "", cep = "", tel = "", email = ""; double cadas = 0;
            string diretorio = Application.StartupPath + @"\";
            if (lvusuario.SelectedItems.Count > 0)
            {
                foreach (var pega in Cliente.Clientes)
                {
                    if (pega.Nome == lvusuario.Text)
                    {
                        nome = pega.Nome;
                        end = pega.End;
                        tel = pega.Tel;
                        email = pega.Email;
                        cep = pega.Cep;
                        cadas = pega.NumCadastro;
                        diretorio += pega.Local;
                        break;
                    }
                }
            }
            AlterarCliente exibe2 = new AlterarCliente(nome, end, tel, email, cep, cadas, diretorio);
            exibe2.ShowDialog();
            if (cancelar == true)
            {
                MessageBox.Show("Alteranção cancelada!");
                cancelar = false;
            }
            else if (alarmes == true)//Testa se nenhum parametro foi digitado errado!
            {
                if (lvusuario.SelectedItems.Count > 0)
                {

                    foreach (var itens in Cliente.Clientes)
                    {
                        if (itens.Nome == lvusuario.Text)
                        {
                            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja " + "\ndeseja alterar os dados do" +
                             "\ncliente: " + lvusuario.Text + " ?", "Alterar Cliente", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                string saida = @"perfis\" + itens.NumCadastro + ".png";

                                Arquivo.Copiar(Local, saida);
                                itens.Nome = Nome;
                                itens.End = End;
                                itens.Tel = Tel;
                                itens.Email = Email;
                                itens.Cep = Cep;
                                itens.NumCadastro = Cadastro;
                                itens.Local = saida;

                                MessageBox.Show("Dados alterados com sucesso!");
                                break;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Alteração cancelada!");
                                break;
                            }

                        }
                    }
                    AtualizaCliente();
                }
            }


        }
    }
}
