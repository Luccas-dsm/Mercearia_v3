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
    public partial class Quantidade : Form
    {
        public static int quantidad;
        public static bool alarm;
        public Quantidade()//construtor
        {
            InitializeComponent();
        }
        public Quantidade(string nome)//construtor
        {
            InitializeComponent();

            foreach (var pega in Base.Produto) //Assim que inicializa ja pega os dados do produto selecionado.
            {
                if (pega.Nomedoproduto == nome)
                {
                    tbnome.Text = nome;
                    cbcat.Text = pega.Categoria;
                    tbcod.Text = pega.Codigodebarra;
                    quantidad = pega.Quantidade;
                    tbpreco.Text = Convert.ToString(pega.Preço);
                    tbdes.Text = pega.Descricao;
                    pbimagem.Image = Arquivo.Carregar(pega.Local);
                    pbimagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }
        private void bfinaliza_Click(object sender, EventArgs e)//confirma a quantidade desejada
        {
            bool condicao = false, formato = false; int quant = 0;
            try
            {
                quant = Convert.ToInt32(tbquant.Text);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("O formato digitado está incorreto!");
                formato = true; //Alarme para saber se foi digitado algum caractere errado
                

            }
            if (quant > 0)
            {
                condicao = true;
                if (quant <= quantidad) //Verifica se a quantidade pedida é maior que a outra.
                {
                    alarm = true;
                }
                else
                {
                    alarm = false;
                }

            }
            else if (quant <= 0 && formato == false)
            {
                condicao = false;
            }

            Vendas mandaquant = new Vendas(quant, alarm, condicao, formato); //Envia para o metodo construtor de vendas

            
        }
        public int Quantia()
        {
            return quantidad;
        }

        private void bcancela_Click(object sender, EventArgs e)//cancela as alterações
        {
            Vendas.cancelar = true;
            this.Close();
        }

        private void Quantidade_Load(object sender, EventArgs e)//carrega os valores dos atributos ao iniciar o forms
        {
            tbquant.MaxLength = 3;
        }

        private void tbquant_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
