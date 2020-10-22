using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using CamadaModelo;
using System.Data.SqlServerCe;


namespace CamadaDados
{
     public class GerenteDAO
    {
         private bool resultado;

         public Dictionary<Int32, Gerente> ListarTodos()
         {
             Dictionary<Int32, Gerente> mapaGerente = new Dictionary<Int32, Gerente>();
             try
             {
                 String SQL = "SELECT * FROM Gerente;";

                 SqlCeDataReader data = BD.ExecutarSelect(SQL);

                 while (data.Read())
                 {
                     Gerente o = new Gerente();

                     o.cpf = data.GetInt32(0);
                     o.nome = data.GetString(1);
                     o.celular = data.GetInt32(2);
                   //  o.cnpj = data.GetInt32(3);

                     mapaGerente.Add(o.cpf, o);

                 }

                 data.Close();
                 BD.FecharConexao();
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message);
             }

             return mapaGerente;
         }


         public Boolean InserirNoBD(Gerente _o)
         {

             bool resultado = false;
             try
             {
                 //  string SQL = String.Format("INSERT INTO Produto (codigo,nome, valor, categoria, deposito)"
                 //  + " VALUES ({0} {1} {2} {3})",
                 //   _o.codigo,_o.nome,_o.valor,_o.categoria,_o.deposito);

                 string SQL = string.Format("INSERT INTO Gerente (cpf, nome, celular) VALUES ('{0}', '{1}', '{2}')",
                          
                     _o.cpf,
                     _o.nome,
                    _o.celular);
                


                 // return  BD.ExecutarIDU(SQL);

                 int linhasAfetadas = BD.ExecutarIDU(SQL);
                 if (linhasAfetadas > 0)
                 {

                     resultado = true;

                 }

             }
             catch (Exception ex)
             {


                 throw new Exception("ERRO AO INSERIR Gerente NO BD: " + ex.Message);
             }

             return resultado;
         }


         public Boolean AlterarNoBD(Gerente _f)
         {
             bool reultado = false;
             try
             {
                 String SQL = String.Format("UPDATE Produto SET cpf = {0}, nome = '{1}', celular = '{2}' WHERE cpf = {0};",


               // + "WHERE codigo = {4};",
                     _f.cpf,
                     _f.nome,
                     _f.celular);
                   

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


                 throw new Exception("ERRO AO ALTERAR Gerente NO BD: " + ex.Message);
             }
             return reultado;
         }

         public Boolean DeletarNoBD(Int32 _cpf)
         {
             bool resultado = false;
             try
             {
                 string SQL = String.Format("DELETE FROM Produto WHERE cpf = {0};", _cpf);

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





         public Gerente BuscarPorcpf(Int32 _cpf)
         {
            Gerente o = null;
             try
             {
                 String SQL = "SELECT * FROM Gerente;";

                 SqlCeDataReader data = BD.ExecutarSelect(SQL);

                 while (data.Read())
                 {
                     o = new Gerente();

                     o.cpf= data.GetInt32(0);
                     o.nome = data.GetString(1);
                     o.celular = data.GetInt32(2);
                    // o.cnpj = data.GetInt32(3);

                 }

                 data.Close();
                 BD.FecharConexao();
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message);
             }

             return o;
         }

         public List<Gerente> ListarGerentePorDistribuidora(Int32 cpf)
         {
             List<Gerente> listaGerente = new List<Gerente>();
              
             try
             {
                 String SQL = String.Format("SELECT * FROM Gerente WHERE cpf = {0}", cpf);

                 SqlCeDataReader data = BD.ExecutarSelect(SQL);

                 while (data.Read())
                 {
                     Gerente o = new Gerente();

                     o.cpf = data.GetInt32(0);                
                     o.nome = data.GetString(1);
                     o.celular = data.GetInt32(2);
                    // o.cnpj = data.GetInt32(3);

                     listaGerente.Add(o);
                    

                 }
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message);
             }

             return listaGerente;
         }

         public Dictionary<Int32, Gerente> BuscarListaFiltrada(String _filtros)
         {
             try
             {
                 // " id = {0}"
                 Dictionary<Int32, Gerente> listGerente = new Dictionary<Int32, Gerente>();

                 String SQL = "SELECT * FROM Gerente WHERE";

                 Int32 saida;
                 if (Int32.TryParse(_filtros, out saida))
                 {
                     SQL += String.Format(" cpf = {0}", _filtros);
                 }
                 else
                 {

                   
                     SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                 }

                 SqlCeDataReader data = BD.ExecutarSelect(SQL);

                 while (data.Read())
                 {
                     Gerente Item = new Gerente();

                     Item.cpf = data.GetInt32(0);
                     Item.nome = data.GetString(1);
                     Item.celular = data.GetInt32(2);                 
                 //    Item.cnpj = data.GetInt32(3);

                     // listCategoria.Add(nItem.id, nItem);
                     listGerente.Add(Item.cpf, Item);

                 }

                 data.Close();
                 BD.FecharConexao();

                 return listGerente;

             }


             catch (Exception ex)
             {
                 BD.FecharConexao();
                 throw new Exception(ex.Message);
             }



         }
    }
}
