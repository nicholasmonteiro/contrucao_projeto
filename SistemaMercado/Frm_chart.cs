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
    public partial class Frm_chart : Form
    {
        private Dictionary<Int32, Armazem> TabelaArmazem;

      public Frm_chart()
       {
             

            InitializeComponent();

           // DataTable Table = new DataTable();


           // Table.Columns.Add("nome");
           // Table.Columns.Add("valor");







            //Table.Rows.Add("macarrao", 10);
            // Table.Rows.Add("8", 5);
            //  Table.Rows.Add("15", 10);
            //  Table.Rows.Add("20", 8);
            //  Table.Rows.Add("69", 50);



                  // chart1.Series["nome"].Points.AddXY("miojo");
            //   chart1.Series["media"].Points.AddXY("queijo", 20);
            //   chart1.Series["media"].Points.AddXY("salame", 69);





              //chart1.Series["valor "].Points.AddXY("", 0);
           //  chart1.Series["valor"].Points.AddXY( "");
            // chart1.Series["valor Distribuidora"].Points.AddXY("queijo", 8);
            //chart1.Series["valor Distribuidora"].Points.AddXY("salame", 50);









          //  dataGridView1.DataSource = Table;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CarregarGridoBD("");

        }

        private void chart1_Click(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarGridoBD(String _filtro)
        {

            try
            {

                dataGridView1.Rows.Clear();


                Armazenctrl control = new Armazenctrl();

                if (_filtro.Equals(""))
                {

                    TabelaArmazem = (Dictionary<Int32, Armazem>)control.BD('t', null);
                }
                else
                {


                    TabelaArmazem = (Dictionary<Int32, Armazem>)control.BD('f', _filtro);

                }
                foreach (Armazem intem in TabelaArmazem.Values)
                {

                    dataGridView1.Rows.Add(intem.nome, intem.valor, intem.categoria,intem.deposito);
                    chart1.Series["Produto"].Points.AddXY(intem.nome, intem.deposito);
                   // chart1.Series["produto"].Points.AddXY(intem.nome, intem.quantidade);
                    //chart2.Series["Categoria"].Points.AddXY(intem.nome, intem.quantidade);

                                  
                   // chart1.Series["Categoria"].Points.AddXY(intem.categoria, intem.quantidade);


                

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO AO CARREGAR BD: " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Armazem intem in TabelaArmazem.Values)
            {

                chart2.Series["Categoria"].Points.AddXY(intem.nome, intem.quantidade);

            }

        }





    }





}
  


        

        
    
  
