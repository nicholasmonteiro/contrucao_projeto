using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaModelo;

namespace SistemaMercado
{
    public partial class frm_menuprincipal : Form
    {
        public frm_menuprincipal()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_Produto frm = new frm_Produto();
            frm.Show();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Frm_categoria frm = new Frm_categoria();
            frm.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            Frm_ajuda frm = new Frm_ajuda();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Produto frm = new frm_Produto();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_categoria frm = new Frm_categoria();
            frm.Show();
        }

 

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ajuda frm = new Frm_ajuda();
            frm.Show();
        }

        private void btn_Aarmarzem_Click(object sender, EventArgs e)
        {
            Frm_armazem frm = new Frm_armazem();
            frm.Show();
        }

        private void frm_menuprincipal_Load(object sender, EventArgs e)
        {

            this.Hide();
            Frm_Login form = new Frm_Login();

            if (form.ShowDialog() == DialogResult.OK)
            {
                // mostrando usuário na tela principal
                Gerente user = (Gerente)form.Tag;
                //itemStatusUserLog.Text = user.nome;
                      

                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void btnDistribuidora_Click(object sender, EventArgs e)
        {
            Frm_Distribuidora frm = new Frm_Distribuidora();
            frm.Show();

            
            //frm_Distribuidora frm = new frm_Distribuidora();
           // frm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ProdutoD frm = new Frm_ProdutoD();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_chart frm = new Frm_chart();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            frm_trabalho frm = new frm_trabalho();
            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm consum = new Frm();
            consum.Show();
        }

        private void cadastrarDadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        }


        }


      

       
    

