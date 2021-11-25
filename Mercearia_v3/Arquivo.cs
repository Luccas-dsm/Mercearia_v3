using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
namespace Mercearia_v3
{
   public class Arquivo
    {
        public static bool alarme = false;

        public NotaFiscal NotaFiscal
        {
            get => default;
            set
            {
            }
        }

        public void Ler_Arquivo(string arquivo)//Pegamos o nome do arquivo
        {
            Base Classe;
            Cliente Busca;
            Dinheiro Cash;
           
            if (File.Exists(arquivo))
            {
                StreamReader Dados = new StreamReader(arquivo, Encoding.Default); //Usamos para ler de forma padrão
                string linha, Nome, Categoria, tel,cep,CodigodeBarra, local, descricao,end,email;                              //Para os caracteres como " ~ " não ficarem com
                string[] separa;                                                                           //simbolo estranho.
                int quantidade,quantidade2,cad;
                double preço,teste=0;
                DateTime datadecompra, datadevalidade, data, data2;
                if (arquivo == "DadosProdutos1.txt")
                {
                    while ((linha = Dados.ReadLine()) != null)
                    {
                       
                        if (linha != null)
                        {
                            separa = linha.Split(';');
                            Nome = separa[0];
                            Categoria = separa[1];
                            try
                            {
                                teste = Convert.ToDouble(separa[2]);
                            }
                            catch { }
                            if(teste>0)
                            {
                               foreach(var verificando in Base.Produto)
                                {
                                    double codigo = Convert.ToDouble(verificando.Codigodebarra);
                                    if(codigo==teste)
                                    {
                                        teste++;
                                        break;
                                    }
                                }
                                CodigodeBarra = Convert.ToString(teste);
                            }
                            else
                            {
                                CodigodeBarra = Convert.ToString(Base.Contagem++);
                            }
                            
                           
                            try
                            {
                                quantidade = Convert.ToInt32(separa[3]);
                               
                                if (quantidade < 0)
                                {
                                    quantidade = 0;
                                }
                              
                            }
                            catch
                            {
                                quantidade = 0;
                            }
                            try
                            {
                                preço = Convert.ToDouble(separa[4]);
                                if (preço < 0)
                                {
                                    preço = 0;
                                }
                            }
                            catch
                            {
                                preço = 0;
                            }
                            local = Convert.ToString(separa[5]);
                            descricao = Convert.ToString(separa[6]);
                            try
                            {
                                datadecompra = Convert.ToDateTime(separa[7]);
                            }
                            catch
                            {
                                datadecompra = DateTime.Now;
                            }
                            try
                            {
                                datadevalidade = Convert.ToDateTime(separa[8]);
                            }
                            catch
                            {
                                datadevalidade = DateTime.Now;
                            }
                           
                            Classe = new Base(Nome, Categoria, CodigodeBarra, quantidade, preço, local, descricao, datadecompra, datadevalidade);
                            Base.Produto.Add(Classe);
                            data = DateTime.Now;
                            data2 = data.AddYears(5);
                            preço *= 0.5;

                            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);//{
                            var Random = new Random(random.Next(100, 700));                     //Usamos para gerar quantidades aleatórias no fornecedor
                            quantidade2 = Random.Next(100, 700);                                 //para cada vez que o programa é iniciado.
                            Thread.Sleep(200);                                               //}

                            Classe = new Base(Nome, Categoria, CodigodeBarra, quantidade2, preço, local, descricao, data2);
                            Base.Fornecedor.Add(Classe);
                            Base.Contagem++;
                        }
                    }
                }
                else if (arquivo == "Clientes.txt")
                {
                    string[] linhas = File.ReadAllLines(arquivo, Encoding.Default);
                    foreach (var lin in linhas)
                    {

                        separa = lin.Split(';');
                        Nome = separa[0];
                        end = separa[1];
                        tel = separa[2];
                        email = separa[3];
                        cep = separa[4];
                        cad = int.Parse(separa[5]);
                        local = separa[6];
                        Cliente.Cadastro++;
                        Busca = new Cliente(Nome, end, tel, email, cep, cad, local);
                        Cliente.Clientes.Add(Busca);
                    }

                }
                else if (arquivo == "Caixa.txt")
                  {
                    string[] linhas = File.ReadAllLines(arquivo, Encoding.Default);
                    foreach (var lin in linhas)
                    {
                        separa = lin.Split(';');
                        Cash = new Dinheiro(double.Parse(separa[0]));
                        Classe = new Base(double.Parse(separa[1]));
                        Busca = new Cliente(double.Parse(separa[2]));
                    }
                }
                
                Dados.Close();
            }
        }
        public void LeitordeNotinhadodia()
        {
           
            string hoje = Convert.ToString(DateTime.Now).Substring(0, 10);
            string[] sep;
            sep = hoje.Split('/');
            int dia = int.Parse(sep[0]), mes = int.Parse(sep[1]), ano = int.Parse(sep[2]);
            string nomedoarquivo = dia + "-" + mes + "-" + ano + ".txt";
            string local = Application.StartupPath+@"\notaVenda\" + nomedoarquivo;
            string[] separa;
            double num=0, valor;
            string Nome, end, prod;
            DateTime date;
            NotaFiscal nota;
            NotaCompra notac;
            
            NotaFiscal.Notasantigas.Clear();
            if (File.Exists(local))
            {
                string[] linhas = File.ReadAllLines(local, Encoding.UTF8);
                foreach (var lin in linhas)
                {
                    separa = lin.Split(';');
                    num = double.Parse(separa[0]);
                    Nome = separa[1];
                    end = separa[2];
                    prod = separa[3];
                    valor = double.Parse(separa[4]);
                    date = Convert.ToDateTime(separa[5]);
                    nota = new NotaFiscal(num, Nome, end, prod, valor, date);
                    NotaFiscal.Notas.Add(nota);
                }
                NotaFiscal.numero = num+1;
               
            }
            local = Application.StartupPath + @"\notaCompra\" + nomedoarquivo;
            
            if (File.Exists(local))
            {
                NotaCompra.NotasCompras.Clear();
                
                string[] linhas = File.ReadAllLines(local, Encoding.UTF8);
                foreach (var lin in linhas)
                {
                    separa = lin.Split(';');
                    num = double.Parse(separa[0]);
                    Nome = separa[1];
                    end = separa[2];
                    prod = separa[3];
                    valor = double.Parse(separa[4]);
                    date = Convert.ToDateTime(separa[5]);
                    notac = new NotaCompra(num, Nome, end, prod, valor, date);
                    NotaCompra.NotasCompras.Add(notac);
                }
                NotaCompra.numero = num + 1;
               
            }
        }
        public void LeitordeNotinha(string arquivo,string pasta) 
        {
            string[] separa;        
            double num,valor;
            string Nome, end, prod;
            DateTime date;
            NotaFiscal nota;
            NotaCompra notac;
            NotaCompra.NotasCompras.Clear();
            NotaFiscal.Notasantigas.Clear();
            if (pasta == "notaVenda")
            {
                if (File.Exists(arquivo))
                {
                    string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
                    foreach (var lin in linhas)
                    {
                        separa = lin.Split(';');
                        num = double.Parse(separa[0]);
                        Nome = separa[1];
                        end = separa[2];
                        prod = separa[3];
                        valor = double.Parse(separa[4]);
                        date = Convert.ToDateTime(separa[5]);
                        nota = new NotaFiscal(num, Nome, end, prod, valor, date);
                        NotaFiscal.Notasantigas.Add(nota);
                    }
                }
                else { MessageBox.Show("Arquivo não encontrado.\n Digite como no exemplo: 26-5-2020"); }
           
            }
            else if (pasta=="notaCompra")
            {
                if (File.Exists(arquivo))
                {
                    string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
                    foreach (var lin in linhas)
                    {
                        separa = lin.Split(';');
                        num = double.Parse(separa[0]);
                        Nome = separa[1];
                        end = separa[2];
                        prod = separa[3];
                        valor = double.Parse(separa[4]);
                        date = Convert.ToDateTime(separa[5]);
                        notac = new NotaCompra(num, Nome, end, prod, valor, date);
                        NotaCompra.NotasCompras.Add(notac);
                    }
                }
                else { MessageBox.Show("Arquivo não encontrado.\n Digite como no exemplo: 26-5-2020"); }

            }
        }
        public static void Caixa()//gravamos o valor total do saldo da empresa 
        {
            StreamWriter Grava = new StreamWriter("Caixa.txt");

            Grava.WriteLine(Dinheiro.saldo+";"+ Base.Contagem+";"+Cliente.Cadastro);
            Grava.Close();
        }
        public static void GravaNotinha(double num,string pasta,string nome,string end,string prod,double val,DateTime data)
        {
            string local = Application.StartupPath + @"\" + pasta + @"\";
         //   bool alarme=false;
            string hoje = Convert.ToString(DateTime.Now).Substring(0, 10);
            string[] sep;
            sep = hoje.Split('/');
            int dia = int.Parse(sep[0]), mes = int.Parse(sep[1]), ano = int.Parse(sep[2]);
            string nomedoarquivo = dia + "-" + mes + "-" + ano + ".txt";
            local += nomedoarquivo;
            if (pasta == "notaVenda")
            {
                if (File.Exists(local))
                {
                    alarme = true;
                }
                StreamWriter Grava = new StreamWriter(local, true);

                Grava.WriteLine(num + ";" + nome + ";" + end + ";" + prod.Substring(0, prod.Length - 1) + ";" + val + ";" + data);
                Grava.Close();
            }
            else if (pasta=="notaCompra")
            {
                if (File.Exists(local))
                {
                    alarme = true;
                }
                StreamWriter Grava = new StreamWriter(local, true);

                Grava.WriteLine(num + ";" + nome + ";" + end + ";" + prod.Substring(0, prod.Length - 1) + ";" + val + ";" + data);
                MessageBox.Show("Arquivo gravado com sucesso");
                Grava.Close();
            }
            
        }
        public static void Grava(string nomedoproduto, string categoria, string codigodebarra, int quantidade, double preço, string local, string descricao, DateTime datadecompra, DateTime datadevalidade,bool arquivo)//gravamos os dados dos produtos
        {
            string val, compra;
            val =Convert.ToString(datadevalidade);
            val= val.Substring(1, 9);
            compra = Convert.ToString(datadecompra);
            compra = compra.Substring(1, 9);
            StreamWriter grava = new StreamWriter("DadosProdutos1.txt", arquivo,Encoding.Default);
            grava.WriteLine(nomedoproduto + ";" + categoria + ";" + codigodebarra + ";" + quantidade + ";" + preço + ";" + local + ";" + descricao + ";" + compra + ";" + val);
            grava.Close();
        }
        public static void GravaCliente(string nom, string ende, string tele, string ema,string cep, double cad,string local,bool arquivo)//gravamos os dados dos clientes
        {
            StreamWriter Grava = new StreamWriter("Clientes.txt",arquivo);

            Grava.WriteLine(nom + ";" + ende + ";" + tele + ";" + ema + ";"+cep+";"+cad+";"+local);

            Grava.Close();
        }
        public static Bitmap Carregar(string caminho)//carregamos qualquer imagem para uma picturebox
        {
            if (File.Exists(caminho))
            {
                byte[] imageByte = File.ReadAllBytes(caminho);
                MemoryStream mStream = new MemoryStream();
                mStream.Write(imageByte, 0, Convert.ToInt32(imageByte.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            else
            {
                Bitmap bmp = new Bitmap(172, 220);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, 172, 220);
                    graph.FillRectangle(Brushes.Transparent, ImageSize);
                }
                return bmp;
            }

        }
        public static void Copiar(string entradaImg, string saidaImg)//copiamos arquivos de imagem de um local para a raiz do programa
        {
            if (alarme == true)
            {
                if (File.Exists(entradaImg) == false)
                {
                    MessageBox.Show("Não foi possível encontrar o arquivo Origem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
           
                if (File.Exists(saidaImg) == true) { }
                try
                {
                    Stream s1 = File.Open(entradaImg, FileMode.Open);
                    Stream s2 = File.Open(saidaImg, FileMode.Create);

                    BinaryReader f1 = new BinaryReader(s1);
                    BinaryWriter f2 = new BinaryWriter(s2);

                    while (true)
                    {
                        byte[] buf = new byte[10240];
                        int sz = f1.Read(buf, 0, 10240);
                        if (sz <= 0)
                            break;
                        f2.Write(buf, 0, sz);
                        if (sz < 10240)
                            break; // fim de arquivo
                    }
                    f1.Close();
                    f2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao copiar a o arquivo ...: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                alarme = false;
            }
            else {  }
        }
        public static void Deleta(string nomArq)
        {
            if (File.Exists(Application.StartupPath+@"\"+nomArq))//Verificamos se o Arquivo existe
            {
                File.Delete(Application.StartupPath + @"\"+nomArq );//Se existir deletamos o arquivo

                //   Console.WriteLine("O arquivo: " + nomeArq + ".txt" + " foi apagado!");

            }
            else //Caso o arquivo não exista exibe a mensagem!
            {
                Console.WriteLine("Erro o arquivo não foi encontrado!");
            }
        }
    }
}
