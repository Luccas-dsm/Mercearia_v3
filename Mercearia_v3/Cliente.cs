using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mercearia_v3
{
    public class Cliente
    {
        public static List<Cliente> Clientes = new List<Cliente>();
        private string nome, end, tel, email,local,cep;
        private double numCadastro;
        public static double Cadastro = 0; //Contagem, cada vez que um novo produto é cadastrado atualizamos o contador.
        public Cliente() { }
        public Cliente(double ultimonum)
        {
            NumCadastro = ultimonum;
        }
        public string Nome
            {
            get{ return nome; }
            set { nome = value; }
            }
        public string End
        {
            get { return end; }
            set { end = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public double NumCadastro
        {
            get { return numCadastro; }
            set { numCadastro = value; }
        }
        public Cliente(string nom,string end,string cell,string emai,string ceep,double num, string diretorio)
        {
            this.Nome = nom;
            this.End = end;
            this.Tel = cell;
            this.Email = emai;
            this.Cep = ceep;
            this.numCadastro = num;
            this.local = diretorio;
            
        }
       
        public void Altera(string nome) //Metodo para retirar o Objeto da nossa lista de clientes
        {
            foreach (var altera in Clientes)
            {
                if (altera.Nome == nome)
                {
                    Clientes.Remove(altera);
                    MessageBox.Show("Removido com sucesso!");
                    break;
                }
            }
            
        }

        public Fclientes Fclientes
        {
            get => default;
            set
            {
            }
        }
    }
}
