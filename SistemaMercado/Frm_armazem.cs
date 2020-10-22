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
using CamadaDados;
using CamadaModelo;

namespace SistemaMercado
{
    public partial class Frm_armazem : Form
    {

        private Dictionary<Int32, Armazem> TabelaArmazem;

        public Frm_armazem()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_armazem_Load(object sender, EventArgs e)
        {
            CarregarGridoBD("");
        }


        private void CarregarGridoBD(String _filtro)
        {

            try
            {
                
                
                dataGridArmazem.Rows.Clear();
               

                Armazenctrl control = new Armazenctrl();

                if (_filtro.Equals(""))
                {

                    TabelaArmazem = (Dictionary<Int32, Armazem>)control.BD('t', null);
                }
                else
                {


                    TabelaArmazem= (Dictionary<Int32, Armazem>)control.BD('f', _filtro);

                }
                foreach (Armazem intem in TabelaArmazem.Values)
                {

                    dataGridArmazem.Rows.Add(intem.codigo, intem.nome, intem.valor, intem.categoria, intem.deposito,intem.quantidade);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO AO CARREGAR BD: " + ex.Message);

            }






        }

   
    


        }

   
        

        
    }
  
















// frm_produto//
//   String ConexaoCon= @"Data Source=C:\Users\HP\Documents\Visual Studio 2012\Projects\SistemaMercado\MyDatadados#1.sdf;Password=***********";

//  SqlConnection conexao = new SqlConnection
//      (ConexaoCon);
//  String sql = "INSERT  INTO Produto values(@codigo,@nome,@valor,@categoria,@deposito)";

//   try
//  {
//    conexao.Open();

//     for(int i=0; i< dtgvProduto.Rows.Count-1;i++)
//   {

//       SqlCommand comando=new SqlCommand(sql,conexao);

//     dtgvProduto.Rows[n].Cells[0].Value = text_codigo.Text;
//   dtgvProduto.Rows[n].Cells[1].Value = text_produto.Text;
//    dtgvProduto.Rows[n].Cells[2].Value = text_valor.Text;
//    dtgvProduto.Rows[n].Cells[3].Value = cbn_categoria.Text;
//  dtgvProduto.Rows[n].Cells[4].Value = rdbtn1.Bottom;
//   comando.CommandText = sql;  
//   comando.ExecuteNonQuery();
//  MessageBox.Show("dados inseridos com sucesso no banco");