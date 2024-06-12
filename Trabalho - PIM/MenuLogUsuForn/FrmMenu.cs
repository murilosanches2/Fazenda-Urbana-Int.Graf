using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho___PIM
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroForn frm = new FrmCadastroForn();
            frm.ShowDialog();
        }
        private void VendasLegumes_Click(object sender, EventArgs e)
        {
            FrmLegumesVendas frm = new FrmLegumesVendas();
            frm.Show();
        }

        private void VendasVerduras_Click(object sender, EventArgs e)
        {
            FrmVerdurasVendas frm = new FrmVerdurasVendas();
            frm.Show();
        }

        private void VendasFrutas_Click(object sender, EventArgs e)
        {
            FrmFrutasVendas frm = new FrmFrutasVendas();
            frm.Show();
        }

        private void RegistroLegumes_Click(object sender, EventArgs e)
        {
            FrmLegumes frm = new FrmLegumes();
            frm.Show();
        }

        private void RegistroVerduras_Click(object sender, EventArgs e)
        {
            FrmVerduras frm = new FrmVerduras();
            frm.Show();
        }

        private void RegistroFrutas_Click(object sender, EventArgs e)
        {
            FrmFrutas frm = new FrmFrutas();
            frm.Show();
        }
    }
}
