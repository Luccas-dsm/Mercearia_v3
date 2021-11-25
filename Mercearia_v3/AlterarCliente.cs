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
    public partial class AlterarCliente : Form
    {
        
        public static string diretorio; public static double cadastro;
        public AlterarCliente(string nome, string end, string tel, string email, string cep,double cad,string local)//construtor recebe dados de um cliente
        {
            InitializeComponent();
            tbnome.Text = nome;
            tbend.Text = end;
            tbcep.Text = cep;
            tbtel.Text = tel;
            tbmail.Text = email;
            cadastro= cad;
            diretorio = local;
            pbimg.Image = Arquivo.Carregar(@diretorio);
            pbimg.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public AlterarCliente()//cosntrutor
        {
            InitializeComponent();
        }

        private void bconf_Click(object sender, EventArgs e)//confirma as alterações
        {
            try
            {
                    Fclientes PassaParametros = new Fclientes(tbnome.Text, tbend.Text, tbtel.Text, tbmail.Text, tbcep.Text, cadastro, diretorio);
                    this.Close();
               
               
              
            }
            catch
            {
                MessageBox.Show("Parametro digitado errado tente novamente!");
                
               // Form1 PassaParametros = new Form1(alarme);
                this.Close();
            }
        }

        private void bcancel_Click(object sender, EventArgs e)//cancela as alterações
        {
            Fclientes.cancelar = true;
            this.Close();
        }

        private void pbimg_Click(object sender, EventArgs e)//carrega uma imagem
        {
            Arquivo.alarme = true;
            OpenFileDialog CarregaImagem = new OpenFileDialog();
            CarregaImagem.ShowDialog();
            diretorio = CarregaImagem.FileName;

            pbimg.Image = Arquivo.Carregar(diretorio);
            pbimg.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageBox.Show("Imagem carregada com sucesso!");
        }

        private void tbnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8|| e.KeyChar == 32)
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
    }
}
