using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using System.Data;
using System.Data.SqlServerCe;
namespace CamadaDados
{
   public class DistribuidoraDAO
    {


        private bool resultado;

        // public List<Produto> BuscarTodos()

        public Dictionary<Int32, Distribuidora> listarTodos()
        {
            Dictionary<Int32, Distribuidora> mapaDistribuidora = new Dictionary<Int32, Distribuidora>();
            try
            {
                //List<Produto> ListarProdutos = new List<Produto>();

                String SQL = "SELECT * FROM Distribuidora;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Distribuidora f = new Distribuidora();

                   
                    f.cnpj  = data.GetInt32(0);
                    f.nome = data.GetString(1);
                    f.cidade =  data.GetString(2);
                    f.estado = data.GetString(3);
                    f.valor = data.GetInt32(4);
                  

                    mapaDistribuidora.Add(f.cnpj, f);


                    //ListarProdutos.Add(f);
                }

                data.Close();
                BD.FecharConexao();

                //  return ListarProdutos;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();

                throw new Exception("ERRO AO BUSCAR DISTRIBUIDORA BD: " + ex.Message);
            }

            return mapaDistribuidora; ;
        }
        public Boolean InserirNoBD(Distribuidora _o)
        {

            bool resultado = false;
            try
            {
                //  string SQL = String.Format("INSERT INTO Produto (codigo,nome, valor, categoria, deposito)"
                //  + " VALUES ({0} {1} {2} {3})",
                //   _o.codigo,_o.nome,_o.valor,_o.categoria,_o.deposito);

                string SQL = string.Format("INSERT INTO Distribuidora (cnpj, nome , cidade ,estado ,valor ) VALUES ('{0}', '{1}', '{2}', '{3}','{4}' )",
                    _o.cnpj,
                    _o.nome,
                    _o.cidade,
                    _o.estado,
                    _o.valor);
                    

                // return  BD.ExecutarIDU(SQL);

                int linhasAfetadas = BD.ExecutarIDU(SQL);
                if (linhasAfetadas > 0)
                {

                    resultado = true;

                }

            }
            catch (Exception ex)
            {


                throw new Exception("ERRO AO INSERIR DISTRIBUIDORA NO BD: " + ex.Message);
            }

            return resultado;
        }
        public Boolean AlterarNoBD(Distribuidora _f)
        {
            bool reultado = false;
            try
            {
                String SQL = String.Format("UPDATE Distribuidora SET cnpj = {0}, nome = '{1}', cidade = '{2}', estado = '{3}' , valor = '{4}'  WHERE cnpj = {0};",


              // + "WHERE codigo = {4};",
                    _f.cnpj,
                    _f.nome,
                    _f.cidade,
                    _f.estado,
                    _f.valor);
                   


                // "UPDATE cliente SET id = {0}, nome = '{1}', tel = '{2}'  WHERE id = {0};",

                //string SQL = String.Format("UPDATE Produto SET nome = '{0}',valor'{1}',categoria'{2}',deposito'{3}' WHERE codigo = {4}",
                // f.codigo,f.nome,f.valor,f.categoria,f.deposito);


                int linhasAfetadas = BD.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {

                    resultado = true;

                }

                //return BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {


                throw new Exception("ERRO AO ALTERAR Produto NO BD: " + ex.Message);
            }
            return reultado;
        }

        public Boolean DeletarNoBD(Int32 _cnpj)
        {
            bool resultado = false;
            try
            {
                string SQL = String.Format("DELETE FROM Distribuidora WHERE cnpj = {0};", _cnpj);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }

            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);

            }

            return resultado;
        }



    }
}
