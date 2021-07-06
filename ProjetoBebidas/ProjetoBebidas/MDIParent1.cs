using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBebidas
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra swingTrade = new Compra();
            swingTrade.MdiParent = this;
            swingTrade.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque swingTrade = new Estoque();
            swingTrade.MdiParent = this;
            swingTrade.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas swingTrade = new Vendas();
            swingTrade.MdiParent = this;
            swingTrade.Show();
        }
    }
}
