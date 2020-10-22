using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelo;
using CamadaControle;

namespace SistemaMercado
{
    public partial class Frm_Distribuidora : Form
    {
        public Frm_Distribuidora()
        {
            InitializeComponent();
        }

        private void Frm_Distribuidora_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                btnDeletar.Visible = true;
                btnSalvar.Visible = true;
                btnAlterar.Visible = true;
                Distribuidora p = (Distribuidora)this.Tag;
                CarregarFormDistribuidora(p);
            }

        }
           private void CarregarFormDistribuidora(Distribuidora _p)
              
        {
            try
            {
                text_cnpj.Text = Convert.ToString(_p.cnpj);
                text_nome.Text = _p.nome;
                text_cidade.Text = _p.cidade;
                text_estado.Text = _p.estado;
                text_valor.Text = Convert.ToString(_p.valor);
                text_valor.Text = Convert.ToString(_p.valor);
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR INFORMAÇÕES: " + ex.Message);
            }


        }

           private Distribuidora CarregarDistribuidoraDoForm()
           {

               Distribuidora p = new Distribuidora();

               try
               {

                   String cnpj = text_cnpj.Text.Replace(".", "").Replace(".", "");
                   p.cnpj = Convert.ToInt32(cnpj);
                   p.nome = text_nome.Text;
                   p.cidade = text_cidade.Text;
                   p.estado = text_estado.Text;
                   string valor = text_valor.Text.Replace(".", "").Replace(".", "");
                   p.valor = Convert.ToInt32(valor);


               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERRO: " + ex.Message);
               }

               return p;
           }

           private void btnSalvar_Click(object sender, EventArgs e)
           {

               try
               {

                   Distribuidora p = CarregarDistribuidoraDoForm();

                   Distribuidoractrl control = new Distribuidoractrl();


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

           private void btnAlterar_Click(object sender, EventArgs e)
           {


                    //Método para alterar dados no BD
         try
          {
                Distribuidora   distri = CarregarDistribuidoraDoForm();
               // Produto p = new Produto();

            Distribuidoractrl  controlProduto = new Distribuidoractrl();

               if ((bool)controlProduto.BD('u', distri))
               {
                   MessageBox.Show("Cadastro atualizado com sucesso!!");
               }
          }
         catch (Exception ex)
          {
              MessageBox.Show("ERRO AO ATUALIZAR DADOS: " + ex.Message);
          }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
       
             try

            {
                 Int32 cnpj = Convert.ToInt32(text_cnpj.Text.Replace("-","").Replace("-",""));

              
                Distribuidoractrl control = new Distribuidoractrl();

                if ((bool)control.BD('d', cnpj))
                {
                    MessageBox.Show("Cadastro deletado com sucesso!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao deletar Cadastro: " + ex.Message);
            }


        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


           }





    }

