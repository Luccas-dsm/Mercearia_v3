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
    public partial class AddCl : Form
    {
        public static string Diretorio;
        public static string prod;
        public static double val;
        public AddCl(string produ,double valor) { prod = produ; val = valor; }
        public AddCl()
        {
            InitializeComponent();
        }

        private void bconfAdd_Click(object sender, EventArgs e)
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

            Notinha nota = new Notinha(prod, val, nome, end,"notaVenda");
            Notinha ap = new Notinha();
            ap.Show();
            this.Close();
        }

        private void pbimgadd_Click(object sender, EventArgs e)
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

        private void bacancelAdd_Click(object sender, EventArgs e)
        {
            Notinha nota = new Notinha(prod, val, "", "", "notaVenda");
            Notinha not = new Notinha();
            not.Show();
            this.Close();
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
    }
}
