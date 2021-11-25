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
    public partial class Alterar : Form
    {
        public static string diretorio; public static bool alarme;
        public Alterar(string nome, string categoria, string codigodebarra, double preço, string descricao, int quantidade, string local)//construtor recebe os dados de um produto
        {
            InitializeComponent();
            tbnome.Text = nome;
            cbcat.Text = categoria;
            tbcod.Text = codigodebarra;
            tbpreco.Text = Convert.ToString(preço);
            tbdes.Text = descricao;
            diretorio = local;
            pbimagem.Image = Arquivo.Carregar( @diretorio);
            pbimagem.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Alterar()//construtor
        {
            InitializeComponent();
        }

      
        private void bfinaliza_Click(object sender, EventArgs e)//confirma as alterações feitas no produto
        {
            try
            {
                
                double Preco = Convert.ToDouble(tbpreco.Text);
                Estoque PassaParametros = new Estoque(tbnome.Text, cbcat.Text, tbcod.Text, Preco, tbdes.Text,diretorio);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Parametro digitado errado tente novamente!");
                alarme = false;
                Estoque PassaParametros = new Estoque(alarme);
               
            }
        }

        private void bcancela_Click(object sender, EventArgs e)//cancela as alterações feitas
        {
            Estoque.Cancela = true;
            this.Close();
        }

        private void pbimagem_Click(object sender, EventArgs e)//carrega as imagens
        {
            Arquivo.alarme = true;
            OpenFileDialog CarregaImagem = new OpenFileDialog();
            CarregaImagem.ShowDialog();
            diretorio = CarregaImagem.FileName;

            pbimagem.Image = Arquivo.Carregar(diretorio);
            pbimagem.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageBox.Show("Imagem carregada com sucesso!");
        }

        private void Alterar_Load(object sender, EventArgs e)//define os atributos iniciais do forms
        {
            tbnome.MaxLength = 23;
            tbpreco.MaxLength = 10;
            tbdes.MaxLength = 35;
            
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

        private void tbdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8||e.KeyChar==32)
            {
                e.Handled = false;
            }
        }
    }
}
