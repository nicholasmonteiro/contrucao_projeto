using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using System.Data.SqlServerCe;


namespace CamadaDados
{
    public class CategoriaDAO
    {

        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int32, Categoria> ListarTodos()
        {
            Dictionary<Int32, Categoria> mapaCategorias = new Dictionary<Int32, Categoria>();
            try
            {
                String SQL = "SELECT * FROM Categoria;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Categoria o = new Categoria();

                    o.id = data.GetInt32(0);
                    o.codigo = data.GetInt32(1);
                    o.nome = data.GetString(2);
                    o.valor = data.GetInt32(3);

                    mapaCategorias.Add(o.id, o);

                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaCategorias;
        }

        public Categoria BuscarPorid(Int32 _codigo)
        {
            Categoria o = null;
            try
            {
                String SQL = "SELECT * FROM Categoria;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    o = new Categoria();

                    o.id = data.GetInt32(0);
                    o.codigo = data.GetInt32(1);
                    o.nome = data.GetString(2);
                    o.valor = data.GetInt32(3);

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

        public List<Categoria> ListarCategoriaPorProduto(Int32 id)
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            try
            {
                String SQL = String.Format("SELECT * FROM Categoria WHERE id = {1}", id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Categoria o = new Categoria();

                    o.id = data.GetInt32(0);
                    o.codigo = data.GetInt32(1);
                    o.nome = data.GetString(2);
                    o.valor = data.GetInt32(3);

                    listaCategorias.Add(o);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaCategorias;
        }

        #endregion

        public Dictionary<Int32, Categoria> BuscarListaFiltrada(String _filtros)
        {
            try
            {
             // " id = {0}"
                Dictionary<Int32, Categoria> listCategoria = new Dictionary<Int32, Categoria>();

                String SQL = "SELECT * FROM Categoria WHERE";

                Int32 saida;
                if ( Int32.TryParse(_filtros, out saida))
                {
                    SQL += String.Format( " id = {0}", _filtros);
                }
                else
                {
                  
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Categoria Item = new Categoria();

                    Item.id = data.GetInt32(0);
                    Item.codigo = data.GetInt32(1);
                    Item.nome = data.GetString(2);
                    Item.valor = data.GetInt32(3);

                    // listCategoria.Add(nItem.id, nItem);
                    listCategoria.Add(Item.id, Item);

                }

                data.Close();
                BD.FecharConexao();

                return listCategoria;

            }


            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }



        }
    }
}



   

