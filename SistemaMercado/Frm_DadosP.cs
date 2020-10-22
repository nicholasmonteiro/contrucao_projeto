using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaControle;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using CamadaModelo;


namespace SistemaMercado
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {

            if (this.Tag != null)
            {
                btnDeletar.Visible = true;
                btnSalvar.Visible = true;
                btnAlterar.Visible = true;
                Gerente p = (Gerente)this.Tag;
                CarregarFormGerente(p);
            }
        }

        private void CarregarFormGerente(Gerente _p)
        {
            try
            {
                text_cpf.Text = Convert.ToString(_p.cpf);            
                text_nome.Text = _p.nome;
                text_celular.Text = Convert.ToString(_p.celular);
           

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR INFORMAÇÕES: " + ex.Message);
            }


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

           //ext.Replace("-", "").Replace("-", ""));
           try
            {

                Int32 cpf = Convert.ToInt32(text_cpf.Text.Replace("-", "").Replace("-", ""));
                Gerentectrl control = new Gerentectrl();

                if ((bool)control.BD('d',cpf))
                {
                    MessageBox.Show("Cadastro deletado com sucesso!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao deletar Cadastro: " + ex.Message);
            }

        }

        private   Gerente CarregarGerenteDoForm()
        {

            Gerente p = new Gerente();

            try
            {
                String cpf = text_cpf.Text.Replace("-", "").Replace("-", "");
                p.cpf = Convert.ToInt32(cpf);
                p.nome = text_nome.Text;

                string celular = text_celular.Text.Replace("-", "").Replace("-", "");
                p.celular = Convert.ToInt32(celular);
           

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return p;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Método para alterar dados no BD
            try
            {
                Gerente prod = CarregarGerenteDoForm();
                // Produto p = new Produto();

               Gerentectrl controlProduto = new Gerentectrl();

                if ((bool)controlProduto.BD('u', prod))
                {
                    MessageBox.Show("Cadastro atualizado com sucesso!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ATUALIZAR DADOS: " + ex.Message);
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                Gerente p = CarregarGerenteDoForm();

                Gerentectrl control = new Gerentectrl();


                if ((bool)control.BD('i', p))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro não efetuado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }


        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
