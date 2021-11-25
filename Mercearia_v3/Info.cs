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

    public partial class Info : Form
    {
        List<Panel> RolagemdePaineis = new List<Panel>(); // armazenar lista de paineis sobrepostos

        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)//carrega todos os atributos iniciais do forms
        {
            pndesen.Enabled = false;
            pndesen.Visible = false;
            RolagemdePaineis.Add(pnpdf);
            RolagemdePaineis.Add(pndesen);
            RolagemdePaineis[0].BringToFront();
            adbPdf.LoadFile(Application.StartupPath+@"\relatorio\Relatorio TF.pdf"); //carrega o pdf da parte escrita do TF
        }

        private void bdesen_Click(object sender, EventArgs e)//vai para o painel desenvolvedor
        {
            pnpdf.Visible = false;
            pnpdf.Enabled = false;
            pndesen.Enabled = true;
            pndesen.Visible = true;
            RolagemdePaineis[0].BringToFront();
        }

        private void bsobre_Click(object sender, EventArgs e)//vai para o painel sobre, onde aparece o pdf descrevendo o trabalho
        {
            pnpdf.Visible = true;
            pnpdf.Enabled = true;
            pndesen.Enabled = false;
            pndesen.Visible = false;
            RolagemdePaineis[0].BringToFront();
        }
    }
}
