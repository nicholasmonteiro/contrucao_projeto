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
using CamadaDados;
using CamadaControle;

namespace SistemaMercado
{
    public partial class Frm_categoria : Form
    {
        private Dictionary<Int32, Categoria> tabelaCategoria;


        public Frm_categoria()
        {
            InitializeComponent();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_categoria_Load(object sender, EventArgs e)
        {

            

            CarregarGridDoBD("");



        }

        private void CarregarGridDoBD(string _filtro)
        {

            try
            {
                dataGridCategoria.Rows.Clear();


                Categoriactrl control = new Categoriactrl();

                if (_filtro.Equals(""))
                {

                    tabelaCategoria = (Dictionary<Int32, Categoria>)control.BD('p', null);
                }
                else
                {

                    tabelaCategoria = (Dictionary<Int32, Categoria>)control.BD('n', _filtro);

                }

                foreach( Categoria item in tabelaCategoria.Values)
                {


                   dataGridCategoria.Rows.Add(item.codigo,item.nome,item.valor);
                }

            }

                catch(Exception ex)
                {

                    MessageBox.Show("ERRO AO CARREGAR BD:" + ex.Message);

                }



            }







        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {

            try
            {
                CarregarGridDoBD(textPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO PESQUISAR: " + ex.Message);
            }


        }

        private void dataGridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //(dgvDados.SelectedRows[0].Cells[0].Value);
            try
            {
                Int32 codigo = Convert.ToInt32(dataGridCategoria.SelectedRows[0].Cells.SyncRoot);
                    
               Categoria p =   tabelaCategoria [codigo];

                Frm_categoria form = new Frm_categoria();

                form.Tag = p;

                form.ShowDialog();


                 CarregarGridDoBD("");
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR CADASTRO: " + ex.Message);
            }



        }

       


        }


      

            
        }


      
         
      

        

      
       
    

