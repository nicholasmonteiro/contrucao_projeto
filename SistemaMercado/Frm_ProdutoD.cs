using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMercado
{
    public partial class Frm_ProdutoD : Form

    {
        private int indice;

        public Frm_ProdutoD()
        {
            InitializeComponent();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {

            indice++;

            if (indice > 2)
                indice = 0;

            lblfoto.ImageIndex = indice;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ProdutoD_Load(object sender, EventArgs e)
        {

        }
    }
}
