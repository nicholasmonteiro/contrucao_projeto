using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using CamadaModelo;
using CamadaControle;

namespace SistemaMercado
{
    public partial class frm_Produto : Form
    {

        public frm_Produto()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Produto p = CarregarProdutoDoForm();

                produtoctrl control = new produtoctrl();

                
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
                Produto prod = CarregarProdutoDoForm();
               // Produto p = new Produto();

            produtoctrl   controlProduto = new produtoctrl();

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

        private Produto CarregarProdutoDoForm()
        {
            
            Produto p = new Produto();

            try
            {

                 String codigo = text_codigo.Text.Replace(".","").Replace("-","");
                 p.codigo = Convert.ToInt32(codigo);                                                          
             
                 p.nome = text_produto.Text;
                 string valor = text_valor.Text.Replace(".", "").Replace("-", "");
                 p.valor = Convert.ToInt32(valor);
                // p.Categorias = (Int32)cmbCategoria.SelectedValue;
                 p.categoria = (String)cmbCategoria.SelectedValue;
           
                if (rdbDeposito1.Checked)
                {
                    p.deposito =  1;
                }
                else
                {
                    p.deposito = 2;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return p;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
             try

            {
                Int32 codigo = Convert.ToInt32(text_codigo.Text.Replace("-", "").Replace("-", ""));
                produtoctrl control = new produtoctrl();

                if ((bool)control.BD('d', codigo))
                {
                    MessageBox.Show("Cadastro deletado com sucesso!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao deletar Cadastro: " + ex.Message);
            }

        }

        private void frm_Produto_Load(object sender, EventArgs e)
        {
            
                if (this.Tag != null)
                {
                    btnDeletar.Visible = true;
                    btnSalvar.Visible = true;
                    btnAlterar.Visible = true;
                    Produto p = (Produto)this.Tag;
                   CarregarFormProduto(p);
                }
        }


             private void CarregarFormProduto(Produto _p)
        {
            try
            {
                text_codigo.Text= Convert.ToString( _p.codigo);
                text_produto.Text =  _p.nome;
                text_valor.Text =  Convert.ToString(_p.valor);
                cmbCategoria.SelectedValue = _p.categoria;
                if (_p.deposito.Equals("1"))
                {
                    rdbDeposito1.Checked = true;


                }

                else
                {

                    rdbDeposito2.Checked = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR INFORMAÇÕES: " + ex.Message);
            }


        }

             private void carregarCategoriasFiltradas(string _categoria)
             {
                 try
                 {

                     produtoctrl controlCategoria = new produtoctrl();

                     List<Produto> listaCategorias = (List<Produto>)controlCategoria.BD('c', _categoria);

                     cmbCategoria.DisplayMember = "massas";
                     cmbCategoria.DisplayMember = "frios";
                     cmbCategoria.DisplayMember = " biscoito";


                     cmbCategoria.DataSource = listaCategorias;
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show("ERRO AO CARREGAR  COMO CATEGORIAS:" + ex.Message);

                 }

             }

             private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
             {

                 try
                 {

                     if (cmbCategoria.SelectedValue != null)
                     {

                         string categoria = (String)cmbCategoria.SelectedValue;

                         carregarCategoriasFiltradas(categoria);


                     }


                 }

                 catch (Exception ex)
                 {

                     MessageBox.Show("ERRO AO FILTRAR CATEGORIAS :" + ex.Message);

                 }

             }
             
        }
        

        }



   //private Produto CarregarProdutoDoForm()

//String cod = text_codigo.Text;
//p.codigo = Convert.ToInt16(cod);
//p.nome = text_produto.Text;
//  String valor = text_valor.Text;
// p.valor = Convert.ToInt32(valor);
//  Int32 categoria = (Int32) cbmCategoriaSelectedValue;
//   p.categoria = Convert.ToString(categoria);