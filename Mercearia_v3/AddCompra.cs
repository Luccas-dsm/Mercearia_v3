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
    public partial class AddCompra : Form
    {
        public static int quantidad;
        public static bool alarm;
        public AddCompra()//construtor
        {
            InitializeComponent();
        }
        public AddCompra(string nome)//construtor inicia o forms
        {
            InitializeComponent();
            tbnome.Text = nome;
            foreach (var pega in Base.Fornecedor)
            {

                if (pega.Nomedoproduto == nome)
                {

                    tbcat.Text = pega.Categoria;
                    tbcod.Text = pega.Codigodebarra;
                    quantidad = pega.Quantidade;
                    tbpreco.Text = Convert.ToString(pega.Preço);
                    tbdes.Text = pega.Descricao;
                    pbimagem.Image = Image.FromFile(pega.Local);
                    pbimagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        private void bfinaliza_Click(object sender, EventArgs e)//finaliza quantidade que vai ser enviada para o carrinho
        {

            int quant = 0; bool condicao = false, formato = false;
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
            Compra mandaquant = new Compra(quant, alarm, condicao, formato);//Envia para o metodo construtor de Fornecedores
            
        }

        private void bcancela_Click(object sender, EventArgs e)//cancela a quantidade selecionada
        {
            Compra.Cancelar = true;
            this.Close();
        }

        private void AddCompra_Load(object sender, EventArgs e)//carrega atributos ao forms apos iniciado
        {
            tbdes.MaxLength = 35;
            tbquant.MaxLength = 3;
        }

        private void tbquant_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "0123456789,";

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
